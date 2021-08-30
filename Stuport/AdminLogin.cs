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
    public partial class AdminLogin : Form
    {
        bool blnValidInput = false;
        private readonly DataBaseManager db = DataBaseManager.getInstance;

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            blnValidInput = validateInput();
            if (blnValidInput) {
                String userId = txtBoxAdminNum.Text.Trim();
                String userPass = txtPassword.Text.Trim();

                OleDbDataReader reader = db.select("select User_id from StuPortUser where User_id = @0 and User_Password = @1 and User_Type = 1",
                    new String[] { userId, userPass });
                int i = 0;
                while (reader.Read())
                {
                    if (i == 2) break;
                    i++;
                }

                //close reader and connection, because when db.select was called, it left the connection open
                reader.Close();
                db.closeConnection();

                if (i == 1)
                {
                    //login success
                    DefaultMethods.LaunchActivity(this, new AdminPage(), true);

                }
                else
                {
                    //login failed
                    MessageBox.Show("Login failed");
                }

            }
        }

        private bool validateInput()
        {
            bool allIsOkay = true;

            if (txtBoxAdminNum.Text.Trim() == "")
            {
                allIsOkay = false;
                //display error close to textbox
                errorProvider1.SetError(txtBoxAdminNum, "Enter student number");
            }
            else
            {
                //clear error if textbox contains input
                errorProvider1.SetError(txtBoxAdminNum, "");
            }

            if (txtPassword.Text.Trim() == "")
            {
                allIsOkay = false;
                errorProvider1.SetError(txtPassword, "Enter password");
            }
            else
            {
                //clear error if textbox contains input
                errorProvider1.SetError(txtPassword, "");
            }

            return allIsOkay;
        }

    }
}
