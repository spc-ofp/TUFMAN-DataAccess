using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ref {
    
    public class Ports {
        public int port_id { get; set; }
        public string port_name { get; set; }
        public string country_code { get; set; }
        public string location_code { get; set; }
        public string port_lat { get; set; }
        public string port_lon { get; set; }
    }
}
