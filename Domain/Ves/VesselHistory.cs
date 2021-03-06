using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ves {
    
    public class VesselHistory {
        public virtual int vessel_history_id { get; set; }
        public virtual Vessels vessels { get; set; }
        public virtual DateTime first_date { get; set; }
        public virtual DateTime? last_date { get; set; }
        public virtual string vessel_name { get; set; }
        public virtual string regist_no { get; set; }
        public virtual string gear_code { get; set; }
        public virtual decimal? grt { get; set; }
        public virtual string flag_code { get; set; }
        public virtual string flag_conv_code { get; set; }
        public virtual string ircs { get; set; }
        public virtual int? alc_id { get; set; }
        public virtual decimal? ffa_vid { get; set; }
        public virtual int? owner_id { get; set; }
        public virtual int? agent_id { get; set; }
        public virtual int? captain_id { get; set; }
        public virtual int? fishmaster_id { get; set; }
        public virtual bool inactive { get; set; }
        public virtual string win { get; set; }
        public virtual string comments { get; set; }
        public virtual string vregport { get; set; }
        public virtual string vownname { get; set; }
        public virtual string vownaddress { get; set; }
        public virtual string vmastname { get; set; }
        public virtual string vmastnationality { get; set; }
        public virtual string vbuiltwhere { get; set; }
        public virtual string vbuiltwhen { get; set; }
        public virtual string vprevname { get; set; }
        public virtual string vprevircs { get; set; }
        public virtual string vprevflag { get; set; }
        public virtual string vprevregno { get; set; }
        public virtual string vinmarsatchannels { get; set; }
        public virtual string vinmarsatnumbers { get; set; }
        public virtual string vinmarsatano { get; set; }
        public virtual string vinmarsatbno { get; set; }
        public virtual string vinmarsatcno { get; set; }
        public virtual string vinmarsatfno { get; set; }
        public virtual string vinmarsatmno { get; set; }
        public virtual short? vcrew { get; set; }
        public virtual decimal? vlength { get; set; }
        public virtual string vlengthtype { get; set; }
        public virtual string vlengthunits { get; set; }
        public virtual decimal? vmdepth { get; set; }
        public virtual decimal? vbeam { get; set; }
        public virtual decimal? vpower { get; set; }
        public virtual string vpowerunits { get; set; }
        public virtual string vfreezertypes { get; set; }
        public virtual bool vstoremethod1 { get; set; }
        public virtual bool vstoremethod2 { get; set; }
        public virtual bool vstoremethod3 { get; set; }
        public virtual bool vstoremethod4 { get; set; }
        public virtual short? vfreezerno { get; set; }
        public virtual decimal? vfreezercapacity { get; set; }
        public virtual string vfreezcapunits { get; set; }
        public virtual decimal? vfholdcapacity { get; set; }
        public virtual string vcapacityunits { get; set; }
        public virtual string vauthtype { get; set; }
        public virtual string vauthno { get; set; }
        public virtual string vauthareas { get; set; }
        public virtual string vauthspecies { get; set; }
        public virtual string vauthperiod { get; set; }
        public virtual bool refrig_seawater { get; set; }
        public virtual bool refrig_aircoils { get; set; }
        public virtual bool refrig_airblast { get; set; }
        public virtual bool refrig_brinenacl { get; set; }
        public virtual bool refrig_ice { get; set; }
        public virtual bool refrig_brinecacl { get; set; }
        public virtual string refrig_other { get; set; }
        public virtual int? boat_id { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
