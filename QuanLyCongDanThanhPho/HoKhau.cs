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
    
    public partial class HoKhau
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoKhau()
        {
            this.TamTruTamVangs = new HashSet<TamTruTamVang>();
            this.ThuongTrus = new HashSet<ThuongTru>();
        }
    
        public int MaHo { get; set; }
        public string ChuHo { get; set; }
        public string TinhThanh { get; set; }
        public string QuanHuyen { get; set; }
        public string PhuongXa { get; set; }
        public System.DateTime NgayDangKy { get; set; }
    
        public virtual CanCuocCongDan CanCuocCongDan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TamTruTamVang> TamTruTamVangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThuongTru> ThuongTrus { get; set; }
    }
}