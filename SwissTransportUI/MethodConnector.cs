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
        /// <param name="CurrentQuery"></param>
        /// <returns> AutoCompleteStringCollection </returns>
        public AutoCompleteStringCollection GetStationSuggestions(string CurrentQuery)
        {

            AutoCompleteStringCollection resCollection = new AutoCompleteStringCollection();
            stations = transportAPI.GetStations(CurrentQuery);
            Query = CurrentQuery;
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
        /// <param name="DateTimeOfConnections"></param>
        /// <param name="BtnOnArrival"></param>
        /// <returns></returns>
        public Connections GetConnections(string FromStation, string ToStation, DateTime DateTimeOfConnections, bool BtnOnArrival)
        {
            string BtnOnArrivalInString = "1";
            if (BtnOnArrival == false)
            {
                BtnOnArrivalInString = "0";
            }
            return transportAPI.GetConnections(FromStation, ToStation, DateTimeOfConnections, BtnOnArrivalInString);
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

        /// <summary>
        /// Method gets the coordinates of the Start Station.
        /// </summary>
        /// <param name="Station"></param>
        /// <returns> Connections </returns>
        public string GetStationCoordinates(string Station)
        {
            return transportAPI.GetStations(Station).StationList[0].Coordinate.XCoordinate.ToString().Replace(',', '.') + "," + stations.StationList[0].Coordinate.YCoordinate.ToString().Replace(',', '.');
        }

    }
}
