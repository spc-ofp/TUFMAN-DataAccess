using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Tufman {
    
    public class Subareas {
        public virtual string subarea_id { get; set; }
        public virtual string subarea_lib { get; set; }
        public virtual float? lat_dec_from { get; set; }
        public virtual float? lat_dec_to { get; set; }
        public virtual float? lon_dec_from { get; set; }
        public virtual float? lon_dec_to { get; set; }
        public virtual float? lat_dec_mid { get; set; }
        public virtual float? lon_dec_mid { get; set; }
        public virtual string geographic_area { get; set; }
        public virtual string lat_mid { get; set; }
        public virtual string lon_mid { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
