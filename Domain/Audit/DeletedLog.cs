using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Audit {
    
    public class DeletedLog {
        public virtual int del_log_id { get; set; }
        public virtual AuditedTables audited_table { get; set; }
        public virtual string keyvalue { get; set; }
        public virtual DateTime? deleted_date { get; set; }
    }
}
