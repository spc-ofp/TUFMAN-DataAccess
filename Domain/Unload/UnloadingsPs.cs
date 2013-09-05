using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ves;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Unload {
    
    public class UnloadingsPs {
        public virtual int unload_id { get; set; }
        public virtual int? recon_trip_id { get; set; }
        public virtual Vessels vessels { get; set; }
        public virtual Ports ports { get; set; }
        public virtual int? unload_carr_id { get; set; }
        public virtual string flag_code { get; set; }
        public virtual DateTime? unload_startdate { get; set; }
        public virtual DateTime? unload_enddate { get; set; }
        public virtual int? log_trip_id { get; set; }
        public virtual DateTime? log_dep_date { get; set; }
        public virtual DateTime? log_ret_date { get; set; }
        public virtual bool? logsheet { get; set; }
        public virtual int? obs_trip_id { get; set; }
        public virtual int? vess_act_id { get; set; }
        public virtual int? license_id { get; set; }
        public virtual string unload_type_code { get; set; }
        public virtual int? sample_id { get; set; }
        public virtual string batch_code { get; set; }
        public virtual int? nat_fleet_id { get; set; }
        public virtual float? skj_mt { get; set; }
        public virtual float? yft_lt9_mt { get; set; }
        public virtual float? yft_gt9_mt { get; set; }
        public virtual float? yft_mt { get; set; }
        public virtual float? bet_lt9_mt { get; set; }
        public virtual float? bet_gt9_mt { get; set; }
        public virtual float? bet_mt { get; set; }
        public virtual float? yft_bet_mt { get; set; }
        public virtual float? skj_yft_bet_mt { get; set; }
        public virtual float? oth_mt { get; set; }
        public virtual float? tot_mt { get; set; }
        public virtual string unload_type_code2 { get; set; }
        public virtual string entered_by { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
