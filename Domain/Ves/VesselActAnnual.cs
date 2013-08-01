using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Ves {
    
    public class VesselActAnnual {
        public virtual int vess_act_id { get; set; }
        public virtual Vessels vessels { get; set; }
        public virtual VesselActivities vessel_activities { get; set; }
        public virtual int? log_trip_id { get; set; }
        public virtual int? unload_id { get; set; }
        public virtual int? yy { get; set; }
        public virtual DateTime? period_from { get; set; }
        public virtual DateTime? period_to { get; set; }
        public virtual bool logsheet { get; set; }
        public virtual string comments { get; set; }
        public virtual int? license_id { get; set; }
        public virtual int? sample_id { get; set; }
        public virtual int? recon_trip_id { get; set; }
        public virtual int? nat_fleet_id { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
