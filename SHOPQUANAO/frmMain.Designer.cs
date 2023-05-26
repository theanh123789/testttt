namespace SHOPQUANAO
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hoaDonUC1 = new SHOPQUANAO.HoaDonUC();
            this.nhanVienUC1 = new SHOPQUANAO.NhanVienUC();
            this.sanPhamUC1 = new SHOPQUANAO.SanPhamUC();
            this.trangChuUC1 = new SHOPQUANAO.TrangChuUC();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnHoaDon);
            this.panel1.Controls.Add(this.btnSanPham);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.btnTrangChu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 693);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtChucVu);
            this.panel4.Controls.Add(this.txtTen);
            this.panel4.Location = new System.Drawing.Point(0, 196);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(187, 50);
            this.panel4.TabIndex = 4;
            // 
            // txtChucVu
            // 
            this.txtChucVu.BackColor = System.Drawing.Color.SandyBrown;
            this.txtChucVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChucVu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtChucVu.Enabled = false;
            this.txtChucVu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChucVu.Location = new System.Drawing.Point(0, 28);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(187, 22);
            this.txtChucVu.TabIndex = 5;
            this.txtChucVu.Text = "CHỦ SHOP";
            this.txtChucVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.SandyBrown;
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTen.Enabled = false;
            this.txtTen.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTen.Location = new System.Drawing.Point(0, 0);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(187, 26);
            this.txtTen.TabIndex = 4;
            this.txtTen.Text = "Nguyễn Hải Âu";
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.Location = new System.Drawing.Point(4, 568);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(186, 61);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.Location = new System.Drawing.Point(4, 501);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(186, 61);
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Text = "HÓA ĐƠN";
            this.btnHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSanPham.ForeColor = System.Drawing.Color.Black;
            this.btnSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btnSanPham.Image")));
            this.btnSanPham.Location = new System.Drawing.Point(4, 367);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(186, 61);
            this.btnSanPham.TabIndex = 4;
            this.btnSanPham.Text = "  SẢN PHẨM";
            this.btnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.Location = new System.Drawing.Point(4, 434);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(186, 61);
            this.btnNhanVien.TabIndex = 3;
            this.btnNhanVien.Text = "NHÂN VIÊN";
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.Black;
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.Location = new System.Drawing.Point(4, 300);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(186, 61);
            this.btnTrangChu.TabIndex = 2;
            this.btnTrangChu.Text = "  TRANG CHỦ";
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(187, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 40);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(299, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "SPORT CLOTHINGS SHOP";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1021, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(62, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTieuDe.Location = new System.Drawing.Point(188, 43);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(192, 37);
            this.lblTieuDe.TabIndex = 2;
            this.lblTieuDe.Text = "TRANG CHỦ";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1215, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 34);
            this.button5.TabIndex = 6;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1158, 43);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 34);
            this.button6.TabIndex = 7;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(1099, 43);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 34);
            this.button7.TabIndex = 8;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.hoaDonUC1);
            this.panel3.Controls.Add(this.nhanVienUC1);
            this.panel3.Controls.Add(this.sanPhamUC1);
            this.panel3.Controls.Add(this.trangChuUC1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(187, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1083, 610);
            this.panel3.TabIndex = 9;
            // 
            // hoaDonUC1
            // 
            this.hoaDonUC1.ChucVu = null;
            this.hoaDonUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoaDonUC1.Location = new System.Drawing.Point(0, 0);
            this.hoaDonUC1.Margin = new System.Windows.Forms.Padding(4);
            this.hoaDonUC1.Name = "hoaDonUC1";
            this.hoaDonUC1.Size = new System.Drawing.Size(1083, 610);
            this.hoaDonUC1.TabIndex = 3;
            this.hoaDonUC1.Ten = null;
            // 
            // nhanVienUC1
            // 
            this.nhanVienUC1.BackColor = System.Drawing.Color.White;
            this.nhanVienUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanVienUC1.Location = new System.Drawing.Point(0, 0);
            this.nhanVienUC1.Name = "nhanVienUC1";
            this.nhanVienUC1.Size = new System.Drawing.Size(1083, 610);
            this.nhanVienUC1.TabIndex = 2;
            // 
            // sanPhamUC1
            // 
            this.sanPhamUC1.ChucVu = null;
            this.sanPhamUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sanPhamUC1.Location = new System.Drawing.Point(0, 0);
            this.sanPhamUC1.Name = "sanPhamUC1";
            this.sanPhamUC1.Size = new System.Drawing.Size(1083, 610);
            this.sanPhamUC1.TabIndex = 1;
            // 
            // trangChuUC1
            // 
            this.trangChuUC1.BackColor = System.Drawing.Color.White;
            this.trangChuUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trangChuUC1.Location = new System.Drawing.Point(0, 0);
            this.trangChuUC1.Name = "trangChuUC1";
            this.trangChuUC1.Size = new System.Drawing.Size(1083, 610);
            this.trangChuUC1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1270, 693);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel3;
        private TrangChuUC trangChuUC1;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtTen;
        public HoaDonUC hoaDonUC1;
        public NhanVienUC nhanVienUC1;
        public SanPhamUC sanPhamUC1;
        private System.Windows.Forms.Label label1;

    }
}