using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Audit; 

namespace TUFMAN.DAL.Maps.Audit {
    
    
    public class AuditedTablesMap : ClassMap<AuditedTables> {
        
        public AuditedTablesMap() {
            Schema("audit");
			Table("audited_tables");
			Id(x => x.table_id).GeneratedBy.Identity().Column("tabled_id");
			Map(x => x.table_schema).Column("table_schema").Not.Nullable().Length(10);
			Map(x => x.table_name).Column("table_name").Not.Nullable().Length(50);
			Map(x => x.key_field).Column("key_field").Not.Nullable().Length(50);
			Map(x => x.key_field_type).Column("key_field_type").Not.Nullable().Length(10);
        }
    }
}
