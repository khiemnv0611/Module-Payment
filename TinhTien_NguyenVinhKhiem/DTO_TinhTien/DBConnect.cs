using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DTO_TinhTien
{
    public class DBConnect
    {
        protected SqlConnection connect = new SqlConnection("Data Source=KHIEMNV;Initial Catalog=QLBanHang;Integrated Security=True");
    }
}
