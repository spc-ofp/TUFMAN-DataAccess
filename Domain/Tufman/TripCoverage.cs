using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Tufman {
    
    public class TripCoverage {
        public virtual int trip_cov_id { get; set; }
        public virtual Gears gears { get; set; }
        public virtual Countries countries { get; set; }
        public virtual int? yy { get; set; }
        public virtual int? trips_n { get; set; }
        public virtual string est_method { get; set; }
        public virtual DateTime? est_date { get; set; }
        public virtual bool overwrite { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
