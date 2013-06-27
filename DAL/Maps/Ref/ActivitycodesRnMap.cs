using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace TUFMAN.DAL.Maps.Ref {
    
    
    public class ActivitycodesRNMap : ClassMap<ActivitycodesRN> {
        
        public ActivitycodesRNMap() {
            Schema("ref");
			Table("activitycodes_rn");
			Id(x => x.r_activity_id).GeneratedBy.Identity().Column("r_activity_id");
			Map(x => x.activity_desc).Column("activity_desc").Length(60);
        }
    }
}
