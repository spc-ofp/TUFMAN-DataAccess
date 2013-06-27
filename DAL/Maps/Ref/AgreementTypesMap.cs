using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace TUFMAN.DAL.Maps.Ref {
    
    
    public class AgreementTypesMap : ClassMap<AgreementTypes> {
        
        public AgreementTypesMap() {
            Schema("ref");
			Table("agreement_types");
			Id(x => x.agr_type_id).GeneratedBy.Identity().Column("agr_type_id");
			Map(x => x.agr_type_desc).Column("agr_type_desc").Length(50);
        }
    }
}
