using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Tufman {
    
    public class Companies {
        public virtual int company_id { get; set; }
        public virtual string company_name { get; set; }
        public virtual string country_code { get; set; }
        public virtual string jv_country_code { get; set; }
        public virtual string company_code { get; set; }
        public virtual string address1 { get; set; }
        public virtual string address2 { get; set; }
        public virtual string address3 { get; set; }
        public virtual string city { get; set; }
        public virtual string contact_name { get; set; }
        public virtual string phone { get; set; }
        public virtual string fax { get; set; }
        public virtual string email { get; set; }
        public virtual bool agreements_flag { get; set; }
        public virtual bool inactive { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
