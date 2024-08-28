using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_TinhTien;

namespace BUS_TinhTien
{
    public class BUS_LichSuDonHang
    {
        DAL_LichSuDonHang dalLichSuDonHang = new DAL_LichSuDonHang();
        public DataTable getLichSuDonHang()
        {
            return dalLichSuDonHang.getLichSuDonHang();
        }
        public DataTable getChiTietDonHang(int maDonHang)
        {
            return dalLichSuDonHang.getChiTietDonHang(maDonHang);
        }
    }
}
