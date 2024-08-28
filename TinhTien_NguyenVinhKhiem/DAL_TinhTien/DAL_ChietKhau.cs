using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TinhTien;

namespace DAL_TinhTien
{
    public class DAL_ChietKhau : DBConnect
    {
        public DataTable getChietKhau()
        {
            DataTable dtChietKhau = new DataTable();

            try
            {
                string SQL = "SELECT MaChietKhau, TenChietKhau, PhanTramChietKhau FROM ChietKhau";
                using (SqlDataAdapter da = new SqlDataAdapter(SQL, connect))
                {
                    da.Fill(dtChietKhau);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi: " + e.Message);
            }

            return dtChietKhau;
        }

        public bool themChietKhau(DTO_ChietKhau ck)
        {
            try
            {
                string SQL = "INSERT INTO ChietKhau (TenChietKhau, PhanTramChietKhau) VALUES (@TenChietKhau, @PhanTramChietKhau)";
                using (SqlCommand cmd = new SqlCommand(SQL, connect))
                {
                    cmd.Parameters.AddWithValue("@TenChietKhau", ck.TenChietKhau);
                    cmd.Parameters.AddWithValue("@PhanTramChietKhau", ck.PhanTramChietKhau);

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

        public bool suaChietKhau(DTO_ChietKhau ck)
        {
            try
            {
                string SQL = "UPDATE ChietKhau SET TenChietKhau = @TenChietKhau, PhanTramChietKhau = @PhanTramChietKhau WHERE MaChietKhau = @MaChietKhau";
                using (SqlCommand cmd = new SqlCommand(SQL, connect))
                {
                    cmd.Parameters.AddWithValue("@MaChietKhau", ck.MaChietKhau);
                    cmd.Parameters.AddWithValue("@TenChietKhau", ck.TenChietKhau);
                    cmd.Parameters.AddWithValue("@PhanTramChietKhau", ck.PhanTramChietKhau);

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

        public bool xoaChietKhau(int maChietKhau)
        {
            try
            {
                string SQL = "DELETE FROM ChietKhau WHERE MaChietKhau = @MaChietKhau";
                using (SqlCommand cmd = new SqlCommand(SQL, connect))
                {
                    cmd.Parameters.AddWithValue("@MaChietKhau", maChietKhau);

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
