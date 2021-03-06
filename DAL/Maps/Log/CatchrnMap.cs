using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Log; 

namespace TUFMAN.DAL.Maps.Log {
    
    
    public class CatchRNMap : ClassMap<CatchRN> {
        
        public CatchRNMap() {
            Schema("log");
			Table("catch_rn");
			Id(x => x.log_catch_id).GeneratedBy.Identity().Column("log_catch_id");
			References(x => x.sets_rn).Column("log_set_id");
			References(x => x.species).Column("sp_code");
			Map(x => x.sp_n).Column("sp_n").Not.Nullable().Precision(5);
			Map(x => x.sp_mt).Column("sp_mt").Precision(53);
			Map(x => x.sp_n_est).Column("sp_n_est").Precision(10);
			Map(x => x.sp_mt_est).Column("sp_mt_est").Precision(53);
			Map(x => x.est_meth_id).Column("est_meth_id").Precision(3);
			Map(x => x.discard).Column("discard").Not.Nullable();
			Map(x => x.sizeclass).Column("sizeclass").Length(1);
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}
