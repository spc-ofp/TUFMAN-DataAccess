using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Tufman {
    
    public class Passwords {
        public virtual string text_id { get; set; }
        public virtual string password { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
