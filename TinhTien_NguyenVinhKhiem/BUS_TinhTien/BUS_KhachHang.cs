using DAL_TinhTien;
using DTO_TinhTien;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_TinhTien
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKhachHang = new DAL_KhachHang();
        public DataTable getKhachHang()
        {
            return dalKhachHang.getKhachHang();
        }
        public bool themKhachHang(DTO_KhachHang kh)
        {
            return dalKhachHang.themKhachHang(kh);
        }
        public bool suaKhachHang(DTO_KhachHang kh)
        {
            return dalKhachHang.suaKhachHang(kh);
        }
        public bool xoaKhachHang(int maKhachHang)
        {
            return dalKhachHang.xoaKhachHang(maKhachHang);
        }
        public bool kiemTraSoDienThoaiTonTai(string soDienThoai)
        {
            return dalKhachHang.kiemTraSoDienThoaiTonTai(soDienThoai);
        }
        public bool kiemTraSoDienThoaiTonTai(string soDienThoai, int maKhachHang)
        {
            return dalKhachHang.kiemTraSoDienThoaiTonTai(soDienThoai, maKhachHang);
        }
    }
}
