using System;
using System.Text;
using System.Collections.Generic;


namespace TUFMAN.Domain.Ves {
    
    public class VesselHistory {
        public int vessel_history_id { get; set; }
        public Vessels vessels { get; set; }
        public DateTime first_date { get; set; }
        public DateTime? last_date { get; set; }
        public string vessel_name { get; set; }
        public string regist_no { get; set; }
        public string gear_code { get; set; }
        public decimal? grt { get; set; }
        public string flag_code { get; set; }
        public string flag_conv_code { get; set; }
        public string ircs { get; set; }
        public int? alc_id { get; set; }
        public decimal? ffa_vid { get; set; }
        public int? owner_id { get; set; }
        public int? agent_id { get; set; }
        public int? captain_id { get; set; }
        public DateTime? entry_date { get; set; }
        public int? fishmaster_id { get; set; }
        public bool inactive { get; set; }
        public string win { get; set; }
        public string comments { get; set; }
        public string vregport { get; set; }
        public string vownname { get; set; }
        public string vownaddress { get; set; }
        public string vmastname { get; set; }
        public string vmastnationality { get; set; }
        public string vbuiltwhere { get; set; }
        public string vbuiltwhen { get; set; }
        public string vprevname { get; set; }
        public string vprevircs { get; set; }
        public string vprevflag { get; set; }
        public string vprevregno { get; set; }
        public string vinmarsatchannels { get; set; }
        public string vinmarsatnumbers { get; set; }
        public string vinmarsatano { get; set; }
        public string vinmarsatbno { get; set; }
        public string vinmarsatcno { get; set; }
        public string vinmarsatfno { get; set; }
        public string vinmarsatmno { get; set; }
        public short? vcrew { get; set; }
        public decimal? vlength { get; set; }
        public string vlengthtype { get; set; }
        public string vlengthunits { get; set; }
        public decimal? vmdepth { get; set; }
        public decimal? vbeam { get; set; }
        public decimal? vpower { get; set; }
        public string vpowerunits { get; set; }
        public string vfreezertypes { get; set; }
        public bool vstoremethod1 { get; set; }
        public bool vstoremethod2 { get; set; }
        public bool vstoremethod3 { get; set; }
        public bool vstoremethod4 { get; set; }
        public short? vfreezerno { get; set; }
        public decimal? vfreezercapacity { get; set; }
        public string vfreezcapunits { get; set; }
        public decimal? vfholdcapacity { get; set; }
        public string vcapacityunits { get; set; }
        public string vauthtype { get; set; }
        public string vauthno { get; set; }
        public string vauthareas { get; set; }
        public string vauthspecies { get; set; }
        public string vauthperiod { get; set; }
        public bool refrig_seawater { get; set; }
        public bool refrig_aircoils { get; set; }
        public bool refrig_airblast { get; set; }
        public bool refrig_brinenacl { get; set; }
        public bool refrig_ice { get; set; }
        public bool refrig_brinecacl { get; set; }
        public string refrig_other { get; set; }
        public int? boat_id { get; set; }
    }
}
