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
        public Connections GetConnections(string FromStation, string ToStation)
        {
            /*
            List<Connection> resultConnections = new List<Connection>();
            Connections currentConnections = transportAPI.GetConnections(FromStation, ToStation);
            resultConnections.AddRange(currentConnections.ConnectionList);
            */
            return transportAPI.GetConnections(FromStation, ToStation);
        }

        /// <summary>
        /// Method gets the connections of the StationBoard from Start Station.
        /// </summary>
        /// <param name="Station"></param>
        /// <returns> Connections </returns>
        public List<StationBoard> GetStationBoard(string Station)
        {
            string id = transportAPI.GetStations(Station).StationList[0].Id;
            return transportAPI.GetStationBoard(Station, id).Entries;
        }

    }
}
