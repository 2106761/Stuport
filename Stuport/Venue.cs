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
    public partial class Venue : Form
    {
        private readonly DataBaseManager db = DataBaseManager.getInstance;
        bool blnValidInput = false;

        public Venue()
        {
            InitializeComponent();
            DisplayVenues();
        }

        private void DisplayVenues()
        {
            OleDbDataReader reader = db.select("select * from Venue", new String[] {});
            while (reader.Read())
            {
                String venue_name = reader[1].ToString();

                addVenueToVenueFlowLayout(venue_name, false);

            }

            //close reader and connection, because when db.select was called, it left the connection open
            reader.Close();
            db.closeConnection();
        }

        /*
         dynamically create a label
         then add it to venueFlowLayout
         */
        private void addVenueToVenueFlowLayout(string venue_name, bool venueIsNew)
        {
            
            Padding viewMargins = new Padding();
            viewMargins.Left = 5;
            viewMargins.Right = 0;
            viewMargins.Top = 5;
            viewMargins.Bottom = 5;

            Font font = new Font(
                new FontFamily("Open Sans"),
                12,
                FontStyle.Bold);


            Label venueLable = new Label();
            venueLable.Text = venue_name;
            venueLable.Width = 305;
            venueLable.Height = 60;
            venueLable.TextAlign = ContentAlignment.MiddleCenter;
            venueLable.BackColor = Color.DarkSlateBlue;
            venueLable.Margin = viewMargins;
            venueLable.ForeColor = Color.White;
            venueLable.Font = font;

            venueFlowLayout.Controls.Add(venueLable);

            if (venueIsNew)
            {
                venueFlowLayout.Controls.SetChildIndex(venueLable, 1);
            }
            
        }

        private void btnAddVenue_Click(object sender, EventArgs e)
        {
            blnValidInput = validateInput();
            if (blnValidInput) {

                String venueName = txtBoxVenue.Text.Trim();

                int result = db.insert(
                    "Venue", //table name
                    new string[] { "Venue_Name" }, //column names
                    new object[] { venueName } //values
                    );

                if (result > 0)
                { //success
                    MessageBox.Show("Venue successfully added", "Venue");
                    //add new venue to the flow Layout
                    addVenueToVenueFlowLayout(venueName, true);
                    txtBoxVenue.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to Add Venue", "Venue");
                }
            }
        }

        private bool validateInput()
        {

            bool allIsOkay = true;

            if (txtBoxVenue.Text.Trim() == "") {
                allIsOkay = false;
                errorProvider1.SetError(txtBoxVenue, "Enter Venue");
            }

            return allIsOkay;
        }
    }
}
