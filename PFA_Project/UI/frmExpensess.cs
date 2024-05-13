
using DAL.Extension;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PFA_Project.UI
{
    public partial class frmExpensess : Form
    {

        private readonly PFAdbContext _dbContext;

        public frmExpensess(PFAdbContext dbContext)
        {
            _dbContext = dbContext;
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //int UserID = 0;
            ////Getting Values from UI
            //if (textBoxUserID.Text.Trim() != "")
            //{
            //    UserID = int.Parse(textBoxUserID.Text.Trim());
            //}
            //string FullName = textBoxFullName.Text.Trim();
            //string Username = textBoxUsername.Text.Trim();
            //string Email = textBoxEmail.Text.Trim();
            //string Contact = textBoxContact.Text.Trim();
            //string Password = textBoxPassword.Text.Trim();
            //string UserType = comboBoxUserType.Text.Trim();

            ////Declare and Assign Object
            //User U = new User();
            //U.UserID = UserID;
            //U.FullName = FullName;
            //U.Username = Username;
            //U.Email = Email;
            //U.Contact = Contact;
            //U.Password = Password;
            //U.UserType = UserType;

            ////Create Object for User DAL
            //UserDAL dal = new UserDAL();
            ////Identify the Case for Insert or Update
            //if (U.UserID == 0)
            //{
            //    //Case for Insert
            //    bool success = dal.Insert_User(U);
            //    if (success == true)
            //    {
            //        MessageBox.Show("New User Successfully Added");
            //        //Refreshing the DAta Grid view
            //        DataTable dt = dal.Select_User();
            //        dataGridViewUsers.DataSource = dt;

            //        //Clear the fields
            //        Clear();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Failed to add new user. Try Again.");

            //    }
            //}
            //else
            //{
            //    //Case for Update
            //    bool success = dal.Update_User(U);
            //    if (success == true)
            //    {
            //        MessageBox.Show("User Successfully Updated.");
            //        //Refreshing the DAta Grid view
            //        DataTable dt = dal.Select_User();
            //        dataGridViewUsers.DataSource = dt;

            //        //Clear the Testfields
            //        Clear();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Failed to Update User. Try Again.");
            //    }
            //}
        }
        private void dataGridViewUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ////Find index of the row clicked
            //int index = e.RowIndex;
            ////Get VAlues from Row Clicked
            //string UserID = dataGridViewUsers.Rows[index].Cells[0].Value.ToString();
            //string FullName = dataGridViewUsers.Rows[index].Cells[1].Value.ToString();
            //string Username = dataGridViewUsers.Rows[index].Cells[2].Value.ToString();
            //string Email = dataGridViewUsers.Rows[index].Cells[3].Value.ToString();
            //string Contact = dataGridViewUsers.Rows[index].Cells[4].Value.ToString();
            //string Password = dataGridViewUsers.Rows[index].Cells[5].Value.ToString();
            //string UserType = dataGridViewUsers.Rows[index].Cells[6].Value.ToString();

            ////Write These Values to the Textbox
            //textBoxUserID.Text = UserID;
            //textBoxFullName.Text = FullName;
            //textBoxUsername.Text = Username;
            //textBoxEmail.Text = Email;
            //textBoxContact.Text = Contact;
            //textBoxPassword.Text = Password;
            //comboBoxUserType.Text = UserType;
        }
        private void frmExpensess_Load(object sender, EventArgs e)
        {

            var _TblExpentidures = _dbContext.TblExpentidures.ToList();
            var _TblFundTypes = _dbContext.TblFundTypes.ToList();
            // Perform the join operation
            var result = from fund in _dbContext.TblFundTypes.ToList()
                         join exp in _TblExpentidures on fund.FundTypeId equals exp.FundTypeId
                         select new { exp.ExpentidureId, exp.FundTypeId, fund.FundTypeName, exp.Amount, exp.Details };
            dgvExpentidure.DataSource = result.ToList();
            dgvExpentidure.Columns["ExpentidureId"].Visible = false;
            dgvExpentidure.Columns["FundTypeId"].Visible = false;
            //dgvExpentidure.Dock = DockStyle.Fill;
            foreach (DataGridViewColumn column in dgvExpentidure.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            //dgvExpentidure.AutoGenerateColumns = true;
            cmbFundType.DataSource = _TblFundTypes;
            cmbFundType.DisplayMember = "FundTypeName";//  // Display the 'Text' property of Item
            cmbFundType.ValueMember = "FundTypeID"; // Use the 'Value' property of Item as the valu
                                                    //cmbFundType.ValueMember = "Name";
                                                    //cmbFundType.Text = "Name";

        }
        private void frmFunds_Load(object sender, EventArgs e)
        {


        }
        void Clear()
        {
            txtAmount.Text = "";
            cmbFundType.SelectedValue = "Select";
            txtDetails.Text = "";
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //int UserID = int.Parse(textBoxUserID.Text.Trim());
            //if (UserID != 0 || textBoxUserID.Text != null)
            //{
            //    User U = new User();
            //    U.UserID = UserID;

            //    UserDAL dal = new UserDAL();
            //    bool success = dal.Delete_User(U);
            //    if (success == true)
            //    {
            //        MessageBox.Show("User Successfully Deleted.");
            //        //Refresh
            //        DataTable dt = dal.Select_User();
            //        dataGridViewUsers.DataSource = dt;

            //        //Clear
            //        Clear();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Failed to Delete USer.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Select User First.");
            //}
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ////Get User Input
            //string keyword = txtSearch.Text;

            //if (keyword != null)
            //{
            //    UserDAL dal = new UserDAL();
            //    DataTable dt = dal.Select_User_By_Keywords(keyword);
            //    dataGridViewUsers.DataSource = dt;
            //}
            //else
            //{
            //    UserDAL dal = new UserDAL();
            //    DataTable dt = dal.Select_User();
            //    dataGridViewUsers.DataSource = dt;
            //}
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int _txtAmount = Convert.ToInt32(txtAmount.Text);
                int _cmbFundType = Convert.ToInt32(cmbFundType.SelectedValue);
                string _txtDetails = txtDetails.Text.ToString();

                TblExpentidure tblExpentidure = new TblExpentidure()
                {
                    Amount = _txtAmount,
                    FundTypeId = _cmbFundType,
                    Details = _txtDetails
                };
                _dbContext.TblExpentidures.Add(tblExpentidure);
                _dbContext.SaveChanges();
                Clear();
                frmExpensess_Load(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // Retrieve the entity you want to update
            var productToUpdate = _dbContext.TblExpentidures.FirstOrDefault(p => p.ExpentidureId == txtExpID.Text.ToInt32());

            if (productToUpdate != null)
            {
                // Modify the properties of the retrieved entity
                productToUpdate.Amount = txtAmount.Text.ToInt32();
                productToUpdate.Details = txtDetails.Text.ToString();
                productToUpdate.FundTypeId = cmbFundType.SelectedValue.ToInt32();
                // Save the changes to the database
                _dbContext.SaveChanges();
                frmExpensess_Load(null, null);
                MessageBox.Show("Record updated successfully.");
            }
            else
            {
                MessageBox.Show("Record not updated successfully.");
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {


            // Retrieve the entity you want to update
            var productToUpdate = _dbContext.TblExpentidures.FirstOrDefault(p => p.ExpentidureId == txtExpID.Text.ToInt32());



            if (productToUpdate != null)
            {
                // Save the changes to the database
                _dbContext.TblExpentidures.Remove(productToUpdate);
                _dbContext.SaveChanges();
                frmExpensess_Load(null, null);
                MessageBox.Show("Record Deleted successfully.");
            }
            else
            {
                MessageBox.Show("Record not Deleted successfully.");
            }

        }
        private void dgvExpentidure_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click event here
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Access the clicked row
                DataGridViewRow clickedRow = dgvExpentidure.Rows[e.RowIndex];
                txtExpID.Text = clickedRow.Cells[0].Value?.ToString(); // Adjust the cell index as needed
                txtFundTypeID.Text = clickedRow.Cells[1].Value?.ToString(); // Adjust the cell index as needed
                cmbFundType.Text = clickedRow.Cells[2].Value?.ToString(); // Adjust the cell index as needed
                txtAmount.Text = clickedRow.Cells[3].Value?.ToString(); // Adjust the cell index as needed
                txtDetails.Text = clickedRow.Cells[4].Value?.ToString(); // Adjust the cell index as needed


                // You can access cell values using the column index, for example
            }
        }
        private void dgvExpentidure_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvExpentidure_CellClick(sender, e);
        }
        private void dgvExpentidure_RegionChanged(object sender, EventArgs e)
        {

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            frmExpensess_Load(null, null);
            Clear();
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is not a digit or a control key (e.g., Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Block the input by setting Handled to true
                e.Handled = true;
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string searchTerm = txtSearch.Text.Trim();

            //// Perform the search using Entity Framework Core LINQ query

            //var searchResults1 = _dbContext.TblExpentidures
            //                     .Where(entity => entity.Details.Contains(searchTerm))
            //                     .ToList();

            //// Bind the search results to the DataGridView
            //dgvExpentidure.DataSource = searchResults1;

        }
        private void cbSearchBox_Click(object sender, EventArgs e)
        {

        }
    }
}
