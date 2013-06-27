using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ves;

namespace TUFMAN.Domain.Log {
    
    public class TripsGN {
        public TripsGN() { }
        public int log_trip_id { get; set; }
        public TripsGN trips_gnVal { get; set; }
        public Vessels vessels { get; set; }
        public int? license_id { get; set; }
        public int? unload_id { get; set; }
        public int? vess_act_id { get; set; }
        public string flag_code { get; set; }
        public int? ffa_vid { get; set; }
        public string ircs { get; set; }
        public string license_no { get; set; }
        public short? trip_no { get; set; }
        public int? fads_n { get; set; }
        public string tender_vessel { get; set; }
        public DateTime? first_logdate { get; set; }
        public DateTime? last_logdate { get; set; }
        public int? depart_port_id { get; set; }
        public DateTime? depart_date { get; set; }
        public DateTime? return_date { get; set; }
        public int? return_port_id { get; set; }
        public int? fish_start_mt { get; set; }
        public int? fish_after_mt { get; set; }
        public DateTime? entry_date { get; set; }
        public string comments { get; set; }
        public int? obs_trip_id { get; set; }
        public int? sample_id { get; set; }
        public int? nat_fleet_id { get; set; }
        public bool eez_catch_only { get; set; }
        public string entered_by { get; set; }
        public string batch_code { get; set; }
        public bool totals_checked { get; set; }
        public int? first_logdate_yy { get; set; }
    }
}
