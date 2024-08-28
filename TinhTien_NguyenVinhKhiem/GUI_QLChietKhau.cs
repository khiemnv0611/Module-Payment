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
    public partial class GUI_QLChietKhau : Form
    {
        BUS_ChietKhau busCK = new BUS_ChietKhau();
        public GUI_QLChietKhau()
        {
            InitializeComponent();
        }

        private void GUI_QLChietKhau_Load(object sender, EventArgs e)
        {
            dgvCK.DataSource = busCK.getChietKhau();
        }

        private void dgvCK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCK.Rows.Count)
            {
                DataGridViewRow row = dgvCK.Rows[e.RowIndex];
                string tenChietKhau = row.Cells["TenChietKhau"].Value.ToString();
                decimal phanTramChietKhau = Convert.ToDecimal(row.Cells["PhanTramChietKhau"].Value);

                txtTenChietKhau.Text = tenChietKhau;
                txtPhanTramChietKhau.Text = phanTramChietKhau.ToString();
            }
        }

        private void btnReNew_Click(object sender, EventArgs e)
        {
            txtTenChietKhau.Text = "";
            txtPhanTramChietKhau.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenChietKhau = txtTenChietKhau.Text;

            if (string.IsNullOrEmpty(tenChietKhau))
            {
                MessageBox.Show("Vui lòng nhập tên chiết khấu!");
                return;
            }

            double phanTramChietKhau;
            if (!double.TryParse(txtPhanTramChietKhau.Text.Replace(",", "."), out phanTramChietKhau))
            {
                MessageBox.Show("Vui lòng nhập phần trăm chiết khấu hợp lệ!");
                return;
            }

            phanTramChietKhau = Math.Round(phanTramChietKhau, 2);

            DTO_ChietKhau ck = new DTO_ChietKhau(0, tenChietKhau, phanTramChietKhau);

            if (busCK.themChietKhau(ck))
            {
                MessageBox.Show("Thêm thành công");
                dgvCK.DataSource = busCK.getChietKhau();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (dgvCK.CurrentRow != null)
            {
                int maChietKhau = Convert.ToInt32(dgvCK.CurrentRow.Cells["MaChietKhau"].Value);
                string tenChietKhau = txtTenChietKhau.Text;

                if (string.IsNullOrEmpty(tenChietKhau))
                {
                    MessageBox.Show("Vui lòng nhập tên chiết khấu!");
                    return;
                }

                double phanTramChietKhau;
                if (!double.TryParse(txtPhanTramChietKhau.Text.Replace(",", "."), out phanTramChietKhau))
                {
                    MessageBox.Show("Vui lòng nhập phần trăm chiết khấu hợp lệ!");
                    return;
                }

                phanTramChietKhau = Math.Round(phanTramChietKhau, 2);

                DTO_ChietKhau ck = new DTO_ChietKhau(maChietKhau, tenChietKhau, phanTramChietKhau);

                if (busCK.suaChietKhau(ck))
                {
                    MessageBox.Show("Sửa thành công");
                    dgvCK.DataSource = busCK.getChietKhau();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chiết khấu cần sửa!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvCK.CurrentRow != null)
            {
                int maChietKhau = Convert.ToInt32(dgvCK.CurrentRow.Cells["MaChietKhau"].Value);
                DialogResult result = MessageBox.Show("Chắc chắn muốn xóa chiết khấu này?", "Xóa Chiết Khấu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (busCK.xoaChietKhau(maChietKhau))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvCK.DataSource = busCK.getChietKhau();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chiết khấu cần xóa!");
            }
        }
    }
}
