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
using System.IO;
using System.Drawing.Imaging;

namespace SHOPQUANAO
{
    public partial class SanPhamUC : UserControl
    {

        private string chucvu;

        public SanPhamUC()
        {
            InitializeComponent();
        }


        public string ChucVu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }

        



        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=H:\\PHATTRIENUNGDUNGTRENWINDOWS\\SHOPQUANAO\\SHOPQUANAO\\Database1.mdf;Integrated Security=True");
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable dt = new DataTable();




        private void SanPhamUC_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadDuLieu();
            ThemSuaXoaDL();
            LayDuLieuLenTextBox();
            DisableTextBox();
            DisableHuyButton();


            string cv = chucvu;

            if (cv == "NHÂN VIÊN")
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
            }
        }




        public void LoadDuLieu()
        {
            dt.Clear();
            SqlCommand cm = new SqlCommand("SELECT * FROM SanPham", conn);
            adap.SelectCommand = cm;
            adap.Fill(dt);
            dgvDSSanPham.DataSource = dt;
        }




        public void ThemSuaXoaDL()
        {

            adap.InsertCommand = new SqlCommand("INSERT INTO SanPham VALUES (@masanpham, @tensanpham, @giasanpham, @motasanpham, @size, @nhasanxuat, @ngaysanxuat, @soluong)", conn);

            // dinh nghia parameter
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@masanpham";
            p1.SourceColumn = "masanpham";
            adap.InsertCommand.Parameters.Add(p1);


            //dinh nghia parameter
            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@tensanpham";
            p2.SourceColumn = "tensanpham";
            adap.InsertCommand.Parameters.Add(p2);

            //dinh nghia parameter
            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@giasanpham";
            p3.SourceColumn = "giasanpham";
            adap.InsertCommand.Parameters.Add(p3);


            //dinh nghia parameter
            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@motasanpham";
            p4.SourceColumn = "motasanpham";
            adap.InsertCommand.Parameters.Add(p4);


            //dinh nghia parameter
            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@size";
            p5.SourceColumn = "size";
            adap.InsertCommand.Parameters.Add(p5);


            //dinh nghia parameter
            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@nhasanxuat";
            p6.SourceColumn = "nhasanxuat";
            adap.InsertCommand.Parameters.Add(p6);


            //dinh nghia parameter
            SqlParameter p7 = new SqlParameter();
            p7.ParameterName = "@ngaysanxuat";
            p7.SourceColumn = "ngaysanxuat";
            adap.InsertCommand.Parameters.Add(p7);

            //dinh nghia parameter
            SqlParameter p8 = new SqlParameter();
            p8.ParameterName = "@soluong";
            p8.SourceColumn = "soluong";
            adap.InsertCommand.Parameters.Add(p8);




            adap.UpdateCommand = new SqlCommand("UPDATE SanPham SET tensanpham = @tensanpham, giasanpham = @giasanpham, motasanpham = @motasanpham, size = @size, nhasanxuat =  @nhasanxuat, ngaysanxuat = @ngaysanxuat, soluong = @soluong WHERE masanpham = @masanpham", conn);

            SqlParameter p9 = new SqlParameter();
            p9.ParameterName = "@masanpham";
            p9.SourceColumn = "masanpham";
            adap.UpdateCommand.Parameters.Add(p9);


            SqlParameter p10 = new SqlParameter();
            p10.ParameterName = "@tensanpham";
            p10.SourceColumn = "tensanpham";
            adap.UpdateCommand.Parameters.Add(p10);


            SqlParameter p11 = new SqlParameter();
            p11.ParameterName = "@giasanpham";
            p11.SourceColumn = "giasanpham";
            adap.UpdateCommand.Parameters.Add(p11);


            SqlParameter p12 = new SqlParameter();
            p12.ParameterName = "@motasanpham";
            p12.SourceColumn = "motasanpham";
            adap.UpdateCommand.Parameters.Add(p12);


            SqlParameter p13 = new SqlParameter();
            p13.ParameterName = "@size";
            p13.SourceColumn = "size";
            adap.UpdateCommand.Parameters.Add(p13);


            SqlParameter p14 = new SqlParameter();
            p14.ParameterName = "@nhasanxuat";
            p14.SourceColumn = "nhasanxuat";
            adap.UpdateCommand.Parameters.Add(p14);


            SqlParameter p15 = new SqlParameter();
            p15.ParameterName = "@ngaysanxuat";
            p15.SourceColumn = "ngaysanxuat";
            adap.UpdateCommand.Parameters.Add(p15);


            SqlParameter p16 = new SqlParameter();
            p16.ParameterName = "@soluong";
            p16.SourceColumn = "soluong";
            adap.UpdateCommand.Parameters.Add(p16);





            adap.DeleteCommand = new SqlCommand("delete from SanPham where masanpham = @masanpham", conn);

            //dinh nghia parameter @masanpham
            SqlParameter p17 = new SqlParameter();
            p17.ParameterName = "@masanpham";
            p17.SourceColumn = "masanpham";
            adap.DeleteCommand.Parameters.Add(p17);


        }


        public void LayDuLieuLenTextBox()
        {
            // hiện giá sản phẩm lên ô textbox giá sản phẩm 
            txtGiaSanPham.DataBindings.Clear();
            txtGiaSanPham.DataBindings.Add("Text", dgvDSSanPham.DataSource, "giasanpham");

            // hiện giá sản phẩm lên ô mã sản phẩm
            txtMaSanPham.DataBindings.Clear();
            txtMaSanPham.DataBindings.Add("Text", dgvDSSanPham.DataSource, "masanpham");

            // hiện giá sản phẩm lên ô mã sản phẩm
            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", dgvDSSanPham.DataSource, "tensanpham");

            // hiện giá sản phẩm lên ô mã sản phẩm
            txtMoTaSanPham.DataBindings.Clear();
            txtMoTaSanPham.DataBindings.Add("Text", dgvDSSanPham.DataSource, "motasanpham");

            // hiện giá sản phẩm lên ô mã sản phẩm
            txtSize.DataBindings.Clear();
            txtSize.DataBindings.Add("Text", dgvDSSanPham.DataSource, "size");

            // hiện giá sản phẩm lên ô mã sản phẩm
            txtNhaSanXuat.DataBindings.Clear();
            txtNhaSanXuat.DataBindings.Add("Text", dgvDSSanPham.DataSource, "nhasanxuat");

            // hiện giá sản phẩm lên ô mã sản phẩm
            txtNgaySanXuat.DataBindings.Clear();
            txtNgaySanXuat.DataBindings.Add("Text", dgvDSSanPham.DataSource, "ngaysanxuat");

            // hiện giá sản phẩm lên ô mã sản phẩm
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvDSSanPham.DataSource, "soluong");

            //txtImagePath.DataBindings.Clear();
            //txtImagePath.DataBindings.Add("Text", dgvDSSanPham.DataSource, "hinhanh");


            // hiển thị hình ảnh sản phẩm lên PictureBox
            


        }


        public void XoaTrang()
        {
            txtSoLuong.Text = "";
            txtTenSanPham.Text = "";
            txtSize.Text = "";
            txtNhaSanXuat.Text = "";
            txtNgaySanXuat.Text = "";
            txtMoTaSanPham.Text = "";
            txtMaSanPham.Text = "";
            txtGiaSanPham.Text = "";
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




        public void EnableTextBox()
        {
            txtGiaSanPham.Enabled = true;
            txtMaSanPham.Enabled = true;
            txtMoTaSanPham.Enabled = true;
            txtNgaySanXuat.Enabled = true;
            txtNhaSanXuat.Enabled = true;
            txtSize.Enabled = true;
            txtSoLuong.Enabled = true;
            txtTenSanPham.Enabled = true;
        }




        public void DisableTextBox()
        {
            // disable textbox
            txtGiaSanPham.Enabled = false;
            txtMaSanPham.Enabled = false;
            txtMoTaSanPham.Enabled = false;
            txtNgaySanXuat.Enabled = false;
            txtNhaSanXuat.Enabled = false;
            txtSize.Enabled = false;
            txtSoLuong.Enabled = false;
            txtTenSanPham.Enabled = false;
        }





        private void btnHuy_Click(object sender, EventArgs e)
        {
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

            LoadDuLieu();
            LayDuLieuLenTextBox();
        }





        private void btnThem_Click(object sender, EventArgs e)
        {

            // lấy dữ liệu từ textBox
            string masp = txtMaSanPham.Text;
            string tensp = txtTenSanPham.Text;
            string giasp = txtGiaSanPham.Text;
            string motasp = txtMoTaSanPham.Text;
            string size = txtSize.Text;
            string nhasx = txtNhaSanXuat.Text;
            string ngaysx = txtNgaySanXuat.Text;
            string soluong = txtSoLuong.Text;

            if (masp == "")
            {
                MessageBox.Show("Vui lòng điền 'mã sản phẩm'");
                return;
            }

            else if (tensp == "")
            {
                MessageBox.Show("Vui lòng điền 'tên sản phẩm'");
                return;
            }

            else if (giasp == "")
            {
                MessageBox.Show("Vui lòng điền 'giá sản phẩm'");
                return;
            }

            else if (motasp == "")
            {
                MessageBox.Show("Vui lòng điền 'mô tả sản phẩm'");
                return;
            }

            else if (size == "")
            {
                MessageBox.Show("Vui lòng điền 'size sản phẩm'");
                return;
            }


            else if (nhasx == "")
            {
                MessageBox.Show("Vui lòng điền 'nhà sản xuất sản phẩm'");
                return;
            }


            else if (ngaysx == "")
            {
                MessageBox.Show("Vui lòng điền 'ngày sản xuất sản phẩm'");
                return;
            }


            else if (soluong == "")
            {
                MessageBox.Show("Vui lòng điền 'số lượng sản phẩm'");
                return;
            }

            else
            {

                if (btnThem.Text.Equals("THÊM"))
                {
                    EnableTextBox();
                    XoaTrang();
                    btnThem.Text = "LƯU";

                    EnableHuyButton();
                    DisableSuaButton();
                    DisableXoaButton();

                }
                else
                {
                    try
                    {
                        // mở kết nối
                        //conn.Open();

                        //insert vào csdl
                        string str_them = "INSERT INTO SanPham VALUES ('" + masp + "', N'" + tensp + "', '" + giasp + "', N'" + motasp + "', '" + size + "', N'" + nhasx + "', '" + ngaysx + "', '" + soluong + "')";
                        SqlCommand cmd = new SqlCommand(str_them, conn);
                        cmd.ExecuteNonQuery();

                        //load lại dữ liệu trên form
                        LoadDuLieu();

                        //xóa trắng các ô textbox
                        //XoaTrang();
                        DisableTextBox();
                        btnThem.Text = "THÊM";

                        DisableHuyButton();
                        EnableSuaButton();
                        EnableXoaButton();

                        //đóng kết nối
                        //conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("'Mã sản phẩm đã tồn tại!'");
                    }
                }
            }
        }





        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("SỬA"))
            {
                EnableTextBox();

                DisableThemButton();
                DisableXoaButton();

                btnSua.Text = "LƯU";

                EnableHuyButton();
            }
            else if (btnSua.Text.Equals("LƯU"))
            {
                // lấy dữ liệu từ textBox
                string masp = txtMaSanPham.Text;
                string tensp = txtTenSanPham.Text;
                string giasp = txtGiaSanPham.Text;
                string motasp = txtMoTaSanPham.Text;
                string size = txtSize.Text;
                string nhasx = txtNhaSanXuat.Text;
                string ngaysx = txtNgaySanXuat.Text;
                string soluong = txtSoLuong.Text;


                if (masp == "")
                {
                    MessageBox.Show("Vui lòng điền 'mã sản phẩm'");
                    return;
                }

                else if (tensp == "")
                {
                    MessageBox.Show("Vui lòng điền 'tên sản phẩm'");
                    return;
                }

                else if (giasp == "")
                {
                    MessageBox.Show("Vui lòng điền 'giá sản phẩm'");
                    return;
                }

                else if (motasp == "")
                {
                    MessageBox.Show("Vui lòng điền 'mô tả sản phẩm'");
                    return;
                }

                else if (size == "")
                {
                    MessageBox.Show("Vui lòng điền 'size sản phẩm'");
                    return;
                }


                else if (nhasx == "")
                {
                    MessageBox.Show("Vui lòng điền 'nhà sản xuất sản phẩm'");
                    return;
                }


                else if (ngaysx == "")
                {
                    MessageBox.Show("Vui lòng điền 'ngày sản xuất sản phẩm'");
                    return;
                }


                else if (soluong == "")
                {
                    MessageBox.Show("Vui lòng điền 'số lượng sản phẩm'");
                    return;
                }

                else
                {
                    //sửa dòng dl trong csdl
                    string str_sua = "UPDATE SanPham SET tensanpham = N'" + tensp + "', giasanpham = '" + giasp + "', motasanpham =  N'" + motasp + "', size = '" + size + "', nhasanxuat = N'" + nhasx + "', ngaysanxuat = '" + ngaysx + "', soluong = '" + soluong + "' WHERE masanpham = '" + masp + "' ";
                    SqlCommand cmd = new SqlCommand(str_sua, conn);
                    cmd.ExecuteNonQuery();

                    //load lại dữ liệu trên form
                    LoadDuLieu();

                    DisableTextBox();

                    btnSua.Text = "SỬA";
                    DisableHuyButton();
                    EnableThemButton();
                    EnableXoaButton();

                    //đóng kết nối
                    //conn.Close();
                } 
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu từ textBox
            string masp = txtMaSanPham.Text;

            //xóa dòng dl trong csdl
            string str_xoa = "DELETE FROM SanPham WHERE masanpham = '" + masp + "' ";
            SqlCommand cmd = new SqlCommand(str_xoa, conn);
            cmd.ExecuteNonQuery();

            //load lại dữ liệu trên form
            LoadDuLieu();
        }





        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                adap.Update((DataTable)dgvDSSanPham.DataSource);
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
