using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Recon; 

namespace TUFMAN.DAL.Maps.Recon {
    
    
    public class ViewLogYyMmEezAllIDMap : ClassMap<ViewLogYyMmEezAllID> {
        
        public ViewLogYyMmEezAllIDMap() {
            Schema("recon");
			Table("view_log_yy_mm_eez_all_id");
            ReadOnly();
            Id(x => x.row_id).GeneratedBy.Assigned().Column("row_id");
			Map(x => x.YY).Column("YY").Not.Nullable();
			Map(x => x.MM).Column("MM");
			Map(x => x.flag_code).Column("flag_code").Length(2);
			Map(x => x.company_country_code).Column("company_country_code").Length(2);
			Map(x => x.gear_code).Column("gear_code").Not.Nullable().Length(2);
			Map(x => x.eez_code).Column("eez_code").Length(2);
			Map(x => x.trips_n).Column("trips_n");
            Map(x => x.vessels_n).Column("vessels_n");
			Map(x => x.sets_n).Column("sets_n");
			Map(x => x.hooks_n).Column("hooks_n");
			Map(x => x.days_n).Column("days_n").Precision(8).Scale(2);
            Map(x => x.alb_n).Column("alb_n");
            Map(x => x.bet_n).Column("bet_n");
            Map(x => x.skj_n).Column("skj_n");
            Map(x => x.yft_n).Column("yft_n");
            Map(x => x.oth_n).Column("oth_n");
            Map(x => x.tot_n).Column("tot_n");
            Map(x => x.alb_mt).Column("alb_mt");
            Map(x => x.bet_mt).Column("bet_mt");
            Map(x => x.skj_mt).Column("skj_mt");
            Map(x => x.yft_mt).Column("yft_mt");
			Map(x => x.oth_mt).Column("oth_mt");
			Map(x => x.tot_mt).Column("tot_mt");
        }
    }
}
