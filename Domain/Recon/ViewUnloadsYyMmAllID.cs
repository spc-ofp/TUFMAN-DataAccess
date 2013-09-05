using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Recon {
    
    public class ViewUnloadsYyMmAllID {
        public virtual int row_id { get; set; }
        public virtual short YY { get; set; }
        public virtual short? MM { get; set; }
        public virtual string flag_code { get; set; }
        public virtual string company_country_code { get; set; }
        public virtual string gear_code { get; set; }
        public virtual int? unloads_n { get; set; }
        public virtual int? vessels_n { get; set; }
        public virtual int? alb_n { get; set; }
        public virtual int? bet_n { get; set; }
        public virtual int? skj_n { get; set; }
        public virtual int? yft_n { get; set; }
        public virtual int? oth_n { get; set; }
        public virtual int? tot_n { get; set; }
        public virtual float? alb_mt { get; set; }
        public virtual float? bet_mt { get; set; }
        public virtual float? skj_mt { get; set; }
        public virtual float? yft_mt { get; set; }
        public virtual float? oth_mt { get; set; }
        public virtual float? tot_mt { get; set; }
    }
}
