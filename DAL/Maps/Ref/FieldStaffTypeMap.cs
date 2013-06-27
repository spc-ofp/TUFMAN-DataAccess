using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace TUFMAN.DAL.Maps.Ref {
    
    
    public class FieldStaffTypeMap : ClassMap<FieldStaffType> {
        
        public FieldStaffTypeMap() {
            Schema("ref");
			Table("field_staff_type");
			Id(x => x.staff_type_id).GeneratedBy.Identity().Column("staff_type_id");
			Map(x => x.staff_type).Column("staff_type").Length(50);
        }
    }
}
