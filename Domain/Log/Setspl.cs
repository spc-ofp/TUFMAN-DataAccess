using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Log {
    
    public class SetsPL {
        public SetsPL() { }
        public int log_set_id { get; set; }
        public TripsPL trips_pl { get; set; }
        public ActivitycodesPL activitycodes_pl { get; set; }
        public DateTime? logdate { get; set; }
        public string bait { get; set; }
        public decimal? gear_code { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string eez_code { get; set; }
        public string set_time_x { get; set; }
        public string subarea_id { get; set; }
        public bool? in_wcpfc_area { get; set; }
    }
}
