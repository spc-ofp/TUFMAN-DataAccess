using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Log {
    
    public class CatchGN {
        public int log_catch_id { get; set; }
        public SetsGN sets_gn { get; set; }
        public Species species { get; set; }
        public short sp_n { get; set; }
        public float? sp_mt { get; set; }
        public int? sp_n_est { get; set; }
        public float? sp_mt_est { get; set; }
        public decimal? est_meth_id { get; set; }
        public bool discard { get; set; }
        public string sizeclass { get; set; }
    }
}
