using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Lic {
    
    public class NatFleetReg {
        public virtual int nat_fleet_reg_id { get; set; }
        public virtual NationalFleets national_fleets { get; set; }
        public virtual string certificate_no { get; set; }
        public virtual DateTime start_date { get; set; }
        public virtual DateTime end_date { get; set; }
        public virtual string comments { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
