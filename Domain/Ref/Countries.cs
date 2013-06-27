using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ref {
    
    public class Countries {
        public string country_code { get; set; }
        public string country_name { get; set; }
        public string country_short { get; set; }
        public bool spc_member { get; set; }
        public bool ffa_member { get; set; }
        public bool pna_member { get; set; }
        public string iso3_code { get; set; }
        public short? un_id { get; set; }
    }
}
