using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNHANVIENNET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-55LPTFI\SQLEXPRESS;Initial Catalog=QL_NHANVIEN_NET;Integrated Security=True;TrustServerCertificate=True");

            try
            {
                con.Open(); // Mở kết nối
                string tk = txttaikhoan.Text.Trim(); // Lấy tài khoản từ TextBox
                string mk = txtmatkhau.Text.Trim(); // Lấy mật khẩu từ TextBox

                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(tk))
                {
                    MessageBox.Show("Vui lòng nhập tài khoản!", "Thông báo");
                    txttaikhoan.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(mk))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo");
                    txtmatkhau.Focus();
                    return;
                }

                // Câu truy vấn kiểm tra thông tin đăng nhập
                string sql = "SELECT * FROM TaiKhoan where Ten_TKhoan = '" + tk + "'and Mat_Khau = '" + mk + "'";

                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();

                // Kiểm tra kết quả truy vấn
                if (dta.Read()) // Nếu có dòng kết quả trả về
                {
                    string loaitk = dta["Loai_TKhoan"].ToString();
                    if(loaitk == "Quản Lý")
                    {
                        
                    }
                    MessageBox.Show("Đăng nhập thành công! Loại tài khoản: " + loaitk, "Thông báo");
                    frmmain _frmmain = new frmmain(loaitk); // Mở form chính
                    _frmmain.Show();
                    this.Hide(); // Ẩn form đăng nhập
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo");
                    txttaikhoan.Clear();
                    txtmatkhau.Clear();
                    txttaikhoan.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Thông báo");
            }
            finally
            {
                // Đảm bảo đóng kết nối
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
