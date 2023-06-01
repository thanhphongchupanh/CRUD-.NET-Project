using Service.Models;
using Service.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Console
{
    public partial class BankAccountManagement : Form
    {
        BankAccountService _bankAccount = new BankAccountService();
        public BankAccountManagement()
        {
            InitializeComponent();

            var listBankAccount = _bankAccount.GetAll();
            dgvBankAccount.DataSource = new BindingSource
            {
                DataSource = listBankAccount
            };
        }

        private void BankAccountManagement_Load(object sender, EventArgs e)
        {
            AccountTypeService _accountType = new AccountTypeService();
            var typeID = _accountType.GetAll().Select(x => x.TypeId);
            cboTypeID.Items.AddRange(typeID.ToArray());
            cboTypeID.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;

            BankAccount bankAccount = new BankAccount();
            bankAccount.AccountId = txtAccountID.Text.ToUpper();
            bankAccount.AccountName = txtAccountName.Text;
            bankAccount.BranchName = txtBranchName.Text;
            bankAccount.OpenDate = dtpOpenDate.Value;
            bankAccount.TypeId = cboTypeID.Text;
            bool check = Validation.checkEmpty(bankAccount.AccountId, bankAccount.AccountName, bankAccount.BranchName, bankAccount.TypeId);
            if (check)
            {
            }
            else
            {
                _bankAccount.Create(bankAccount);
                clearText();
            }

            var listBankAccount = _bankAccount.GetAll();
            dgvBankAccount.DataSource = null;
            dgvBankAccount.DataSource = new BindingSource { DataSource = listBankAccount };


            btnAdd.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this account ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                // chọn dòng cần xóa
                var account = _bankAccount.GetAll().ToList()[dgvBankAccount.CurrentRow.Index];
                int preRowDeleted = dgvBankAccount.CurrentRow.Index - 1;

                // xóa dòng dc chọn
                _bankAccount.Delete(account);

                // reload datagridview
                var listBankAccount = _bankAccount.GetAll();
                dgvBankAccount.DataSource = null;
                dgvBankAccount.DataSource = new BindingSource
                {
                    DataSource = listBankAccount
                };


                // row selected
                int numOfListRow = dgvBankAccount.Rows.Count;
                if (preRowDeleted >= 0 && preRowDeleted < numOfListRow)
                {
                    dgvBankAccount.Rows[preRowDeleted].Selected = true;
                    dgvBankAccount.CurrentCell = dgvBankAccount.Rows[preRowDeleted].Cells[0];  //chọn ô đầu tiên của dòng mún chọn
                    dgvBankAccount.Focus(); // Đặt trỏ chuột vào DataGridView
                }

                clearText();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // selected row before update
            int currRow = dgvBankAccount.CurrentRow.Index;

            btnUpdate.Enabled = false;
            //get updating text
            var bankAccount = _bankAccount.GetAll()[dgvBankAccount.CurrentRow.Index];
            bankAccount.AccountId = txtAccountID.Text;
            bankAccount.AccountName = txtAccountName.Text;
            bankAccount.BranchName = txtBranchName.Text;
            bankAccount.OpenDate = dtpOpenDate.Value;
            bankAccount.TypeId = cboTypeID.Text;

            _bankAccount.Update(bankAccount);
            clearText();

            //reload datagridview
            var listBankAccount = _bankAccount.GetAll();
            dgvBankAccount.DataSource = null;
            dgvBankAccount.DataSource = new BindingSource { DataSource = listBankAccount };

            //select current row          
            int numOfListRow = dgvBankAccount.Rows.Count;
            if (currRow >= 0 && currRow < numOfListRow)
            {
                dgvBankAccount.Rows[currRow].Selected = true;
                dgvBankAccount.CurrentCell = dgvBankAccount.Rows[currRow].Cells[0];  //chọn ô đầu tiên của dòng mún chọn
                dgvBankAccount.Focus(); // Đặt trỏ chuột vào DataGridView
            }

            btnUpdate.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;

            string branchName = txtSearch.Text.ToLower();
            if (string.IsNullOrEmpty(branchName))
            {
                MessageBox.Show("Branch name box must be filled to search", this.Text);
            }
            else
            {
                var listSearchBankAccount = _bankAccount.GetAll();

                var bankAccountAfterSearch = listSearchBankAccount.Where(x => x.BranchName.ToLower().Equals(branchName));

                if (bankAccountAfterSearch != null)
                {
                    dgvBankAccount.DataSource = null;
                    dgvBankAccount.DataSource = new BindingSource { DataSource = bankAccountAfterSearch };
                }
                else
                {
                    MessageBox.Show("No result", this.Text);
                }
            }

            btnSearch.Enabled = true;
        }

        private void dgvBankAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.RowIndex == dgv.Rows.Count - 1 || e.RowIndex == -1)
            {
                clearText();
            }
            else
            {
                var listBankAccount = _bankAccount.GetAll();
                var bankAccount = listBankAccount[e.RowIndex];
                //txtAccountID.ReadOnly = true;
                txtAccountID.Text = bankAccount.AccountId.ToString();
                txtAccountName.Text = bankAccount.AccountName.ToString();
                txtBranchName.Text = bankAccount.BranchName.ToString();
                DateTime openDate;
                if (DateTime.TryParse(bankAccount.OpenDate.ToString(), out openDate))
                {
                    dtpOpenDate.Value = openDate;
                }
                cboTypeID.Text = bankAccount.TypeId.ToString();
            }
        }

        private void clearText()
        {
            txtAccountID.Text = "";
            txtAccountName.Text = "";
            txtBranchName.Text = "";
            dtpOpenDate.Value = DateTime.Now;
            cboTypeID.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearText();

            var listBankAccount = _bankAccount.GetAll();

            dgvBankAccount.DataSource = new BindingSource { DataSource = listBankAccount };
        }
    }
}
