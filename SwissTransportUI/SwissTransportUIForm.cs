using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransportUI
{
    public partial class SwissTransportUIForm : System.Windows.Forms.Form
    {

        MethodConnector MethodConnector = new MethodConnector();
        AutoCompleteStringCollection StationSuggestionsSource = new AutoCompleteStringCollection();

        public SwissTransportUIForm()
        {
            InitializeComponent();
        }

        private void SwissTransportUIForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method gets Station suggestions to autocomplete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetStationSuggestions(object sender, EventArgs e)
        {
            TextBox currtextBox = (TextBox)sender;
            currtextBox.AutoCompleteSource = AutoCompleteSource.None;

            if (currtextBox.Text.Length >= 3)
            {
                StationSuggestionsSource = MethodConnector.GetStationSuggestions(currtextBox.Text);
                currtextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                currtextBox.AutoCompleteCustomSource = StationSuggestionsSource;
                currtextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            }

        }

        /// <summary>
        /// Method searches for Connections between txtFrom & txtTo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            listConnections.Items.Clear();

            if (txtFrom.Text == "" || txtTo.Text == "")
            {
                MessageBox.Show("Bitte gebe beide Stationen an.", "Eingabefehler");
            }

            DateTime dateTime = Convert.ToDateTime(dtpDate.Text).Date.Add(Convert.ToDateTime(dtpTime.Text).TimeOfDay);
            bool btnOnArrival = rdBtnArrival.Checked;
            Connections connections = MethodConnector.GetConnections(txtFrom.Text, txtTo.Text, dateTime, btnOnArrival);

            if (connections == null)
            {
                MessageBox.Show("Es wurden keine Verbindungen gefunden.", "Fehler beim Suchen.");

            }

            foreach (Connection connection in connections.ConnectionList)
            {
                listConnections.Items.Add(connection.From.Departure + ": " + connection.From.Station.Name
                    + " to " + connection.To.Station.Name + " (" + connection.Duration + ")");
            }
        }

        private void btnCreateTimeTable_Click(object sender, EventArgs e)
        {
            listTimeTable.Items.Clear();

            if (txtStartStation.Text == "")
            {
                MessageBox.Show("Bitte gib eine gültige Station ein.");
            }

            List<StationBoard> stationBoardEntries = MethodConnector.GetStationBoard(txtStartStation.Text);
            if (stationBoardEntries.Count == 0)
            {
                MessageBox.Show("Es wurden keine Verbindungen zu der Station " + txtStartStation.Text + " gefunden.", "Fehler beim Erstellen.");

            }
            foreach (StationBoard entry in stationBoardEntries)
            {
                listTimeTable.Items.Add(entry.Number + ": name : " + entry.Name
                    + ": stop : " + entry.Stop.Departure + " : to : " + entry.To);
            }
        }

        private void btnShowStation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://google.com/maps/place/" + MethodConnector.GetStationCoordinates(txtStartStation.Text));

        }
    }
}
