using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace TUFMAN.DAL.Maps.Ref {
    
    
    public class ActivitycodesHLMap : ClassMap<ActivitycodesHL> {
        
        public ActivitycodesHLMap() {
            Schema("ref");
			Table("activitycodes_hl");
			Id(x => x.h_activity_id).GeneratedBy.Identity().Column("h_activity_id");
			Map(x => x.activity_desc).Column("activity_desc").Length(60);
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}
