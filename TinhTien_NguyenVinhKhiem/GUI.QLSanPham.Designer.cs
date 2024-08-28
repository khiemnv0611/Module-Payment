namespace TinhTien_NguyenVinhKhiem
{
    partial class GUI_QLSanPham
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.labelMoTa = new System.Windows.Forms.Label();
            this.btnReNew = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.labelTenKH = new System.Windows.Forms.Label();
            this.btnFix = new System.Windows.Forms.Button();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelGia = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMoTa);
            this.groupBox2.Controls.Add(this.labelMoTa);
            this.groupBox2.Controls.Add(this.btnReNew);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.labelTenKH);
            this.groupBox2.Controls.Add(this.btnFix);
            this.groupBox2.Controls.Add(this.txtTenSP);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.labelGia);
            this.groupBox2.Controls.Add(this.txtGia);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(549, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 363);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(143, 110);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(175, 26);
            this.txtMoTa.TabIndex = 39;
            // 
            // labelMoTa
            // 
            this.labelMoTa.AutoSize = true;
            this.labelMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoTa.Location = new System.Drawing.Point(38, 113);
            this.labelMoTa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoTa.Name = "labelMoTa";
            this.labelMoTa.Size = new System.Drawing.Size(57, 20);
            this.labelMoTa.TabIndex = 38;
            this.labelMoTa.Text = "Mô tả :";
            // 
            // btnReNew
            // 
            this.btnReNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReNew.Location = new System.Drawing.Point(212, 305);
            this.btnReNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnReNew.Name = "btnReNew";
            this.btnReNew.Size = new System.Drawing.Size(79, 34);
            this.btnReNew.TabIndex = 37;
            this.btnReNew.Text = "Khởi tạo";
            this.btnReNew.UseVisualStyleBackColor = true;
            this.btnReNew.Click += new System.EventHandler(this.btnReNew_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(66, 305);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(79, 34);
            this.btnDel.TabIndex = 36;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // labelTenKH
            // 
            this.labelTenKH.AutoSize = true;
            this.labelTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenKH.Location = new System.Drawing.Point(38, 52);
            this.labelTenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.Size = new System.Drawing.Size(69, 20);
            this.labelTenKH.TabIndex = 22;
            this.labelTenKH.Text = "Tên SP :";
            // 
            // btnFix
            // 
            this.btnFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.Location = new System.Drawing.Point(212, 250);
            this.btnFix.Margin = new System.Windows.Forms.Padding(2);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(79, 34);
            this.btnFix.TabIndex = 35;
            this.btnFix.Text = "Sửa";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(143, 46);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(175, 26);
            this.txtTenSP.TabIndex = 23;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(66, 250);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 34);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelGia
            // 
            this.labelGia.AutoSize = true;
            this.labelGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGia.Location = new System.Drawing.Point(38, 179);
            this.labelGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(42, 20);
            this.labelGia.TabIndex = 24;
            this.labelGia.Text = "Giá :";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(143, 176);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(175, 26);
            this.txtGia.TabIndex = 25;
            // 
            // dgvSP
            // 
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(12, 80);
            this.dgvSP.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowTemplate.Height = 24;
            this.dgvSP.Size = new System.Drawing.Size(519, 355);
            this.dgvSP.TabIndex = 49;
            this.dgvSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSP_CellClick);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Red;
            this.labelTitle.Location = new System.Drawing.Point(292, 19);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(281, 31);
            this.labelTitle.TabIndex = 48;
            this.labelTitle.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // GUI_QLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 438);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvSP);
            this.Controls.Add(this.labelTitle);
            this.Name = "GUI_QLSanPham";
            this.Text = "GUI_QLSanPham";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReNew;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label labelTenKH;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label labelMoTa;
    }
}