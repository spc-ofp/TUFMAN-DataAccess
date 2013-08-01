using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ves {
    
    public class VesselCategories {
        public virtual string vessel_category_code { get; set; }
        public virtual string vessel_category_desc { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
