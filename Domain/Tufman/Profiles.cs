using System;
using System.Text;
using System.Collections.Generic;
using TUFMAN.Domain.Ref;

namespace TUFMAN.Domain.Tufman {
    
    public class Profiles {
        public virtual string country_code { get; set; }
        public virtual Countries countries { get; set; }
        public virtual Ports ports { get; set; }
        public virtual string revision { get; set; }
        public virtual string mapinfo_path { get; set; }
        public virtual string show_logsheet { get; set; }
        public virtual bool show_vess_act { get; set; }
        public virtual string show_sampling { get; set; }
        public virtual bool show_unloading { get; set; }
        public virtual bool show_pack_list { get; set; }
        public virtual bool show_licensing { get; set; }
        public virtual bool show_observer { get; set; }
        public virtual bool show_registrations { get; set; }
        public virtual bool show_receipting { get; set; }
        public virtual bool show_telex { get; set; }
        public virtual bool show_artisanal { get; set; }
        public virtual bool show_registry { get; set; }
        public virtual string local_cur_code { get; set; }
        public virtual string agr_format { get; set; }
        public virtual string arp_type_code { get; set; }
        public virtual bool show_nat_fleet { get; set; }
        public virtual bool eez_catch_only { get; set; }
        public virtual int? vidmast { get; set; }
        public virtual DateTime? link_lic_date { get; set; }
        public virtual DateTime? link_nat_date { get; set; }
        public virtual DateTime? link_ll_date { get; set; }
        public virtual DateTime? link_ps_date { get; set; }
        public virtual DateTime? link_pl_date { get; set; }
        public virtual DateTime? links_oth_date { get; set; }
        public virtual DateTime? est_catch_date { get; set; }
        public virtual DateTime? est_hooks_date { get; set; }
        public virtual DateTime? raise_catch_date { get; set; }
        public virtual DateTime? trip_cov_date { get; set; }
        public virtual string odbc_driver { get; set; }
        public virtual string odbc_database { get; set; }
        public virtual string odbc_server { get; set; }
        public virtual string odbc_connect_string { get; set; }
        public virtual DateTime? license_upload_date { get; set; }
        public virtual int? install_no { get; set; }
        public virtual bool? copy_only { get; set; }
        public virtual bool? iw_eez_entry { get; set; }
        public virtual bool use_ringnet { get; set; }
        public virtual bool use_gillnet { get; set; }
        public virtual bool use_alia { get; set; }
        public virtual bool require_ves_cat { get; set; }
        public virtual bool ps_vessel_unloads { get; set; }
        public virtual string all_vessels_licensed { get; set; }
        public virtual string all_vessels_national { get; set; }
        public virtual DateTime? recon_date_full { get; set; }
        public virtual DateTime? recon_date_inc { get; set; }
        public virtual string smartpdfdata_path { get; set; }
        public virtual DateTime? entered_date { get; set; }
        public virtual DateTime? changed_date { get; set; }
    }
}
