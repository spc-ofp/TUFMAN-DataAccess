using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ves;

namespace TUFMAN.Domain.Log {
    
    public class TripsHL {
        public TripsHL() { }
        public int log_trip_id { get; set; }
        public Vessels vessels { get; set; }
        public int? recon_trip_id { get; set; }
        public int? license_id { get; set; }
        public int? unload_id { get; set; }
        public int? vess_act_id { get; set; }
        public int? sample_id { get; set; }
        public string flag_code { get; set; }
        public int? ffa_vid { get; set; }
        public string ircs { get; set; }
        public string license_no { get; set; }
        public short? trip_no { get; set; }
        public DateTime? first_logdate { get; set; }
        public DateTime? last_logdate { get; set; }
        public int? depart_port_id { get; set; }
        public DateTime? depart_date { get; set; }
        public DateTime? return_date { get; set; }
        public int? return_port_id { get; set; }
        public int? hk_bt_flt_n { get; set; }
        public string target_sp_code { get; set; }
        public DateTime? entry_date { get; set; }
        public string comments { get; set; }
        public int? obs_trip_id { get; set; }
        public int? nat_fleet_id { get; set; }
        public bool eez_catch_only { get; set; }
        public string entered_by { get; set; }
        public string batch_code { get; set; }
        public int? aux_vessels_n { get; set; }
        public int? handline_len_min { get; set; }
        public int? handline_len_max { get; set; }
        public bool totals_checked { get; set; }
        public int? first_logdate_yy { get; set; }
    }
}