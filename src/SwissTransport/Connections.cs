using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Connections
    {
        [JsonProperty("connections")]
        public List<Connection> ConnectionList { get; set; } 
    }

    public class Connection
    {
        [JsonProperty("from")]
        public ConnectionPoint From  { get; set; }

        [JsonProperty("to")]
        public ConnectionPoint To { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
        public DateTime DateTimeDuration { get; set; }

        public void ConvertDuration()
        {
            string[] durations = Duration.Split('d');
            DateTimeDuration = Convert.ToDateTime(durations[1]);
        }
    }

    public class ConnectionPoint
    {
        [JsonProperty("station")]
        public Station Station { get; set; }

        public string Arrival { get; set; }

        public string ArrivalTimestamp { get; set; }

        public string Departure { get; set; }

        public string DepartureTimestamp { get; set; }

        public int? Delay { get; set; }

        public string Platform { get; set; }

        public string RealtimeAvailability { get; set; }

        public DateTime DateTimeArrival { get; set; }

        public DateTime DateTimeDeparture { get; set; }
        public void ConvertDateTimeArrivalAndDeparture()
        {
            DateTimeArrival = Convert.ToDateTime(Arrival);
            DateTimeDeparture = Convert.ToDateTime(Departure);
        }
    }
}