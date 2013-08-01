using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace TUFMAN.DAL.Maps.Ref {
    
    
    public class SpeciesRangesMap : ClassMap<SpeciesRanges> {
        
        public SpeciesRangesMap() {
            Schema("ref");
			Table("species_ranges");
			CompositeId().KeyProperty(x => x.gear_code, "gear_code")
			             .KeyProperty(x => x.sp_code, "sp_code");
			Map(x => x.sp_name).Column("sp_name").Length(50);
			Map(x => x.avg_wt).Column("avg_wt").Precision(10);
			Map(x => x.min_n).Column("min_n").Precision(5);
			Map(x => x.max_n).Column("max_n").Precision(5);
			Map(x => x.min_wt).Column("min_wt").Precision(11).Scale(3);
			Map(x => x.max_wt).Column("max_wt").Precision(11).Scale(3);
			Map(x => x.min_lf_wt).Column("min_lf_wt").Precision(10);
			Map(x => x.low_lf_wt).Column("low_lf_wt").Precision(10);
			Map(x => x.high_lf_wt).Column("high_lf_wt").Precision(10);
			Map(x => x.max_lf_wt).Column("max_lf_wt").Precision(10);
			Map(x => x.min_avgwt).Column("min_avgwt").Precision(6).Scale(1);
			Map(x => x.max_avgwt).Column("max_avgwt").Precision(7).Scale(1);
			Map(x => x.min_len).Column("min_len").Precision(5);
			Map(x => x.low_len).Column("low_len").Precision(5);
			Map(x => x.high_len).Column("high_len").Precision(5);
			Map(x => x.max_len).Column("max_len").Precision(5);
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}
