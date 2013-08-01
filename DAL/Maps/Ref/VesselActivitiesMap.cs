using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace TUFMAN.DAL.Maps.Ref {
    
    
    public class VesselActivitiesMap : ClassMap<VesselActivities> {
        
        public VesselActivitiesMap() {
            Schema("ref");
			Table("vessel_activities");
			Id(x => x.activitylog_id).GeneratedBy.Identity().Column("activitylog_id");
			Map(x => x.activity).Column("activity").Length(50);
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}
