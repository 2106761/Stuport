using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stuport
{
    public partial class StudentMainPage : Form
    {
        private readonly String userId;
        private readonly DataBaseManager db = DataBaseManager.getInstance;
        public StudentMainPage(String userId)
        {
            this.userId = userId;
            InitializeComponent();
            DisplayUserData();
        }

        private void DisplayUserData() {
            OleDbDataReader reader = db.select("select User_FName, User_LName, User_Email, User_PhoneNumber from StuPortUser where User_id = @0",
                    new String[] { userId });
            while (reader.Read())
            {

                String student_first_name = reader[0].ToString();
                String student_last_name = reader[1].ToString();
                String student_email = reader[2].ToString();
                String student_phone_number = reader[3].ToString();

                lblStudentName.Text = student_first_name + " " + student_last_name;
                lblStudEmail.Text = student_email;
                lblPhoneNumber.Text = student_phone_number;

                break;
            }

            //close reader and connection, because when db.select was called, it left the connection open
            reader.Close();
            db.closeConnection();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            DefaultMethods.LaunchActivity(this, new StudentUpdateData(userId), false);
            //if user updates their data, then display the new data
            DisplayUserData();
        }

        private void btnProfile_MouseEnter(object sender, EventArgs e)
        {
            DefaultMethods.setFlowLayoutHoverColor(btnProfile);
        }

        private void btnProfile_MouseLeave(object sender, EventArgs e)
        {
            DefaultMethods.setFlowLayoutNormalColor(btnProfile);
        }

        private void btnStudSetAppointment_Click(object sender, EventArgs e)
        {
            DefaultMethods.LaunchActivity(this, new StudentAppointment(userId), false);
        }

        private void appointmentLayout_MouseEnter(object sender, EventArgs e)
        {
            DefaultMethods.setFlowLayoutHoverColor(appointmentLayout);
        }

        private void appointmentLayout_MouseLeave(object sender, EventArgs e)
        {
            DefaultMethods.setFlowLayoutNormalColor(appointmentLayout);
        }

        private void appointmentLayout_Click(object sender, EventArgs e)
        {
            DefaultMethods.LaunchActivity(this, new StudentAppointment(userId), false);
        }
    }
}
