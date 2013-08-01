using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Tufman {
    
    public class MarketPrices {
        public virtual int market_price_id { get; set; }
        public virtual int? yy { get; set; }
        public virtual int? mm { get; set; }
        public virtual string market_code { get; set; }
        public virtual string sp_code { get; set; }
        public virtual int? price_us { get; set; }
        public virtual int? price_yen { get; set; }
        public virtual int? price_local { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
