using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TinhTien
{
    public class DTO_SanPham
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string MoTa { get; set; }
        public decimal Gia { get; set; }

        // Constructor không tham số
        public DTO_SanPham() { }

        // Constructor với tham số
        public DTO_SanPham(int maSP, string tenSP, string moTa, decimal gia)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;            
            this.MoTa = moTa;
            this.Gia = gia;
        }
    }
}
