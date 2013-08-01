using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Lic {
    
    public class NatFleetIaf {
        public virtual int iaf_id { get; set; }
        public virtual NationalFleets national_fleets { get; set; }
        public virtual string iaf_no { get; set; }
        public virtual IafZones iaf_zones { get; set; }
        public virtual string iaf_zone_other { get; set; }
        public virtual DateTime iaf_startdate { get; set; }
        public virtual DateTime iaf_enddate { get; set; }
        public virtual DateTime iaf_issuedate { get; set; }
        public virtual decimal? iaf_fee { get; set; }
        public virtual string entered_by { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
