using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ref {
    
    public class AgreementOwnership {
        public virtual int agr_own_id { get; set; }
        public virtual string agr_own_desc { get; set; }
        public virtual string agr_own_longdesc { get; set; }
    }
}
