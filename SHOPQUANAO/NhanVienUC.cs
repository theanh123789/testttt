using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SHOPQUANAO
{
    public partial class NhanVienUC : UserControl
    {


        public NhanVienUC()
        {
            InitializeComponent();
        }




        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=H:\\PHATTRIENUNGDUNGTRENWINDOWS\\SHOPQUANAO\\SHOPQUANAO\\Database1.mdf;Integrated Security=True");
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable dt = new DataTable();




        private void NhanVienUC_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadDuLieu();
            ThemSuaXoaDL();
            DisableTextBox();
            DisableComboBox();
            LayDuLieuLenTextBox();
            cbbChucVu.Text = "Chủ quán";
            cbbGioiTinh.Text = "Nam";
            DisableHuyButton();


        }



        public void LoadDuLieu()
        {
            dt.Clear();
            SqlCommand cm = new SqlCommand("SELECT manv, tennv, gioitinh, namsinh, diachi, sdt, tendn, matkhau, chucvu FROM NhanVien", conn);
            adap.SelectCommand = cm;
            adap.Fill(dt);
            dgvDSNhanVien.DataSource = dt;
        }



        public void LayDuLieuLenTextBox()
        {
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "diachi");

            txtMaNhanVien.DataBindings.Clear();
            txtMaNhanVien.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "manv");

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "matkhau");

            txtNamSinh.DataBindings.Clear();
            txtNamSinh.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "namsinh");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "sdt");

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "tendn");

            txtTenNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "tennv");

            cbbChucVu.DataBindings.Clear();
            cbbChucVu.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "chucvu");

            cbbGioiTinh.DataBindings.Clear();
            cbbGioiTinh.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "gioitinh");
        }



        private void ThemSuaXoaDL()
        {

            adap.InsertCommand = new SqlCommand("INSERT INTO NhanVien VALUES (@manv, @tennv, @gioitinh, @namsinh, @diachi, @sdt, @tendn, @matkhau, @chucvu)", conn);

            // dinh nghia parameter
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@manv";
            p1.SourceColumn = "manv";
            adap.InsertCommand.Parameters.Add(p1);


            //dinh nghia parameter
            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@tennv";
            p2.SourceColumn = "tennv";
            adap.InsertCommand.Parameters.Add(p2);

            //dinh nghia parameter
            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@gioitinh";
            p3.SourceColumn = "gioitinh";
            adap.InsertCommand.Parameters.Add(p3);


            //dinh nghia parameter
            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@namsinh";
            p4.SourceColumn = "namsinh";
            adap.InsertCommand.Parameters.Add(p4);


            //dinh nghia parameter
            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@diachi";
            p5.SourceColumn = "diachi";
            adap.InsertCommand.Parameters.Add(p5);


            //dinh nghia parameter
            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@sdt";
            p6.SourceColumn = "sdt";
            adap.InsertCommand.Parameters.Add(p6);


            //dinh nghia parameter
            SqlParameter p7 = new SqlParameter();
            p7.ParameterName = "@tendn";
            p7.SourceColumn = "tendn";
            adap.InsertCommand.Parameters.Add(p7);

            //dinh nghia parameter
            SqlParameter p8 = new SqlParameter();
            p8.ParameterName = "@matkhau";
            p8.SourceColumn = "matkhau";
            adap.InsertCommand.Parameters.Add(p8);

            //dinh nghia parameter
            SqlParameter p9 = new SqlParameter();
            p9.ParameterName = "@chucvu";
            p9.SourceColumn = "chucvu";
            adap.InsertCommand.Parameters.Add(p9);




            adap.UpdateCommand = new SqlCommand("UPDATE NhanVien SET tennv = @tennv, gioitinh = @gioitinh, namsinh = @namsinh, diachi = @diachi, sdt =  @sdt, tendn = @tendn, matkhau = @matkhau, chucvu = @chucvu WHERE manv = @manv", conn);

            SqlParameter p10 = new SqlParameter();
            p10.ParameterName = "@manv";
            p10.SourceColumn = "manv";
            adap.UpdateCommand.Parameters.Add(p10);


            SqlParameter p11 = new SqlParameter();
            p11.ParameterName = "@tennv";
            p11.SourceColumn = "tennv";
            adap.UpdateCommand.Parameters.Add(p11);


            SqlParameter p12 = new SqlParameter();
            p12.ParameterName = "@gioitinh";
            p12.SourceColumn = "gioitinh";
            adap.UpdateCommand.Parameters.Add(p12);


            SqlParameter p13 = new SqlParameter();
            p13.ParameterName = "@namsinh";
            p13.SourceColumn = "namsinh";
            adap.UpdateCommand.Parameters.Add(p13);


            SqlParameter p14 = new SqlParameter();
            p14.ParameterName = "@diachi";
            p14.SourceColumn = "diachi";
            adap.UpdateCommand.Parameters.Add(p14);


            SqlParameter p15 = new SqlParameter();
            p15.ParameterName = "@sdt";
            p15.SourceColumn = "sdt";
            adap.UpdateCommand.Parameters.Add(p15);


            SqlParameter p16 = new SqlParameter();
            p16.ParameterName = "@tendn";
            p16.SourceColumn = "tendn";
            adap.UpdateCommand.Parameters.Add(p16);


            SqlParameter p17 = new SqlParameter();
            p17.ParameterName = "@matkhau";
            p17.SourceColumn = "matkhau";
            adap.UpdateCommand.Parameters.Add(p17);

            //dinh nghia parameter
            SqlParameter p18 = new SqlParameter();
            p18.ParameterName = "@chucvu";
            p18.SourceColumn = "chucvu";
            adap.UpdateCommand.Parameters.Add(p18);





            adap.DeleteCommand = new SqlCommand("DELETE  FROM NhanVien WHERE manv = @manv", conn);

            //dinh nghia parameter @masanpham
            SqlParameter p19 = new SqlParameter();
            p19.ParameterName = "@manv";
            p19.SourceColumn = "manv";
            adap.DeleteCommand.Parameters.Add(p19);


        }

        

        public void DisableTextBox()
        {
            // disable textbox
            txtDiaChi.Enabled = false;
            txtMaNhanVien.Enabled = false;
            txtMatKhau.Enabled = false;
            txtNamSinh.Enabled = false;
            txtSDT.Enabled = false;
            txtTenDangNhap.Enabled = false;
            txtTenNhanVien.Enabled = false;
        }



        public void DisableComboBox()
        {
            // disable ComboBox
            cbbChucVu.Enabled = false;
            cbbGioiTinh.Enabled = false;
        }


        
        
        public void EnableTextBox()
        {
            txtDiaChi.Enabled = true;
            txtMaNhanVien.Enabled = true;
            txtMatKhau.Enabled = true;
            txtNamSinh.Enabled = true;
            txtSDT.Enabled = true;
            txtTenDangNhap.Enabled = true;
            txtTenNhanVien.Enabled = true;
        }




        public void EnableComboBox()
        {
            cbbChucVu.Enabled = true;
            cbbGioiTinh.Enabled = true;
        }





        public void EnableHuyButton()
        {
            btnHuy.Enabled = true;
            btnHuy.BackColor = Color.DeepSkyBlue;
        }





        public void DisableHuyButton()
        {
            btnHuy.Enabled = false;
            btnHuy.BackColor = Color.White;
        }





        public void DisableThemButton()
        {
            btnThem.Enabled = false;
            btnThem.BackColor = Color.White;
        }




        public void EnableThemButton()
        {
            btnThem.Enabled = true;
            btnThem.BackColor = Color.Turquoise;
        }




        public void EnableSuaButton()
        {
            btnSua.Enabled = true;
            btnSua.BackColor = Color.RoyalBlue;
        }




        public void DisableSuaButton()
        {
            btnSua.Enabled = false;
            btnSua.BackColor = Color.White;
        }




        public void DisableXoaButton()
        {
            btnXoa.Enabled = false;
            btnXoa.BackColor = Color.White;
        }




        public void EnableXoaButton()
        {
            btnXoa.Enabled = true;
            btnXoa.BackColor = Color.Tomato;
        }





        public void XoaTrang()
        {
            txtDiaChi.Text = "";
            txtMaNhanVien.Text = "";
            txtMatKhau.Text = "";
            txtNamSinh.Text = "";
            txtSDT.Text = "";
            txtTenDangNhap.Text = "";
            txtTenNhanVien.Text = "";
            cbbChucVu.Text = "Chủ quán";
            cbbGioiTinh.Text = "Nam";
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            LayDuLieuLenTextBox();

            if (btnThem.Text.Equals("LƯU")) 
            {
                btnThem.Text = "THÊM";
                EnableSuaButton();
                EnableXoaButton();
            }

            
            if (btnSua.Text.Equals("LƯU"))
            {
                btnSua.Text = "SỬA";
                EnableXoaButton();
                EnableThemButton();
            }

            DisableHuyButton();
            DisableTextBox();
            DisableComboBox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("THÊM"))
            {
                
                EnableComboBox();
                EnableTextBox();
                XoaTrang();
                btnThem.Text = "LƯU";

                EnableHuyButton();
                DisableSuaButton();
                DisableXoaButton();
                
            }

            else if (btnThem.Text.Equals("LƯU"))
            {
                try
                {
                    // mở kết nối
                    //conn.Open();

                    // lấy dữ liệu từ textBox
                    string manv = txtMaNhanVien.Text;
                    string tennv = txtTenNhanVien.Text;
                    string gioitinh = cbbGioiTinh.Text;
                    string namsinh = txtNamSinh.Text;
                    string diachi = txtDiaChi.Text;
                    string sdt = txtSDT.Text;
                    string tendn = txtTenDangNhap.Text;
                    string matkhau = txtMatKhau.Text;
                    string chucvu = cbbChucVu.Text;


                    if (manv == "")
                    {
                        MessageBox.Show("Vui lòng điền 'mã nhân viên'");
                        return;
                    }

                    if (tennv == "")
                    {
                        MessageBox.Show("Vui lòng điền 'tên nhân viên'");
                        return;
                    }

                    if (namsinh == "")
                    {
                        MessageBox.Show("Vui lòng điền 'năm sinh nhân viên'");
                        return;
                    }

                    if (diachi == "")
                    {
                        MessageBox.Show("Vui lòng điền 'địa chi của nhân viên'");
                        return;
                    }

                    if (sdt == "")
                    {
                        MessageBox.Show("Vui lòng điền 'sđt của nhân viên'");
                        return;
                    }

                    if (tendn == "")
                    {
                        MessageBox.Show("Vui lòng điền 'tên đăng nhập của nhân viên'");
                        return;
                    }

                    if (matkhau == "")
                    {
                        MessageBox.Show("Vui lòng điền 'mật khẩu của nhân viên'");
                        return;
                    }


                    //insert vào csdl
                    string str_them = "INSERT INTO NhanVien VALUES ('" + manv + "', N'" + tennv + "', N'" + gioitinh + "', N'" + namsinh + "', N'" + diachi + "', N'" + sdt + "', '" + tendn + "', '" + matkhau + "', N'" + chucvu + "')";
                    SqlCommand cmd = new SqlCommand(str_them, conn);
                    cmd.ExecuteNonQuery();

                    //load lại dữ liệu trên form
                    LoadDuLieu();

                    //xóa trắng các ô textbox
                    //XoaTrang();

                    DisableTextBox();
                    DisableComboBox();
                    btnThem.Text = "THÊM";

                    DisableHuyButton();
                    EnableSuaButton();
                    EnableXoaButton();

                    //đóng kết nối
                    //conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("'Mã nhân viên' đã tồn tại!");
                }

            }

        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("SỬA"))
            {

                EnableComboBox();
                EnableTextBox();

                DisableThemButton();
                DisableXoaButton();

                btnSua.Text = "LƯU";

                EnableHuyButton();
            }
            else {
                // mở kết nối
                //conn.Open();

                // lấy dữ liệu từ textBox
                string manv = txtMaNhanVien.Text;
                string tennv = txtTenNhanVien.Text;
                string gioitinh = cbbGioiTinh.Text;
                string namsinh = txtNamSinh.Text;
                string diachi = txtDiaChi.Text;
                string sdt = txtSDT.Text;
                string tendn = txtTenDangNhap.Text;
                string matkhau = txtMatKhau.Text;
                string chucvu = cbbChucVu.Text;


                if (manv == "")
                {
                    MessageBox.Show("Vui lòng điền 'mã nhân viên'");
                    return;
                }

                if (tennv == "")
                {
                    MessageBox.Show("Vui lòng điền 'tên nhân viên'");
                    return;
                }

                if (namsinh == "")
                {
                    MessageBox.Show("Vui lòng điền 'năm sinh nhân viên'");
                    return;
                }

                if (diachi == "")
                {
                    MessageBox.Show("Vui lòng điền 'địa chi của nhân viên'");
                    return;
                }

                if (sdt == "")
                {
                    MessageBox.Show("Vui lòng điền 'sđt của nhân viên'");
                    return;
                }

                if (tendn == "")
                {
                    MessageBox.Show("Vui lòng điền 'tên đăng nhập của nhân viên'");
                    return;
                }

                if (matkhau == "")
                {
                    MessageBox.Show("Vui lòng điền 'mật khẩu của nhân viên'");
                    return;
                }

                //sửa dòng dl trong csdl
                string str_sua = "UPDATE NhanVien SET tennv = N'" + tennv + "', gioitinh = N'" + gioitinh + "', namsinh =  '" + namsinh + "', diachi = N'" + diachi + "', sdt = N'" + sdt + "', tendn = '" + tendn + "', matkhau = '" + matkhau + "', chucvu = N'" + chucvu + "'  WHERE manv = '" + manv + "' ";
                SqlCommand cmd = new SqlCommand(str_sua, conn);
                cmd.ExecuteNonQuery();

                //load lại dữ liệu trên form
                LoadDuLieu();

                DisableTextBox();
                DisableComboBox();

                btnSua.Text = "SỬA";
                DisableHuyButton();
                EnableThemButton();
                EnableXoaButton();

                //đóng kết nối
                //conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //mở kết nối
            //conn.Open();

            // lấy dữ liệu từ textBox
            string manv = txtMaNhanVien.Text;

            //xóa dòng dl trong csdl
            string str_xoa = "DELETE FROM NhanVien WHERE manv = '" + manv + "' ";
            SqlCommand cmd = new SqlCommand(str_xoa, conn);
            cmd.ExecuteNonQuery();

            //load lại dữ liệu trên form
            LoadDuLieu();

            //đóng kết nối
            //conn.Close();
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                adap.Update((DataTable)dgvDSNhanVien.DataSource);
                dt.Clear();
                LoadDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
