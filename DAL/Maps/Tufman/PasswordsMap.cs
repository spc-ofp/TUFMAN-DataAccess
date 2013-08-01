using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Tufman; 

namespace TUFMAN.DAL.Maps.Tufman {
    
    
    public class PasswordsMap : ClassMap<Passwords> {
        
        public PasswordsMap() {
            Schema("tufman");
			Table("passwords");
			Id(x => x.text_id).GeneratedBy.Assigned().Column("text_id");
			Map(x => x.password).Column("password").Length(50);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}
