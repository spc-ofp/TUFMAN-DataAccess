using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Tufman {
    
    public class SbAreas {
        public virtual decimal grid { get; set; }
        public virtual string lat { get; set; }
        public virtual string lon { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
