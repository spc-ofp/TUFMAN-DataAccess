using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ref {
    
    public class Countries {
        public virtual string country_code { get; set; }
        public virtual string country_name { get; set; }
        public virtual string country_short { get; set; }
        public virtual bool spc_member { get; set; }
        public virtual bool ffa_member { get; set; }
        public virtual bool pna_member { get; set; }
        public virtual string iso3_code { get; set; }
        public virtual short? un_id { get; set; }
    }
}
