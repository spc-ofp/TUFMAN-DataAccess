using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace TUFMAN.DAL.Maps.Ref {
    
    
    public class SchoolCodesPSMap : ClassMap<SchoolCodesPS> {
        
        public SchoolCodesPSMap() {
            Schema("ref");
			Table("school_codes_ps");
			Id(x => x.school_id).GeneratedBy.Assigned().Column("school_id");
			Map(x => x.school_desc).Column("school_desc").Not.Nullable().Length(60);
        }
    }
}
