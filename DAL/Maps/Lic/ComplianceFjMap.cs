using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Lic; 

namespace TUFMAN.DAL.Maps.Lic {
    
    
    public class ComplianceFjMap : ClassMap<ComplianceFj> {
        
        public ComplianceFjMap() {
            Schema("lic");
			Table("compliance_fj");
			Id(x => x.license_id).GeneratedBy.Identity().Column("license_id");
			Map(x => x.vat).Column("vat").Length(3);
			Map(x => x.fimsacert).Column("fimsacert");
			Map(x => x.hull_cert).Column("hull_cert");
			Map(x => x.vesselownperc).Column("vesselownperc").Length(50);
			Map(x => x.fiji_mast).Column("fiji_mast").Not.Nullable();
			Map(x => x.crewnation).Column("crewnation").Length(50);
			Map(x => x.fimsaclass).Column("fimsaclass").Length(15);
			Map(x => x.fimsarec).Column("fimsarec").Not.Nullable();
        }
    }
}
