using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Log {
    
    public class UnloadsPS {
        public int log_unload_id { get; set; }
        public int? log_trip_id { get; set; }
        public DateTime? start_date { get; set; }
        public DateTime? end_date { get; set; }
        public string destination { get; set; }
        public string ircs { get; set; }
        public float? skj_mt { get; set; }
        public float? yft_mt { get; set; }
        public float? bet_mt { get; set; }
        public float? mixed_mt { get; set; }
    }
}
