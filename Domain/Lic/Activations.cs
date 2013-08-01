using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Lic {
    
    public class Activations {
        public virtual int activation_id { get; set; }
        public virtual int license_id { get; set; }
        public virtual DateTime activation_date { get; set; }
        public virtual float? activation_fee { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
