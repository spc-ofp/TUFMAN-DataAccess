using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Log {
    
    public class SetsRN {
        public SetsRN() { }
        public int log_set_id { get; set; }
        public TripsRN trips_rn { get; set; }
        public ActivitycodesRN activitycodes_rn { get; set; }
        public DateTime? logdate { get; set; }
        public int? school_id { get; set; }
        public DateTime? set_time { get; set; }
        public DateTime? end_set_time { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string well_no { get; set; }
        public string eez_code { get; set; }
        public string set_time_x { get; set; }
        public string subarea_id { get; set; }
        public int? port_id { get; set; }
        public bool? in_wcpfc_area { get; set; }
    }
}