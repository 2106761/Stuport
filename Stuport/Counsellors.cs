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
    public partial class Counsellors : Form
    {
        bool blnValidInput = false;
        private readonly DataBaseManager db = DataBaseManager.getInstance;

        public Counsellors()
        {
            InitializeComponent();
            DisplayCounsellors();
        }

        private void DisplayCounsellors()
        {
            OleDbDataReader reader = db.select("select * from Personnel ORDER BY Personnel_id desc", new String[] { });
            while (reader.Read())
            {
                string personnel_first_name = reader[1].ToString();
                string personnel_last_name = reader[2].ToString();
                string personnel_email = reader[3].ToString();
                string personnel_phone_number = reader[4].ToString();

                addCounsellorToFlowLayout(personnel_first_name, personnel_last_name, personnel_email, personnel_phone_number, false);
            }

            //close reader and connection, because when db.select was called, it left the connection open
            reader.Close();
            db.closeConnection();
        }

        private void addCounsellorToFlowLayout(string personnel_first_name, string personnel_last_name, string personnel_email, string personnel_phone_number, bool newRecord)
        {
            String counsellorInfo = personnel_first_name + " " + personnel_last_name + "\n"
                                    + personnel_email + "\n"
                                    + personnel_phone_number;

            Padding viewMargins = new Padding();
            viewMargins.Left = 5;
            viewMargins.Right = 0;
            viewMargins.Top = 5;
            viewMargins.Bottom = 5;

            Font font = new Font(
                new FontFamily("Open Sans"),
                8,
                FontStyle.Bold);

            Label counsellorLabel = new Label();
            counsellorLabel.Text = counsellorInfo;
            counsellorLabel.Width = 305;
            counsellorLabel.Height = 90;
            counsellorLabel.TextAlign = ContentAlignment.MiddleCenter;
            counsellorLabel.BackColor = Color.DarkSlateBlue;
            counsellorLabel.Margin = viewMargins;
            counsellorLabel.ForeColor = Color.White;
            counsellorLabel.Font = font;
            counsellorLabel.Cursor = Cursors.Hand;

            counsellorFlowLayout.Controls.Add(counsellorLabel);

            if (newRecord) counsellorFlowLayout.Controls.SetChildIndex(counsellorLabel, 1);
        }

        private void btnAddCounsellor_Click(object sender, EventArgs e)
        {
            blnValidInput = validateInput();
            if (blnValidInput) {
                string personnel_first_name = txtBoxFirstName.Text.Trim();
                string personnel_last_name = txtBoxLastName.Text.Trim();
                string personnel_email = txtBoxEmail.Text.Trim();
                string personnel_phone_number = maskedTxtBoxPhoneNum.Text.Trim();

                int result = db.insert(
                    "Personnel", //table name
                    new string[] { "personnel_FName", "Personnel_LName", "Personnel_Email", "Personnel_PhoneNumber"}, //column names
                    new object[] { personnel_first_name, personnel_last_name, personnel_email, personnel_phone_number} //values
                    );

                if (result > 0)
                { //success
                    MessageBox.Show("Counsellor registration success");
                    addCounsellorToFlowLayout(personnel_first_name, personnel_last_name, personnel_email, personnel_phone_number, true);

                    txtBoxFirstName.Text = "";
                    txtBoxLastName.Text = "";
                    txtBoxEmail.Text = "";
                    maskedTxtBoxPhoneNum.Text = "";
                }
                else
                {
                    MessageBox.Show("Counsellor registration failed");
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

            
            return allIsOkay;
        }
    }
}
