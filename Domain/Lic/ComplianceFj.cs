using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Lic {
    
    public class ComplianceFj {
        public virtual int license_id { get; set; }
        public virtual string vat { get; set; }
        public virtual DateTime? fimsacert { get; set; }
        public virtual DateTime? hull_cert { get; set; }
        public virtual string vesselownperc { get; set; }
        public virtual bool fiji_mast { get; set; }
        public virtual string crewnation { get; set; }
        public virtual string fimsaclass { get; set; }
        public virtual bool fimsarec { get; set; }
    }
}
