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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void btnTenDN_Click(object sender, EventArgs e)
        {
            txtTenDN.Text = null;
        }




        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = null;
        }





        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu từ textbox
            string tendn = txtTenDN.Text;
            string matkhau = txtMatKhau.Text;

            //kết nối csdl
            string str = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=H:\\PHATTRIENUNGDUNGTRENWINDOWS\\SHOPQUANAO\\SHOPQUANAO\\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            //truy vấn dữ liệu
            SqlCommand cmd = new SqlCommand("SELECT matkhau, tennv, chucvu FROM NhanVien WHERE tendn = '" + tendn + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            //so sánh password
            if (reader.HasRows)
            {
                reader.Read();

                /*
                // không cho nhân viên đăng nhập vào phần mềm
                if (reader.GetString(2) == "NHÂN VIÊN")
                {
                    MessageBox.Show("Xin lỗi. 'NHÂN VIÊN' không có quyền sử dụng phần mềm này!");
                    return;
                }
                 */

                if (reader.GetString(0) == matkhau)
                {
                    string tennv = reader.GetString(1);
                    string chucvu = reader.GetString(2);

                    

                    //MessageBox.Show("Đăng nhập thành công!");
                    MessageBox.Show("Xin chào " + "'" + chucvu + "'" + " " + tennv + "!");

                    // gọi frmMain lên và truyền tham số tennv và chucvu qua frmMain
                    frmMain f = new frmMain(tennv, chucvu);
                    //f.nhandulieu_ten = tennv;
                    //f.nhandulieu_chucvu = chucvu;
                    f.hoaDonUC1.Ten = tennv;
                    f.hoaDonUC1.ChucVu = chucvu;
                    f.sanPhamUC1.ChucVu = chucvu;

                    HoaDonUC h = new HoaDonUC();
                    h.Ten = tennv;
                    h.ChucVu = chucvu;

                    SanPhamUC s = new SanPhamUC();
                    s.ChucVu = chucvu;

                    f.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Mật khẩu sai!");
                
            }
            else
            {
                MessageBox.Show("Người dùng không hợp lệ!");
            }

            reader.Close();
        }
    }
}
