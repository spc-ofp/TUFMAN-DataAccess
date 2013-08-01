using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Lic {
    
    public class LicenseHistory {
        public virtual int status_id { get; set; }
        public virtual int? license_id { get; set; }
        public virtual int? lic_status_id { get; set; }
        public virtual DateTime? status_effect_date { get; set; }
        public virtual string entered_by { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual string comments { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
