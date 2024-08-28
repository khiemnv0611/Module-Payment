using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_TinhTien;
using static DTO_TinhTien.DTO_TaoDonHang;

namespace BUS_TinhTien
{
    public class BUS_TaoDonHang
    {
        DAL_TaoDonHang dalTaoDonHang = new DAL_TaoDonHang();
        public DataTable getKhachHangCu()
        {
            return dalTaoDonHang.getKhachHangCu();
        }
    }
}
