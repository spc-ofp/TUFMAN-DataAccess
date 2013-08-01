using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Lic; 

namespace TUFMAN.DAL.Maps.Lic {
    
    
    public class PositionReportsMap : ClassMap<PositionReports> {
        
        public PositionReportsMap() {
            Schema("lic");
			Table("position_reports");
			Id(x => x.telex_id).GeneratedBy.Identity().Column("telex_id");
			References(x => x.licenses).Column("license_id");
			References(x => x.telex_codes).Column("rpt_code");
			References(x => x.ports).Column("port_id");
			Map(x => x.recon_trip_id).Column("recon_trip_id").Precision(10);
			Map(x => x.gear_code).Column("gear_code").Length(2);
			Map(x => x.log_trip_id).Column("log_trip_id").Precision(10);
			Map(x => x.telex_date).Column("telex_date").Not.Nullable();
			Map(x => x.telex_time).Column("telex_time").Length(5);
			Map(x => x.telex_aux_date).Column("telex_aux_date");
			Map(x => x.lat).Column("lat").Length(5);
			Map(x => x.lon).Column("lon").Length(6);
			Map(x => x.gar_id).Column("gar_id").Precision(10);
			Map(x => x.catch_mt).Column("catch_mt").Precision(53);
			Map(x => x.noop_reason).Column("noop_reason").Length(25);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.skj_mt).Column("skj_mt").Precision(53);
			Map(x => x.yft_mt).Column("yft_mt").Precision(53);
			Map(x => x.bet_mt).Column("bet_mt").Precision(53);
			Map(x => x.alb_mt).Column("alb_mt").Precision(53);
			Map(x => x.oth_mt).Column("oth_mt").Precision(53);
			Map(x => x.completion_num).Column("completion_num").Precision(5);
			Map(x => x.zone_entry_code).Column("zone_entry_code").Length(1);
			Map(x => x.nat_fleet_id).Column("nat_fleet_id").Precision(10);
			Map(x => x.fish_days_n).Column("fish_days_n").Precision(10);
			Map(x => x.fuel).Column("fuel").Precision(10);
			Map(x => x.tank_id).Column("tank_id").Not.Nullable().Precision(10);
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}
