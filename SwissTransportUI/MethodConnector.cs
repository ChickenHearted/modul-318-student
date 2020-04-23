﻿using System;
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
        public List<string> GetStationSuggestions(string query)
        {

            List<string> resCollection = new List<string>();
            stations = transportAPI.GetStations(query);
            Query = query;
            foreach (Station station in stations.StationList)
            {
                resCollection.Add(station.Name);
            }

            return resCollection;
        }

    }
}