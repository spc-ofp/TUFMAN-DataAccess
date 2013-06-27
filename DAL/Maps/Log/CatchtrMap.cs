using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Log; 

namespace TUFMAN.DAL.Maps.Log {
    
    
    public class CatchTRMap : ClassMap<CatchTR> {
        
        public CatchTRMap() {
            Schema("log");
			Table("catch_tr");
			Id(x => x.log_catch_id).GeneratedBy.Identity().Column("log_catch_id");
			References(x => x.sets_tr).Column("log_set_id");
			References(x => x.species).Column("sp_code");
			Map(x => x.sp_n).Column("sp_n").Not.Nullable().Precision(5);
			Map(x => x.sp_kg).Column("sp_kg").Precision(5);
			Map(x => x.sp_n_est).Column("sp_n_est").Precision(10);
			Map(x => x.sp_kg_est).Column("sp_kg_est").Precision(10);
			Map(x => x.spdiscard_n).Column("spdiscard_n").Precision(5);
			Map(x => x.est_meth_id).Column("est_meth_id").Precision(3);
        }
    }
}
