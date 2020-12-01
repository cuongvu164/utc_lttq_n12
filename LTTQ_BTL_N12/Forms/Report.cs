using LTTQ_BTL_N12.Core.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTQ_BTL_N12.Forms
{
    public partial class Report : UserControl
    {
        ProcessDataBase db = new ProcessDataBase();
        public Report()
        {
            InitializeComponent();
        }

        private void btnshow1_Click(object sender, EventArgs e)
        {
            var data = db.DocBang("select * from KhoDia kd " +
                "where kd.MaDia not in (select cthdb.MaDia from HoaDonBan hdb join ChiTietHoaDonBan cthdb on hdb.SoHDB = cthdb.SoHDB " +
                "where DATEPART(quarter, hdb.NgayBan) = "+txtSPKB.Text+")");
            ExcelUtil.ExportExcel(data, @"E:\utc_lttq_n12\danhsachsp.xlsx", "Danh sách các sản phẩm");
            MessageBox.Show("Xuất báo cáo thành công!\nE:\\utc_lttq_n12\\danhsachsp.xlsx");
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void btnshow2_Click(object sender, EventArgs e)
        {
            var data = db.DocBang("select hdn.SoHDN,hdn.TongTien from HoaDonNhap hdn where MONTH(hdn.NgayNhap) = "+txtHDN.Text);
            ExcelUtil.ExportExcel(data, @"E:\utc_lttq_n12\dshdn.xlsx", "DS hóa đơn nhập");
            MessageBox.Show("Xuất báo cáo thành công!\nE:\\utc_lttq_n12\\dshdn.xlsx");
        }

        private void btnshow3_Click(object sender, EventArgs e)
        {
            var data = db.DocBang("select hdb.SoHDB,hdb.TongTien from HoaDonBan hdb join KhachHang kh on hdb.MaKhach = kh.MaKhach " +
                "where kh.TenKhach = N'"+txtHDM.Text+"'");
            ExcelUtil.ExportExcel(data, @"E:\utc_lttq_n12\dshdm.xlsx", "DS hóa đơn,tổng tiền mua hàng");
            MessageBox.Show("Xuất báo cáo thành công!\nE:\\utc_lttq_n12\\dshdm.xlsx");
        }

        private void btnshow4_Click(object sender, EventArgs e)
        {
            var data = db.DocBang("select top(5) ncc.TenNcc,Sum(cthdn.SoLuong) as N'Tổng Nhập' from NhaCungCap ncc join HoaDonNhap hdn on ncc.MaNCC = hdn.MaNCC join ChiTietHoaDonNhap cthdn on hdn.SoHDN = cthdn.SoHDN where YEAR(hdn.NgayNhap)" +
                " = "+txtNCC.Text+" group by ncc.TenNcc order by count(cthdn.SoLuong) desc");
            ExcelUtil.ExportExcel(data, @"E:\utc_lttq_n12\dsncc.xlsx", "DS 5 NCC giao nhiều");
            MessageBox.Show("Xuất báo cáo thành công!\nE:\\utc_lttq_n12\\dsncc.xlsx");
        }
    }
}
