using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Log {
    
    public class SetsLL {
        public SetsLL() { }
        public int log_set_id { get; set; }
        public TripsLL trips_ll { get; set; }
        public ActivitycodesLL activitycodes_ll { get; set; }
        public int? hooks_n { get; set; }
        public int? hk_bt_flt_n { get; set; }
        public decimal? hk_est_meth_id { get; set; }
        public DateTime? logdate { get; set; }
        public DateTime? set_time { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public int? set_no { get; set; }
        public string eez_code { get; set; }
        public string set_time_x { get; set; }
        public string subarea_id { get; set; }
        public bool? in_wcpfc_area { get; set; }
        public DateTime? unload_time { get; set; }
        public bool? fish_unloaded { get; set; }
    }
}
