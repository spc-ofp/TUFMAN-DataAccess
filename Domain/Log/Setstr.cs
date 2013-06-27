using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Log {
    
    public class SetsTR {
        public SetsTR() { }
        public int log_set_id { get; set; }
        public TripsTR trips_tr { get; set; }
        public ActivitycodesLL activitycodes_ll { get; set; }
        public DateTime? logdate { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public int? lines_n { get; set; }
        public int? hours_fished { get; set; }
        public int? set_no { get; set; }
        public string eez_code { get; set; }
        public string set_time_x { get; set; }
        public string subarea_id { get; set; }
        public bool? in_wcpfc_area { get; set; }
    }
}
