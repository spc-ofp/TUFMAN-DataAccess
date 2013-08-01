using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ves; 

namespace TUFMAN.DAL.Maps.Ves {
    
    
    public class VesselActAnnualMap : ClassMap<VesselActAnnual> {
        
        public VesselActAnnualMap() {
            Schema("ves");
			Table("vessel_act_annual");
			Id(x => x.vess_act_id).GeneratedBy.Identity().Column("vess_act_id");
			References(x => x.vessels).Column("vessel_id");
			References(x => x.vessel_activities).Column("activitylog_id");
			Map(x => x.log_trip_id).Column("log_trip_id").Precision(10);
			Map(x => x.unload_id).Column("unload_id").Precision(10);
			Map(x => x.yy).Column("yy").Precision(10);
			Map(x => x.period_from).Column("period_from");
			Map(x => x.period_to).Column("period_to");
			Map(x => x.logsheet).Column("logsheet").Not.Nullable();
			Map(x => x.comments).Column("comments").Length(50);
			Map(x => x.license_id).Column("license_id").Precision(10);
			Map(x => x.sample_id).Column("sample_id").Precision(10);
			Map(x => x.recon_trip_id).Column("recon_trip_id").Precision(10);
			Map(x => x.nat_fleet_id).Column("nat_fleet_id").Precision(10);
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}
