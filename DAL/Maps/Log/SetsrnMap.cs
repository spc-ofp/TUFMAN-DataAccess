using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Log; 

namespace TUFMAN.DAL.Maps.Log {
    
    
    public class SetsRNMap : ClassMap<SetsRN> {
        
        public SetsRNMap() {
            Schema("log");
			Table("sets_rn");
			Id(x => x.log_set_id).GeneratedBy.Identity().Column("log_set_id");
			References(x => x.trips_rn).Column("log_trip_id");
			References(x => x.activitycodes_rn).Column("r_activity_id");
			Map(x => x.logdate).Column("logdate");
			Map(x => x.school_id).Column("school_id").Precision(10);
			Map(x => x.set_time).Column("set_time");
			Map(x => x.end_set_time).Column("end_set_time");
			Map(x => x.lat).Column("lat").Length(9);
			Map(x => x.lon).Column("lon").Length(10);
			Map(x => x.well_no).Column("well_no").Length(15);
			Map(x => x.eez_code).Column("eez_code").Length(2);
			Map(x => x.set_time_x).Column("set_time_x").Length(4);
			Map(x => x.subarea_id).Column("subarea_id").Length(2);
			Map(x => x.port_id).Column("port_id").Precision(10);
			Map(x => x.in_wcpfc_area).Column("in_wcpfc_area");
        }
    }
}
