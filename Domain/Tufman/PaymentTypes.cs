using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Tufman {
    
    public class PaymentTypes {
        public virtual int payment_type_id { get; set; }
        public virtual string payment_type_desc { get; set; }
        public virtual string payment_group { get; set; }
        public virtual string table_key { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
