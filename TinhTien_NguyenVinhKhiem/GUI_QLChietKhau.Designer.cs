namespace TinhTien_NguyenVinhKhiem
{
    partial class GUI_QLChietKhau
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
            this.dgvCK = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReNew = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.labelTenCK = new System.Windows.Forms.Label();
            this.btnFix = new System.Windows.Forms.Button();
            this.txtTenChietKhau = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtPhanTramChietKhau = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCK)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Red;
            this.labelTitle.Location = new System.Drawing.Point(243, 27);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(306, 31);
            this.labelTitle.TabIndex = 49;
            this.labelTitle.Text = "QUẢN LÝ CHIẾT KHẤU";
            // 
            // dgvCK
            // 
            this.dgvCK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCK.Location = new System.Drawing.Point(11, 84);
            this.dgvCK.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCK.Name = "dgvCK";
            this.dgvCK.RowHeadersWidth = 51;
            this.dgvCK.RowTemplate.Height = 24;
            this.dgvCK.Size = new System.Drawing.Size(584, 355);
            this.dgvCK.TabIndex = 50;
            this.dgvCK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCK_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReNew);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.labelTenCK);
            this.groupBox2.Controls.Add(this.btnFix);
            this.groupBox2.Controls.Add(this.txtTenChietKhau);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.labelEmail);
            this.groupBox2.Controls.Add(this.txtPhanTramChietKhau);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(608, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 363);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // btnReNew
            // 
            this.btnReNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReNew.Location = new System.Drawing.Point(263, 324);
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
            this.btnDel.Location = new System.Drawing.Point(180, 324);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(79, 34);
            this.btnDel.TabIndex = 36;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // labelTenCK
            // 
            this.labelTenCK.AutoSize = true;
            this.labelTenCK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenCK.Location = new System.Drawing.Point(26, 130);
            this.labelTenCK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTenCK.Name = "labelTenCK";
            this.labelTenCK.Size = new System.Drawing.Size(121, 20);
            this.labelTenCK.TabIndex = 22;
            this.labelTenCK.Text = "Tên chiết khấu :";
            // 
            // btnFix
            // 
            this.btnFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.Location = new System.Drawing.Point(97, 324);
            this.btnFix.Margin = new System.Windows.Forms.Padding(2);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(79, 34);
            this.btnFix.TabIndex = 35;
            this.btnFix.Text = "Sửa";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // txtTenChietKhau
            // 
            this.txtTenChietKhau.Location = new System.Drawing.Point(151, 127);
            this.txtTenChietKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenChietKhau.Name = "txtTenChietKhau";
            this.txtTenChietKhau.Size = new System.Drawing.Size(175, 26);
            this.txtTenChietKhau.TabIndex = 23;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(14, 324);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 34);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(26, 184);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(115, 20);
            this.labelEmail.TabIndex = 24;
            this.labelEmail.Text = "Phần trăm CK :";
            // 
            // txtPhanTramChietKhau
            // 
            this.txtPhanTramChietKhau.Location = new System.Drawing.Point(151, 181);
            this.txtPhanTramChietKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhanTramChietKhau.Name = "txtPhanTramChietKhau";
            this.txtPhanTramChietKhau.Size = new System.Drawing.Size(175, 26);
            this.txtPhanTramChietKhau.TabIndex = 25;
            // 
            // GUI_QLChietKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 448);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvCK);
            this.Controls.Add(this.labelTitle);
            this.Name = "GUI_QLChietKhau";
            this.Text = "GUI_QLGiamGia";
            this.Load += new System.EventHandler(this.GUI_QLChietKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCK)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dgvCK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReNew;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label labelTenCK;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.TextBox txtTenChietKhau;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtPhanTramChietKhau;
    }
}