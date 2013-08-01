using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Log; 

namespace TUFMAN.DAL.Maps.Log {
    
    
    public class SetsHLMap : ClassMap<SetsHL> {
        
        public SetsHLMap() {
            Schema("log");
			Table("sets_hl");
			Id(x => x.log_set_id).GeneratedBy.Identity().Column("log_set_id");
			References(x => x.trips_hl).Column("log_trip_id");
			References(x => x.activitycodes_hl).Column("h_activity_id");
			Map(x => x.hooks_n).Column("hooks_n").Precision(10);
			Map(x => x.hk_est_meth_id).Column("hk_est_meth_id").Precision(3);
			Map(x => x.logdate).Column("logdate");
			Map(x => x.set_time).Column("set_time");
			Map(x => x.end_set_time).Column("end_set_time");
			Map(x => x.lat).Column("lat").Length(50);
			Map(x => x.lat_dec).Column("lat_dec").Precision(24);
			Map(x => x.lon).Column("lon").Length(50);
			Map(x => x.set_no).Column("set_no").Precision(10);
			Map(x => x.eez_code).Column("eez_code").Length(3);
			Map(x => x.set_time_x).Column("set_time_x").Length(6);
			Map(x => x.subarea_id).Column("subarea_id").Length(2);
			Map(x => x.aux_vess_dep_n).Column("aux_vess_dep_n").Precision(10);
			Map(x => x.in_wcpfc_area).Column("in_wcpfc_area");
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}
