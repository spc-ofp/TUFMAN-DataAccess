using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ref {
    
    public class LicenseStatus {
        public virtual int lic_status_id { get; set; }
        public virtual string lic_status_name { get; set; }
        public virtual string lic_status_desc { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
