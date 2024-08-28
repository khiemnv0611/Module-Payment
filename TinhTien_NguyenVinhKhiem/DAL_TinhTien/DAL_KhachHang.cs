using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TinhTien;

namespace DAL_TinhTien
{
    public class DAL_KhachHang : DBConnect
    {
        public DataTable getKhachHang()
        {
            DataTable dtKhachHang = new DataTable();

            try
            {
                string SQL = "SELECT MaKhachHang, TenKhachHang, Email, SoDienThoai, DiaChi FROM KhachHang";
                using (SqlDataAdapter da = new SqlDataAdapter(SQL, connect))
                {
                    da.Fill(dtKhachHang);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi: " + e.Message);
            }

            return dtKhachHang;
        }

        public bool themKhachHang(DTO_KhachHang kh)
        {
            try
            {
                string SQL = "INSERT INTO KhachHang (TenKhachHang, Email, SoDienThoai, DiaChi) VALUES (@TenKhachHang, @Email, @SoDienThoai, @DiaChi)";
                using (SqlCommand cmd = new SqlCommand(SQL, connect))
                {
                    cmd.Parameters.AddWithValue("@TenKhachHang", kh.TenKhachHang);
                    cmd.Parameters.AddWithValue("@Email", kh.Email);
                    cmd.Parameters.AddWithValue("@SoDienThoai", kh.SoDienThoai);
                    cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);

                    connect.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi: " + e.Message);
            }
            finally
            {
                connect.Close();
            }

            return false;
        }

        public bool suaKhachHang(DTO_KhachHang kh)
        {
            try
            {
                string SQL = "UPDATE KhachHang SET TenKhachHang = @TenKhachHang, Email = @Email, SoDienThoai = @SoDienThoai, DiaChi = @DiaChi WHERE MaKhachHang = @MaKhachHang";
                using (SqlCommand cmd = new SqlCommand(SQL, connect))
                {
                    cmd.Parameters.AddWithValue("@MaKhachHang", kh.MaKhachHang);
                    cmd.Parameters.AddWithValue("@TenKhachHang", kh.TenKhachHang);
                    cmd.Parameters.AddWithValue("@Email", kh.Email);
                    cmd.Parameters.AddWithValue("@SoDienThoai", kh.SoDienThoai);
                    cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);

                    connect.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi: " + e.Message);
            }
            finally
            {
                connect.Close();
            }

            return false;
        }

        public bool xoaKhachHang(int maKhachHang)
        {
            try
            {
                string SQL = "DELETE FROM KhachHang WHERE MaKhachHang = @MaKhachHang";
                using (SqlCommand cmd = new SqlCommand(SQL, connect))
                {
                    cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);

                    connect.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi: " + e.Message);
            }
            finally
            {
                connect.Close();
            }

            return false;
        }

        public bool kiemTraSoDienThoaiTonTai(string soDienThoai)
        {
            try
            {
                string SQL = "SELECT COUNT(*) FROM KhachHang WHERE SoDienThoai = @SoDienThoai";
                using (SqlCommand cmd = new SqlCommand(SQL, connect))
                {
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);

                    connect.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi: " + e.Message);
            }
            finally
            {
                connect.Close();
            }

            return false;
        }

        public bool kiemTraSoDienThoaiTonTai(string soDienThoai, int maKhachHang)
        {
            try
            {
                string SQL = "SELECT COUNT(*) FROM KhachHang WHERE SoDienThoai = @SoDienThoai AND MaKhachHang != @MaKhachHang";
                using (SqlCommand cmd = new SqlCommand(SQL, connect))
                {
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);

                    connect.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi: " + e.Message);
            }
            finally
            {
                connect.Close();
            }

            return false;
        }
    }
}
