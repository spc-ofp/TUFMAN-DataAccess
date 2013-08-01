using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Lic; 

namespace TUFMAN.DAL.Maps.Lic {
    
    
    public class AgrCorpFjMap : ClassMap<AgrCorpFj> {
        
        public AgrCorpFjMap() {
            Schema("lic");
			Table("agr_corp_fj");
			Id(x => x.agr_code).GeneratedBy.Assigned().Column("agr_code");
			Map(x => x.workpermit_sea).Column("workpermit_sea").Length(50);
			Map(x => x.workpermit_shore).Column("workpermit_shore").Length(50);
			Map(x => x.firca).Column("firca").Length(50);
			Map(x => x.share_chg).Column("share_chg").Length(50);
			Map(x => x.neg_ddil).Column("neg_ddil").Not.Nullable();
			Map(x => x.company_reg_cert).Column("company_reg_cert").Not.Nullable();
			Map(x => x.sharecertjv).Column("sharecertjv").Not.Nullable();
			Map(x => x.moa).Column("moa").Not.Nullable();
			Map(x => x.finstat).Column("finstat").Not.Nullable();
			Map(x => x.busplan).Column("busplan").Not.Nullable();
			Map(x => x.cust_irs).Column("cust_irs").Not.Nullable();
			Map(x => x.trust).Column("trust").Not.Nullable();
			Map(x => x.vkb).Column("vkb").Length(3);
			Map(x => x.company_status).Column("company_status").Not.Nullable();
        }
    }
}
