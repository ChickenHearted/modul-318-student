using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransportUI
{
    class MethodConnector
    {
        public Transport transportAPI = new Transport();
        private Stations stations;
        private string Query;

        /// <summary>
        /// Method provides Station suggestions.
        /// </summary>
        /// <param name="query"></param>
        /// <returns> AutoCompleteStringCollection </returns>
        public AutoCompleteStringCollection GetStationSuggestions(string query)
        {

            AutoCompleteStringCollection resCollection = new AutoCompleteStringCollection();
            stations = transportAPI.GetStations(query);
            Query = query;
            foreach (Station station in stations.StationList)
            {
                resCollection.Add(station.Name);
            }

            return resCollection;
        }

        /// <summary>
        /// Gets Connections from the From Station, the To Station and the Date as ListViewItemArray
        /// </summary>
        /// <param name="FromStation"></param>
        /// <param name="ToStation"></param>
        /// <returns></returns>
        public ListViewItem[] GetConnections(string FromStation, string ToStation)
        {
            List<ListViewItem> resultConnections = new List<ListViewItem>();
            Connections currentConnections = transportAPI.GetConnections(FromStation, ToStation);
            foreach (Connection connection in currentConnections.ConnectionList)
            {
                string[] result = { connection.From.DepartureTimestamp, connection.To.ArrivalTimestamp, connection.Duration, connection.From.Platform };
                resultConnections.Add(new ListViewItem(result));
            }

            return resultConnections.ToArray();
        }

    }
}
