using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Tufman {
    
    public class FjArch {
        public virtual int fj_arch_id { get; set; }
        public virtual float? lond { get; set; }
        public virtual float? latd { get; set; }
        public virtual string lat_long { get; set; }
        public virtual string lon_long { get; set; }
    }
}
