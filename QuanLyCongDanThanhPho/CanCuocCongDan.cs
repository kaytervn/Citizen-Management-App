//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCongDanThanhPho
{
    using System;
    using System.Collections.Generic;
    
    public partial class CanCuocCongDan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CanCuocCongDan()
        {
            this.HoKhaus = new HashSet<HoKhau>();
            this.KetHons = new HashSet<KetHon>();
            this.KetHons1 = new HashSet<KetHon>();
            this.KhaiTus = new HashSet<KhaiTu>();
            this.Thues = new HashSet<Thue>();
        }
    
        public string CCCD { get; set; }
        public int MaCD { get; set; }
        public System.DateTime NgayDangKy { get; set; }
    
        public virtual CongDan CongDan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoKhau> HoKhaus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KetHon> KetHons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KetHon> KetHons1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhaiTu> KhaiTus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thue> Thues { get; set; }
    }
}
