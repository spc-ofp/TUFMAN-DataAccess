using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace TUFMAN.DAL.Maps.Ref {
    
    
    public class FieldStaffMap : ClassMap<FieldStaff> {
        
        public FieldStaffMap() {
            Schema("ref");
			Table("field_staff");
			Id(x => x.staff_id).GeneratedBy.Identity().Column("staff_id");
			Map(x => x.lev_id).Column("lev_id").Precision(10);
			Map(x => x.staff_code).Column("staff_code").Length(3);
			Map(x => x.first_name).Column("first_name").Length(50);
			Map(x => x.family_name).Column("family_name").Length(50);
			Map(x => x.birth_date).Column("birth_date");
			Map(x => x.staff_type_id).Column("staff_type_id").Precision(10);
			Map(x => x.country_code).Column("country_code").Length(2);
			Map(x => x.home_port_id).Column("home_port_id").Precision(10);
			Map(x => x.home_portold).Column("home_portold").Length(255);
			Map(x => x.address1).Column("address1").Length(100);
			Map(x => x.address2).Column("address2").Length(100);
			Map(x => x.prv_id).Column("prv_id").Precision(10);
			Map(x => x.phone).Column("phone").Length(30);
			Map(x => x.fax).Column("fax").Length(30);
			Map(x => x.email).Column("email").Length(50);
			Map(x => x.contact_name).Column("contact_name").Length(50);
			Map(x => x.mst_id).Column("mst_id").Precision(10);
			Map(x => x.marital_status).Column("marital_status").Length(50);
			Map(x => x.next_of_kin_name).Column("next_of_kin_name").Length(50);
			Map(x => x.next_of_kin_phone).Column("next_of_kin_phone").Length(50);
			Map(x => x.passport_number).Column("passport_number").Length(50);
			Map(x => x.passport_name).Column("passport_name").Length(50);
			Map(x => x.passport_issue_date).Column("passport_issue_date");
			Map(x => x.passport_issue_place).Column("passport_issue_place").Length(50);
			Map(x => x.passport_expiry_date).Column("passport_expiry_date");
			Map(x => x.bank_name).Column("bank_name").Length(50);
			Map(x => x.bank_account_number).Column("bank_account_number").Length(50);
			Map(x => x.height).Column("height").Length(50);
			Map(x => x.weight).Column("weight").Length(50);
			Map(x => x.shoe_size).Column("shoe_size").Length(50);
			Map(x => x.shirt_size).Column("shirt_size").Length(50);
			Map(x => x.trouser_size).Column("trouser_size").Length(50);
			Map(x => x.kit_type).Column("kit_type").Length(50);
			Map(x => x.kit_issue_date).Column("kit_issue_date");
			Map(x => x.rating).Column("rating").Precision(5);
			Map(x => x.entered_by).Column("entered_by").Length(50);
        }
    }
}
