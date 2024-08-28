using DTO_TinhTien;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_TinhTien
{
    public class DAL_SanPham : DBConnect
    {
        public DataTable getSanPham()
        {
            DataTable dtSanPham = new DataTable();

            try
            {
                string SQL = "SELECT MaSanPham, TenSanPham, MoTa, Gia FROM SanPham";
                using (SqlDataAdapter da = new SqlDataAdapter(SQL, connect))
                {
                    da.Fill(dtSanPham);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi: " + e.Message);
            }

            return dtSanPham;
        }

        public bool themSanPham(DTO_SanPham sp)
        {
            try
            {
                string SQL = "INSERT INTO SanPham (TenSanPham, MoTa, Gia) VALUES (@TenSanPham, @MoTa, @Gia)";
                using (SqlCommand cmd = new SqlCommand(SQL, connect))
                {
                    cmd.Parameters.AddWithValue("@TenSanPham", sp.TenSP);
                    cmd.Parameters.AddWithValue("@MoTa", sp.MoTa);
                    cmd.Parameters.AddWithValue("@Gia", sp.Gia);

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

        public bool suaSanPham(DTO_SanPham sp)
        {
            try
            {
                string SQL = "UPDATE SanPham SET TenSanPham = @TenSanPham, MoTa = @MoTa, Gia = @Gia WHERE MaSanPham = @MaSanPham";
                using (SqlCommand cmd = new SqlCommand(SQL, connect))
                {
                    cmd.Parameters.AddWithValue("@MaSanPham", sp.MaSP);
                    cmd.Parameters.AddWithValue("@TenSanPham", sp.TenSP);               
                    cmd.Parameters.AddWithValue("@MoTa", sp.MoTa);
                    cmd.Parameters.AddWithValue("@Gia", sp.Gia);

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

        public bool xoaSanPham(int maSanPham)
        {
            try
            {
                string SQL = "DELETE FROM SanPham WHERE MaSanPham = @MaSanPham";
                using (SqlCommand cmd = new SqlCommand(SQL, connect))
                {
                    cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);

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
    }
}
