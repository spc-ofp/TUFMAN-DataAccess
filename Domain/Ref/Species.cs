using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ref {
    
    public class Species {
        public virtual string sp_code { get; set; }
        public virtual string sp_name { get; set; }
        public virtual string sp_cat_code { get; set; }
        public virtual string sp_sci_name { get; set; }
        public virtual string sp_name_japan { get; set; }
        public virtual string sp_name_french { get; set; }
        public virtual string sci_cat_code { get; set; }
        public virtual bool target_filter { get; set; }
        public virtual bool bait { get; set; }
        public virtual bool interim { get; set; }
        public virtual bool upd_species { get; set; }
        public virtual string sp_id_old { get; set; }
        public virtual string sp_comments { get; set; }
        public virtual decimal? avwt_est { get; set; }
        public virtual decimal? lenwt_a { get; set; }
        public virtual decimal? lenwt_b { get; set; }
        public virtual string len_code { get; set; }
        public virtual string wt_code { get; set; }
        public virtual string sp_pict_file { get; set; }
        public virtual DateTime? last_update { get; set; }
        public virtual bool display_in_list { get; set; }
    }
}
