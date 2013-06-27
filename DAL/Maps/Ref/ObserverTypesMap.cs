using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace TUFMAN.DAL.Maps.Ref {
    
    
    public class ObserverTypesMap : ClassMap<ObserverTypes> {
        
        public ObserverTypesMap() {
            Schema("ref");
			Table("observer_types");
			Id(x => x.obs_type_id).GeneratedBy.Identity().Column("obs_type_id");
			Map(x => x.obs_type_desc).Column("obs_type_desc").Length(50);
        }
    }
}
