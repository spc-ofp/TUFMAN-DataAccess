using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Tufman; 

namespace TUFMAN.DAL.Maps.Tufman {
    
    
    public class SbAreasMap : ClassMap<SbAreas> {
        
        public SbAreasMap() {
            Schema("tufman");
			Table("sb_areas");
			Id(x => x.grid).GeneratedBy.Assigned().Column("grid");
			Map(x => x.lat).Column("lat").Length(9);
			Map(x => x.lon).Column("lon").Length(10);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}
