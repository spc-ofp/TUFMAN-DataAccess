using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Log {
    
    public class SetsLL {
        public SetsLL() { }
        public virtual int log_set_id { get; set; }
        public virtual TripsLL trips_ll { get; set; }
        public virtual ActivitycodesLL activitycodes_ll { get; set; }
        public virtual int? hooks_n { get; set; }
        public virtual int? hk_bt_flt_n { get; set; }
        public virtual decimal? hk_est_meth_id { get; set; }
        public virtual DateTime? logdate { get; set; }
        public virtual DateTime? set_time { get; set; }
        public virtual string lat { get; set; }
        public virtual string lon { get; set; }
        public virtual int? set_no { get; set; }
        public virtual string eez_code { get; set; }
        public virtual string set_time_x { get; set; }
        public virtual string subarea_id { get; set; }
        public virtual bool? in_wcpfc_area { get; set; }
        public virtual DateTime? unload_time { get; set; }
        public virtual bool? fish_unloaded { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
