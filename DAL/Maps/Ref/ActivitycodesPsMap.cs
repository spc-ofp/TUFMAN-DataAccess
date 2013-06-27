using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace TUFMAN.DAL.Maps.Ref {
    
    
    public class ActivitycodesPSMap : ClassMap<ActivitycodesPS> {
        
        public ActivitycodesPSMap() {
            Schema("ref");
			Table("activitycodes_ps");
			Id(x => x.s_activity_id).GeneratedBy.Identity().Column("s_activity_id");
			Map(x => x.activity_desc).Column("activity_desc").Length(60);
        }
    }
}
