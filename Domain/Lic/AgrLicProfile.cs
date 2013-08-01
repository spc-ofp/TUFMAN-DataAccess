using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Lic {
    
    public class AgrLicProfile {
        public virtual int agr_lic_id { get; set; }
        public virtual string agr_code { get; set; }
        public virtual int? lic_profile_id { get; set; }
        public virtual decimal lic_fee { get; set; }
        public virtual decimal? obs_fee { get; set; }
        public virtual decimal? reg_fee { get; set; }
        public virtual decimal? voc_fee { get; set; }
        public virtual float? acc_fee { get; set; }
        public virtual string cur_code { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
