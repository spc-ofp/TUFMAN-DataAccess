using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ref {
    
    public class VesselActivities {
        public virtual int activitylog_id { get; set; }
        public virtual string activity { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
