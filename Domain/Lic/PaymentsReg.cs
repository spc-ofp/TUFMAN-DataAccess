using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Lic {
    
    public class PaymentsReg {
        public virtual int pmt_id { get; set; }
        public virtual int? rec_id { get; set; }
        public virtual int? reg_id { get; set; }
        public virtual int payment_type_id { get; set; }
        public virtual float amount_foreign { get; set; }
        public virtual string cur_code { get; set; }
        public virtual float? amount_local { get; set; }
        public virtual string comments { get; set; }
        public virtual string zprl_id { get; set; }
        public virtual int? zref_id { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
