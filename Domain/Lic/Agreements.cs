using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;
using TUFMAN.Domain.Tufman;

namespace TUFMAN.Domain.Lic {
    
    public class Agreements {
        public Agreements() { }
        public virtual string agr_code { get; set; }
        public virtual Companies companies { get; set; }
        public virtual AgreementTypes agreement_types { get; set; }
        public virtual DateTime? agr_signdate { get; set; }
        public virtual string agr_place { get; set; }
        public virtual short agr_no { get; set; }
        public virtual int agr_own_id { get; set; }
        public virtual DateTime agr_startdate { get; set; }
        public virtual DateTime agr_enddate { get; set; }
        public virtual int? reg_profile_id { get; set; }
        public virtual int? agr_vessels_n { get; set; }
        public virtual float? agr_lumpsum_fee { get; set; }
        public virtual float? agr_extra_fee { get; set; }
        public virtual float? agr_reg_fee { get; set; }
        public virtual string cur_code { get; set; }
        public virtual string entered_by { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual string arp_code { get; set; }
        public virtual string comments { get; set; }
        public virtual string auth_areas { get; set; }
        public virtual string auth_species { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
