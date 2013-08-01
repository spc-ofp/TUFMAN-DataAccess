using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Log; 

namespace TUFMAN.DAL.Maps.Log {
    
    
    public class SetsPLMap : ClassMap<SetsPL> {
        
        public SetsPLMap() {
            Schema("log");
			Table("sets_pl");
			Id(x => x.log_set_id).GeneratedBy.Identity().Column("log_set_id");
			References(x => x.trips_pl).Column("log_trip_id");
			References(x => x.activitycodes_pl).Column("p_activity_id");
			Map(x => x.logdate).Column("logdate");
			Map(x => x.bait).Column("bait").Length(1);
			Map(x => x.gear_code).Column("gear_code").Precision(3);
			Map(x => x.lat).Column("lat").Length(9);
			Map(x => x.lon).Column("lon").Length(10);
			Map(x => x.eez_code).Column("eez_code").Length(3);
			Map(x => x.set_time_x).Column("set_time_x").Length(50);
			Map(x => x.subarea_id).Column("subarea_id").Length(2);
			Map(x => x.in_wcpfc_area).Column("in_wcpfc_area");
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}
