using BUS_TinhTien;
using DTO_TinhTien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTien_NguyenVinhKhiem
{
    public partial class GUI_TaoDonHang : Form
    {
        BUS_SanPham busSP = new BUS_SanPham();
        BUS_ChietKhau busCK = new BUS_ChietKhau();
        BUS_KhachHang busKH = new BUS_KhachHang();
        BUS_TaoDonHang busTaoDonHang = new BUS_TaoDonHang();

        public GUI_TaoDonHang()
        {
            InitializeComponent();
        }

        private void GUI_TaoDonHang_Load(object sender, EventArgs e)
        {
            dgvSP.DataSource = busSP.getSanPham();
            dgvCK.DataSource = busCK.getChietKhau();
            dgvKHMoi.DataSource = busKH.getKhachHang();
            dgvKHCu.DataSource = busTaoDonHang.getKhachHangCu();

            // dgv Sản phẩm đã chọn
            dgvSPDC.Columns.Add("maSanPham", "Mã Sản Phẩm");
            dgvSPDC.Columns.Add("tenSanPham", "Tên Sản Phẩm");
            dgvSPDC.Columns.Add("donGia", "Giá");
            dgvSPDC.Columns.Add("soLuong", "Số Lượng");
            dgvSPDC.Columns.Add("thanhTien", "Thành Tiền");

            // dgv Chiết khấu đã chọn
            dgvCKDC.Columns.Add("MaChietKhau", "Mã Chiết Khấu");
            dgvCKDC.Columns.Add("TenChietKhau", "Tên Chiết Khấu");
            dgvCKDC.Columns.Add("PhanTramChietKhau", "Phần Trăm Chiết Khấu");
        }

        // Thêm sản phẩm
        private void btnAddSP_Click(object sender, EventArgs e)
        {
            if (dgvSP.CurrentRow != null && !string.IsNullOrEmpty(txtSoLuong.Text) && int.TryParse(txtSoLuong.Text, out int soLuong) && soLuong > 0)
            {
                DataGridViewRow selectedRow = dgvSP.CurrentRow;

                string maSanPham = selectedRow.Cells["MaSanPham"].Value.ToString();
                string tenSanPham = selectedRow.Cells["TenSanPham"].Value.ToString();
                decimal gia = Convert.ToDecimal(selectedRow.Cells["Gia"].Value);

                decimal thanhTien = soLuong * gia;

                dgvSPDC.Rows.Add(maSanPham, tenSanPham, gia, soLuong, thanhTien);

                decimal tongThanhTien = 0;
                foreach (DataGridViewRow row in dgvSPDC.Rows)
                {
                    tongThanhTien += Convert.ToDecimal(row.Cells["thanhTien"].Value);
                }

                txtThanhTienChuaCK.Text = tongThanhTien.ToString("N0");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng hợp lệ.");
            }
        }
        // Thêm chiết khấu
        private void btnAddCK_Click(object sender, EventArgs e)
        {
            if (dgvCK.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dgvCK.CurrentRow;

                string maChietKhau = selectedRow.Cells["MaChietKhau"].Value.ToString();
                string tenChietKhau = selectedRow.Cells["TenChietKhau"].Value.ToString();
                decimal phanTramChietKhau = Convert.ToDecimal(selectedRow.Cells["PhanTramChietKhau"].Value);

                dgvCKDC.Rows.Add(maChietKhau, tenChietKhau, phanTramChietKhau);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chiết khấu.");
            }
        }


        // Loại chiết khấu
        private void comboBoxLoaiCK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLoaiCK.SelectedItem != null)
            {
                string loaiChietKhau = comboBoxLoaiCK.SelectedItem.ToString();
                decimal tongTienBanDau = Convert.ToDecimal(txtThanhTienChuaCK.Text);
                decimal thanhTienSauChietKhau = tongTienBanDau;
                decimal chietKhau = 0;

                foreach (DataGridViewRow row in dgvCKDC.Rows)
                {
                    if (row.Cells["PhanTramChietKhau"].Value != null)
                    {
                        decimal phanTramChietKhau = Convert.ToDecimal(row.Cells["PhanTramChietKhau"].Value);
                        chietKhau += tongTienBanDau * phanTramChietKhau / 100;
                    }
                }

                txtTongTienCK.Text = chietKhau.ToString("N0");

                if (loaiChietKhau == "Voucher")
                {
                    txtVoucherSau.Text = chietKhau.ToString("N0");
                }
                else if (loaiChietKhau == "Tructiep")
                {
                    thanhTienSauChietKhau -= chietKhau;
                    txtVoucherSau.Text = "0";
                }

                txtThanhTienSauCK.Text = thanhTienSauChietKhau.ToString("N0");
            }
        }

        // btn Xóa Sản phẩm
        private void btnDelSP_Click(object sender, EventArgs e)
        {
            if (dgvSPDC.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dgvSPDC.Rows.RemoveAt(dgvSPDC.CurrentRow.Index);
                    decimal totalAmount = 0;
                    foreach (DataGridViewRow row in dgvSPDC.Rows)
                    {
                        if (row.Cells["donGia"].Value != null && row.Cells["soLuong"].Value != null)
                        {
                            decimal gia = Convert.ToDecimal(row.Cells["donGia"].Value);
                            int soLuong = Convert.ToInt32(row.Cells["soLuong"].Value);
                            totalAmount += gia * soLuong;
                        }
                    }

                    txtThanhTienChuaCK.Text = totalAmount.ToString("N0");
                }
            }
            else
            {
                MessageBox.Show("Không có hàng nào được chọn. Vui lòng chọn một hàng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // btn Xóa Chiết khấu
        private void btnDelCK_Click(object sender, EventArgs e)
        {
            if (dgvCKDC.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chiết khấu này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dgvCKDC.Rows.RemoveAt(dgvCKDC.CurrentRow.Index);

                    txtVoucherSau.Text = string.Empty;
                    txtThanhTienSauCK.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Không có chiết khấu nào được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // txtThanhToan
        private void TinhToanThanhToan()
        {
            decimal thanhTienSauCK = decimal.Parse(txtThanhTienSauCK.Text);
            decimal thanhToan;

            if (!string.IsNullOrEmpty(txtVoucherTruoc.Text))
            {
                decimal soTienVoucher = decimal.Parse(txtVoucherTruoc.Text);
                thanhToan = thanhTienSauCK - soTienVoucher;
            }
            else
            {
                thanhToan = thanhTienSauCK;
            }

            txtThanhToan.Text = thanhToan.ToString("N0");
        }

        // dgv Khách hàng mới
        private void dgvKHMoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKHMoi.Rows[e.RowIndex];
                string maKhachHang = row.Cells["MaKhachHang"].Value.ToString();
                txtMaKhachHang.Text = maKhachHang;

                TinhToanThanhToan();
            }
        }


        //dgv Khách hàng cũ
        private void dgvKHCu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvKHCu.Rows[e.RowIndex];

            string maKhachHang = selectedRow.Cells["MaKhachHang"].Value.ToString();
            string soTienVoucher = selectedRow.Cells["SoTienVoucherLanMuaTruoc"].Value.ToString();

            txtMaKhachHang.Text = maKhachHang;
            txtVoucherTruoc.Text = soTienVoucher;

            TinhToanThanhToan();
        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection("Data Source=KHIEMNV;Initial Catalog=QLBanHang;Integrated Security=True"))
                {
                    connect.Open();

                    using (SqlTransaction transaction = connect.BeginTransaction())
                    {
                        try
                        {
                            // 1. Kiểm tra và cập nhật SoTienChietKhau = 0 cho các Voucher cũ
                            string updateVoucherQuery = @"
                            UPDATE DonHangChietKhau
                            SET SoTienChietKhau = 0
                            WHERE MaDonHang IN (SELECT MaDonHang FROM DonHang WHERE MaKhachHang = @MaKhachHang)
                            AND LoaiChietKhau = 'Voucher'";

                            SqlCommand cmdUpdateVoucher = new SqlCommand(updateVoucherQuery, connect, transaction);
                            cmdUpdateVoucher.Parameters.AddWithValue("@MaKhachHang", int.Parse(txtMaKhachHang.Text));
                            cmdUpdateVoucher.ExecuteNonQuery();

                            // 2. Thêm đơn hàng vào bảng DonHang
                            string insertDonHangQuery = @"
                            INSERT INTO DonHang (NgayTao, GiaTriChuaChietKhau, GiaTriSauChietKhau, SoTienThanhToan, MaKhachHang)
                            OUTPUT INSERTED.MaDonHang
                            VALUES (@NgayTao, @GiaTriChuaCK, @GiaTriSauCK, @SoTienThanhToan, @MaKhachHang)";

                            SqlCommand cmdDonHang = new SqlCommand(insertDonHangQuery, connect, transaction);
                            cmdDonHang.Parameters.AddWithValue("@NgayTao", DateTime.ParseExact(dtpNgayTao.Text, "HH:mm:ss dd/MM/yyyy", null));
                            cmdDonHang.Parameters.AddWithValue("@GiaTriChuaCK", decimal.Parse(txtThanhTienChuaCK.Text));
                            cmdDonHang.Parameters.AddWithValue("@GiaTriSauCK", decimal.Parse(txtThanhTienSauCK.Text));
                            cmdDonHang.Parameters.AddWithValue("@SoTienThanhToan", decimal.Parse(txtThanhToan.Text));
                            cmdDonHang.Parameters.AddWithValue("@MaKhachHang", int.Parse(txtMaKhachHang.Text));

                            int maDonHang = (int)cmdDonHang.ExecuteScalar();

                            // 3. Thêm chi tiết đơn hàng vào bảng ChiTietDonHang
                            foreach (DataGridViewRow row in dgvSPDC.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    string insertChiTietDonHangQuery = @"
                                    INSERT INTO ChiTietDonHang (MaDonHang, MaSanPham, SoLuong, DonGia, ThanhTien)
                                    VALUES (@MaDonHang, @MaSanPham, @SoLuong, @DonGia, @ThanhTien)";

                                    SqlCommand cmdChiTietDonHang = new SqlCommand(insertChiTietDonHangQuery, connect, transaction);
                                    cmdChiTietDonHang.Parameters.AddWithValue("@MaDonHang", maDonHang);
                                    cmdChiTietDonHang.Parameters.AddWithValue("@MaSanPham", row.Cells["maSanPham"].Value);
                                    cmdChiTietDonHang.Parameters.AddWithValue("@SoLuong", row.Cells["soLuong"].Value);
                                    cmdChiTietDonHang.Parameters.AddWithValue("@DonGia", row.Cells["donGia"].Value);
                                    cmdChiTietDonHang.Parameters.AddWithValue("@ThanhTien", row.Cells["thanhTien"].Value);

                                    cmdChiTietDonHang.ExecuteNonQuery();
                                }
                            }

                            // 4. Thêm chi tiết chiết khấu vào bảng DonHangChietKhau
                            foreach (DataGridViewRow row in dgvCKDC.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    string insertDonHangChietKhauQuery = @"
                                    INSERT INTO DonHangChietKhau (MaDonHang, MaChietKhau, SoTienChietKhau, LoaiChietKhau)
                                    VALUES (@MaDonHang, @MaChietKhau, @SoTienChietKhau, @LoaiChietKhau)";

                                    SqlCommand cmdDonHangChietKhau = new SqlCommand(insertDonHangChietKhauQuery, connect, transaction);
                                    cmdDonHangChietKhau.Parameters.AddWithValue("@MaDonHang", maDonHang);
                                    cmdDonHangChietKhau.Parameters.AddWithValue("@MaChietKhau", row.Cells["MaChietKhau"].Value);
                                    cmdDonHangChietKhau.Parameters.AddWithValue("@SoTienChietKhau", decimal.Parse(txtTongTienCK.Text));
                                    cmdDonHangChietKhau.Parameters.AddWithValue("@LoaiChietKhau", comboBoxLoaiCK.SelectedItem.ToString());

                                    cmdDonHangChietKhau.ExecuteNonQuery();
                                }
                            }

                            // 5. Thêm vào bảng LichSuChietKhau
                            foreach (DataGridViewRow row in dgvCKDC.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    string insertLichSuChietKhauQuery = @"
                                INSERT INTO LichSuChietKhau (MaDonHang, MaChietKhau)
                                VALUES (@MaDonHang, @MaChietKhau)";

                                    SqlCommand cmdLichSuChietKhau = new SqlCommand(insertLichSuChietKhauQuery, connect, transaction);
                                    cmdLichSuChietKhau.Parameters.AddWithValue("@MaDonHang", maDonHang);
                                    cmdLichSuChietKhau.Parameters.AddWithValue("@MaChietKhau", row.Cells["MaChietKhau"].Value);

                                    cmdLichSuChietKhau.ExecuteNonQuery();
                                }
                            }

                            // Commit transaction
                            transaction.Commit();

                            MessageBox.Show("Đơn hàng đã được tạo thành công!");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Lỗi: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
