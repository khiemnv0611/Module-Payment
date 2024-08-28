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
    public partial class GUI_QLSanPham : Form
    {
        BUS_SanPham busSP = new BUS_SanPham();

        private void dgvSP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSP.Columns[e.ColumnIndex].Name == "Gia" && e.Value != null)
            {
                decimal gia;
                if (decimal.TryParse(e.Value.ToString(), out gia))
                {
                    e.Value = gia.ToString("N0");
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvSP_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (dgvSP.Columns[e.ColumnIndex].Name == "Gia" && e.Value != null)
            {
                string input = e.Value.ToString();
                input = input.Replace(".", "").Replace(",", "");

                decimal gia;
                if (decimal.TryParse(input, out gia))
                {
                    e.Value = gia;
                    e.ParsingApplied = true;
                }
                else
                {
                    e.ParsingApplied = false;
                    MessageBox.Show("Giá trị không hợp lệ!");
                }
            }
        }

        public GUI_QLSanPham()
        {
            InitializeComponent();
            dgvSP.CellFormatting += dgvSP_CellFormatting;
            dgvSP.CellParsing += dgvSP_CellParsing;
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            dgvSP.DataSource = busSP.getSanPham();
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSP.Rows.Count)
            {
                DataGridViewRow row = dgvSP.Rows[e.RowIndex];
                txtTenSP.Text = row.Cells["TenSanPham"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();
                txtGia.Text = row.Cells["Gia"].Value.ToString();
            }
        }

        private void btnReNew_Click(object sender, EventArgs e)
        {
            txtTenSP.Text = "";
            txtMoTa.Text = "";
            txtGia.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenSanPham = txtTenSP.Text;
            string moTa = txtMoTa.Text;

            if (decimal.TryParse(txtGia.Text, out decimal gia))
            {
                if (string.IsNullOrEmpty(tenSanPham))
                {
                    MessageBox.Show("Vui lòng nhập tên và giá sản phẩm!");
                    return;
                }
                else
                {
                    DTO_SanPham sp = new DTO_SanPham(0, tenSanPham, moTa, gia);
                    if (busSP.themSanPham(sp))
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvSP.DataSource = busSP.getSanPham();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Giá không hợp lệ!");
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (dgvSP.CurrentRow != null)
            {
                int maSanPham = Convert.ToInt32(dgvSP.CurrentRow.Cells["MaSanPham"].Value);
                string tenSanPham = txtTenSP.Text;
                string moTa = txtMoTa.Text;
                string giaText = txtGia.Text;

                if (string.IsNullOrEmpty(tenSanPham))
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm!");
                    return;
                }

                if (!decimal.TryParse(giaText, out decimal gia))
                {
                    MessageBox.Show("Giá sản phẩm không hợp lệ!");
                    return;
                }

                DTO_SanPham sp = new DTO_SanPham(maSanPham, tenSanPham, moTa, gia);
                if (busSP.suaSanPham(sp))
                {
                    MessageBox.Show("Sửa thành công");
                    dgvSP.DataSource = busSP.getSanPham();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvSP.CurrentRow != null && dgvSP.CurrentRow.Index >= 0)
            {
                int maSanPham = Convert.ToInt32(dgvSP.CurrentRow.Cells["MaSanPham"].Value);
                DialogResult result = MessageBox.Show("Chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (busSP.xoaSanPham(maSanPham))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvSP.DataSource = busSP.getSanPham();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
            }
        }
    }
}
