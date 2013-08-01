using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Lic {
    
    public class NatFleetLic {
        public virtual int nat_fleet_lic_id { get; set; }
        public virtual NationalFleets national_fleets { get; set; }
        public virtual Countries countries { get; set; }
        public virtual string license_no { get; set; }
        public virtual DateTime lic_startdate { get; set; }
        public virtual DateTime lic_enddate { get; set; }
        public virtual int? license_id { get; set; }
        public virtual string comments { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
