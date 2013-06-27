using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ref {
    
    public class SpeciesRanges {
        public string gear_code { get; set; }
        public string sp_code { get; set; }
        public string sp_name { get; set; }
        public int? avg_wt { get; set; }
        public decimal? min_n { get; set; }
        public decimal? max_n { get; set; }
        public decimal? min_wt { get; set; }
        public decimal? max_wt { get; set; }
        public int? min_lf_wt { get; set; }
        public int? low_lf_wt { get; set; }
        public int? high_lf_wt { get; set; }
        public int? max_lf_wt { get; set; }
        public decimal? min_avgwt { get; set; }
        public decimal? max_avgwt { get; set; }
        public decimal? min_len { get; set; }
        public decimal? low_len { get; set; }
        public decimal? high_len { get; set; }
        public decimal? max_len { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as SpeciesRanges;
			if (t == null) return false;
			if (gear_code == t.gear_code
			 && sp_code == t.sp_code)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = 13;
			hash += gear_code.GetHashCode();
			hash += sp_code.GetHashCode();

			return hash;
        }
        #endregion
    }
}
