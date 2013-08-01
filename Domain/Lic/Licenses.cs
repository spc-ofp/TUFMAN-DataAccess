using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;
using TUFMAN.Domain.Ves;
using TUFMAN.Domain.Tufman;

namespace TUFMAN.Domain.Lic {
    
    public class Licenses {
        public Licenses() { }
        public virtual int license_id { get; set; }
        public virtual LicenseProfiles license_profiles { get; set; }
        public virtual LicenseStatus license_status { get; set; }
        public virtual Vessels vessels { get; set; }
        public virtual LicenseTypes license_types { get; set; }
        public virtual AgrRepPeriod agr_rep_period { get; set; }
        public virtual string license_no { get; set; }
        public virtual DateTime? status_effect_date { get; set; }
        public virtual string agr_code { get; set; }
        public virtual int? lic_seq_no { get; set; }
        public virtual DateTime? lic_startdate { get; set; }
        public virtual DateTime? lic_enddate { get; set; }
        public virtual DateTime? lic_issue_date { get; set; }
        public virtual int? license_holder { get; set; }
        public virtual decimal? lic_fee { get; set; }
        public virtual decimal? obs_fee { get; set; }
        public virtual decimal? reg_fee { get; set; }
        public virtual decimal? voc_fee { get; set; }
        public virtual float? acc_fee { get; set; }
        public virtual float? oth_fee { get; set; }
        public virtual float? gst_value { get; set; }
        public virtual float? activation_fees { get; set; }
        public virtual string cur_code { get; set; }
        public virtual bool cert_issued { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual string entered_by { get; set; }
        public virtual DateTime? changed_date { get; set; }
        public virtual string changed_by { get; set; }
        public virtual string comments { get; set; }
        public virtual string discharge_port1 { get; set; }
        public virtual string discharge_port2 { get; set; }
        public virtual string discharge_port3 { get; set; }
        public virtual string discharge_port4 { get; set; }
        public virtual short? trip_no { get; set; }
        public virtual string auth_areas { get; set; }
        public virtual string auth_species { get; set; }
    }
}
