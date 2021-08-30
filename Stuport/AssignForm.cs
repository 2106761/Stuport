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
    public partial class AssignForm : Form
    {
        private readonly DataBaseManager db = DataBaseManager.getInstance;
        private bool blnValidInput = false;
        DateTime nextWeekMonday = DateTime
                          .Today
                          .AddDays(-(DateTime.Today.DayOfWeek - DayOfWeek.Monday))
                          .AddHours(10)
                          .AddDays(7);
        private readonly String userId;
        private readonly String groupId;
        private int selected_venue_id = -1;
        private int selected_counsellor_id = -1;

        public AssignForm(String userId, String groupId)
        {
            InitializeComponent();
            this.userId = userId;
            this.groupId = groupId;
            datePicker.Value = nextWeekMonday;
            DisplayVenues();
            DisplayCounsellors();
        }

        private void DisplayCounsellors()
        {
            OleDbDataReader reader = db.select("select * from Personnel", new String[] { });
            while (reader.Read())
            {
                String fName = reader[1].ToString().Trim();
                String lName = reader[2].ToString().Trim();

                addCounsellorToComboBox(fName + " " + lName);
            }

            //close reader and connection, because when db.select was called, it left the connection open
            reader.Close();
            db.closeConnection();
        }

        private void DisplayVenues()
        {
            OleDbDataReader reader = db.select("select * from Venue", new String[] { });
            while (reader.Read())
            {
                String venueName = reader[1].ToString().Trim();
                addVenueToComboBox(venueName);
            }

            //close reader and connection, because when db.select was called, it left the connection open
            reader.Close();
            db.closeConnection();
        }

        private void addVenueToComboBox(string venueName)
        {
            cbVenueList.Items.Add(venueName);
        }

        private void addCounsellorToComboBox(string counsellorName)
        {
            cbCounsellor.Items.Add(counsellorName);
        }

        private bool validateAppointmentInputs()
        {
            bool allIsOkay = true;
            DateTime selectedDate = datePicker.Value;

            if (cbVenueList.SelectedIndex < 0)
            {
                allIsOkay = false;
                MessageBox.Show("Select a venue");
            }

            if (cbCounsellor.SelectedIndex < 0)
            {
                allIsOkay = false;
                MessageBox.Show("Select a counsellor");
            }

            if (selectedDate.Date < nextWeekMonday.Date)
            {
                allIsOkay = false;
                MessageBox.Show("Select date in the upcoming week");
            }

            if (!radioAcademicHelp.Checked && !radioPersonalAndPsych.Checked) {
                allIsOkay = false;
                MessageBox.Show("Select service type");
            }

            return allIsOkay;
        }

        private void btnSetAppointment_Click(object sender, EventArgs e)
        {
            blnValidInput = validateAppointmentInputs();
            if (blnValidInput)
            {
                selected_counsellor_id = cbCounsellor.SelectedIndex + 1;
                selected_venue_id = cbVenueList.SelectedIndex + 1;

                DateTime selectedDate = datePicker.Value;

                string sSelectedDate = selectedDate.ToString("dd/MM/yyyy");
                string sSelectedTime = TimePicker.Value.ToString("HH:mm");

                int type;
                if (radioAcademicHelp.Checked)
                {
                    type = 1;
                }
                else {
                    type = 2;
                }
                
                int result = db.insert(
                    "Appointment", //table name
                    new string[] { "User_id", "Service_id", "Appoint_Date", "Appoint_Time", "Personnel_id", "Venue_id" }, //column names
                    new object[] { userId, type, sSelectedDate, sSelectedTime, selected_counsellor_id, selected_venue_id } //values
                    );

                if (result > 0)
                { //success
                    
                    MessageBox.Show("Appointment set successfully");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Appointment set failed");
                }
            }
        }
    }
}
