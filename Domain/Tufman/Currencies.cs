using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Tufman {
    
    public class Currencies {
        public virtual string cur_code { get; set; }
        public virtual string cur_desc { get; set; }
        public virtual float? min_rate { get; set; }
        public virtual float? max_rate { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
