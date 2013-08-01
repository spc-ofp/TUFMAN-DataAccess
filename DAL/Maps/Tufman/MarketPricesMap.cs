using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Tufman; 

namespace TUFMAN.DAL.Maps.Tufman {
    
    
    public class MarketPricesMap : ClassMap<MarketPrices> {
        
        public MarketPricesMap() {
            Schema("tufman");
			Table("market_prices");
			Id(x => x.market_price_id).GeneratedBy.Identity().Column("market_price_id");
			Map(x => x.yy).Column("yy").Precision(10);
			Map(x => x.mm).Column("mm").Precision(10);
			Map(x => x.market_code).Column("market_code").Length(2);
			Map(x => x.sp_code).Column("sp_code").Length(3);
			Map(x => x.price_us).Column("price_us").Precision(10);
			Map(x => x.price_yen).Column("price_yen").Precision(10);
			Map(x => x.price_local).Column("price_local").Precision(10);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}
