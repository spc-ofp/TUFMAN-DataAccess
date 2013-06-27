using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ref {
    
    public class Species {
        public string sp_code { get; set; }
        public string sp_name { get; set; }
        public string sp_cat_code { get; set; }
        public string sp_sci_name { get; set; }
        public string sp_name_japan { get; set; }
        public string sp_name_french { get; set; }
        public string sci_cat_code { get; set; }
        public bool target_filter { get; set; }
        public bool bait { get; set; }
        public bool interim { get; set; }
        public bool upd_species { get; set; }
        public string sp_id_old { get; set; }
        public string sp_comments { get; set; }
        public decimal? avwt_est { get; set; }
        public decimal? lenwt_a { get; set; }
        public decimal? lenwt_b { get; set; }
        public string len_code { get; set; }
        public string wt_code { get; set; }
        public string sp_pict_file { get; set; }
        public DateTime? last_update { get; set; }
        public bool display_in_list { get; set; }
    }
}
