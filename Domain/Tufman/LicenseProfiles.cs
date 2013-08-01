using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Tufman {
    
    public class LicenseProfiles {
        public virtual int lic_profile_id { get; set; }
        public virtual Countries countries { get; set; }
        public virtual Gears gears { get; set; }
        public virtual LicenseTypes license_types { get; set; }
        public virtual int? lic_own_id { get; set; }
        public virtual string lic_desc { get; set; }
        public virtual string lic_short { get; set; }
        public virtual string license_mask { get; set; }
        public virtual short? lic_period { get; set; }
        public virtual bool reg_required { get; set; }
        public virtual bool license_holder { get; set; }
        public virtual bool payment_required { get; set; }
        public virtual bool reg_fee { get; set; }
        public virtual bool obs_fee { get; set; }
        public virtual bool lic_fee { get; set; }
        public virtual bool extra_ves_fee { get; set; }
        public virtual bool voc_fee { get; set; }
        public virtual bool acc_fee { get; set; }
        public virtual bool activation_fee { get; set; }
        public virtual bool activation_required { get; set; }
        public virtual bool goods_services { get; set; }
        public virtual bool oth_fee { get; set; }
        public virtual string oth_fee_desc { get; set; }
        public virtual string sequence_group { get; set; }
        public virtual string lic_certificate { get; set; }
        public virtual string period_units_code { get; set; }
        public virtual string comments { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
