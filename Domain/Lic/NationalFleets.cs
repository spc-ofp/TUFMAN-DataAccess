using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ves;

namespace TUFMAN.Domain.Lic {
    
    public class NationalFleets {
        public NationalFleets() { }
        public virtual int nat_fleet_id { get; set; }
        public virtual Vessels vessels { get; set; }
        public virtual DateTime date_from { get; set; }
        public virtual DateTime? date_to { get; set; }
        public virtual bool active { get; set; }
        public virtual string regist_no { get; set; }
        public virtual string auth_no { get; set; }
        public virtual int? company_id { get; set; }
        public virtual string fishing_zones { get; set; }
        public virtual string auth_ports { get; set; }
        public virtual string comments { get; set; }
        public virtual bool charter { get; set; }
        public virtual string nat_subfleet_code { get; set; }
        public virtual bool? active_wcpfc { get; set; }
        public virtual bool? authorized_vessel { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
