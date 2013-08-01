using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ves;

namespace TUFMAN.Domain.Log {
    
    public class TripsLL {
        public TripsLL() { }
        public virtual int log_trip_id { get; set; }
        public virtual TripsLL trips_llVal { get; set; }
        public virtual Vessels vessels { get; set; }
        public virtual int vessel_id { get; set; }
        public virtual int? license_id { get; set; }
        public virtual int? unload_id { get; set; }
        public virtual int? vess_act_id { get; set; }
        public virtual int? sample_id { get; set; }
        public virtual string flag_code { get; set; }
        public virtual int? ffa_vid { get; set; }
        public virtual string ircs { get; set; }
        public virtual string license_no { get; set; }
        public virtual short? trip_no { get; set; }
        public virtual DateTime? first_logdate { get; set; }
        public virtual DateTime? last_logdate { get; set; }
        public virtual int? depart_port_id { get; set; }
        public virtual DateTime? depart_date { get; set; }
        public virtual DateTime? return_date { get; set; }
        public virtual int? return_port_id { get; set; }
        public virtual string target_sp_code { get; set; }
        public virtual string comments { get; set; }
        public virtual int? obs_trip_id { get; set; }
        public virtual int? nat_fleet_id { get; set; }
        public virtual bool eez_catch_only { get; set; }
        public virtual string entered_by { get; set; }
        public virtual string batch_code { get; set; }
        public virtual bool totals_checked { get; set; }
        public virtual int? form_type_id { get; set; }
        public virtual int? first_logdate_yy { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
