using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Log; 

namespace TUFMAN.DAL.Maps.Log {
    
    
    public class TripsLLMap : ClassMap<TripsLL> {
        
        public TripsLLMap() {
            Schema("log");
			Table("trips_ll");
			Id(x => x.log_trip_id).GeneratedBy.Identity().Column("log_trip_id");
			References(x => x.trips_llVal).Column("recon_trip_id");
			References(x => x.vessels).Column("vessel_id");
			Map(x => x.license_id).Column("license_id").Precision(10);
            Map(x => x.vessel_id).Column("vessel_id").Precision(10);
            Map(x => x.unload_id).Column("unload_id").Precision(10);
			Map(x => x.vess_act_id).Column("vess_act_id").Precision(10);
			Map(x => x.sample_id).Column("sample_id").Precision(10);
			Map(x => x.flag_code).Column("flag_code").Length(20);
			Map(x => x.ffa_vid).Column("ffa_vid").Precision(10);
			Map(x => x.ircs).Column("ircs").Length(50);
			Map(x => x.license_no).Column("license_no").Length(50);
			Map(x => x.trip_no).Column("trip_no").Precision(5);
			Map(x => x.first_logdate).Column("first_logdate");
			Map(x => x.last_logdate).Column("last_logdate");
			Map(x => x.depart_port_id).Column("depart_port_id").Precision(10);
			Map(x => x.depart_date).Column("depart_date");
			Map(x => x.return_date).Column("return_date");
			Map(x => x.return_port_id).Column("return_port_id").Precision(10);
			Map(x => x.target_sp_code).Column("target_sp_code").Length(3);
			Map(x => x.entry_date).Column("entry_date");
			Map(x => x.comments).Column("comments");
			Map(x => x.obs_trip_id).Column("obs_trip_id").Precision(10);
			Map(x => x.nat_fleet_id).Column("nat_fleet_id").Precision(10);
			Map(x => x.eez_catch_only).Column("eez_catch_only").Not.Nullable();
			Map(x => x.entered_by).Column("entered_by").Length(50);
			Map(x => x.batch_code).Column("batch_code").Length(10);
			Map(x => x.totals_checked).Column("totals_checked").Not.Nullable();
			Map(x => x.form_type_id).Column("form_type_id").Precision(10);
			Map(x => x.first_logdate_yy).Column("first_logdate_yy").Precision(10);
        }
    }
}
