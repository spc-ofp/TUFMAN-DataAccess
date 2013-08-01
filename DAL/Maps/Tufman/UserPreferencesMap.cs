using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Tufman; 

namespace TUFMAN.DAL.Maps.Tufman {
    
    
    public class UserPreferencesMap : ClassMap<UserPreferences> {
        
        public UserPreferencesMap() {
            Schema("tufman");
			Table("user_preferences");
			Id(x => x.user_code).GeneratedBy.Assigned().Column("user_code");
			Map(x => x.permit_artisanal).Column("permit_artisanal").Precision(5);
			Map(x => x.permit_data_registry).Column("permit_data_registry").Precision(5);
			Map(x => x.permit_lic_registrations).Column("permit_lic_registrations").Precision(5);
			Map(x => x.permit_lic_licenses).Column("permit_lic_licenses").Precision(5);
			Map(x => x.permit_lic_agreements).Column("permit_lic_agreements").Precision(5);
			Map(x => x.permit_lic_receipts).Column("permit_lic_receipts").Precision(5);
			Map(x => x.permit_lic_telex_reports).Column("permit_lic_telex_reports").Precision(5);
			Map(x => x.permit_lookup).Column("permit_lookup").Precision(5);
			Map(x => x.permit_logsheet).Column("permit_logsheet").Precision(5);
			Map(x => x.permit_vessact).Column("permit_vessact").Precision(5);
			Map(x => x.permit_sampling).Column("permit_sampling").Precision(5);
			Map(x => x.permit_unloading).Column("permit_unloading").Precision(5);
			Map(x => x.permit_pack_list).Column("permit_pack_list").Precision(5);
			Map(x => x.permit_observer).Column("permit_observer").Precision(5);
			Map(x => x.show_licensing).Column("show_licensing").Not.Nullable();
			Map(x => x.show_logsheet).Column("show_logsheet").Not.Nullable();
			Map(x => x.show_vess_act).Column("show_vess_act").Not.Nullable();
			Map(x => x.show_sampling).Column("show_sampling").Not.Nullable();
			Map(x => x.show_unloading).Column("show_unloading").Not.Nullable();
			Map(x => x.show_pack_list).Column("show_pack_list").Not.Nullable();
			Map(x => x.show_observer).Column("show_observer").Not.Nullable();
			Map(x => x.show_lookup).Column("show_lookup").Not.Nullable();
			Map(x => x.show_telex).Column("show_telex").Not.Nullable();
			Map(x => x.permit_nat_fleet).Column("permit_nat_fleet").Precision(5);
			Map(x => x.show_nat_fleet).Column("show_nat_fleet").Not.Nullable();
			Map(x => x.show_artisanal).Column("show_artisanal").Not.Nullable();
			Map(x => x.show_data_registry).Column("show_data_registry").Not.Nullable();
			Map(x => x.entry_id).Column("entry_id").Precision(10);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}
