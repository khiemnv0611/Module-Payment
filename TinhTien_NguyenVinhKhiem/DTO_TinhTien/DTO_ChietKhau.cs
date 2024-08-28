using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TinhTien
{
    public class DTO_ChietKhau
    {
        public int MaChietKhau { get; set; }
        public string TenChietKhau { get; set; }
        public double PhanTramChietKhau { get; set; }

        // Constructor không tham số
        public DTO_ChietKhau()
        {
        }

        // Constructor với tham số
        public DTO_ChietKhau(int maChietKhau, string tenChietKhau, double phanTramChietKhau)
        {
            this.MaChietKhau = maChietKhau;
            this.TenChietKhau = tenChietKhau;
            this.PhanTramChietKhau = phanTramChietKhau;
        }
    }
}
