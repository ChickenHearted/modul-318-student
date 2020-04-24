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

            try
            {
                currtextBox.AutoCompleteSource = AutoCompleteSource.None;
                if (currtextBox.Text.Length >= 3)
                {
                    StationSuggestionsSource = MethodConnector.GetStationSuggestions(currtextBox.Text);
                  
                    currtextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    currtextBox.AutoCompleteCustomSource = StationSuggestionsSource;
                    currtextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                }
            }
            catch (NoStationFoundException ex)
            {
                MessageBox.Show(ex.Message, "Fehler");
                return;
            }
        }

        /// <summary>
        /// Method searches for Connections between txtFrom & txtTo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text == "" || txtTo.Text == "")
            {
                MessageBox.Show("Bitte gebe beide Stationen an.", "Eingabefehler");
            }
            else
            {
                
                try
                {
                    listConnections.Items.Clear();
                    Connections connections = MethodConnector.GetConnections(txtFrom.Text, txtTo.Text);
                    
                    foreach (Connection result in connections.ConnectionList)
                    {
                        listConnections.Items.Add(result.From.Departure + ": " + result.From.Station.Name
                            + " to " + result.To.Station.Name + " (" + result.Duration + ")");
                    }
                    //listConnections.Items.AddRange(searchResults);
                }
                catch (NoConnectionFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Fehler");
                    txtFrom.Text = "";
                    txtTo.Text = "";
                    return;
                }
            }
        }

        private void btnCreateTimeTable_Click(object sender, EventArgs e)
        {
            if (txtStartStation.Text == "")
            {
                MessageBox.Show("Bitte gib eine gültige Station ein.");
            }
            else
            {
                try
                {
                    listTimeTable.Items.Clear();
                    List<StationBoard> stationBoardEntries = MethodConnector.GetStationBoard(txtStartStation.Text);
                    foreach (StationBoard entry in stationBoardEntries)
                    {
                        listTimeTable.Items.Add(entry.Number + ": name : " + entry.Name
                            + ": stop : " + entry.Stop.Departure + " : to : " + entry.To);
                    }
                }
                catch (NoStationBoardFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    return;
                }
            }
        }
    }
}
