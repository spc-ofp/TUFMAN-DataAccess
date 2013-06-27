using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace TUFMAN.DAL.Maps.Ref {
    
    
    public class ActivitycodesGNMap : ClassMap<ActivitycodesGN> {
        
        public ActivitycodesGNMap() {
            Schema("ref");
			Table("activitycodes_gn");
			Id(x => x.n_activity_id).GeneratedBy.Identity().Column("n_activity_id");
			Map(x => x.activity_desc).Column("activity_desc").Length(60);
        }
    }
}
