using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Tufman; 

namespace TUFMAN.DAL.Maps.Tufman {
    
    
    public class TripCoverageMap : ClassMap<TripCoverage> {
        
        public TripCoverageMap() {
            Schema("tufman");
			Table("trip_coverage");
			Id(x => x.trip_cov_id).GeneratedBy.Identity().Column("trip_cov_id");
			References(x => x.gears).Column("gear_code");
			References(x => x.countries).Column("flag_code");
			Map(x => x.yy).Column("yy").Precision(10);
			Map(x => x.trips_n).Column("trips_n").Precision(10);
			Map(x => x.est_method).Column("est_method").Length(50);
			Map(x => x.est_date).Column("est_date");
			Map(x => x.overwrite).Column("overwrite").Not.Nullable();
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}
