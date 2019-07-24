namespace MyTestProject
{
    using System.Windows.Forms;
    partial class Test_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetData = new System.Windows.Forms.Button();
            this.lbList = new System.Windows.Forms.ListBox();
            this.tbPattern = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBackups = new System.Windows.Forms.DataGridView();
            this.tbSetBackupDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bnSetBackupDirectory = new System.Windows.Forms.Button();
            this.btnTestCode = new System.Windows.Forms.Button();
            this.btnTestMessage = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(310, 216);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 26);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.Location = new System.Drawing.Point(12, 171);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(268, 134);
            this.lbList.TabIndex = 2;
            // 
            // tbPattern
            // 
            this.tbPattern.Location = new System.Drawing.Point(12, 145);
            this.tbPattern.Name = "tbPattern";
            this.tbPattern.Size = new System.Drawing.Size(131, 20);
            this.tbPattern.TabIndex = 3;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 311);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(70, 26);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Load List";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pattern";
            // 
            // tbDirectory
            // 
            this.tbDirectory.Location = new System.Drawing.Point(149, 145);
            this.tbDirectory.Name = "tbDirectory";
            this.tbDirectory.Size = new System.Drawing.Size(131, 20);
            this.tbDirectory.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Directory";
            // 
            // dgvBackups
            // 
            this.dgvBackups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBackups.Location = new System.Drawing.Point(310, 76);
            this.dgvBackups.Name = "dgvBackups";
            this.dgvBackups.Size = new System.Drawing.Size(449, 134);
            this.dgvBackups.TabIndex = 8;
            // 
            // tbSetBackupDirectory
            // 
            this.tbSetBackupDirectory.Location = new System.Drawing.Point(12, 34);
            this.tbSetBackupDirectory.Name = "tbSetBackupDirectory";
            this.tbSetBackupDirectory.Size = new System.Drawing.Size(419, 20);
            this.tbSetBackupDirectory.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Set Backup Directory";
            // 
            // bnSetBackupDirectory
            // 
            this.bnSetBackupDirectory.Location = new System.Drawing.Point(12, 59);
            this.bnSetBackupDirectory.Name = "bnSetBackupDirectory";
            this.bnSetBackupDirectory.Size = new System.Drawing.Size(108, 24);
            this.bnSetBackupDirectory.TabIndex = 11;
            this.bnSetBackupDirectory.Text = "Save to Database";
            this.bnSetBackupDirectory.UseVisualStyleBackColor = true;
            this.bnSetBackupDirectory.Click += new System.EventHandler(this.bnSetBackupDirectory_Click);
            // 
            // btnTestCode
            // 
            this.btnTestCode.Location = new System.Drawing.Point(12, 412);
            this.btnTestCode.Name = "btnTestCode";
            this.btnTestCode.Size = new System.Drawing.Size(70, 26);
            this.btnTestCode.TabIndex = 12;
            this.btnTestCode.Text = "Test Code";
            this.btnTestCode.UseVisualStyleBackColor = true;
            this.btnTestCode.Click += new System.EventHandler(this.btnTestCode_Click);
            // 
            // btnTestMessage
            // 
            this.btnTestMessage.Location = new System.Drawing.Point(655, 31);
            this.btnTestMessage.Name = "btnTestMessage";
            this.btnTestMessage.Size = new System.Drawing.Size(90, 23);
            this.btnTestMessage.TabIndex = 13;
            this.btnTestMessage.Text = "Test Message";
            this.btnTestMessage.UseVisualStyleBackColor = true;
            this.btnTestMessage.Click += new System.EventHandler(this.btnTestMessage_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 115);
            this.dataGridView1.TabIndex = 14;
            // 
            // Test_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTestMessage);
            this.Controls.Add(this.btnTestCode);
            this.Controls.Add(this.bnSetBackupDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSetBackupDirectory);
            this.Controls.Add(this.dgvBackups);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.tbPattern);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.btnGetData);
            this.Name = "Test_Form";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private Button btnGetData;
        private Button btnTest;
        private ListBox lbList;
        private TextBox tbPattern;
        private Label label1;
        private TextBox tbDirectory;
        private Label label2;
        private DataGridView dgvBackups;
        private TextBox tbSetBackupDirectory;
        private Label label3;
        private Button bnSetBackupDirectory;
        private Button btnTestCode;
        private Button btnTestMessage;
        private DataGridView dataGridView1;
    }
}