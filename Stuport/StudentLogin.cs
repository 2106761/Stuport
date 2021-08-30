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
    public partial class StudentLogin : Form
    {
        bool blnValidInput = false;
        private readonly DataBaseManager db = DataBaseManager.getInstance;

        public StudentLogin()
        {
            InitializeComponent();
        }

        private void btnStudLogIn_Click(object sender, EventArgs e)
        {
            blnValidInput = validateInput();

            if (blnValidInput) {

                String userId = txtBoxStudentNum.Text.Trim();
                String userPass = txtBoxPassword.Text.Trim();

                OleDbDataReader reader = db.select("select User_id from StuPortUser where User_id = @0 and User_Password = @1",
                    new String[] { userId, userPass});

                //checking if the student is in the database
                int i = 0;
                while (reader.Read()) {
                    if (i == 2) break;
                    i++;
                }

                //close reader and connection, because when db.select was called, it left the connection open
                reader.Close();
                db.closeConnection();

                if (i == 1)
                {

                    //login success
                    DefaultMethods.LaunchActivity(this, new StudentMainPage(userId), true);

                }
                else {
                    //login failed
                    MessageBox.Show("Login failed");
                }

            }
        }

        /*
         Validates the users input by checking if user inputted student num and password
         */
        private bool validateInput()
        {
            bool allIsOkay = true;

            if (txtBoxStudentNum.Text.Trim() == "")
            {
                allIsOkay = false;
                //display error close to textbox
                errorProvider1.SetError(txtBoxStudentNum, "Enter student number");
            }
            else {
                //clear error if textbox contains input
                errorProvider1.SetError(txtBoxStudentNum, "");
            }

            if (txtBoxPassword.Text.Trim() == "")
            {
                allIsOkay = false;
                errorProvider1.SetError(txtBoxPassword, "Enter password");
            }
            else {
                //clear error if textbox contains input
                errorProvider1.SetError(txtBoxPassword, "");
            }

            return allIsOkay;
        }
    }
}
