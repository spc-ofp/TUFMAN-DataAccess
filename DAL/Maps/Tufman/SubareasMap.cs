using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Tufman; 

namespace TUFMAN.DAL.Maps.Tufman {
    
    
    public class SubareasMap : ClassMap<Subareas> {
        
        public SubareasMap() {
            Schema("tufman");
			Table("subareas");
			Id(x => x.subarea_id).GeneratedBy.Assigned().Column("subarea_id");
			Map(x => x.subarea_lib).Column("subarea_lib").Length(50);
			Map(x => x.lat_dec_from).Column("lat_dec_from").Precision(24);
			Map(x => x.lat_dec_to).Column("lat_dec_to").Precision(24);
			Map(x => x.lon_dec_from).Column("lon_dec_from").Precision(24);
			Map(x => x.lon_dec_to).Column("lon_dec_to").Precision(24);
			Map(x => x.lat_dec_mid).Column("lat_dec_mid").Precision(24);
			Map(x => x.lon_dec_mid).Column("lon_dec_mid").Precision(24);
			Map(x => x.geographic_area).Column("geographic_area");
			Map(x => x.lat_mid).Column("lat_mid").Length(5);
			Map(x => x.lon_mid).Column("lon_mid").Length(6);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}
