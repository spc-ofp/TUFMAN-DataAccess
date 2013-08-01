using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Tufman; 

namespace TUFMAN.DAL.Maps.Tufman {
    
    
    public class FjArchMap : ClassMap<FjArch> {
        
        public FjArchMap() {
            Schema("tufman");
			Table("fj_arch");
			Id(x => x.fj_arch_id).GeneratedBy.Identity().Column("fj_arch_id");
			Map(x => x.lond).Column("lond").Precision(53);
			Map(x => x.latd).Column("latd").Precision(53);
			Map(x => x.lat_long).Column("lat_long").Length(255);
			Map(x => x.lon_long).Column("lon_long").Length(255);
        }
    }
}
