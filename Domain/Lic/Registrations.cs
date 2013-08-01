using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Lic {
    
    public class Registrations {
        public virtual int reg_id { get; set; }
        public virtual string agr_code { get; set; }
        public virtual int? arp_id { get; set; }
        public virtual int vessel_id { get; set; }
        public virtual int reg_profile_id { get; set; }
        public virtual string reg_no { get; set; }
        public virtual int reg_seq_no { get; set; }
        public virtual DateTime reg_startdate { get; set; }
        public virtual DateTime reg_enddate { get; set; }
        public virtual DateTime? reg_issuedate { get; set; }
        public virtual decimal? reg_fee { get; set; }
        public virtual decimal? obs_fee { get; set; }
        public virtual string cur_code { get; set; }
        public virtual string port_code { get; set; }
        public virtual string entered_by { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
