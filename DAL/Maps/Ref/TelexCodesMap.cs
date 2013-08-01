using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace TUFMAN.DAL.Maps.Ref {
    
    
    public class TelexCodesMap : ClassMap<TelexCodes> {
        
        public TelexCodesMap() {
            Schema("ref");
			Table("telex_codes");
			Id(x => x.rpt_code).GeneratedBy.Assigned().Column("rpt_code");
			Map(x => x.rpt_desc).Column("rpt_desc").Length(100);
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}
