using System;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class Form_DangNhap : Form
    {
        public bool login_Success = false;

        public Form_DangNhap()
        {
            InitializeComponent();
        }

        private void txt_TenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txt_MatKhau.Focus();
        }

        private void txt_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btn_DangNhap.Focus();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            BLL_DangNhap bll_DangNhap = new BLL_DangNhap();
            login_Success = bll_DangNhap.AuthenticateUser(txt_TenDangNhap.Text, txt_MatKhau.Text);

            if (login_Success)
            {
                MessageBox.Show(
                    "Đăng nhập thành công!", 
                    "Thông báo", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Nhập sai thông tin rồi, nhập lại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.txt_TenDangNhap.Focus();
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
