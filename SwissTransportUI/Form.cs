using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportUI
{
    public partial class Form : System.Windows.Forms.Form
    {

        MethodConnector MethodConnector = new MethodConnector();
        AutoCompleteStringCollection StationSuggestionSource = new AutoCompleteStringCollection();

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            txtFrom.AutoCompleteCustomSource = StationSuggestionSource;
            txtFrom.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        /// <summary>
        /// Method gets Station suggestions to autocomplete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetStationSuggestions(object sender, EventArgs e)
        {
            TextBox currtextBox = (TextBox)sender;
            
            if (currtextBox.Text.Length >= 3)
            {
                GC.Collect();
                StationSuggestionSource = MethodConnector.GetStationSuggestions(currtextBox.Text);
                currtextBox.AutoCompleteCustomSource = StationSuggestionSource;
                currtextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
        }
    }
}
