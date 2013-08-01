using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ref {
    
    public class IafZones {
        public virtual int iaf_zone_id { get; set; }
        public virtual string iaf_zone_name { get; set; }
        public virtual string iaf_zone_desc { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
