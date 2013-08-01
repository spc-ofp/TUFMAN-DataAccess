using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Audit; 

namespace TUFMAN.DAL.Maps.Audit {
    
    
    public class DeletedLogMap : ClassMap<DeletedLog> {
        
        public DeletedLogMap() {
            Schema("audit");
			Table("deleted_log");
			Id(x => x.del_log_id).GeneratedBy.Identity().Column("del_log_id");
			References(x => x.audited_table).Column("table_id");
			Map(x => x.keyvalue).Column("keyvalue").Not.Nullable().Length(50);
			Map(x => x.deleted_date).Column("deleted_date");
        }
    }
}
