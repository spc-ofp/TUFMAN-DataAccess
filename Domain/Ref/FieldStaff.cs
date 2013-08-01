using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ref {
    
    public class FieldStaff {
        public virtual int staff_id { get; set; }
        public virtual int? lev_id { get; set; }
        public virtual string staff_code { get; set; }
        public virtual string first_name { get; set; }
        public virtual string family_name { get; set; }
        public virtual DateTime? birth_date { get; set; }
        public virtual int? staff_type_id { get; set; }
        public virtual string country_code { get; set; }
        public virtual int? home_port_id { get; set; }
        public virtual string home_portold { get; set; }
        public virtual string address1 { get; set; }
        public virtual string address2 { get; set; }
        public virtual int? prv_id { get; set; }
        public virtual string phone { get; set; }
        public virtual string fax { get; set; }
        public virtual string email { get; set; }
        public virtual string contact_name { get; set; }
        public virtual int? mst_id { get; set; }
        public virtual string marital_status { get; set; }
        public virtual string next_of_kin_name { get; set; }
        public virtual string next_of_kin_phone { get; set; }
        public virtual string passport_number { get; set; }
        public virtual string passport_name { get; set; }
        public virtual DateTime? passport_issue_date { get; set; }
        public virtual string passport_issue_place { get; set; }
        public virtual DateTime? passport_expiry_date { get; set; }
        public virtual string bank_name { get; set; }
        public virtual string bank_account_number { get; set; }
        public virtual string height { get; set; }
        public virtual string weight { get; set; }
        public virtual string shoe_size { get; set; }
        public virtual string shirt_size { get; set; }
        public virtual string trouser_size { get; set; }
        public virtual string kit_type { get; set; }
        public virtual DateTime? kit_issue_date { get; set; }
        public virtual short? rating { get; set; }
        public virtual string entered_by { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
