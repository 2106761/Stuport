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
    public partial class AdminAppointments : Form
    {
        private readonly DataBaseManager db = DataBaseManager.getInstance;

        public AdminAppointments()
        {
            InitializeComponent();
            DisplayAppointments();
        }

        private void DisplayAppointments()
        {
            //OleDbDataReader reader = db.select("", new String[] { });

            db.openConnection();

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select " +
                "Appointment.User_id, StuPortUser.User_FName, StuPortUser.User_LName, StuPortUser.User_Email, StuPortUser.User_PhoneNumber, Service.Service_Name, Appointment.Appoint_Date, Appointment.Appoint_Time" +
                " from (Appointment inner join Service on Appointment.service_id = Service.Service_id) inner join StuPortUser on StuPortUser.User_id = Appointment.User_id", db.GetOleDbConnection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            db.closeConnection();

            /*while (reader.Read())
            {
                string personnel_first_name = reader[1].ToString();
                string personnel_last_name = reader[2].ToString();
                string personnel_email = reader[3].ToString();
                string personnel_phone_number = reader[4].ToString();

                addCounsellorToFlowLayout(personnel_first_name, personnel_last_name, personnel_email, personnel_phone_number, false);
            }

            //close reader and connection, because when db.select was called, it left the connection open
            reader.Close();
            db.closeConnection();*/
        }
    }
}
