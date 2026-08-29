namespace EFTest
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileCreateDatabase = new ToolStripMenuItem();
            mnuFileDeleteDatabase = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuFileExit = new ToolStripMenuItem();
            mnuCustomer = new ToolStripMenuItem();
            mnuCustomerAdd = new ToolStripMenuItem();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.ImageScalingSize = new Size(20, 20);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuCustomer });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(800, 28);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "mnuMain";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileCreateDatabase, mnuFileDeleteDatabase, toolStripMenuItem1, mnuFileExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "File";
            // 
            // mnuFileCreateDatabase
            // 
            mnuFileCreateDatabase.Name = "mnuFileCreateDatabase";
            mnuFileCreateDatabase.Size = new Size(203, 26);
            mnuFileCreateDatabase.Text = "Create Database";
            mnuFileCreateDatabase.Click += mnuFileCreateDatabase_Click;
            // 
            // mnuFileDeleteDatabase
            // 
            mnuFileDeleteDatabase.Name = "mnuFileDeleteDatabase";
            mnuFileDeleteDatabase.Size = new Size(203, 26);
            mnuFileDeleteDatabase.Text = "Delete Database";
            mnuFileDeleteDatabase.Click += mnuFileDeleteDatabase_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(200, 6);
            // 
            // mnuFileExit
            // 
            mnuFileExit.Name = "mnuFileExit";
            mnuFileExit.Size = new Size(203, 26);
            mnuFileExit.Text = "Exit";
            // 
            // mnuCustomer
            // 
            mnuCustomer.DropDownItems.AddRange(new ToolStripItem[] { mnuCustomerAdd });
            mnuCustomer.Name = "mnuCustomer";
            mnuCustomer.Size = new Size(86, 24);
            mnuCustomer.Text = "Customer";
            // 
            // mnuCustomerAdd
            // 
            mnuCustomerAdd.Name = "mnuCustomerAdd";
            mnuCustomerAdd.Size = new Size(248, 26);
            mnuCustomerAdd.Text = "Customer Maintainance";
            mnuCustomerAdd.Click += mnuCustomerAdd_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuMain);
            MainMenuStrip = mnuMain;
            Name = "frmMain";
            Text = "EF Core Testing App";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileCreateDatabase;
        private ToolStripMenuItem mnuFileDeleteDatabase;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuFileExit;
        private ToolStripMenuItem mnuCustomer;
        private ToolStripMenuItem mnuCustomerAdd;
    }
}
