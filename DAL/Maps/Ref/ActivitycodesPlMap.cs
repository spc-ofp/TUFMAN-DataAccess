using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace TUFMAN.DAL.Maps.Ref {
    
    
    public class ActivitycodesPLMap : ClassMap<ActivitycodesPL> {
        
        public ActivitycodesPLMap() {
            Schema("ref");
			Table("activitycodes_pl");
			Id(x => x.p_activity_id).GeneratedBy.Identity().Column("p_activity_id");
			Map(x => x.activity_desc).Column("activity_desc").Length(60);
        }
    }
}
