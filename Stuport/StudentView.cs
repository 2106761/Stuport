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
    public partial class StudentView : Form
    {
        private readonly DataBaseManager db = DataBaseManager.getInstance;

        public StudentView()
        {
            InitializeComponent();
            DisplayStudents();
        }

        private void DisplayStudents()
        {
            OleDbDataReader reader = db.select("select * from StuPortUser", new String[] { });
            while (reader.Read())
            {
                String student_num = reader[0].ToString();
                String student_first_name = reader[1].ToString();
                String student_last_name = reader[2].ToString();
                String student_email = reader[3].ToString();
                String student_phone_number = reader[5].ToString();

                addStudentToStudentsFlowLayout(student_num, student_first_name, student_last_name, student_email, student_phone_number);

            }

            //close reader and connection, because when db.select was called, it left the connection open
            reader.Close();
            db.closeConnection();
        }

        private void addStudentToStudentsFlowLayout(string student_num, string student_first_name, string student_last_name, string student_email, string student_phone_number)
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
            studentLabel.Name = student_num;
            studentLabel.Text = studentInfo;
            studentLabel.Width = 305;
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

            studentFlowLayout.Controls.Add(studentLabel);
        }

        private void studentLabel_MouseEnter(object sender, EventArgs e)
        {
            DefaultMethods.setLabelHoverColor((Label)sender);
        }

        private void studentLabel_MouseLeave(object sender, EventArgs e) {
            DefaultMethods.setLabelNormalColor((Label)sender);
        }

        private void studentLabel_MouseClick(object sender, EventArgs e) {
            Label studLabel = (Label)sender;
            string userId = studLabel.Name;

            DefaultMethods.LaunchActivity(this, new StudentUpdateData(userId), false);

            //update the label that was clicked
            updateLabelClickedIfThereAreChanges(studLabel, userId);
        }

        private void updateLabelClickedIfThereAreChanges(Label studLabel, string userId)
        {
            OleDbDataReader reader = db.select("select * from StuPortUser where User_id = @0", new string[] {userId});
            while (reader.Read())
            {
                string student_num = reader[0].ToString();
                string student_first_name = reader[1].ToString();
                string student_last_name = reader[2].ToString();
                string student_email = reader[3].ToString();
                string student_phone_number = reader[5].ToString();

                string studentInfo = student_first_name + " " + student_last_name + "\n"
                                + student_num + "\n"
                                + student_email + "\n"
                                + student_phone_number;

                studLabel.Text = studentInfo;

                break;
            }

            //close reader and connection, because when db.select was called, it left the connection open
            reader.Close();
            db.closeConnection();
        }
    }
}
