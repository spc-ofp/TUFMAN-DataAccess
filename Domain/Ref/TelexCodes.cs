using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ref {
    
    public class TelexCodes {
        public virtual string rpt_code { get; set; }
        public virtual string rpt_desc { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
