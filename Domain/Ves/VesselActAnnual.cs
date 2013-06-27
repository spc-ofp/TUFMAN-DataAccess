using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Ves {
    
    public class VesselActAnnual {
        public int vess_act_id { get; set; }
        public Vessels vessels { get; set; }
        public VesselActivities vessel_activities { get; set; }
        public int? log_trip_id { get; set; }
        public int? unload_id { get; set; }
        public int? yy { get; set; }
        public DateTime? period_from { get; set; }
        public DateTime? period_to { get; set; }
        public bool logsheet { get; set; }
        public string comments { get; set; }
        public int? license_id { get; set; }
        public int? sample_id { get; set; }
        public int? recon_trip_id { get; set; }
        public int? nat_fleet_id { get; set; }
    }
}
