namespace EFTest
{
    partial class frmCustomer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCustId = new TextBox();
            txtCustName = new TextBox();
            txtAddr = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            btnSearch = new Button();
            btnNew = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 64);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 97);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // txtCustId
            // 
            txtCustId.Location = new Point(137, 28);
            txtCustId.Name = "txtCustId";
            txtCustId.Size = new Size(186, 27);
            txtCustId.TabIndex = 3;
            // 
            // txtCustName
            // 
            txtCustName.Location = new Point(137, 61);
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(447, 27);
            txtCustName.TabIndex = 4;
            // 
            // txtAddr
            // 
            txtAddr.Location = new Point(137, 94);
            txtAddr.Name = "txtAddr";
            txtAddr.Size = new Size(447, 27);
            txtAddr.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(290, 142);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(390, 142);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(490, 142);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(329, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(190, 142);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 10;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 200);
            Controls.Add(btnNew);
            Controls.Add(btnSearch);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtAddr);
            Controls.Add(txtCustName);
            Controls.Add(txtCustId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Entry Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCustId;
        private TextBox txtCustName;
        private TextBox txtAddr;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClose;
        private Button btnSearch;
        private Button btnNew;
    }
}