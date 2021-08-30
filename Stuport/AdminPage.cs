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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        

        private void btnAppointment_MouseLeave(object sender, EventArgs e)
        {
            DefaultMethods.setFlowLayoutNormalColor(btnAppointment);
        }

        

        private void btnCounsellingGroup_MouseLeave(object sender, EventArgs e)
        {
            DefaultMethods.setFlowLayoutNormalColor(btnCounsellingGroup);
        }

        private void btnCounsellors_MouseLeave(object sender, EventArgs e)
        {
            DefaultMethods.setFlowLayoutNormalColor(btnCounsellors);
        }

        private void btnStudents_MouseEnter(object sender, EventArgs e)
        {

            DefaultMethods.setFlowLayoutHoverColor(btnStudents);
        }

        private void btnStudents_MouseLeave(object sender, EventArgs e)
        {
            DefaultMethods.setFlowLayoutNormalColor(btnStudents);
        }

        private void btnAppointment_MouseEnter(object sender, EventArgs e)
        {
            DefaultMethods.setFlowLayoutHoverColor(btnAppointment);
        }

        private void btnCounsellingGroup_MouseEnter(object sender, EventArgs e)
        {
            DefaultMethods.setFlowLayoutHoverColor(btnCounsellingGroup);
        }

        private void btnCounsellors_MouseEnter(object sender, EventArgs e)
        {
            DefaultMethods.setFlowLayoutHoverColor(btnCounsellors);
        }

        private void btnVenues_MouseEnter(object sender, EventArgs e)
        {
            DefaultMethods.setFlowLayoutHoverColor(btnVenues);
        }

        private void btnVenues_MouseLeave(object sender, EventArgs e)
        {
            DefaultMethods.setFlowLayoutNormalColor(btnVenues);
        }

        private void btnVenues_Click(object sender, EventArgs e)
        {
            DefaultMethods.LaunchActivity(this, new Venue(), false);
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            DefaultMethods.LaunchActivity(this, new StudentView(), false);
        }

        private void btnCounsellors_Click(object sender, EventArgs e)
        {
            DefaultMethods.LaunchActivity(this, new Counsellors(), false);
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            DefaultMethods.LaunchActivity(this, new AdminAppointments(), false);
        }

        private void btnCounsellingGroup_Click(object sender, EventArgs e)
        {
            DefaultMethods.LaunchActivity(this, new CounsellingGroups(), false);
        }
    }
}
