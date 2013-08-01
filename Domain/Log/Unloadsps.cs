using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Log {
    
    public class UnloadsPS {
        public UnloadsPS() { }
        public virtual int log_unload_id { get; set; }
        public virtual int? log_trip_id { get; set; }
        public virtual DateTime? start_date { get; set; }
        public virtual DateTime? end_date { get; set; }
        public virtual string destination { get; set; }
        public virtual string ircs { get; set; }
        public virtual float? skj_mt { get; set; }
        public virtual float? yft_mt { get; set; }
        public virtual float? bet_mt { get; set; }
        public virtual float? mixed_mt { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
