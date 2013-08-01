using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ves; 

namespace TUFMAN.DAL.Maps.Ves {
    
    
    public class VesselHistoryMap : ClassMap<VesselHistory> {
        
        public VesselHistoryMap() {
            Schema("ves");
			Table("vessel_history");
			Id(x => x.vessel_history_id).GeneratedBy.Identity().Column("vessel_history_id");
			References(x => x.vessels).Column("vessel_id");
			Map(x => x.first_date).Column("first_date").Not.Nullable();
			Map(x => x.last_date).Column("last_date");
			Map(x => x.vessel_name).Column("vessel_name").Length(30);
			Map(x => x.regist_no).Column("regist_no").Length(20);
			Map(x => x.gear_code).Column("gear_code").Length(1);
			Map(x => x.grt).Column("grt").Precision(8).Scale(2);
			Map(x => x.flag_code).Column("flag_code").Length(2);
			Map(x => x.flag_conv_code).Column("flag_conv_code").Length(2);
			Map(x => x.ircs).Column("ircs").Length(10);
			Map(x => x.alc_id).Column("alc_id").Precision(10);
			Map(x => x.ffa_vid).Column("ffa_vid").Precision(6);
			Map(x => x.owner_id).Column("owner_id").Precision(10);
			Map(x => x.agent_id).Column("agent_id").Precision(10);
			Map(x => x.captain_id).Column("captain_id").Precision(10);
			Map(x => x.fishmaster_id).Column("fishmaster_id").Precision(10);
			Map(x => x.inactive).Column("inactive").Not.Nullable();
			Map(x => x.win).Column("win").Length(10);
			Map(x => x.comments).Column("comments");
			Map(x => x.vregport).Column("vregport").Length(50);
			Map(x => x.vownname).Column("vownname").Length(250);
			Map(x => x.vownaddress).Column("vownaddress").Length(250);
			Map(x => x.vmastname).Column("vmastname").Length(250);
			Map(x => x.vmastnationality).Column("vmastnationality").Length(250);
			Map(x => x.vbuiltwhere).Column("vbuiltwhere").Length(50);
			Map(x => x.vbuiltwhen).Column("vbuiltwhen").Length(50);
			Map(x => x.vprevname).Column("vprevname").Length(50);
			Map(x => x.vprevircs).Column("vprevircs").Length(50);
			Map(x => x.vprevflag).Column("vprevflag").Length(50);
			Map(x => x.vprevregno).Column("vprevregno").Length(50);
			Map(x => x.vinmarsatchannels).Column("vinmarsatchannels").Length(250);
			Map(x => x.vinmarsatnumbers).Column("vinmarsatnumbers").Length(50);
			Map(x => x.vinmarsatano).Column("vinmarsatano").Length(50);
			Map(x => x.vinmarsatbno).Column("vinmarsatbno").Length(50);
			Map(x => x.vinmarsatcno).Column("vinmarsatcno").Length(50);
			Map(x => x.vinmarsatfno).Column("vinmarsatfno").Length(50);
			Map(x => x.vinmarsatmno).Column("vinmarsatmno").Length(50);
			Map(x => x.vcrew).Column("vcrew").Precision(5);
			Map(x => x.vlength).Column("vlength").Precision(10).Scale(2);
			Map(x => x.vlengthtype).Column("vlengthtype").Length(1);
			Map(x => x.vlengthunits).Column("vlengthunits").Length(1);
			Map(x => x.vmdepth).Column("vmdepth").Precision(10).Scale(2);
			Map(x => x.vbeam).Column("vbeam").Precision(10).Scale(2);
			Map(x => x.vpower).Column("vpower").Precision(10).Scale(1);
			Map(x => x.vpowerunits).Column("vpowerunits").Length(2);
			Map(x => x.vfreezertypes).Column("vfreezertypes").Length(50);
			Map(x => x.vstoremethod1).Column("vstoremethod1").Not.Nullable();
			Map(x => x.vstoremethod2).Column("vstoremethod2").Not.Nullable();
			Map(x => x.vstoremethod3).Column("vstoremethod3").Not.Nullable();
			Map(x => x.vstoremethod4).Column("vstoremethod4").Not.Nullable();
			Map(x => x.vfreezerno).Column("vfreezerno").Precision(5);
			Map(x => x.vfreezercapacity).Column("vfreezercapacity").Precision(10).Scale(2);
			Map(x => x.vfreezcapunits).Column("vfreezcapunits").Length(2);
			Map(x => x.vfholdcapacity).Column("vfholdcapacity").Precision(10).Scale(2);
			Map(x => x.vcapacityunits).Column("vcapacityunits").Length(2);
			Map(x => x.vauthtype).Column("vauthtype").Length(50);
			Map(x => x.vauthno).Column("vauthno").Length(50);
			Map(x => x.vauthareas).Column("vauthareas").Length(50);
			Map(x => x.vauthspecies).Column("vauthspecies").Length(50);
			Map(x => x.vauthperiod).Column("vauthperiod").Length(50);
			Map(x => x.refrig_seawater).Column("refrig_seawater").Not.Nullable();
			Map(x => x.refrig_aircoils).Column("refrig_aircoils").Not.Nullable();
			Map(x => x.refrig_airblast).Column("refrig_airblast").Not.Nullable();
			Map(x => x.refrig_brinenacl).Column("refrig_brinenacl").Not.Nullable();
			Map(x => x.refrig_ice).Column("refrig_ice").Not.Nullable();
			Map(x => x.refrig_brinecacl).Column("refrig_brinecacl").Not.Nullable();
			Map(x => x.refrig_other).Column("refrig_other").Length(50);
			Map(x => x.boat_id).Column("boat_id").Precision(10);
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}
