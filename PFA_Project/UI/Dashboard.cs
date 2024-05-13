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
    public partial class Dashboard : Form
    {
        private readonly PFAdbContext _dbContext;
        public Dashboard(PFAdbContext dbContext)
        {
            _dbContext = dbContext;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            labelCountUser.Text = _dbContext.TblUsers.Count().ToString();
            lblFund.Text = _dbContext.TblFundReciveds.Count().ToString();
            lblExp.Text = _dbContext.TblExpentidures.Count().ToString();
        }
    }
}
