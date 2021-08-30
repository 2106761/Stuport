using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace Stuport
{
    public partial class StudentRegister : Form
    {
        bool blnValidInput = false;
        private readonly DataBaseManager db = DataBaseManager.getInstance;

        public StudentRegister()
        {
            InitializeComponent();
        }

        private void btnStudentCreateAcc_Click(object sender, EventArgs e)
        {
            blnValidInput = validateInput();
            if (blnValidInput) {

                int result = db.insert(
                    "StuPortUser", //table name
                    new string[] {"User_id", "User_FName", "User_LName", "User_Email", "User_Password", "User_PhoneNumber", "User_Type"}, //column names
                    new object[] { txtBoxStudentNum.Text, txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxEmail.Text, txtPassword.Text, maskedTxtBoxPhoneNum.Text, 0 } //values
                    );

                if (result > 0)
                { //success
                    MessageBox.Show("Registration success");
                    this.Close();
                }
                else {
                    MessageBox.Show("Registration failed");
                }
            }
        }

        //validates if user inputted data correctly
        private bool validateInput()
        {
            bool allIsOkay = true;

            if (txtBoxStudentNum.Text.Trim() == "")
            {
                //show error
                allIsOkay = false;
                errorProvider1.SetError(txtBoxStudentNum, "Enter student number");
            }
            else {
                //hide error if user has entered this input
                errorProvider1.SetError(txtBoxStudentNum, "");
            }

            if (txtBoxFirstName.Text.Trim() == "")
            {
                allIsOkay = false;
                errorProvider1.SetError(txtBoxFirstName, "enter first name");
            }
            else {
                errorProvider1.SetError(txtBoxFirstName, "");
            }

            if (txtBoxLastName.Text.Trim() == "")
            {
                allIsOkay = false;
                errorProvider1.SetError(txtBoxLastName, "enter last name");
            }
            else {
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
            else {
                errorProvider1.SetError(txtBoxEmail, "");
            }

            if (!maskedTxtBoxPhoneNum.MaskCompleted)
            {
                allIsOkay = false;
                errorProvider1.SetError(maskedTxtBoxPhoneNum, "enter full phone number");
            }
            else {
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

            else {
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
            else {
                errorProvider1.SetError(txtConfPassword, "");
            }
       

            return allIsOkay;
        }
    }
}
