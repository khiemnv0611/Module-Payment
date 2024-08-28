using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_TinhTien;
using DTO_TinhTien;

namespace TinhTien_NguyenVinhKhiem
{
    public partial class GUI_QLKhachHang : Form
    {
        BUS_KhachHang busKH = new BUS_KhachHang();

        public GUI_QLKhachHang()
        {
            InitializeComponent();
        }

        private void GUI_QLKhachHang_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = busKH.getKhachHang();
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKH.Rows.Count)
            {
                DataGridViewRow row = dgvKH.Rows[e.RowIndex];
                string tenKhachHang = row.Cells["TenKhachHang"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                string soDienThoai = row.Cells["SoDienThoai"].Value.ToString();
                string diaChi = row.Cells["DiaChi"].Value.ToString();

                txtTenKH.Text = tenKhachHang;
                txtEmail.Text = email;
                txtSoDienThoai.Text = soDienThoai;
                txtDiaChi.Text = diaChi;
            }
        }

        private void btnReNew_Click(object sender, EventArgs e)
        {
            txtTenKH.Text = "";
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            txtDiaChi.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txtTenKH.Text;
            string soDienThoai = txtSoDienThoai.Text;

            if (string.IsNullOrEmpty(tenKhachHang) || string.IsNullOrEmpty(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập tên và số điện thoại khách hàng!");
                return;
            }
            
            if (busKH.kiemTraSoDienThoaiTonTai(soDienThoai))
            {
                MessageBox.Show("Số điện thoại này đã tồn tại!");
                return;
            }

            string email = txtEmail.Text;
            string diaChi = txtDiaChi.Text;

            DTO_KhachHang kh = new DTO_KhachHang(0, tenKhachHang, email, soDienThoai, diaChi);

            if (busKH.themKhachHang(kh))
            {
                MessageBox.Show("Thêm thành công");
                dgvKH.DataSource = busKH.getKhachHang();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (dgvKH.CurrentRow != null)
            {
                int maKhachHang = Convert.ToInt32(dgvKH.CurrentRow.Cells["MaKhachHang"].Value);
                string tenKhachHang = txtTenKH.Text;
                string soDienThoai = txtSoDienThoai.Text;

                if (string.IsNullOrEmpty(tenKhachHang) || string.IsNullOrEmpty(soDienThoai))
                {
                    MessageBox.Show("Vui lòng nhập tên và số điện thoại khách hàng!");
                    return;
                }

                // Kiểm tra xem số điện thoại đã tồn tại cho khách hàng khác chưa
                if (busKH.kiemTraSoDienThoaiTonTai(soDienThoai, maKhachHang))
                {
                    MessageBox.Show("Số điện thoại này đã tồn tại!");
                    return;
                }

                string email = txtEmail.Text;
                string diaChi = txtDiaChi.Text;

                DTO_KhachHang kh = new DTO_KhachHang(maKhachHang, tenKhachHang, email, soDienThoai, diaChi);

                if (busKH.suaKhachHang(kh))
                {
                    MessageBox.Show("Sửa thành công");
                    dgvKH.DataSource = busKH.getKhachHang();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvKH.CurrentRow != null)
            {
                int maKhachHang = Convert.ToInt32(dgvKH.CurrentRow.Cells["MaKhachHang"].Value);
                DialogResult result = MessageBox.Show("Chắc chắn muốn xóa khách hàng này?", "Xóa Khách Hàng", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (busKH.xoaKhachHang(maKhachHang))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvKH.DataSource = busKH.getKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
            }
        }
    }
}
