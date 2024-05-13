
using DAL.Models;
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

namespace PFA_Project.UI
{
    public partial class frmLogin : Form
    {

        private readonly PFAdbContext _dbContext;
        public frmLogin(PFAdbContext dbContext)
        {
            _dbContext = dbContext;
            InitializeComponent();
        }


        //public static string username;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string _txtUsername = textBoxUsername.Text; // Retrieve hashed password from your database
                string _txtPassword = textBoxPassword.Text;
                // Compare passwords
                var IsExist = UsernameExists(_txtUsername, _txtPassword);
                if (IsExist)
                {
                    frmHome frm = new frmHome(_dbContext);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials", "User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister(_dbContext);
            frmRegister.Show();

            this.Hide();
            // this.Close(
        }

        public bool UsernameExists(string username, string password)
        {
            bool condition = false;
            // Query the database for the username
            var existingUser = _dbContext.TblUsers.FirstOrDefault(u => u.UserName == username && u.UserPassword == password);

            // If existingUser is not null, the username already exists
            if (existingUser != null) 
            { condition = true; }
            else 
            { condition = false; }

            return condition;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            // Add this textbox to form
            this.Controls.Add(textBoxPassword);
        }
    }
}
