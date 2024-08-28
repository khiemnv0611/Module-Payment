namespace TinhTien_NguyenVinhKhiem
{
    partial class GUI_TaoDonHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelNgayTao = new System.Windows.Forms.Label();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaoDonHang = new System.Windows.Forms.Button();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtVoucherTruoc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvKHMoi = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvKHCu = new System.Windows.Forms.DataGridView();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCK = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddSP = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelSP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThanhTienChuaCK = new System.Windows.Forms.TextBox();
            this.dgvSPDC = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddCK = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTongTienCK = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnDelCK = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVoucherSau = new System.Windows.Forms.TextBox();
            this.comboBoxLoaiCK = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThanhTienSauCK = new System.Windows.Forms.TextBox();
            this.dgvCKDC = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHMoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHCu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCK)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPDC)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCKDC)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Red;
            this.labelTitle.Location = new System.Drawing.Point(1017, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(280, 39);
            this.labelTitle.TabIndex = 49;
            this.labelTitle.Text = "TẠO ĐƠN HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Khách hàng :";
            // 
            // labelNgayTao
            // 
            this.labelNgayTao.AutoSize = true;
            this.labelNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayTao.Location = new System.Drawing.Point(23, 676);
            this.labelNgayTao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNgayTao.Name = "labelNgayTao";
            this.labelNgayTao.Size = new System.Drawing.Size(101, 25);
            this.labelNgayTao.TabIndex = 57;
            this.labelNgayTao.Text = "Ngày tạo :";
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTao.CustomFormat = "HH:mm:ss dd/MM/yyyy";
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTao.Location = new System.Drawing.Point(487, 670);
            this.dtpNgayTao.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(251, 30);
            this.dtpNgayTao.TabIndex = 58;
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.Location = new System.Drawing.Point(43, 366);
            this.labelSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(101, 25);
            this.labelSoLuong.TabIndex = 60;
            this.labelSoLuong.Text = "Số lượng :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaoDonHang);
            this.groupBox1.Controls.Add(this.txtThanhToan);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtVoucherTruoc);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtMaKhachHang);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dgvKHMoi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dgvKHCu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelNgayTao);
            this.groupBox1.Controls.Add(this.dtpNgayTao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1277, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(791, 1015);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // btnTaoDonHang
            // 
            this.btnTaoDonHang.BackColor = System.Drawing.Color.Red;
            this.btnTaoDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoDonHang.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTaoDonHang.Location = new System.Drawing.Point(336, 911);
            this.btnTaoDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoDonHang.Name = "btnTaoDonHang";
            this.btnTaoDonHang.Size = new System.Drawing.Size(160, 60);
            this.btnTaoDonHang.TabIndex = 78;
            this.btnTaoDonHang.Text = "Tạo";
            this.btnTaoDonHang.UseVisualStyleBackColor = false;
            this.btnTaoDonHang.Click += new System.EventHandler(this.btnTaoDonHang_Click);
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtThanhToan.Location = new System.Drawing.Point(559, 801);
            this.txtThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.ReadOnly = true;
            this.txtThanhToan.Size = new System.Drawing.Size(179, 30);
            this.txtThanhToan.TabIndex = 77;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(23, 805);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(218, 25);
            this.label18.TabIndex = 76;
            this.label18.Text = "Số tiền cần thanh toán :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(533, 736);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 25);
            this.label16.TabIndex = 75;
            this.label16.Text = "-";
            // 
            // txtVoucherTruoc
            // 
            this.txtVoucherTruoc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtVoucherTruoc.Location = new System.Drawing.Point(559, 732);
            this.txtVoucherTruoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtVoucherTruoc.Name = "txtVoucherTruoc";
            this.txtVoucherTruoc.ReadOnly = true;
            this.txtVoucherTruoc.Size = new System.Drawing.Size(179, 30);
            this.txtVoucherTruoc.TabIndex = 73;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(393, 27);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 31);
            this.label15.TabIndex = 71;
            this.label15.Text = "3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 736);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(384, 25);
            this.label14.TabIndex = 74;
            this.label14.Text = "Số tiền Voucher từ lần mua trước (nếu có) :";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaKhachHang.Location = new System.Drawing.Point(628, 617);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.ReadOnly = true;
            this.txtMaKhachHang.Size = new System.Drawing.Size(109, 30);
            this.txtMaKhachHang.TabIndex = 73;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 620);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(206, 25);
            this.label13.TabIndex = 70;
            this.label13.Text = "Mã khách hàng chọn :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(52, 363);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 25);
            this.label12.TabIndex = 69;
            this.label12.Text = "Cũ :";
            // 
            // dgvKHMoi
            // 
            this.dgvKHMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHMoi.Location = new System.Drawing.Point(8, 151);
            this.dgvKHMoi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKHMoi.Name = "dgvKHMoi";
            this.dgvKHMoi.RowHeadersWidth = 51;
            this.dgvKHMoi.Size = new System.Drawing.Size(775, 165);
            this.dgvKHMoi.TabIndex = 68;
            this.dgvKHMoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKHMoi_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 67;
            this.label6.Text = "Tất cả :";
            // 
            // dgvKHCu
            // 
            this.dgvKHCu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHCu.Location = new System.Drawing.Point(8, 414);
            this.dgvKHCu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKHCu.Name = "dgvKHCu";
            this.dgvKHCu.RowHeadersWidth = 51;
            this.dgvKHCu.Size = new System.Drawing.Size(775, 165);
            this.dgvKHCu.TabIndex = 66;
            this.dgvKHCu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKHCu_CellClick);
            // 
            // dgvSP
            // 
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(67, 75);
            this.dgvSP.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.Size = new System.Drawing.Size(568, 250);
            this.dgvSP.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Sản phẩm :";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(209, 358);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(132, 30);
            this.txtSoLuong.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 64;
            this.label3.Text = "Chiết khấu :";
            // 
            // dgvCK
            // 
            this.dgvCK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCK.Location = new System.Drawing.Point(28, 75);
            this.dgvCK.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCK.Name = "dgvCK";
            this.dgvCK.RowHeadersWidth = 51;
            this.dgvCK.Size = new System.Drawing.Size(508, 250);
            this.dgvCK.TabIndex = 65;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddSP);
            this.groupBox3.Controls.Add(this.dgvSP);
            this.groupBox3.Controls.Add(this.txtSoLuong);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.labelSoLuong);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 57);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(651, 422);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn sản phẩm";
            // 
            // btnAddSP
            // 
            this.btnAddSP.Location = new System.Drawing.Point(488, 351);
            this.btnAddSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSP.Name = "btnAddSP";
            this.btnAddSP.Size = new System.Drawing.Size(100, 47);
            this.btnAddSP.TabIndex = 64;
            this.btnAddSP.Text = "Thêm";
            this.btnAddSP.UseVisualStyleBackColor = true;
            this.btnAddSP.Click += new System.EventHandler(this.btnAddSP_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelSP);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtThanhTienChuaCK);
            this.groupBox4.Controls.Add(this.dgvSPDC);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(7, 486);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(651, 517);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sản phẩm đã chọn";
            // 
            // btnDelSP
            // 
            this.btnDelSP.Location = new System.Drawing.Point(309, 453);
            this.btnDelSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelSP.Name = "btnDelSP";
            this.btnDelSP.Size = new System.Drawing.Size(100, 47);
            this.btnDelSP.TabIndex = 65;
            this.btnDelSP.Text = "Xóa";
            this.btnDelSP.UseVisualStyleBackColor = true;
            this.btnDelSP.Click += new System.EventHandler(this.btnDelSP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(644, 406);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 67;
            this.label5.Text = "(vnđ)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 406);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 25);
            this.label4.TabIndex = 65;
            this.label4.Text = "Thành tiền (Chưa bao gồm chiết khấu) :";
            // 
            // txtThanhTienChuaCK
            // 
            this.txtThanhTienChuaCK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtThanhTienChuaCK.Location = new System.Drawing.Point(409, 406);
            this.txtThanhTienChuaCK.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTienChuaCK.Name = "txtThanhTienChuaCK";
            this.txtThanhTienChuaCK.ReadOnly = true;
            this.txtThanhTienChuaCK.Size = new System.Drawing.Size(179, 30);
            this.txtThanhTienChuaCK.TabIndex = 66;
            // 
            // dgvSPDC
            // 
            this.dgvSPDC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPDC.Location = new System.Drawing.Point(8, 58);
            this.dgvSPDC.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSPDC.Name = "dgvSPDC";
            this.dgvSPDC.RowHeadersWidth = 51;
            this.dgvSPDC.Size = new System.Drawing.Size(627, 324);
            this.dgvSPDC.TabIndex = 65;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddCK);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgvCK);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(558, 391);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn chiết Khấu";
            // 
            // btnAddCK
            // 
            this.btnAddCK.Location = new System.Drawing.Point(263, 333);
            this.btnAddCK.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCK.Name = "btnAddCK";
            this.btnAddCK.Size = new System.Drawing.Size(100, 47);
            this.btnAddCK.TabIndex = 65;
            this.btnAddCK.Text = "Thêm";
            this.btnAddCK.UseVisualStyleBackColor = true;
            this.btnAddCK.Click += new System.EventHandler(this.btnAddCK_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTongTienCK);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.btnDelCK);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtVoucherSau);
            this.groupBox5.Controls.Add(this.comboBoxLoaiCK);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtThanhTienSauCK);
            this.groupBox5.Controls.Add(this.dgvCKDC);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(8, 462);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(558, 542);
            this.groupBox5.TabIndex = 66;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chiết khấu đã chọn";
            // 
            // txtTongTienCK
            // 
            this.txtTongTienCK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTongTienCK.Location = new System.Drawing.Point(379, 400);
            this.txtTongTienCK.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTienCK.Name = "txtTongTienCK";
            this.txtTongTienCK.ReadOnly = true;
            this.txtTongTienCK.Size = new System.Drawing.Size(179, 30);
            this.txtTongTienCK.TabIndex = 78;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(23, 404);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(199, 25);
            this.label19.TabIndex = 77;
            this.label19.Text = "Tổng tiền chiết khấu :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(353, 454);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 25);
            this.label17.TabIndex = 76;
            this.label17.Text = "+";
            // 
            // btnDelCK
            // 
            this.btnDelCK.Location = new System.Drawing.Point(323, 289);
            this.btnDelCK.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelCK.Name = "btnDelCK";
            this.btnDelCK.Size = new System.Drawing.Size(100, 47);
            this.btnDelCK.TabIndex = 68;
            this.btnDelCK.Text = "Xóa";
            this.btnDelCK.UseVisualStyleBackColor = true;
            this.btnDelCK.Click += new System.EventHandler(this.btnDelCK_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 503);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 25);
            this.label9.TabIndex = 72;
            this.label9.Text = "Thành tiền (Đã chiết khấu) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 454);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(280, 25);
            this.label8.TabIndex = 71;
            this.label8.Text = "Voucher cho lần sau (nếu có) :";
            // 
            // txtVoucherSau
            // 
            this.txtVoucherSau.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtVoucherSau.Location = new System.Drawing.Point(379, 450);
            this.txtVoucherSau.Margin = new System.Windows.Forms.Padding(4);
            this.txtVoucherSau.Name = "txtVoucherSau";
            this.txtVoucherSau.ReadOnly = true;
            this.txtVoucherSau.Size = new System.Drawing.Size(179, 30);
            this.txtVoucherSau.TabIndex = 70;
            // 
            // comboBoxLoaiCK
            // 
            this.comboBoxLoaiCK.FormattingEnabled = true;
            this.comboBoxLoaiCK.Items.AddRange(new object[] {
            "Voucher",
            "Tructiep"});
            this.comboBoxLoaiCK.Location = new System.Drawing.Point(227, 352);
            this.comboBoxLoaiCK.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLoaiCK.Name = "comboBoxLoaiCK";
            this.comboBoxLoaiCK.Size = new System.Drawing.Size(223, 33);
            this.comboBoxLoaiCK.TabIndex = 69;
            this.comboBoxLoaiCK.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoaiCK_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 356);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 65;
            this.label7.Text = "Loại chiết khấu :";
            // 
            // txtThanhTienSauCK
            // 
            this.txtThanhTienSauCK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtThanhTienSauCK.Location = new System.Drawing.Point(379, 500);
            this.txtThanhTienSauCK.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTienSauCK.Name = "txtThanhTienSauCK";
            this.txtThanhTienSauCK.ReadOnly = true;
            this.txtThanhTienSauCK.Size = new System.Drawing.Size(179, 30);
            this.txtThanhTienSauCK.TabIndex = 68;
            // 
            // dgvCKDC
            // 
            this.dgvCKDC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCKDC.Location = new System.Drawing.Point(28, 58);
            this.dgvCKDC.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCKDC.Name = "dgvCKDC";
            this.dgvCKDC.RowHeadersWidth = 51;
            this.dgvCKDC.Size = new System.Drawing.Size(508, 224);
            this.dgvCKDC.TabIndex = 66;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(9, 48);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(674, 1015);
            this.groupBox6.TabIndex = 68;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sản phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(368, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 31);
            this.label10.TabIndex = 69;
            this.label10.Text = "1";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.groupBox2);
            this.groupBox7.Controls.Add(this.groupBox5);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(691, 48);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(578, 1015);
            this.groupBox7.TabIndex = 68;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Chiết khấu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(371, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 31);
            this.label11.TabIndex = 70;
            this.label11.Text = "2";
            // 
            // GUI_TaoDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_TaoDonHang";
            this.Text = "GUI_TaoDonHang";
            this.Load += new System.EventHandler(this.GUI_TaoDonHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHMoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHCu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCK)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPDC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCKDC)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNgayTao;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridView dgvCK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddSP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvSPDC;
        private System.Windows.Forms.TextBox txtThanhTienChuaCK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvKHCu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddCK;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvCKDC;
        private System.Windows.Forms.TextBox txtThanhTienSauCK;
        private System.Windows.Forms.ComboBox comboBoxLoaiCK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVoucherSau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelSP;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDelCK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvKHMoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtVoucherTruoc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnTaoDonHang;
        private System.Windows.Forms.TextBox txtTongTienCK;
        private System.Windows.Forms.Label label19;
    }
}