namespace WindowsApplication1
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
    using System.IO;
    using System.Diagnostics;
    using Microsoft.Office.Interop.Outlook;

    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem menu2ToolStripMenuItem;
        private ToolStripMenuItem menu3ToolStripMenuItem;
        private ToolStripButton searchToolStripButton;
        private Button button4;
        private Button btnCalendar;
        private System.ComponentModel.Container components;

        public Form1()
        {
            InitializeComponent();

            // Sets up the initial objects in the CheckedListBox.
            string[] myFruit = { "Apples", "Oranges", "Tomato" };
            checkedListBox1.Items.AddRange(myFruit);

            // Changes the selection mode from double-click to single click.
            checkedListBox1.CheckOnClick = true;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Location = new System.Drawing.Point(16, 85);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 184);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(408, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 186);
            this.listBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(144, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Fruit";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(288, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show Order";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(288, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Save Order";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.menu2ToolStripMenuItem,
            this.menu3ToolStripMenuItem,
            this.searchToolStripButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 27);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.menuToolStripMenuItem.Text = "Menu ";
            // 
            // menu2ToolStripMenuItem
            // 
            this.menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            this.menu2ToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.menu2ToolStripMenuItem.Text = "Menu2";
            // 
            // menu3ToolStripMenuItem
            // 
            this.menu3ToolStripMenuItem.Name = "menu3ToolStripMenuItem";
            this.menu3ToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.menu3ToolStripMenuItem.Text = "Menu3";
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.ForeColor = System.Drawing.Color.Green;
            this.searchToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripButton.Image")));
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(62, 20);
            this.searchToolStripButton.Text = "Search";
            this.searchToolStripButton.ToolTipText = "Search";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(318, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Location = new System.Drawing.Point(135, 300);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(67, 28);
            this.btnCalendar.TabIndex = 6;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(652, 381);
            this.Controls.Add(this.btnCalendar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Fruit Order";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        // Adds the string if the text box has data in it.
        private void button1_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (checkedListBox1.CheckedItems.Contains(textBox1.Text) == false)
                    checkedListBox1.Items.Add(textBox1.Text, CheckState.Checked);
                textBox1.Text = "";
            }

        }
        // Activates or deactivates the Add button.
        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }

        }

        // Moves the checked items from the CheckedListBox to the listBox.
        private void button2_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
            button3.Enabled = false;
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
            }
            if (listBox1.Items.Count > 0)
                button3.Enabled = true;

        }
        // Activates the move button if there are checked items.
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                if (checkedListBox1.CheckedItems.Count == 1)
                {
                    button2.Enabled = false;
                }
            }
            else
            {
                button2.Enabled = true;
            }
        }

        // Saves the items to a file.
        private void button3_Click(object sender, System.EventArgs e)
        {
            // Insert code to save a file.
            listBox1.Items.Clear();
            IEnumerator myEnumerator;
            myEnumerator = checkedListBox1.CheckedIndices.GetEnumerator();
            int y;
            while (myEnumerator.MoveNext() != false)
            {
                y = (int)myEnumerator.Current;
                checkedListBox1.SetItemChecked(y, false);
            }
            button3.Enabled = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Intel\");
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
                try
                {
                    //Microsoft.Office.Interop.Outlook.AppointmentItem newAppointment =
                    //    (Microsoft.Office.Interop.Outlook.AppointmentItem)
                    //Microsoft.Office.Interop.Outlook.Application apptApp = new Outlook.Application();
                    //Application.CreateItem(Outlook.OlItemType.olAppointmentItem);
                    //newAppointment.Start = DateTime.Now.AddHours(2);
                    //newAppointment.End = DateTime.Now.AddHours(3);
                    //newAppointment.Location = "ConferenceRoom #2345";
                    //newAppointment.Body =
                    //    "We will discuss progress on the group project.";
                    //newAppointment.AllDayEvent = false;
                    //newAppointment.Subject = "Group Project";
                    //newAppointment.Recipients.Add("Roger Harui");
                    //Recipients sentTo = newAppointment.Recipients;
                    //Outlook.Recipient sentInvite = null;
                    //sentInvite = sentTo.Add("Holly Holt");
                    //sentInvite.Type = (int)Outlook.OlMeetingRecipientType
                    //    .olRequired;
                    //sentInvite = sentTo.Add("David Junca ");
                    //sentInvite.Type = (int)Outlook.OlMeetingRecipientType
                    //    .olOptional;
                    //sentTo.ResolveAll();
                    //newAppointment.Save();
                    //newAppointment.Display(true);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("The following error occurred: " + ex.Message);
                }
        }
        
    }
}