using fightCrypto.Forms;
using fightCrypto.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Đảm bảo namespace này khớp với namespace trong file Designer
namespace WinFormsAppLogin
{
    public partial class Modau : Form
    {
        private AutoResizer _resizer;
        public Modau()
        {
            InitializeComponent();

            // Chúng ta gán sự kiện Click ở đây thay vì trong Designer
            // để giữ file designer sạch sẽ.
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // Gán sự kiện cho các nút trên panel Đăng Ký
            this.btnConfirmRegister.Click += new System.EventHandler(this.btnConfirmRegister_Click);
            this.btnGoToLogin.Click += new System.EventHandler(this.btnGoToLogin_Click);

            // Mặc định, ẩn panel đăng ký khi khởi động
            this.panelRegister.Visible = false;
        }

        /// <summary>
        /// Xử lý sự kiện khi bấm nút Đăng nhập (trên panel Đăng nhập)
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string emailOrUser = this.txtEmail.Text;
            string password = this.txtPassword.Text;

            // Ví dụ tài khoản test
            if (emailOrUser == "admin" && password == "123")
            {
                // Mở form Trangchu
                Trangchu trangchu = new Trangchu();
                trangchu.Show();

                // Ẩn form hiện tại (hoặc Close nếu muốn)
                this.Hide();
            }
            else
            {
                MessageBox.Show(" MÀY BỊ NGU À ", "Thông báo");
            }
        }

        /// <summary>
        /// Xử lý sự kiện khi bấm nút Đăng ký (trên panel Đăng nhập)
        /// </summary>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Ẩn panel đăng nhập, hiện panel đăng ký
            this.panelContainer.Visible = false;
            this.panelRegister.Visible = true;
        }

        private void btnConfirmRegister_Click(object sender, EventArgs e)
        {
           
            string tenNguoiDung = this.txtRegUser.Text;
            string gmail = this.txtRegGmail.Text;
            string matKhau = this.txtRegPass.Text;


            MessageBox.Show("Đăng ký thành công! Vui lòng đăng nhập.", "Thành công");

            // Quay lại màn hình đăng nhập
            this.panelRegister.Visible = false;
            this.panelContainer.Visible = true;
        }

      
        private void btnGoToLogin_Click(object sender, EventArgs e)
        {
            // Ẩn panel đăng ký, hiện panel đăng nhập
            this.panelRegister.Visible = false;
            this.panelContainer.Visible = true;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // (Code xử lý của bạn)
        }
    }
}