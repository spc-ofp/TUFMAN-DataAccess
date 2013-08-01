using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Log {
    
    public class SetsGN {
        public SetsGN() { }
        public virtual int log_set_id { get; set; }
        public virtual TripsGN trips_gn { get; set; }
        public virtual ActivitycodesGN activitycodes_gn { get; set; }
        public virtual DateTime? logdate { get; set; }
        public virtual int? school_id { get; set; }
        public virtual DateTime? set_time { get; set; }
        public virtual DateTime? end_set_time { get; set; }
        public virtual string lat { get; set; }
        public virtual string lon { get; set; }
        public virtual string well_no { get; set; }
        public virtual string eez_code { get; set; }
        public virtual string set_time_x { get; set; }
        public virtual string subarea_id { get; set; }
        public virtual int? port_id { get; set; }
        public virtual bool? in_wcpfc_area { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
