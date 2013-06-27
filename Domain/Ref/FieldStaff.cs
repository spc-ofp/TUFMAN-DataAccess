using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ref {
    
    public class FieldStaff {
        public int staff_id { get; set; }
        public int? lev_id { get; set; }
        public string staff_code { get; set; }
        public string first_name { get; set; }
        public string family_name { get; set; }
        public DateTime? birth_date { get; set; }
        public int? staff_type_id { get; set; }
        public string country_code { get; set; }
        public int? home_port_id { get; set; }
        public string home_portold { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public int? prv_id { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string contact_name { get; set; }
        public int? mst_id { get; set; }
        public string marital_status { get; set; }
        public string next_of_kin_name { get; set; }
        public string next_of_kin_phone { get; set; }
        public string passport_number { get; set; }
        public string passport_name { get; set; }
        public DateTime? passport_issue_date { get; set; }
        public string passport_issue_place { get; set; }
        public DateTime? passport_expiry_date { get; set; }
        public string bank_name { get; set; }
        public string bank_account_number { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string shoe_size { get; set; }
        public string shirt_size { get; set; }
        public string trouser_size { get; set; }
        public string kit_type { get; set; }
        public DateTime? kit_issue_date { get; set; }
        public short? rating { get; set; }
        public string entered_by { get; set; }
    }
}
