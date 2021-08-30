using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stuport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStudLogin_Click(object sender, EventArgs e)
        {
            DefaultMethods.LaunchActivity(this, new StudentLogin(), true);
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            DefaultMethods.LaunchActivity(this, new AdminLogin(), true);
        }

        private void btnStudCreateAcc_Click(object sender, EventArgs e)
        {
            DefaultMethods.LaunchActivity(this, new StudentRegister(), false);
        }

        
    }
}
