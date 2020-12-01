using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTTQ_BTL_N12.Core.Models
{
    public class KhoDiaVM
    {
        public string MaDia { get; set; }
        public string TenDia { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public int DonGiaBan { get; set; }
        public int DonGiaNhap { get; set; }
        public string MaNSX { get; set; }
        public string MaTheLoai { get; set; }
        public string GhiChu { get; set; }
        public string TenTheLoai { get; set; }
        public string TenNoiSanXuat { get; set; }
    }
}
