using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace TUFMAN.DAL.Maps.Ref {
    
    
    public class ActivitycodesLLMap : ClassMap<ActivitycodesLL> {
        
        public ActivitycodesLLMap() {
            Schema("ref");
			Table("activitycodes_ll");
			Id(x => x.l_activity_id).GeneratedBy.Identity().Column("l_activity_id");
			Map(x => x.activity_desc).Column("activity_desc").Length(60);
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}
