using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Lic {
    
    public class AgrCorpFj {
        public virtual string agr_code { get; set; }
        public virtual string workpermit_sea { get; set; }
        public virtual string workpermit_shore { get; set; }
        public virtual string firca { get; set; }
        public virtual string share_chg { get; set; }
        public virtual bool neg_ddil { get; set; }
        public virtual bool company_reg_cert { get; set; }
        public virtual bool sharecertjv { get; set; }
        public virtual bool moa { get; set; }
        public virtual bool finstat { get; set; }
        public virtual bool busplan { get; set; }
        public virtual bool cust_irs { get; set; }
        public virtual bool trust { get; set; }
        public virtual string vkb { get; set; }
        public virtual bool company_status { get; set; }
    }
}
