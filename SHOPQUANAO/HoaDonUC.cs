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
    public partial class HoaDonUC : UserControl
    {

        private string ten;
        private string chucvu;


        public HoaDonUC()
        {
            InitializeComponent();
        }

        

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }


        public string ChucVu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }



        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=H:\\PHATTRIENUNGDUNGTRENWINDOWS\\SHOPQUANAO\\SHOPQUANAO\\Database1.mdf;Integrated Security=True");
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable dt = new DataTable();




        private void HoaDonUC_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadDuLieu();
            ThemSuaXoaDL();
            DisableTextBox();
            DisableComboBox();
            //LayDuLieuLenTextBox();
            DisableHuyButton();
            LayDuLieuSanPham();


            cbbNhanVienLap.Enabled = false;
            cbbNhanVienLap.Text = ten;
            //label3.Text = chucvu;
            
        }





        public void LoadDuLieu()
        {
            dt.Clear();
            SqlCommand cm = new SqlCommand("SELECT * FROM HoaDon", conn);
            adap.SelectCommand = cm;
            adap.Fill(dt);
            dgvHoaDon.DataSource = dt;
        }






        public void LayDuLieuLenTextBox()
        {
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvHoaDon.DataSource, "dongia");

            //cbbNhanVienLap.DataBindings.Clear();
            //cbbNhanVienLap.DataBindings.Add("Text", dgvHoaDon.DataSource, "nhanvienlap");

            txtNgayLapHD.DataBindings.Clear();
            txtNgayLapHD.DataBindings.Add("Text", dgvHoaDon.DataSource, "ngaylap");

            txtSoHD.DataBindings.Clear();
            txtSoHD.DataBindings.Add("Text", dgvHoaDon.DataSource, "sohd");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvHoaDon.DataSource, "soluong");

            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", dgvHoaDon.DataSource, "khachhang");


            cbbTenSanPham.DataBindings.Clear();
            cbbTenSanPham.DataBindings.Add("Text", dgvHoaDon.DataSource, "sanpham");

        }



        public void LayDuLieuLenTextBox2()
        {
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvHoaDon.DataSource, "dongia");

            cbbNhanVienLap.DataBindings.Clear();
            cbbNhanVienLap.DataBindings.Add("Text", dgvHoaDon.DataSource, "nhanvienlap");

            txtNgayLapHD.DataBindings.Clear();
            txtNgayLapHD.DataBindings.Add("Text", dgvHoaDon.DataSource, "ngaylap");

            txtSoHD.DataBindings.Clear();
            txtSoHD.DataBindings.Add("Text", dgvHoaDon.DataSource, "sohd");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvHoaDon.DataSource, "soluong");

            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", dgvHoaDon.DataSource, "khachhang");


            cbbTenSanPham.DataBindings.Clear();
            cbbTenSanPham.DataBindings.Add("Text", dgvHoaDon.DataSource, "sanpham");

        }






        private void ThemSuaXoaDL()
        {

            adap.InsertCommand = new SqlCommand("INSERT INTO HoaDon VALUES (@sohd, @ngaylap, @nhanvienlap, @khachhang, @sanpham, @dongia, @soluong, @tongtien)", conn);

            // dinh nghia parameter
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@sohd";
            p1.SourceColumn = "sohd";
            adap.InsertCommand.Parameters.Add(p1);


            //dinh nghia parameter
            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@ngaylap";
            p2.SourceColumn = "ngaylap";
            adap.InsertCommand.Parameters.Add(p2);

            //dinh nghia parameter
            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@nhanvienlap";
            p3.SourceColumn = "nhanvienlap";
            adap.InsertCommand.Parameters.Add(p3);


            //dinh nghia parameter
            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@khachhang";
            p4.SourceColumn = "khachhang";
            adap.InsertCommand.Parameters.Add(p4);


            //dinh nghia parameter
            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@sanpham";
            p5.SourceColumn = "sanpham";
            adap.InsertCommand.Parameters.Add(p5);


            //dinh nghia parameter
            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@dongia";
            p6.SourceColumn = "dongia";
            adap.InsertCommand.Parameters.Add(p6);


            //dinh nghia parameter
            SqlParameter p7 = new SqlParameter();
            p7.ParameterName = "@soluong";
            p7.SourceColumn = "soluong";
            adap.InsertCommand.Parameters.Add(p7);

            //dinh nghia parameter
            SqlParameter p8 = new SqlParameter();
            p8.ParameterName = "@tongtien";
            p8.SourceColumn = "tongtien";
            adap.InsertCommand.Parameters.Add(p8);




            adap.UpdateCommand = new SqlCommand("UPDATE HoaDon SET ngaylap = @ngaylap, nhanvienlap = @nhanvienlap, khachhang = @khachhang, sanpham = @sanpham, dongia =  @dongia, soluong = @soluong, tongtien = @tongtien WHERE sohd = @sohd", conn);

            SqlParameter p9 = new SqlParameter();
            p9.ParameterName = "@sohd";
            p9.SourceColumn = "sohd";
            adap.UpdateCommand.Parameters.Add(p9);


            SqlParameter p10 = new SqlParameter();
            p10.ParameterName = "@ngaylap";
            p10.SourceColumn = "ngaylap";
            adap.UpdateCommand.Parameters.Add(p10);


            SqlParameter p11 = new SqlParameter();
            p11.ParameterName = "@nhanvienlap";
            p11.SourceColumn = "nhanvienlap";
            adap.UpdateCommand.Parameters.Add(p11);


            SqlParameter p12 = new SqlParameter();
            p12.ParameterName = "@khachhang";
            p12.SourceColumn = "khachhang";
            adap.UpdateCommand.Parameters.Add(p12);


            SqlParameter p13 = new SqlParameter();
            p13.ParameterName = "@sanpham";
            p13.SourceColumn = "sanpham";
            adap.UpdateCommand.Parameters.Add(p13);


            SqlParameter p14 = new SqlParameter();
            p14.ParameterName = "@dongia";
            p14.SourceColumn = "dongia";
            adap.UpdateCommand.Parameters.Add(p14);


            SqlParameter p15 = new SqlParameter();
            p15.ParameterName = "@soluong";
            p15.SourceColumn = "soluong";
            adap.UpdateCommand.Parameters.Add(p15);


            SqlParameter p16 = new SqlParameter();
            p16.ParameterName = "@tongtien";
            p16.SourceColumn = "tongtien";
            adap.UpdateCommand.Parameters.Add(p16);





            adap.DeleteCommand = new SqlCommand("delete from HoaDon where sohd = @sohd", conn);

            //dinh nghia parameter @masanpham
            SqlParameter p17 = new SqlParameter();
            p17.ParameterName = "@sohd";
            p17.SourceColumn = "sohd";
            adap.DeleteCommand.Parameters.Add(p17);

        }







        public void DisableTextBox()
        {
            // disable textbox

            txtTenKH.Enabled = false;
            txtSoLuong.Enabled = false;
            txtSoHD.Enabled = false;
            txtNgayLapHD.Enabled = false;
            cbbNhanVienLap.Enabled = false;
            txtDonGia.Enabled = false;
        }







        public void DisableComboBox()
        {
            // disable ComboBox
            cbbTenSanPham.Enabled = false;
        }







        public void EnableTextBox()
        {
           
            txtTenKH.Enabled = true;
            txtSoLuong.Enabled = true;
            txtSoHD.Enabled = true;
            txtNgayLapHD.Enabled = true;
            cbbNhanVienLap.Enabled = true;
            //txtDonGia.Enabled = true;
        }



        public void EnableTextBox2()
        {

            txtTenKH.Enabled = true;
            txtSoLuong.Enabled = true;
            txtSoHD.Enabled = true;
            txtNgayLapHD.Enabled = true;
            //cbbNhanVienLap.Enabled = true;
            //txtDonGia.Enabled = true;
        }




        public void EnableComboBox()
        {
            cbbTenSanPham.Enabled = true;
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
            txtDonGia.Text = "";
            //cbbNhanVienLap.Text = "";
            txtNgayLapHD.Text = "";
            txtSoHD.Text = "";
            txtSoLuong.Text = "";
            txtTenKH.Text = "";

        }



        public void XoaTrang2()
        {
            txtDonGia.Text = "";
            //cbbNhanVienLap.Text = "";
            txtNgayLapHD.Text = "";
            txtSoHD.Text = "";
            txtSoLuong.Text = "";
            txtTenKH.Text = "";

        }




        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("THÊM"))
            {
                LayDuLieuSanPham();
                LayDuLieuLenTextBox();
                EnableComboBox();
                EnableTextBox2();
                XoaTrang();
                btnThem.Text = "LƯU";
                
                EnableHuyButton();
                DisableSuaButton();
                DisableXoaButton();
                cbbTenSanPham.Text = "";

            }

            else if (btnThem.Text.Equals("LƯU"))
            {
                try
                {
                    // mở kết nối
                    //conn.Open();

                    // lấy dữ liệu từ textBox
                    string sohd = txtSoHD.Text;
                    string ngaylap = txtNgayLapHD.Text;
                    string nhanvien = cbbNhanVienLap.Text;
                    string khachhang = txtTenKH.Text;
                    string sanpham = cbbTenSanPham.Text;
                    float dongia = float.Parse(txtDonGia.Text);
                    float soluong = float.Parse(txtSoLuong.Text);
                    float tongtien = dongia * soluong;


                    if (sohd == "")
                    {
                        MessageBox.Show("Vui lòng điền 'số hóa đơn'");
                        return;
                    }

                    if (ngaylap == "")
                    {
                        MessageBox.Show("Vui lòng điền 'ngày lập hóa đơn'");
                        return;
                    }

                    if (nhanvien == "")
                    {
                        MessageBox.Show("Vui lòng điền 'nhân viên lập hóa đơn'");
                        return;
                    }

                    if (khachhang == "")
                    {
                        MessageBox.Show("Vui lòng điền 'khách hàng'");
                        return;
                    }

                    if (sanpham == "")
                    {
                        MessageBox.Show("Vui lòng điền 'sản phẩm'");
                        return;
                    }

                    

                    if (soluong.Equals(""))
                    {
                        MessageBox.Show("Vui lòng điền 'số lượng'");
                        return;
                    }

                    


                    //insert vào csdl
                    string str_them = "INSERT INTO HoaDon VALUES ('" + sohd + "', '" + ngaylap + "', N'" + nhanvien + "', N'" + khachhang + "', N'" + sanpham + "', '" + dongia + "', '" + soluong + "', '" + tongtien + "')";
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
                    //MessageBox.Show("'Số hóa đơn' đã tồn tại!");
                    MessageBox.Show(ex.ToString());
                }

            }
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






        private void LayDuLieuSanPham()
        {
            string query = "SELECT *FROM SanPham";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            //conn.Close();
            DataTable tb = new DataTable();
            adap.Fill(tb);

            cbbTenSanPham.DataSource = tb;
            cbbTenSanPham.DisplayMember = "tensanpham";

            txtDonGia.DataSource = tb;
            txtDonGia.DisplayMember = "giasanpham";
        }




        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateTongTienDGV();
                adap.Update((DataTable)dgvHoaDon.DataSource);
                
                dt.Clear();
                
                LoadDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }







        public void UpdateTongTienDGV()
        {
            // lấy dữ liệu từ textBox
            
            string sohd = txtSoHD.Text;
            
            string ngaylap = txtNgayLapHD.Text;
            string nhanvien = cbbNhanVienLap.Text;
            string khachhang = txtTenKH.Text;
            string sanpham = cbbTenSanPham.Text;    
            string dongia = txtDonGia.Text;
            string soluong = txtSoLuong.Text;
            float tongtien = float.Parse(txtSoLuong.Text) * float.Parse(txtDonGia.Text);


            

            //sửa dòng dl trong csdl
            string str_sua = "UPDATE HoaDon SET ngaylap = '" + ngaylap + "', nhanvienlap = N'" + nhanvien + "', khachhang =  N'" + khachhang + "', sanpham = N'" + sanpham + "', dongia = '" + dongia + "', soluong = '" + soluong + "', tongtien = '" + tongtien + "'  WHERE sohd = '" + sohd + "'";
            //string str_sua = "UPDATE HoaDon SET tongtien = '" + tongtien + "'  WHERE sohd = '" + sohd + "'";
            SqlCommand cmd = new SqlCommand(str_sua, conn);
            cmd.ExecuteNonQuery();

            //load lại dữ liệu trên form
            LoadDuLieu();
            //đóng kết nối
            //conn.Close();
        }







        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("SỬA"))
            {
                LayDuLieuLenTextBox2();
                EnableComboBox();
                EnableTextBox();

                DisableThemButton();
                DisableXoaButton();

                btnSua.Text = "LƯU";

                EnableHuyButton();
            }
            else
            {
                // mở kết nối
                //conn.Open();

                // lấy dữ liệu từ textBox
                string sohd = txtSoHD.Text;
                string ngaylap = txtNgayLapHD.Text;
                string nhanvien = cbbNhanVienLap.Text;
                string khachhang = txtTenKH.Text;
                string sanpham = cbbTenSanPham.Text;
                string dongia = txtDonGia.Text;
                string soluong = txtSoLuong.Text;
                float tongtien = float.Parse(txtSoLuong.Text) * float.Parse(txtDonGia.Text);


                if (sohd == "")
                {
                    MessageBox.Show("Vui lòng điền 'số hóa đơn'");
                    return;
                }

                if (ngaylap == "")
                {
                    MessageBox.Show("Vui lòng điền 'ngày lập hóa đơn'");
                    return;
                }

                if (nhanvien == "")
                {
                    MessageBox.Show("Vui lòng điền 'nhân viên lập hóa đơn'");
                    return;
                }

                if (khachhang == "")
                {
                    MessageBox.Show("Vui lòng điền 'khách hàng'");
                    return;
                }

                if (sanpham == "")
                {
                    MessageBox.Show("Vui lòng điền 'sản phẩm'");
                    return;
                }

                if (dongia == "")
                {
                    MessageBox.Show("Vui lòng điền 'đơn giá'");
                    return;
                }

                if (soluong == "")
                {
                    MessageBox.Show("Vui lòng điền 'số lượng'");
                    return;
                }

                //sửa dòng dl trong csdl
                string str_sua = "UPDATE HoaDon SET ngaylap = '" + ngaylap + "', nhanvienlap = N'" + nhanvien + "', khachhang =  N'" + khachhang + "', sanpham = N'" + sanpham + "', dongia = '" + dongia + "', soluong = '" + soluong + "', tongtien = '" + tongtien + "'  WHERE sohd = '" + sohd + "'";
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
            string sohd = txtSoHD.Text;

            //xóa dòng dl trong csdl
            string str_xoa = "DELETE FROM HoaDon WHERE sohd = '" + sohd + "' ";
            SqlCommand cmd = new SqlCommand(str_xoa, conn);
            cmd.ExecuteNonQuery();

            //load lại dữ liệu trên form
            LoadDuLieu();

            //đóng kết nối
            //conn.Close();
        }
    }
}
