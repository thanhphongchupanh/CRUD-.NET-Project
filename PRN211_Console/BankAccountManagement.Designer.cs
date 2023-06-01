namespace PRN211_Console
{
    partial class BankAccountManagement
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
            dgvBankAccount = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtAccountID = new TextBox();
            txtAccountName = new TextBox();
            txtBranchName = new TextBox();
            cboTypeID = new ComboBox();
            dtpOpenDate = new DateTimePicker();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBankAccount).BeginInit();
            SuspendLayout();
            // 
            // dgvBankAccount
            // 
            dgvBankAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBankAccount.Location = new Point(24, 35);
            dgvBankAccount.Name = "dgvBankAccount";
            dgvBankAccount.RowHeadersWidth = 51;
            dgvBankAccount.RowTemplate.Height = 29;
            dgvBankAccount.Size = new Size(592, 242);
            dgvBankAccount.TabIndex = 0;
            dgvBankAccount.CellClick += dgvBankAccount_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 299);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 1;
            label1.Text = "SEARCH BY BRANCH NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(644, 66);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 2;
            label2.Text = "Account ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(642, 114);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 3;
            label3.Text = "Account Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(642, 154);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 4;
            label4.Text = "Open Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(642, 200);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 5;
            label5.Text = "Branch Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(644, 242);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 6;
            label6.Text = "Type ID";
            // 
            // txtAccountID
            // 
            txtAccountID.Location = new Point(762, 59);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(250, 27);
            txtAccountID.TabIndex = 7;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(762, 114);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(250, 27);
            txtAccountName.TabIndex = 8;
            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(762, 200);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(250, 27);
            txtBranchName.TabIndex = 9;
            // 
            // cboTypeID
            // 
            cboTypeID.FormattingEnabled = true;
            cboTypeID.Location = new Point(762, 249);
            cboTypeID.Name = "cboTypeID";
            cboTypeID.Size = new Size(250, 28);
            cboTypeID.TabIndex = 10;
            // 
            // dtpOpenDate
            // 
            dtpOpenDate.Location = new Point(762, 154);
            dtpOpenDate.Name = "dtpOpenDate";
            dtpOpenDate.Size = new Size(250, 27);
            dtpOpenDate.TabIndex = 11;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(219, 342);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(264, 27);
            txtSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(539, 342);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(116, 425);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(345, 425);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(599, 425);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(832, 425);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 17;
            btnClear.Text = "Reset";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // BankAccountManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 498);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dtpOpenDate);
            Controls.Add(cboTypeID);
            Controls.Add(txtBranchName);
            Controls.Add(txtAccountName);
            Controls.Add(txtAccountID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvBankAccount);
            Name = "BankAccountManagement";
            Text = "BankAccountManagement";
            Load += BankAccountManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBankAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBankAccount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAccountID;
        private TextBox txtAccountName;
        private TextBox txtBranchName;
        private ComboBox cboTypeID;
        private DateTimePicker dtpOpenDate;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}