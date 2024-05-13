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

namespace PFA_Project.UI
{
    public partial class frmFundRecived : Form
    {
        private readonly PFAdbContext _dbContext;

        public frmFundRecived(PFAdbContext dbContext)
        {
            _dbContext = dbContext;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int _txtAmount = Convert.ToInt32(txtAmount.Text);
                int _cmbFundType = Convert.ToInt32(cmbFundType.SelectedValue);
                string _txtDetails = txtDetails.Text.ToString();

                TblFundRecived _tblFundRecived = new TblFundRecived()
                {
                    Amount = _txtAmount,
                    FundTypeId = _cmbFundType,
                    Details = _txtDetails
                };
                _dbContext.TblFundReciveds.Add(_tblFundRecived);
                _dbContext.SaveChanges();
                Clear();
                frmFundRecived_Load(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFundRecived_Load(object sender, EventArgs e)
        {

            var _TblFundReciveds = _dbContext.TblFundReciveds.ToList();
            var _TblFundTypes = _dbContext.TblFundTypes.ToList();
            // Perform the join operation
            var result = from fund in _dbContext.TblFundTypes.ToList()
                         join fr in _TblFundReciveds on fund.FundTypeId equals fr.FundTypeId
                         select new { fr.FundRecivedId, fr.FundTypeId, fund.FundTypeName, fr.Amount, fr.Details };
            var resultDesc = result.ToList();
            dgvExpentidure.DataSource = resultDesc.ToList();
            dgvExpentidure.Columns["FundRecivedId"].Visible = false;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtAmount.Text = "";
            cmbFundType.SelectedValue = "Select";
            txtDetails.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {


                // Retrieve the entity you want to update
                var productToUpdate = _dbContext.TblFundReciveds.FirstOrDefault(p => p.FundRecivedId == txtExpID.Text.ToInt32());
                if (productToUpdate != null)
                {
                    // Modify the properties of the retrieved entity
                    productToUpdate.Amount = txtAmount.Text.ToInt32();
                    productToUpdate.Details = txtDetails.Text.ToString();
                    productToUpdate.FundTypeId = cmbFundType.SelectedValue.ToInt32();
                    // Save the changes to the database
                    _dbContext.SaveChanges();
                    frmFundRecived_Load(null, null);
                    MessageBox.Show("Record updated successfully.");
                }
                else
                {
                    MessageBox.Show("Record not updated successfully.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                // Retrieve the entity you want to update
                var productToUpdate = _dbContext.TblFundReciveds.FirstOrDefault(p => p.FundRecivedId == txtExpID.Text.ToInt32());



                if (productToUpdate != null)
                {
                    // Save the changes to the database
                    _dbContext.TblFundReciveds.Remove(productToUpdate);
                    _dbContext.SaveChanges();
                    frmFundRecived_Load(null, null);
                    MessageBox.Show("Record Deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Record not Deleted successfully.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is not a digit or a control key (e.g., Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Block the input by setting Handled to true
                e.Handled = true;
            }
        }
    }
}
