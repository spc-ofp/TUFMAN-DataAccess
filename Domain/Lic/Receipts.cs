using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Lic {
    
    public class Receipts {
        public virtual int rec_id { get; set; }
        public virtual string rem_ref { get; set; }
        public virtual int company_id { get; set; }
        public virtual DateTime recvd_date { get; set; }
        public virtual string bank_ref { get; set; }
        public virtual decimal amount_foreign { get; set; }
        public virtual bool incomplete { get; set; }
        public virtual string cur_code { get; set; }
        public virtual decimal? amount_local { get; set; }
        public virtual decimal? bank_fees { get; set; }
        public virtual float? ex_rate { get; set; }
        public virtual bool confirmed { get; set; }
        public virtual string comments { get; set; }
        public virtual string entered_by { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual string other_ref { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
