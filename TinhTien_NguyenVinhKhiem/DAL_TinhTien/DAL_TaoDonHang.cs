using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TinhTien;
using static DTO_TinhTien.DTO_TaoDonHang;

namespace DAL_TinhTien
{
    public class DAL_TaoDonHang : DBConnect
    {
        public DataTable getKhachHangCu()
        {
            DataTable dtKhachHangCu = new DataTable();

            try
            {
                string SQL = "SELECT kh.MaKhachHang,  kh.TenKhachHang, kh.SoDienThoai, SUM(dhck.SoTienChietKhau) AS SoTienVoucherLanMuaTruoc FROM KhachHang kh JOIN DonHang dh ON kh.MaKhachHang = dh.MaKhachHang JOIN DonHangChietKhau dhck ON dh.MaDonHang = dhck.MaDonHang WHERE dhck.LoaiChietKhau = 'Voucher' GROUP BY kh.MaKhachHang, kh.TenKhachHang, kh.SoDienThoai";
                using (SqlDataAdapter da = new SqlDataAdapter(SQL, connect))
                {
                    da.Fill(dtKhachHangCu);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi: " + e.Message);
            }

            return dtKhachHangCu;
        }
    }
}
