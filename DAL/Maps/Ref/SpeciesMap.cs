using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace TUFMAN.DAL.Maps.Ref {
    
    
    public class SpeciesMap : ClassMap<Species> {
        
        public SpeciesMap() {
            Schema("ref");
			Table("species");
			Id(x => x.sp_code).GeneratedBy.Assigned().Column("sp_code");
			Map(x => x.sp_name).Column("sp_name").Length(50);
			Map(x => x.sp_cat_code).Column("sp_cat_code").Length(3);
			Map(x => x.sp_sci_name).Column("sp_sci_name").Length(30);
			Map(x => x.sp_name_japan).Column("sp_name_japan").Length(30);
			Map(x => x.sp_name_french).Column("sp_name_french").Length(30);
			Map(x => x.sci_cat_code).Column("sci_cat_code").Length(3);
			Map(x => x.target_filter).Column("target_filter").Not.Nullable();
			Map(x => x.bait).Column("bait").Not.Nullable();
			Map(x => x.interim).Column("interim").Not.Nullable();
			Map(x => x.upd_species).Column("upd_species").Not.Nullable();
			Map(x => x.sp_id_old).Column("sp_id_old").Length(3);
			Map(x => x.sp_comments).Column("sp_comments").Length(255);
			Map(x => x.avwt_est).Column("avwt_est").Precision(5);
			Map(x => x.lenwt_a).Column("lenwt_a").Precision(12).Scale(10);
			Map(x => x.lenwt_b).Column("lenwt_b").Precision(9).Scale(6);
			Map(x => x.len_code).Column("len_code").Length(2);
			Map(x => x.wt_code).Column("wt_code").Length(2);
			Map(x => x.sp_pict_file).Column("sp_pict_file").Length(15);
			Map(x => x.last_update).Column("last_update");
			Map(x => x.display_in_list).Column("display_in_list").Not.Nullable();
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}
