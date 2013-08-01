using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Lic {
    
    public class AgrRepPeriod {
        public AgrRepPeriod() { }
        public virtual int arp_id { get; set; }
        public virtual Agreements agreements { get; set; }
        public virtual string arp_type_code { get; set; }
        public virtual short? arp_no { get; set; }
        public virtual DateTime? arp_startdate { get; set; }
        public virtual DateTime? arp_enddate { get; set; }
        public virtual string comments { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
