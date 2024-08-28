using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TinhTien
{
    public class DTO_KhachHang
    {
        public int MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }

        // Constructor không tham số
        public DTO_KhachHang()
        {
        }

        // Constructor với tham số
        public DTO_KhachHang(int maKhachHang, string tenKhachHang, string email, string soDienThoai, string diaChi)
        {
            this.MaKhachHang = maKhachHang;
            this.TenKhachHang = tenKhachHang;
            this.Email = email;
            this.SoDienThoai = soDienThoai;
            this.DiaChi = diaChi;
        }
    }
}
