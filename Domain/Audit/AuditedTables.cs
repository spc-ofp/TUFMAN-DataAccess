using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Audit {
    
    public class AuditedTables {
        public virtual int table_id { get; set; }
        public virtual string table_schema { get; set; }
        public virtual string table_name { get; set; }
        public virtual string key_field { get; set; }
        public virtual string key_field_type { get; set; }
    }
}
