using QuanLySuaChuaXe_Entity.GUI.FormReport;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FM_QuanLySuaChuaXe : Form
    {
        public FM_QuanLySuaChuaXe()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void mnt_DangNhap_Click(object sender, System.EventArgs e)
        {
            Form_DangNhap form_DangNhap = new Form_DangNhap();
            form_DangNhap.ShowDialog();

            if (!form_DangNhap.login_Success) return;
            
            mnt_QuanLy.Enabled = true;
            mnt_ThongBao.Enabled = true;
            mnt_TaiChinh.Enabled = true;
        }

        private void mnt_DangXuat_Click(object sender, System.EventArgs e)
        {
            mnt_QuanLy.Enabled = false;
            mnt_ThongBao.Enabled = false;
            mnt_TaiChinh.Enabled = false;
        }

        private void mnt_Thoat_Click(object sender, System.EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void mnt_NhanSu_NhomTho_Click(object sender, System.EventArgs e)
        {
            FS_NhomTho form = new FS_NhomTho();
            form.ShowDialog();
        }

        private void mnt_NhanSu_Tho_Click(object sender, System.EventArgs e)
        {
            FS_Tho form = new FS_Tho();
            form.ShowDialog();
        }

        private void mnt_CongViec_NhomCongViec_Click(object sender, System.EventArgs e)
        {
            FS_NhomCongViec form = new FS_NhomCongViec();
            form.ShowDialog();
        }

        private void mnt_CongViec_CongViec_Click(object sender, System.EventArgs e)
        {
            FS_CongViec form = new FS_CongViec();
            form.ShowDialog();
        }

        private void mnt_KhachHang_KhachHang_Click(object sender, System.EventArgs e)
        {
            FS_KhachHang form = new FS_KhachHang();
            form.ShowDialog();      
        }
        private void mnt_KhachHang_HopDong_Click(object sender, System.EventArgs e)
        {
            FS_HopDong form = new FS_HopDong();
            form.ShowDialog();
        }

        private void mnt_KhachHang_PhieuThu_Click(object sender, System.EventArgs e)
        {
            FS_PhieuThu form = new FS_PhieuThu();
            form.ShowDialog();
        }

        private void mnt_TraCuu_KhachHang_Click(object sender, System.EventArgs e)
        {
            FF_KhachHang form = new FF_KhachHang();
            form.ShowDialog();
        }

        private void mnt_TraCuu_HopDong_Click(object sender, System.EventArgs e)
        {
            FF_HopDong form = new FF_HopDong();
            form.ShowDialog();
        }

        private void mnt_TracCuu_Tho_Click(object sender, System.EventArgs e)
        {
            FF_Tho form = new FF_Tho();
            form.ShowDialog();  
        }

        private void mnt_TraCuu_CongViec_Click(object sender, System.EventArgs e)
        {
            FF_CongViec form = new FF_CongViec();
            form.ShowDialog();
        }

        private void mnt_TaiChinh_DoanhThu_Click(object sender, System.EventArgs e)
        {
            DoanhThu form = new DoanhThu();
            form.ShowDialog();
        }

        private void mnt_TaiChinh_LoiNhuan_Click(object sender, System.EventArgs e)
        {
            LoiNhuan form = new LoiNhuan();
            form.ShowDialog();
        }

        private void mnt_ThongBao_Luong_Click(object sender, System.EventArgs e)
        {
            Luong form = new Luong();
            form.ShowDialog();
        }

        private void mnt_ThongBao_Thuong_Click(object sender, System.EventArgs e)
        {
            Thuong form = new Thuong();
            form.ShowDialog();
        }

        private void mntTruyThu_Click(object sender, System.EventArgs e)
        {
            TruyThu formTT = new TruyThu();
            formTT.ShowDialog();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            dpt_Time.Value = DateTime.Now;
        }
    }
}
