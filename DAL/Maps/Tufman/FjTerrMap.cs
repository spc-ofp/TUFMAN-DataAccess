using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Tufman; 

namespace TUFMAN.DAL.Maps.Tufman {
    
    
    public class FjTerrMap : ClassMap<FjTerr> {
        
        public FjTerrMap() {
            Schema("tufman");
			Table("fj_terr");
			Id(x => x.fj_terr_id).GeneratedBy.Identity().Column("fj_terr_id");
			Map(x => x.lond).Column("lond").Precision(53);
			Map(x => x.latd).Column("latd").Precision(53);
        }
    }
}
