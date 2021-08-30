using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stuport
{
    public partial class StudentUpdateData : Form
    {
        bool blnValidInput = false;
        private readonly DataBaseManager db = DataBaseManager.getInstance;
        private readonly String userId;


        public StudentUpdateData(String userId)
        {
            this.userId = userId;
            InitializeComponent();
            initializeTextBoxWithUserData(userId);
        }

        private void initializeTextBoxWithUserData(string userId)
        {
            OleDbDataReader reader = db.select("select User_FName, User_LName, User_Email, User_Password, User_PhoneNumber from StuPortUser where User_id = @0",
                    new String[] { userId});
            while (reader.Read())
            {

                String student_first_name = reader[0].ToString();
                String student_last_name = reader[1].ToString();
                String student_email = reader[2].ToString();
                String student_password = reader[3].ToString();
                String student_phone_number = reader[4].ToString();

                txtBoxFirstName.Text = student_first_name;
                txtBoxLastName.Text = student_last_name;
                txtBoxEmail.Text = student_email;
                txtPassword.Text = student_password;
                txtConfPassword.Text = student_password;
                maskedTxtBoxPhoneNum.Text = student_phone_number;
               

                break;
            }

            //close reader and connection, because when db.select was called, it left the connection open
            reader.Close();
            db.closeConnection();
        }

        private void btnStudentUpdateData_Click(object sender, EventArgs e)
        {
            blnValidInput = validateInput();
            if (blnValidInput) {
                String student_first_name = txtBoxFirstName.Text.Trim();
                String student_last_name = txtBoxLastName.Text.Trim();
                String student_email = txtBoxEmail.Text.Trim();
                String student_phone_number = maskedTxtBoxPhoneNum.Text.Trim();
                String student_password = txtPassword.Text.Trim();

                int result = db.update("update StuPortUser set User_FName = @0, User_LName = @1, User_Email = @2, User_Password = @3, User_PhoneNumber = @4 where User_id = @5",
                    new string[] { student_first_name, student_last_name, student_email, student_password, student_phone_number, userId });

                if (result == 1)
                {
                    //update success
                    MessageBox.Show("Student details updated successfully", "Update Data");
                    this.Close();
                }
                else {
                    MessageBox.Show("Student details update failed", "Update Data");
                }
            }
        }

        private bool validateInput()
        {
            bool allIsOkay = true;

            
            if (txtBoxFirstName.Text.Trim() == "")
            {
                allIsOkay = false;
                errorProvider1.SetError(txtBoxFirstName, "enter first name");
            }
            else
            {
                errorProvider1.SetError(txtBoxFirstName, "");
            }

            if (txtBoxLastName.Text.Trim() == "")
            {
                allIsOkay = false;
                errorProvider1.SetError(txtBoxLastName, "enter last name");
            }
            else
            {
                errorProvider1.SetError(txtBoxLastName, "");
            }

            //email is verified differently
            //case 1: check if email is entered
            //case 2: check if email is the correct format
            String enteredEmail = txtBoxEmail.Text.Trim();
            var emailValidator = new EmailAddressAttribute(); //used to check if the email is in the correct format

            if (enteredEmail == "")
            {
                allIsOkay = false;
                errorProvider1.SetError(txtBoxEmail, "Enter email");
            }
            else if (!emailValidator.IsValid(enteredEmail))
            {
                allIsOkay = false;
                errorProvider1.SetError(txtBoxEmail, "incorrect email format");
            }
            else
            {
                errorProvider1.SetError(txtBoxEmail, "");
            }

            if (!maskedTxtBoxPhoneNum.MaskCompleted)
            {
                allIsOkay = false;
                errorProvider1.SetError(maskedTxtBoxPhoneNum, "enter full phone number");
            }
            else
            {
                errorProvider1.SetError(maskedTxtBoxPhoneNum, "");
            }

            //password is verified differently
            //case 1: check if password is entered
            //case 2: check if password matches confirm password

            String password = txtPassword.Text.Trim();
            String conf_password = txtConfPassword.Text.Trim();

            if (password == "")
            {
                allIsOkay = false;
                errorProvider1.SetError(txtPassword, "enter password");
            }

            else
            {
                errorProvider1.SetError(txtPassword, "");
            }

            if (conf_password == "")
            {
                allIsOkay = false;
                errorProvider1.SetError(txtConfPassword, "enter confirm password");
            }
            else if (password != conf_password)
            {
                allIsOkay = false;

                errorProvider1.SetError(txtPassword, "password mismatch");
                errorProvider1.SetError(txtConfPassword, "password mismatch");
            }
            else
            {
                errorProvider1.SetError(txtConfPassword, "");
            }


            return allIsOkay;
        }
    }
}
