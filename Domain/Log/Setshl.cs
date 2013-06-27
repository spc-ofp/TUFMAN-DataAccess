using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Log {
    
    public class SetsHL {
        public SetsHL() { }
        public int log_set_id { get; set; }
        public TripsHL trips_hl { get; set; }
        public ActivitycodesHL activitycodes_hl { get; set; }
        public int? hooks_n { get; set; }
        public decimal? hk_est_meth_id { get; set; }
        public DateTime? logdate { get; set; }
        public DateTime? set_time { get; set; }
        public DateTime? end_set_time { get; set; }
        public string lat { get; set; }
        public float? lat_dec { get; set; }
        public string lon { get; set; }
        public int? set_no { get; set; }
        public string eez_code { get; set; }
        public string set_time_x { get; set; }
        public string subarea_id { get; set; }
        public int? aux_vess_dep_n { get; set; }
        public bool? in_wcpfc_area { get; set; }
    }
}
