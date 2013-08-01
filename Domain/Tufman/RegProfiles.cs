using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Tufman {
    
    public class RegProfiles {
        public virtual int reg_profile_id { get; set; }
        public virtual string reg_desc { get; set; }
        public virtual string reg_mask { get; set; }
        public virtual string country_code { get; set; }
        public virtual short? reg_period { get; set; }
        public virtual bool payment_required { get; set; }
        public virtual bool reg_fee { get; set; }
        public virtual bool obs_fee { get; set; }
        public virtual string reg_certificate { get; set; }
        public virtual string sequence_group { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
