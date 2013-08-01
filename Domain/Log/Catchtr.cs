using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Log {
    
    public class CatchTR {
        public virtual int log_catch_id { get; set; }
        public virtual SetsTR sets_tr { get; set; }
        public virtual Species species { get; set; }
        public virtual short sp_n { get; set; }
        public virtual short? sp_kg { get; set; }
        public virtual int? sp_n_est { get; set; }
        public virtual int? sp_kg_est { get; set; }
        public virtual short? spdiscard_n { get; set; }
        public virtual decimal? est_meth_id { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
