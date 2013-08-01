using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Log {
    
    public class SetsTR {
        public SetsTR() { }
        public virtual int log_set_id { get; set; }
        public virtual TripsTR trips_tr { get; set; }
        public virtual ActivitycodesLL activitycodes_ll { get; set; }
        public virtual DateTime? logdate { get; set; }
        public virtual string lat { get; set; }
        public virtual string lon { get; set; }
        public virtual int? lines_n { get; set; }
        public virtual int? hours_fished { get; set; }
        public virtual int? set_no { get; set; }
        public virtual string eez_code { get; set; }
        public virtual string set_time_x { get; set; }
        public virtual string subarea_id { get; set; }
        public virtual bool? in_wcpfc_area { get; set; }        
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
