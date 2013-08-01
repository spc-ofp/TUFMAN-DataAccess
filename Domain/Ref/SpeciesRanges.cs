using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ref {
    
    public class SpeciesRanges {
        public virtual string gear_code { get; set; }
        public virtual string sp_code { get; set; }
        public virtual string sp_name { get; set; }
        public virtual int? avg_wt { get; set; }
        public virtual decimal? min_n { get; set; }
        public virtual decimal? max_n { get; set; }
        public virtual decimal? min_wt { get; set; }
        public virtual decimal? max_wt { get; set; }
        public virtual int? min_lf_wt { get; set; }
        public virtual int? low_lf_wt { get; set; }
        public virtual int? high_lf_wt { get; set; }
        public virtual int? max_lf_wt { get; set; }
        public virtual decimal? min_avgwt { get; set; }
        public virtual decimal? max_avgwt { get; set; }
        public virtual decimal? min_len { get; set; }
        public virtual decimal? low_len { get; set; }
        public virtual decimal? high_len { get; set; }
        public virtual decimal? max_len { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
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
