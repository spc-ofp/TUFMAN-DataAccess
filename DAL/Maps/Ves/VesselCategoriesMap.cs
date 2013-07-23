using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ves; 

namespace TUFMAN.DAL.Maps.Ves {
    
    
    public class VesselCategoriesMap : ClassMap<VesselCategories> {
        
        public VesselCategoriesMap() {
            Schema("ves");
			Table("vessel_categories");
			Id(x => x.vessel_category_code).GeneratedBy.Assigned().Column("vessel_category_code").Length(2);
			Map(x => x.vessel_category_desc).Column("vessel_category_desc").Length(250);
        }
    }
}
