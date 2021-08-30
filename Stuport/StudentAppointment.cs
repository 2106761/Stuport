using System;
using System.Collections;
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
    public partial class StudentAppointment : Form
    {
        int selected_service_id = -1;
        int selected_group = -1;
        bool blnValidInput = false;
        ArrayList descList = new ArrayList();

        DateTime nextWeekMonday = DateTime
                          .Today
                          .AddDays(-(DateTime.Today.DayOfWeek - DayOfWeek.Monday))
                          .AddHours(10)
                          .AddDays(7);
        RadioButton selectedRadionButton = null;

        private readonly DataBaseManager db = DataBaseManager.getInstance;
        private readonly string userId;

        public StudentAppointment(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            DisplayServices();
            DisplayGroups();
            SetDatePickerDate();
        }

        private void DisplayGroups()
        {
            OleDbDataReader reader = db.select("select * from CounsellingGroup", 
                new String[]{ });

            while (reader.Read())
            {
                int group_id = Int32.Parse(reader[0].ToString().Trim());
                string group_name = reader[1].ToString();
                string group_description = reader[2].ToString();

                addGroupToComboBox(group_id, group_name, group_description);
            }

            reader.Close();
            db.closeConnection();
        }

        private void DisplayServices()
        {
            OleDbDataReader reader = db.select("select * from Service",
                    new String[] { });

            while (reader.Read())
            {
                int serviceId = Int32.Parse(reader[0].ToString().Trim());
                string serviceName = reader[1].ToString();
                string serviceDescription = reader[2].ToString();

                addServiceToServiceLayout(serviceId, serviceName, serviceDescription);
            }

            reader.Close();
            db.closeConnection();
        }

        private void addGroupToComboBox(int group_id, string group_name, string group_description)
        {
            descList.Add(group_description);
            cbGroupList.Items.Add(group_name);
        }

        private void SetDatePickerDate()
        {
            datePicker.Value = nextWeekMonday;
        }

        private void radioResidence_CheckedChanged(object sender, EventArgs e)
        {
            selected_service_id = -1;
            selectedRadionButton = null;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////  
            SetDescription("Includes information about available residences, residence location, residence cost and offered services");
        }

        private void radioFinancialHelp_CheckedChanged(object sender, EventArgs e)
        {
            selected_service_id = -1;
            selectedRadionButton = null;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
            SetDescription("Administers funds on behalf of the University, donors and sponsors, provides information on student funding");
        }
        
        private void SetDescription(String description)
        {
            lblDescription.Text = description;
        }

        
        private void addServiceToServiceLayout(int serviceId, string serviceName, string serviceDescription)
        {
            Padding viewMargins = new Padding();
            viewMargins.Left = 25;
            viewMargins.Right = 0;
            viewMargins.Top = 16;
            viewMargins.Bottom = 0;

            Font font = new Font(
                new FontFamily("Roboto"),
                8,
                FontStyle.Bold);

            RadioButton serviceButton = new RadioButton();
            serviceButton.Height = 17;
            serviceButton.Width = 200;
            serviceButton.Text = serviceName;
            serviceButton.Margin = viewMargins;
            serviceButton.Font = font;
            serviceButton.ForeColor = Color.White;
            serviceButton.Cursor = Cursors.Hand;

            serviceButton.Name = serviceId.ToString();
            serviceButton.Tag = serviceDescription;

            serviceButton.MouseClick += new MouseEventHandler(serviceButton_MouseClick);
            

            serviceLayout.Controls.Add(serviceButton);
            serviceLayout.Controls.SetChildIndex(serviceButton, 1);
        }

        public void serviceButton_MouseClick(object sender, EventArgs e) {
            RadioButton serviceButton = (RadioButton)sender;
            selected_service_id = Int32.Parse(serviceButton.Name);
            string selected_service_desc = serviceButton.Tag.ToString();

            SetDescription(selected_service_desc);

            selectedRadionButton = serviceButton;
        }

        private void btnStudSetAppointment_Click(object sender, EventArgs e)
        {
            blnValidInput = validateInput();
            if (blnValidInput) {

                DateTime selectedDate = datePicker.Value;

                string service_id = selected_service_id.ToString();
                string sSelectedDate = selectedDate.ToString("dd/MM/yyyy");
                string sSelectedTime = TimePicker.Value.ToString("HH:mm");

                int result = db.insert(
                    "Appointment", //table name
                    new string[] { "User_id", "Service_id", "Appoint_Date", "Appoint_Time"}, //column names
                    new object[] { userId, service_id, sSelectedDate, sSelectedTime} //values
                    );

                if (result > 0)
                { //success
                    MessageBox.Show("Appointment set successfully");
                    datePicker.Value = nextWeekMonday;
                    selectedRadionButton.Checked = false;
                }
                else
                {
                    MessageBox.Show("Appointment set failed");
                }
            }
        }

        private bool validateInput()
        {
            bool allIsOkay = true;

            if (selected_service_id == -1) {
                MessageBox.Show("Please select a service");
                allIsOkay = false;
            }

            DateTime selectedDate = datePicker.Value;
            if (selectedDate.Date < nextWeekMonday.Date) {
                MessageBox.Show("Please select a day starting from next week monday and beyond");
                allIsOkay = false;
            }

            return allIsOkay;
        }

        private void cbGroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_group = cbGroupList.SelectedIndex;
            if (selected_group >= 0) {
                string desc = (string)descList[selected_group];
                SetDescription(desc);
            }
            Console.WriteLine("Pos: " + selected_group);
        }

        private void btnJoinGroup_Click(object sender, EventArgs e)
        {
            blnValidInput = validateGroup();
            if (blnValidInput) {

                OleDbDataReader reader = db.select("select * from GroupMembers where User_id = @0 and Group_id = @1", new string[] { userId, (selected_group + 1).ToString()});
                int check = 0;
                while (reader.Read())
                {
                    check++;
                    break;
                }

                //close reader and connection, because when db.select was called, it left the connection open
                reader.Close();
                db.closeConnection();

                if (check == 0)
                {
                    int result = db.insert(
                        "GroupMembers", //table name
                        new string[] { "Group_id", "User_id" }, //column names
                        new object[] { selected_group + 1, userId } //values
                        );

                    if (result > 0)
                    { //success
                        MessageBox.Show("You joined the group successfully");
                        blnValidInput = false;
                    }
                    else
                    {
                        MessageBox.Show("Group join failed");
                    }
                }
                else {
                    MessageBox.Show("Your already in this group");
                }
            }
        }

        private bool validateGroup() {
            bool allIsOkay = true;

            if (selected_group >= 0)
            {
                allIsOkay = true;
            }
            else
            {
                allIsOkay = false;
                MessageBox.Show("Select a group you want to join", "Group Error");
            }

            return allIsOkay;
        }


    }
}
