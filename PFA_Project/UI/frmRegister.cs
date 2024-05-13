using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PFA_Project.UI
{
    public partial class frmRegister : Form
    {
        private readonly PFAdbContext _dbContext;
        public frmRegister(PFAdbContext dbContext)
        {
            _dbContext = dbContext;
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            try
            {
                string _txtPassword = txtPassword.Text; // Retrieve hashed password from your database
                string _txtConfirmPass = txtConfirmPass.Text;
                // Compare passwords
                bool passwordsMatch = _txtPassword.Equals(_txtConfirmPass);
                if (passwordsMatch)
                {

                    //string mobileNumber = txtContact.Text.Trim();
                    //if (IsValidMobileNumber(mobileNumber))
                    //{
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Invalid mobile number, sample: 03349149169", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    return;
                    //}
                    var IsExist = UsernameExists(txtUsername.Text);
                    if (!IsExist)
                    {                 //txtConfirmPass.Text;
                        var tblUsers = new TblUser()
                        {
                            UserName = txtUsername.Text,
                            UserPassword = txtPassword.Text,
                            CreatedDate = DateTime.Now,
                            IsActive = true,
                            CreatedBy = 0,
                            Contact = txtContact.Text.Trim()
                        };
                        _dbContext.TblUsers.Add(tblUsers);
                        _dbContext.SaveChanges();
                        Clear();
                        MessageBox.Show("User Registered Successfully", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User Already Exists", "User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            // After successful registration, close the registration form


            // Open the login form
            frmLogin loginForm = new frmLogin(_dbContext);
            loginForm.Show();


            this.Hide();
            // this.Close();
        }
        public bool IsValidMobileNumber(string mobileNumber)
        {
            // Regular expression pattern for a mobile number
            string pattern = @"^\d{10}$";

            // Check if the mobile number matches the pattern
            return Regex.IsMatch(mobileNumber, pattern);
        }

        void Clear()
        {
            txtConfirmPass.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtContact.Text = "";
        }


        // Check if username already exists
        public bool UsernameExists(string username)
        {

            // Query the database for the username
            var existingUser = _dbContext.TblUsers.FirstOrDefault(u => u.UserName == username);

            // If existingUser is not null, the username already exists
            return existingUser != null;

        }

    }
}
