using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Log {
    
    public class SetsPL {
        public SetsPL() { }
        public virtual int log_set_id { get; set; }
        public virtual TripsPL trips_pl { get; set; }
        public virtual ActivitycodesPL activitycodes_pl { get; set; }
        public virtual DateTime? logdate { get; set; }
        public virtual string bait { get; set; }
        public virtual decimal? gear_code { get; set; }
        public virtual string lat { get; set; }
        public virtual string lon { get; set; }
        public virtual string eez_code { get; set; }
        public virtual string set_time_x { get; set; }
        public virtual string subarea_id { get; set; }
        public virtual bool? in_wcpfc_area { get; set; }
    }
}
