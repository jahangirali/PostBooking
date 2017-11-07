using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostBookingPages.Data
{
    public class FlightSearch
    {
        public bool OneWay { get; set; }
        public string OriginAirport { get; set; }

        public string DestinationAirport { get; set; }
        public string DepartingDate { get; set; }
        public string ReturningDate { get; set; }
        public string NoOfAdults { get; set; }
        public string NoOfChildren { get; set; }
        public string NoOfInfants { get; set; }

        public FlightSearch()
        {
            OneWay = true;
            OriginAirport = "LTN";
            DestinationAirport = "AMS";
            DepartingDate = "";
            ReturningDate = "";
            NoOfAdults = "1";
            NoOfChildren = "0";
            NoOfInfants = "0";

        }
    }
}
