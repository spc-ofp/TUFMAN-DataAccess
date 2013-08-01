using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Log; 

namespace TUFMAN.DAL.Maps.Log {
    
    
    public class UnloadsPSMap : ClassMap<UnloadsPS> {
        
        public UnloadsPSMap() {
            Schema("log");
			Table("unloads_ps");
			Id(x => x.log_unload_id).GeneratedBy.Identity().Column("log_unload_id");
			Map(x => x.log_trip_id).Column("log_trip_id").Precision(10);
			Map(x => x.start_date).Column("start_date");
			Map(x => x.end_date).Column("end_date");
			Map(x => x.destination).Column("destination").Length(50);
			Map(x => x.ircs).Column("ircs").Length(20);
			Map(x => x.skj_mt).Column("skj_mt").Precision(53);
			Map(x => x.yft_mt).Column("yft_mt").Precision(53);
			Map(x => x.bet_mt).Column("bet_mt").Precision(53);
			Map(x => x.mixed_mt).Column("mixed_mt").Precision(53);
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}
