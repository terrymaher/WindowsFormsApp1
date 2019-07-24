using System;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ExtensionMethods;
namespace MyTestProject
{

    public partial class Test_Form : Form
    {
        string strConnectionString = (@"Data Source=192.168.100.47,1433\SQLEXPRESS;" +
                                       "Network Library=DBMSSOCN;Initial Catalog=KDM;" +
                                       "User ID=sa;Password=summerW1nd");
        DataTable dtBackupList = new DataTable();
        BindingSource bsBackupList = new BindingSource();

        public string BackupDirectory { get; set; } = "";

        public Test_Form()
        {
            InitializeComponent();
        }

        private void Test_Form_Load(object sender, EventArgs e)
        {
            ;// tbDirectory.Text = GetBackupDirectory();
            BackupDirectory = GetBackupDirectory();
        }

        private string[] GetFiles(string directory, string pattern, SearchOption sOption)
        {
            string[] filesandpaths = Directory.GetFiles(directory, pattern, sOption);
            return filesandpaths;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbDirectory.Text + "" == "") { tbDirectory.Text = BackupDirectory; }
                if (tbPattern.Text + "" == "") { tbPattern.Text = "*"; }
                lbList.DataSource = GetFiles(tbDirectory.Text, tbPattern.Text, SearchOption.AllDirectories);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SetupDGV()
        {
            //dgvBackups.AutoResizeColumn();
            ;
        }

        private void GetData()
        {
            string strCommandString = "SELECT bs.media_set_id AS 'ID', bmf.physical_device_name AS 'Backup', " +
                                      "bs.backup_finish_date AS 'Finish Date'" +
                                      "FROM msdb.dbo.backupset bs " +
                                      "LEFT JOIN msdb.dbo.backupmediafamily bmf " +
                                      "ON bs.media_set_id = bmf.media_set_id";

            SqlConnection cn = new SqlConnection(strConnectionString);
            SqlCommand cmd = new SqlCommand(strCommandString, cn);
            try
            {
                cn.Open();
                dtBackupList.Load(cmd.ExecuteReader());
                cn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            bsBackupList.DataSource = dtBackupList;
            dgvBackups.DataSource = bsBackupList;
        }

        private void bnSetBackupDirectory_Click(object sender, EventArgs e)
        {
            if (tbSetBackupDirectory.Text + "" == "")
            {
                MessageBox.Show("Enter Backup Directory");
            }

            {
                SetBackupDirectory(tbSetBackupDirectory.Text);
            }
        }

        private void SetBackupDirectory(string strNewBackupDirectory)
        {
            SqlConnection cn = new SqlConnection(strConnectionString);
            string strCommandText = "UPDATE dbo.tblOrg " +
                                    "SET fldOrgBackupDirectory = '" + strNewBackupDirectory + "'" +
                                    "WHERE fldOrgName = 'KDM';";
            SqlCommand cmd = new SqlCommand(strCommandText, cn);
            try
            {
                cn.Open();
                int rows = cmd.ExecuteNonQuery();
                cn.Close();
                if (cn.State == ConnectionState.Open) { cn.Close(); }
            }
            catch (SqlException sqex)
            {
                MessageBox.Show(sqex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetBackupDirectory()
        {
            string strReturn = "";
            SqlConnection cn = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT TOP 1 fldOrgBackupDirectory " +
                                    "FROM dbo.tblOrg " +
                                    "WHERE fldOrgName = 'KDM';";
            SqlCommand cmd = new SqlCommand(strCommandText, cn);

            try
            {
                cn.Open();
                strReturn = Convert.ToString(cmd.ExecuteScalar());
                if (cn.State == ConnectionState.Open) { cn.Close(); }
            }
            catch (SqlException sqex)
            {
                MessageBox.Show(sqex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return strReturn;
        }

        private void btnTestCode_Click(object sender, EventArgs e)
        {
            //TestCode1();
            //TestCode2();
            //TestCode3();
            DeleteOldBackups(7, 7);
        }

        //show use of extension method.
        private void TestCode1()
        {
            int i = 10;
            bool result = i.IsGreaterThan(5);
            MessageBox.Show(String.Format("Result: {0}", result));
        }

        private void TestCode2()
        {
            Func<int, int> multiplyByFive = num => num * 5;
            // Returns 35
            int result = multiplyByFive(7);
            result = 1000;
            MessageBox.Show(String.Format("Result: {0:C}", result));
        }

        private void TestCode3()
        {
            Func<int, int, int> multiplyTwoNumbers = (a, b) => a * b;
            // Returns 35
            int result = multiplyTwoNumbers(7, 5);
            MessageBox.Show(String.Format("Result: {0:C}", result));
        }

        public void DeleteOldBackups(int num, int days)
        {
            if (num < 7) { num = 7; }
            if (days < 7) { days = 7; }

            int intDeletedFiles = 0;
            string[] strSubDirectories;
            DateTime dtref = DateTime.Today.AddDays(-days);
            try
            {
                strSubDirectories = Directory.GetDirectories(BackupDirectory);
                foreach (string strSubDir in strSubDirectories)
                {
                    DirectoryInfo di = new DirectoryInfo(strSubDir);
                    var files = di.GetFiles("*.bak", SearchOption.TopDirectoryOnly).OrderBy(t => t.CreationTime).ToList();
                    int intCount = files.Count();
                    foreach (FileInfo fi in files)
                    {
                        if (intCount > 7 && fi.CreationTime < dtref)
                        {
                            //fi.Delete();
                            intDeletedFiles++;
                            intCount--;
                        }
                        else { break; }
                    }
                }
            }
            catch (IOException ioex) { MessageBox.Show("Problem accessing directory/n" + ioex.Message.ToString()); }
            catch (Exception ex) { MessageBox.Show("Problem deleting files/n" + ex.Message.ToString()); }
            MessageBox.Show(string.Format(String.Format("{0} Old Backups Deleted.", intDeletedFiles)));
        }

        private void btnTestMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A test message with newline \r " + 1 + " Second Part");
        }
    }
}
