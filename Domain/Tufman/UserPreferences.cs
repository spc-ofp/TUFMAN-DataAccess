using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Tufman {
    
    public class UserPreferences {
        public virtual string user_code { get; set; }
        public virtual short? permit_artisanal { get; set; }
        public virtual short? permit_data_registry { get; set; }
        public virtual short? permit_lic_registrations { get; set; }
        public virtual short? permit_lic_licenses { get; set; }
        public virtual short? permit_lic_agreements { get; set; }
        public virtual short? permit_lic_receipts { get; set; }
        public virtual short? permit_lic_telex_reports { get; set; }
        public virtual short? permit_lookup { get; set; }
        public virtual short? permit_logsheet { get; set; }
        public virtual short? permit_vessact { get; set; }
        public virtual short? permit_sampling { get; set; }
        public virtual short? permit_unloading { get; set; }
        public virtual short? permit_pack_list { get; set; }
        public virtual short? permit_observer { get; set; }
        public virtual bool show_licensing { get; set; }
        public virtual bool show_logsheet { get; set; }
        public virtual bool show_vess_act { get; set; }
        public virtual bool show_sampling { get; set; }
        public virtual bool show_unloading { get; set; }
        public virtual bool show_pack_list { get; set; }
        public virtual bool show_observer { get; set; }
        public virtual bool show_lookup { get; set; }
        public virtual bool show_telex { get; set; }
        public virtual short? permit_nat_fleet { get; set; }
        public virtual bool show_nat_fleet { get; set; }
        public virtual bool show_artisanal { get; set; }
        public virtual bool show_data_registry { get; set; }
        public virtual int? entry_id { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
