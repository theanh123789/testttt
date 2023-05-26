using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SHOPQUANAO
{
    public partial class frmMain : Form
    {
        // tạo biến nhận dữ liệu truyền qua
        private string tennv_nhan;
        private string chucvu_nhan;


        public frmMain()
        {
            InitializeComponent();


            trangChuUC1.BringToFront();
            lblTieuDe.Text = "TRANG CHỦ";
            btnTrangChu.BackColor = Color.Tomato;
        }


        // hàm khởi tạo (Constructor)
        //Mọi thứ trong C# đều là class, kể cả Form. Mà class thì luôn có hàm khởi tạo (Contructor).
        //Ta sẽ lợi dụng điều này để truyền tham số vào Form qua Contructor.

        
        public frmMain(string tennv, string chucvu) : this()
        {
            tennv_nhan = tennv;
            chucvu_nhan = chucvu;


            txtTen.Text = tennv_nhan;
            txtChucVu.Text = chucvu_nhan;


            if (chucvu_nhan.Equals("QUẢN LÝ") || chucvu_nhan.Equals("NHÂN VIÊN")) 
            {
                btnNhanVien.Enabled = false;
            }

            
        }
         
         


        /*
        // hàm khởi tạo (constructor) để nhận dũ liệu tên
        public string nhandulieu_ten
        {
            get { return txtTen.Text; }
            set { txtTen.Text = value; }

        }

        // hàm khởi tạo (constructor) để nhận dũ liệu chức vụ
        public string nhandulieu_chucvu
        {
            get { return txtChucVu.Text; }
            set { txtChucVu.Text = value; }



        }
        */


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            trangChuUC1.BringToFront();
            lblTieuDe.Text = "TRANG CHỦ";
            btnTrangChu.BackColor = Color.Tomato;
            btnSanPham.BackColor = Color.SandyBrown;
            btnNhanVien.BackColor = Color.SandyBrown;
            btnHoaDon.BackColor = Color.SandyBrown;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            nhanVienUC1.BringToFront();
            lblTieuDe.Text = "NHÂN VIÊN";
            btnNhanVien.BackColor = Color.Tomato;
            btnTrangChu.BackColor = Color.SandyBrown;
            btnSanPham.BackColor = Color.SandyBrown;
            btnHoaDon.BackColor = Color.SandyBrown;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            sanPhamUC1.BringToFront();
            lblTieuDe.Text = "SẢN PHẨM";
            btnSanPham.BackColor = Color.Tomato;
            btnNhanVien.BackColor = Color.SandyBrown;
            btnTrangChu.BackColor = Color.SandyBrown;
            btnHoaDon.BackColor = Color.SandyBrown;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmDangNhap();
            f.Show();

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            hoaDonUC1.BringToFront();
            btnHoaDon.BackColor = Color.Tomato;
            btnSanPham.BackColor = Color.SandyBrown;
            btnNhanVien.BackColor = Color.SandyBrown;
            btnTrangChu.BackColor = Color.SandyBrown;
        }

    }
}
