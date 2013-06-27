using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace TUFMAN.DAL.Maps.Ref {
    
    
    public class GearsMap : ClassMap<Gears> {
        
        public GearsMap() {
            Schema("ref");
			Table("gears");
			Id(x => x.gear_code).GeneratedBy.Assigned().Column("gear_code");
			Map(x => x.gear_code_2).Column("gear_code_2").Length(2);
			Map(x => x.gear_desc).Column("gear_desc").Length(30);
			Map(x => x.mimra_type_code).Column("mimra_type_code").Length(1);
        }
    }
}
