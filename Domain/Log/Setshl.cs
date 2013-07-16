using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Log {
    
    public class SetsHL {
        public SetsHL() { }
        public virtual int log_set_id { get; set; }
        public virtual TripsHL trips_hl { get; set; }
        public virtual ActivitycodesHL activitycodes_hl { get; set; }
        public virtual int? hooks_n { get; set; }
        public virtual decimal? hk_est_meth_id { get; set; }
        public virtual DateTime? logdate { get; set; }
        public virtual DateTime? set_time { get; set; }
        public virtual DateTime? end_set_time { get; set; }
        public virtual string lat { get; set; }
        public virtual float? lat_dec { get; set; }
        public virtual string lon { get; set; }
        public virtual int? set_no { get; set; }
        public virtual string eez_code { get; set; }
        public virtual string set_time_x { get; set; }
        public virtual string subarea_id { get; set; }
        public virtual int? aux_vess_dep_n { get; set; }
        public virtual bool? in_wcpfc_area { get; set; }
    }
}
