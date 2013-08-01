using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Lic {
    
    public class PositionReports {
        public virtual int telex_id { get; set; }
        public virtual Licenses licenses { get; set; }
        public virtual TelexCodes telex_codes { get; set; }
        public virtual Ports ports { get; set; }
        public virtual int? recon_trip_id { get; set; }
        public virtual string gear_code { get; set; }
        public virtual int? log_trip_id { get; set; }
        public virtual DateTime telex_date { get; set; }
        public virtual string telex_time { get; set; }
        public virtual DateTime? telex_aux_date { get; set; }
        public virtual string lat { get; set; }
        public virtual string lon { get; set; }
        public virtual int? gar_id { get; set; }
        public virtual float? catch_mt { get; set; }
        public virtual string noop_reason { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual float? skj_mt { get; set; }
        public virtual float? yft_mt { get; set; }
        public virtual float? bet_mt { get; set; }
        public virtual float? alb_mt { get; set; }
        public virtual float? oth_mt { get; set; }
        public virtual short? completion_num { get; set; }
        public virtual string zone_entry_code { get; set; }
        public virtual int? nat_fleet_id { get; set; }
        public virtual int? fish_days_n { get; set; }
        public virtual int? fuel { get; set; }
        public virtual int tank_id { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
