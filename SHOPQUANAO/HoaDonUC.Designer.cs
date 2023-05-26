namespace SHOPQUANAO
{
    partial class HoaDonUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblNgaySanXuat = new System.Windows.Forms.Label();
            this.lblNhaSanXuat = new System.Windows.Forms.Label();
            this.txtNgayLapHD = new System.Windows.Forms.TextBox();
            this.lblGiaSanPham = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblMoTaSanPham = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbNhanVienLap = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTenSanPham = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowDrop = true;
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToOrderColumns = true;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 53);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowTemplate.Height = 30;
            this.dgvHoaDon.Size = new System.Drawing.Size(1077, 292);
            this.dgvHoaDon.TabIndex = 76;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(615, 219);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(113, 33);
            this.btnHuy.TabIndex = 96;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Tomato;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(980, 219);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 33);
            this.btnXoa.TabIndex = 95;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(867, 219);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 33);
            this.btnSua.TabIndex = 94;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Turquoise;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(750, 219);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 33);
            this.btnThem.TabIndex = 93;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtSoLuong.Location = new System.Drawing.Point(765, 146);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(257, 29);
            this.txtSoLuong.TabIndex = 6;
            // 
            // txtSoHD
            // 
            this.txtSoHD.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtSoHD.Location = new System.Drawing.Point(200, 41);
            this.txtSoHD.Multiline = true;
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(257, 29);
            this.txtSoHD.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.dgvHoaDon);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1083, 341);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(983, 17);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(97, 33);
            this.btnLuu.TabIndex = 77;
            this.btnLuu.Text = "LƯU LẠI";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblNgaySanXuat
            // 
            this.lblNgaySanXuat.AutoSize = true;
            this.lblNgaySanXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgaySanXuat.Location = new System.Drawing.Point(625, 151);
            this.lblNgaySanXuat.Name = "lblNgaySanXuat";
            this.lblNgaySanXuat.Size = new System.Drawing.Size(90, 19);
            this.lblNgaySanXuat.TabIndex = 89;
            this.lblNgaySanXuat.Text = "SỐ LƯỢNG";
            // 
            // lblNhaSanXuat
            // 
            this.lblNhaSanXuat.AutoSize = true;
            this.lblNhaSanXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhaSanXuat.Location = new System.Drawing.Point(489, 45);
            this.lblNhaSanXuat.Name = "lblNhaSanXuat";
            this.lblNhaSanXuat.Size = new System.Drawing.Size(124, 19);
            this.lblNhaSanXuat.TabIndex = 87;
            this.lblNhaSanXuat.Text = "TÊN SẢN PHẨM";
            // 
            // txtNgayLapHD
            // 
            this.txtNgayLapHD.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtNgayLapHD.Location = new System.Drawing.Point(200, 76);
            this.txtNgayLapHD.Multiline = true;
            this.txtNgayLapHD.Name = "txtNgayLapHD";
            this.txtNgayLapHD.Size = new System.Drawing.Size(257, 29);
            this.txtNgayLapHD.TabIndex = 2;
            // 
            // lblGiaSanPham
            // 
            this.lblGiaSanPham.AutoSize = true;
            this.lblGiaSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiaSanPham.Location = new System.Drawing.Point(39, 81);
            this.lblGiaSanPham.Name = "lblGiaSanPham";
            this.lblGiaSanPham.Size = new System.Drawing.Size(111, 19);
            this.lblGiaSanPham.TabIndex = 81;
            this.lblGiaSanPham.Text = "NGÀY LẬP HĐ";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtTenKH.Location = new System.Drawing.Point(200, 152);
            this.txtTenKH.Multiline = true;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(257, 29);
            this.txtTenKH.TabIndex = 4;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSize.Location = new System.Drawing.Point(35, 156);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(148, 19);
            this.lblSize.TabIndex = 85;
            this.lblSize.Text = "TÊN KHÁCH HÀNG";
            // 
            // lblMoTaSanPham
            // 
            this.lblMoTaSanPham.AutoSize = true;
            this.lblMoTaSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMoTaSanPham.Location = new System.Drawing.Point(39, 118);
            this.lblMoTaSanPham.Name = "lblMoTaSanPham";
            this.lblMoTaSanPham.Size = new System.Drawing.Size(154, 19);
            this.lblMoTaSanPham.TabIndex = 83;
            this.lblMoTaSanPham.Text = "NHÂN VIÊN LẬP HĐ";
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenSanPham.Location = new System.Drawing.Point(39, 46);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(106, 19);
            this.lblTenSanPham.TabIndex = 79;
            this.lblTenSanPham.Text = "SỐ HÓA ĐƠN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbNhanVienLap);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbTenSanPham);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtSoHD);
            this.groupBox1.Controls.Add(this.lblNgaySanXuat);
            this.groupBox1.Controls.Add(this.lblTenSanPham);
            this.groupBox1.Controls.Add(this.lblNhaSanXuat);
            this.groupBox1.Controls.Add(this.txtNgayLapHD);
            this.groupBox1.Controls.Add(this.lblGiaSanPham);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Controls.Add(this.lblMoTaSanPham);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1083, 279);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // cbbNhanVienLap
            // 
            this.cbbNhanVienLap.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cbbNhanVienLap.Location = new System.Drawing.Point(199, 114);
            this.cbbNhanVienLap.Multiline = true;
            this.cbbNhanVienLap.Name = "cbbNhanVienLap";
            this.cbbNhanVienLap.Size = new System.Drawing.Size(257, 29);
            this.cbbNhanVienLap.TabIndex = 116;
            // 
            // txtDonGia
            // 
            this.txtDonGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtDonGia.FormattingEnabled = true;
            this.txtDonGia.Location = new System.Drawing.Point(765, 97);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(257, 31);
            this.txtDonGia.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(625, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 111;
            this.label1.Text = "ĐƠN GIÁ";
            // 
            // cbbTenSanPham
            // 
            this.cbbTenSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenSanPham.FormattingEnabled = true;
            this.cbbTenSanPham.Location = new System.Drawing.Point(629, 40);
            this.cbbTenSanPham.Name = "cbbTenSanPham";
            this.cbbTenSanPham.Size = new System.Drawing.Size(393, 31);
            this.cbbTenSanPham.TabIndex = 107;
            // 
            // HoaDonUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HoaDonUC";
            this.Size = new System.Drawing.Size(1083, 626);
            this.Load += new System.EventHandler(this.HoaDonUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblNgaySanXuat;
        private System.Windows.Forms.Label lblNhaSanXuat;
        private System.Windows.Forms.TextBox txtNgayLapHD;
        private System.Windows.Forms.Label lblGiaSanPham;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblMoTaSanPham;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTenSanPham;
        private System.Windows.Forms.ComboBox txtDonGia;
        private System.Windows.Forms.TextBox cbbNhanVienLap;
    }
}
