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
    
    public partial class KetHon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KetHon()
        {
            this.KhaiSinhs = new HashSet<KhaiSinh>();
        }
    
        public int MaKH { get; set; }
        public string CCCDChong { get; set; }
        public string CCCDVo { get; set; }
        public System.DateTime NgayDangKy { get; set; }
    
        public virtual CanCuocCongDan CanCuocCongDan { get; set; }
        public virtual CanCuocCongDan CanCuocCongDan1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhaiSinh> KhaiSinhs { get; set; }
        public virtual LyHon LyHon { get; set; }
    }
}