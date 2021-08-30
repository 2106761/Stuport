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
    public partial class CounsellingGroups : Form
    {
        private readonly DataBaseManager db = DataBaseManager.getInstance;
        private int selected_group_id = -1;
        private int selected_venue_id = -1;
        private int selected_counsellor_id = -1;
        private int numOfStuds = 0;
        private bool blnValidInput = false;
        DateTime nextWeekMonday = DateTime
                          .Today
                          .AddDays(-(DateTime.Today.DayOfWeek - DayOfWeek.Monday))
                          .AddHours(10)
                          .AddDays(7);

        public CounsellingGroups()
        {
            InitializeComponent();
            DisplayGroups();
            DisplayVenues();
            DisplayCounsellors();
            datePicker.Value = nextWeekMonday;
        }

        private void DisplayCounsellors() {
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

        private void DisplayVenues() {
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

        private void DisplayGroups()
        {
            OleDbDataReader reader = db.select("select * from CounsellingGroup", new String[] { });
            while (reader.Read())
            {
                String groupId = reader[0].ToString().Trim();
                String groupName = reader[1].ToString().Trim();

                addGroupToFlowLayout(groupId, groupName);

            }

            //close reader and connection, because when db.select was called, it left the connection open
            reader.Close();
            db.closeConnection();
        }

        private void addGroupToFlowLayout(string group_id, string groupName)
        {

            Padding viewMargins = new Padding();
            viewMargins.Left = 3;
            viewMargins.Right = 0;
            viewMargins.Top = 5;
            viewMargins.Bottom = 5;

            Font font = new Font(
                new FontFamily("Open Sans"),
                8,
                FontStyle.Bold);

            Label groupLabel = new Label();
            groupLabel.Name = group_id;
            groupLabel.Text = groupName;
            groupLabel.Width = 195;
            groupLabel.Height = 90;
            groupLabel.TextAlign = ContentAlignment.MiddleCenter;
            groupLabel.BackColor = Color.DarkSlateBlue;
            groupLabel.Margin = viewMargins;
            groupLabel.ForeColor = Color.White;
            groupLabel.Font = font;
            groupLabel.Cursor = Cursors.Hand;

            groupLabel.MouseEnter += new EventHandler(groupLabel_MouseEnter);
            groupLabel.MouseLeave += new EventHandler(groupLabel_MouseLeave);
            groupLabel.MouseClick += new MouseEventHandler(groupLabel_MouseClick);

            groupFlowLayout.Controls.Add(groupLabel);
        }

        private void addVenueToComboBox( string venueName) {
            cbVenueList.Items.Add(venueName);
        }

        private void addCounsellorToComboBox(string counsellorName) {
            cbCounsellor.Items.Add(counsellorName);
        }

        private void groupLabel_MouseEnter(object sender, EventArgs e)
        {
            DefaultMethods.setLabelHoverColor((Label)sender);
        }

        private void groupLabel_MouseLeave(object sender, EventArgs e)
        {
            DefaultMethods.setLabelNormalColor((Label)sender);
        }

        private void groupLabel_MouseClick(object sender, EventArgs e)
        {
            Label grpLabel = (Label)sender;
            string groupId = grpLabel.Name;
            selected_group_id = Int32.Parse(groupId);
            DisplayMembersInGroup(groupId);
            //DefaultMethods.LaunchActivity(this, new StudentUpdateData(userId), false);

            //update the label that was clicked
            //updateLabelClickedIfThereAreChanges(studLabel, userId);
        }

        private void DisplayMembersInGroup(string groupId)
        {
            numOfStuds = 0;
            membersFlowLayout.Controls.Clear();

            OleDbDataReader reader = db.select("select * from StuPortUser inner join GroupMembers on StuPortUser.User_id = GroupMembers.User_id where GroupMembers.Group_id = @0", new String[] { groupId});
            while (reader.Read())
            {
                numOfStuds++;
                String student_num = reader[0].ToString();
                String student_first_name = reader[1].ToString();
                String student_last_name = reader[2].ToString();
                String student_email = reader[3].ToString();
                String student_phone_number = reader[5].ToString();
                string group_member_id = reader[7].ToString();
                addStudentToStudentsFlowLayout(group_member_id, student_num, student_first_name, student_last_name, student_email, student_phone_number);

            }

            //close reader and connection, because when db.select was called, it left the connection open
            reader.Close();
            db.closeConnection();
        }

        private void addStudentToStudentsFlowLayout(string group_member_id, string student_num, string student_first_name, string student_last_name, string student_email, string student_phone_number)
        {

            String studentInfo = student_first_name + " " + student_last_name + "\n"
                                + student_num + "\n"
                                + student_email + "\n"
                                + student_phone_number;

            Padding viewMargins = new Padding();
            viewMargins.Left = 25;
            viewMargins.Right = 0;
            viewMargins.Top = 5;
            viewMargins.Bottom = 5;

            Font font = new Font(
                new FontFamily("Open Sans"),
                8,
                FontStyle.Bold);

            Label studentLabel = new Label();
            studentLabel.Name = student_num+"_"+group_member_id;
            studentLabel.Text = studentInfo;
            studentLabel.Width = 220;
            studentLabel.Height = 90;
            studentLabel.TextAlign = ContentAlignment.MiddleCenter;
            studentLabel.BackColor = Color.DarkSlateBlue;
            studentLabel.Margin = viewMargins;
            studentLabel.ForeColor = Color.White;
            studentLabel.Font = font;
            studentLabel.Cursor = Cursors.Hand;

            studentLabel.MouseEnter += new EventHandler(studentLabel_MouseEnter);
            studentLabel.MouseLeave += new EventHandler(studentLabel_MouseLeave);
            studentLabel.MouseClick += new MouseEventHandler(studentLabel_MouseClick);

            membersFlowLayout.Controls.Add(studentLabel);
        }

        private void studentLabel_MouseEnter(object sender, EventArgs e)
        {
            DefaultMethods.setLabelHoverColor((Label)sender);
        }

        private void studentLabel_MouseLeave(object sender, EventArgs e)
        {
            DefaultMethods.setLabelNormalColor((Label)sender);
        }

        private void studentLabel_MouseClick(object sender, EventArgs e)
        {
            Label studLabel = (Label)sender;
            string user_group_id = studLabel.Name;
            string[] user_group_list = user_group_id.Split('_');
            string userId = user_group_list[0];
            string groupId = user_group_list[1];

            DefaultMethods.LaunchActivity(this, new AssignForm(userId, groupId), false);

            //DefaultMethods.LaunchActivity(this, new StudentUpdateData(userId), false);

            //update the label that was clicked
            //updateLabelClickedIfThereAreChanges(studLabel, userId);
        }

        private void btnSetAppointment_Click(object sender, EventArgs e)
        {
            blnValidInput = validateAppointmentInputs();
            if (blnValidInput) {
                selected_counsellor_id = cbCounsellor.SelectedIndex + 1;
                selected_venue_id = cbVenueList.SelectedIndex + 1;
                bool flagGroupAsImportant = chkBoxFlag.Checked;

                DateTime selectedDate = datePicker.Value;

                string sSelectedDate = selectedDate.ToString("dd/MM/yyyy");
                string sSelectedTime = TimePicker.Value.ToString("HH:mm");

                int result = db.insert(
                    "GroupAssignment", //table name
                    new string[] {"group_assign_id", "assign_date", "assign_time", "counsellor_id", "assign_venue_id", "assign_type" }, //column names
                    new object[] {selected_group_id, sSelectedDate, sSelectedTime, selected_counsellor_id, selected_venue_id, -1} //values
                    );

                if (result > 0)
                { //success
                    if (flagGroupAsImportant) {
                        db.update("update CounsellingGroup set Group_Flag = 1 where Group_id = @0",
                    new string[] { selected_group_id.ToString() });
                    }
                    MessageBox.Show("Appointment set successfully");
                    chkBoxFlag.Checked = false;
                    
                }
                else
                {
                    MessageBox.Show("Appointment set failed");
                }
            }
        }

        private bool validateAppointmentInputs() {
            bool allIsOkay = true;
            DateTime selectedDate = datePicker.Value;
            if (numOfStuds < 5) {
                //allIsOkay = false;
                //MessageBox.Show("A group must have atleast 5 members");
            }
            if (selected_group_id == -1) {
                allIsOkay = false;
                MessageBox.Show("select a group first");
            }

            if (cbCounsellor.SelectedIndex < 0) {
                allIsOkay = false;
                MessageBox.Show("Select a counsellor");
            }

            if (cbVenueList.SelectedIndex < 0) {
                allIsOkay = false;
                MessageBox.Show("Select a venue");
            }

            if (selectedDate.Date < nextWeekMonday.Date) {
                allIsOkay = false;
                MessageBox.Show("Select date in the upcoming week");
            }


            return allIsOkay;
        }
    }
}
