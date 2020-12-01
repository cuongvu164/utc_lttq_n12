//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LTTQ_BTL_N12.Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhoDia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhoDia()
        {
            this.ChiTietHoaDonBans = new HashSet<ChiTietHoaDonBan>();
            this.ChiTietHoaDonNhaps = new HashSet<ChiTietHoaDonNhap>();
            this.MatHongDias = new HashSet<MatHongDia>();
        }
    
        public string MaDia { get; set; }
        public string TenDia { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public int DonGiaBan { get; set; }
        public int DonGiaNhap { get; set; }
        public string MaNSX { get; set; }
        public string MaTheLoai { get; set; }
        public string GhiChu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDonBan> ChiTietHoaDonBans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; }
        public virtual TheLoai TheLoai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatHongDia> MatHongDias { get; set; }
        public virtual NoiSanXuat NoiSanXuat { get; set; }
    }
}
