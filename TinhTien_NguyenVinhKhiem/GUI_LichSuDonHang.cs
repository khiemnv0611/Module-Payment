using BUS_TinhTien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTien_NguyenVinhKhiem
{
    public partial class GUI_LichSuDonHang : Form
    {
        BUS_LichSuDonHang busLichSuDonHang = new BUS_LichSuDonHang();
        public GUI_LichSuDonHang()
        {
            InitializeComponent();
        }

        private void GUI_LichSuDonHang_Load(object sender, EventArgs e)
        {
            dgvLichSuDonHang.DataSource = busLichSuDonHang.getLichSuDonHang();
        }

        private void dgvLichSuDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maDonHang = Convert.ToInt32(dgvLichSuDonHang.Rows[e.RowIndex].Cells["MaDonHang"].Value);

                DataTable dtChiTietDonHang = busLichSuDonHang.getChiTietDonHang(maDonHang);
                dgvChiTiet.DataSource = dtChiTietDonHang;
            }
        }
    }
}
