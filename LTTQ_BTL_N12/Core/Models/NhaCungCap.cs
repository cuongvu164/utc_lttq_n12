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
    using System.ComponentModel.DataAnnotations;

    public partial class NhaCungCap
    {
        [Key]
        public string MaNCC { get; set; }
        public string TenNcc { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> DienThoai { get; set; }
    }
}
