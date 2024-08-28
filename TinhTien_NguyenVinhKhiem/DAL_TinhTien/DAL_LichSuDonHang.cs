using DTO_TinhTien;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_TinhTien
{
    public class DAL_LichSuDonHang : DBConnect
    {
        public DataTable getLichSuDonHang()
        {
            DataTable dtLichSuDonHang = new DataTable();

            try
            {
                string SQL = "SELECT " +
                    "dh.MaDonHang, " +             
                    "dh.NgayTao, " +               
                    "kh.MaKhachHang, " +           
                    "kh.TenKhachHang, " +         
                    "kh.SoDienThoai, " +           
                    "dh.GiaTriChuaChietKhau, " +   
                    "dh.GiaTriSauChietKhau, " +   
                    "dhck.SoTienChietKhau, " +      
                    "dhck.LoaiChietKhau, " +       
                    "ck.MaChietKhau, " +             
                    "ck.TenChietKhau, " +           
                    "ck.PhanTramChietKhau, " +     
                    "dh.SoTienThanhToan " + 
                    "FROM DonHang dh " +
                    "JOIN KhachHang kh ON dh.MaKhachHang = kh.MaKhachHang " +
                    "JOIN DonHangChietKhau dhck ON dh.MaDonHang = dhck.MaDonHang " +
                    "JOIN ChietKhau ck ON dhck.MaChietKhau = ck.MaChietKhau " +
                    "ORDER BY dh.NgayTao ASC;";

                using (SqlDataAdapter da = new SqlDataAdapter(SQL, connect))
                {
                    da.Fill(dtLichSuDonHang);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi: " + e.Message);
            }

            return dtLichSuDonHang;
        }

        public DataTable getChiTietDonHang(int maDonHang)
        {
            DataTable dtChiTietDonHang = new DataTable();

            try
            {
                string SQL = "SELECT ctdh.MaDonHang, ctdh.MaSanPham, sp.TenSanPham, sp.Gia, ctdh.SoLuong, ctdh.ThanhTien, sp.MoTa " +
                             "FROM ChiTietDonHang ctdh " +
                             "JOIN SanPham sp ON ctdh.MaSanPham = sp.MaSanPham " +
                             "WHERE ctdh.MaDonHang = @MaDonHang";

                using (SqlDataAdapter da = new SqlDataAdapter(SQL, connect))
                {
                    da.SelectCommand.Parameters.AddWithValue("@MaDonHang", maDonHang);
                    da.Fill(dtChiTietDonHang);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi: " + e.Message);
            }

            return dtChiTietDonHang;
        }
    }
}
