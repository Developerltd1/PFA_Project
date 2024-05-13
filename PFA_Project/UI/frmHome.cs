
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

namespace PFA_Project.UI
{
    public partial class frmHome : Form
    {
        private readonly PFAdbContext _dbContext;
        public frmHome(PFAdbContext dbContext)
        {
            _dbContext = dbContext;
            InitializeComponent();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //frmExpensess user = new frmFunds();
            //user.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmFundRecived frm = new frmFundRecived(_dbContext);
            CheckFormStatus(frm);
            //this.Close();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPurchase purchase = new frmPurchase();
            //purchase.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmSale sale = new frmSale();
            //sale.Show();
        }
        //allow only single instance of form open
        public void CheckFormStatus(Form f)
        {
            bool found = false;
            foreach (Form frm in MdiChildren)
            {
                if (f.Text == frm.Text)
                {
                    found = true;
                    frm.Activate();
                    return;
                }
            }
            if (!found)
            {
                f.MdiParent = this;
                f.Show();
            }
        }
        private void frmHome_Load(object sender, EventArgs e)
        {

            //labelCountUser.Text = _dbContext.TblUsers.Count().ToString();
            //lblFund.Text = _dbContext.TblFundReciveds.Count().ToString();
            //lblExp.Text = _dbContext.TblExpentidures.Count().ToString();
            // ProductDAL dal = new ProductDAL();
            // decimal products = dal.Get_Products();
            // labelCountProduct.Text = products.ToString();

            // UserDAL users = new UserDAL();
            // decimal totalusers =users.Get_Users();
            // labelCountUser.Text = totalusers.ToString();

            // string username = frmLogin.username;
            //labelUser.Text = "Hello "+users.Get_Users_FullName(username);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpensess frm = new frmExpensess(_dbContext);
            CheckFormStatus(frm);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard(_dbContext);
            CheckFormStatus(frm);
        }
    }
}
