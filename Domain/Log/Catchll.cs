using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Log {
    
    public class CatchLL {
        public int log_catch_id { get; set; }
        public SetsLL sets_ll { get; set; }
        public Species species { get; set; }
        public short sp_n { get; set; }
        public int? sp_kg { get; set; }
        public int? sp_n_est { get; set; }
        public int? sp_kg_est { get; set; }
        public short? spdiscard_n { get; set; }
        public decimal? est_meth_id { get; set; }
    }
}
