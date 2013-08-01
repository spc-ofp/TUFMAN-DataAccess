using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Log {
    
    public class CatchRN {
        public virtual int log_catch_id { get; set; }
        public virtual SetsRN sets_rn { get; set; }
        public virtual Species species { get; set; }
        public virtual short sp_n { get; set; }
        public virtual float? sp_mt { get; set; }
        public virtual int? sp_n_est { get; set; }
        public virtual float? sp_mt_est { get; set; }
        public virtual decimal? est_meth_id { get; set; }
        public virtual bool discard { get; set; }
        public virtual string sizeclass { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
