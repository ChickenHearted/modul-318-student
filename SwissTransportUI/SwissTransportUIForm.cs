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
        List<string> StationSuggestionSource = new List<string>();

        public SwissTransportUIForm()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
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
                if (currtextBox.Text.Length >= 3)
                {
                    StationSuggestionSource = MethodConnector.GetStationSuggestions(currtextBox.Text);
                    AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
                    foreach (string station in StationSuggestionSource)
                    {
                        autoCompleteStringCollection.Add(station);
                    }
                    currtextBox.AutoCompleteCustomSource = autoCompleteStringCollection;
                    currtextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                }
            }
            catch (StationNotFoundEx)
            {
                StationSuggestionSource.Clear();
                return;
            }
        }
    }
}
