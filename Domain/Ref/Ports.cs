using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ref {
    
    public class Ports {
        public virtual int port_id { get; set; }
        public virtual string port_name { get; set; }
        public virtual string country_code { get; set; }
        public virtual string location_code { get; set; }
        public virtual string port_lat { get; set; }
        public virtual string port_lon { get; set; }
    }
}
