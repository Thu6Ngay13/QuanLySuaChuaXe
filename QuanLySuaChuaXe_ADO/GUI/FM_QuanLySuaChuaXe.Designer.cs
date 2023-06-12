using System;

namespace GUI
{
    partial class FM_QuanLySuaChuaXe
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
            this.components = new System.ComponentModel.Container();
            this.mnt_ThongBao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_ThongBao_Luong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_ThongBao_Thuong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_TraCuu_CongViec = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_TracCuu_Tho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_TraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_TraCuu_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_TraCuu_HopDong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_KhachHang_PhieuThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_KhachHang_HopDong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_KhachHang_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_NhanSu_NhomTho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_NhanSu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_NhanSu_Tho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_QuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_CongViec = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_CongViec_NhomCongViec = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_CongViec_CongViec = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_DangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnt_TaiChinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_TaiChinh_DoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_TaiChinh_LoiNhuan = new System.Windows.Forms.ToolStripMenuItem();
            this.mntTruyThu = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // mnt_ThongBao
            // 
            this.mnt_ThongBao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnt_ThongBao_Luong,
            this.mnt_ThongBao_Thuong});
            this.mnt_ThongBao.Enabled = false;
            this.mnt_ThongBao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnt_ThongBao.Name = "mnt_ThongBao";
            this.mnt_ThongBao.Size = new System.Drawing.Size(112, 27);
            this.mnt_ThongBao.Text = "Thông báo";
            // 
            // mnt_ThongBao_Luong
            // 
            this.mnt_ThongBao_Luong.Name = "mnt_ThongBao_Luong";
            this.mnt_ThongBao_Luong.Size = new System.Drawing.Size(160, 28);
            this.mnt_ThongBao_Luong.Text = "Lương";
            this.mnt_ThongBao_Luong.Click += new System.EventHandler(this.mnt_ThongBao_Luong_Click);
            // 
            // mnt_ThongBao_Thuong
            // 
            this.mnt_ThongBao_Thuong.Name = "mnt_ThongBao_Thuong";
            this.mnt_ThongBao_Thuong.Size = new System.Drawing.Size(160, 28);
            this.mnt_ThongBao_Thuong.Text = "Thưởng";
            this.mnt_ThongBao_Thuong.Click += new System.EventHandler(this.mnt_ThongBao_Thuong_Click);
            // 
            // mnt_TraCuu_CongViec
            // 
            this.mnt_TraCuu_CongViec.Name = "mnt_TraCuu_CongViec";
            this.mnt_TraCuu_CongViec.Size = new System.Drawing.Size(192, 28);
            this.mnt_TraCuu_CongViec.Text = "Công việc";
            this.mnt_TraCuu_CongViec.Click += new System.EventHandler(this.mnt_TraCuu_CongViec_Click);
            // 
            // mnt_TracCuu_Tho
            // 
            this.mnt_TracCuu_Tho.Name = "mnt_TracCuu_Tho";
            this.mnt_TracCuu_Tho.Size = new System.Drawing.Size(192, 28);
            this.mnt_TracCuu_Tho.Text = "Thợ";
            this.mnt_TracCuu_Tho.Click += new System.EventHandler(this.mnt_TracCuu_Tho_Click);
            // 
            // mnt_TraCuu
            // 
            this.mnt_TraCuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnt_TraCuu_KhachHang,
            this.mnt_TraCuu_HopDong,
            this.mnt_TracCuu_Tho,
            this.mnt_TraCuu_CongViec});
            this.mnt_TraCuu.Name = "mnt_TraCuu";
            this.mnt_TraCuu.Size = new System.Drawing.Size(192, 28);
            this.mnt_TraCuu.Text = "Tra cứu";
            // 
            // mnt_TraCuu_KhachHang
            // 
            this.mnt_TraCuu_KhachHang.Name = "mnt_TraCuu_KhachHang";
            this.mnt_TraCuu_KhachHang.Size = new System.Drawing.Size(192, 28);
            this.mnt_TraCuu_KhachHang.Text = "Khách hàng";
            this.mnt_TraCuu_KhachHang.Click += new System.EventHandler(this.mnt_TraCuu_KhachHang_Click);
            // 
            // mnt_TraCuu_HopDong
            // 
            this.mnt_TraCuu_HopDong.Name = "mnt_TraCuu_HopDong";
            this.mnt_TraCuu_HopDong.Size = new System.Drawing.Size(192, 28);
            this.mnt_TraCuu_HopDong.Text = "Hợp đồng";
            this.mnt_TraCuu_HopDong.Click += new System.EventHandler(this.mnt_TraCuu_HopDong_Click);
            // 
            // mnt_KhachHang_PhieuThu
            // 
            this.mnt_KhachHang_PhieuThu.Name = "mnt_KhachHang_PhieuThu";
            this.mnt_KhachHang_PhieuThu.Size = new System.Drawing.Size(192, 28);
            this.mnt_KhachHang_PhieuThu.Text = "Phiếu thu";
            this.mnt_KhachHang_PhieuThu.Click += new System.EventHandler(this.mnt_KhachHang_PhieuThu_Click);
            // 
            // mnt_KhachHang_HopDong
            // 
            this.mnt_KhachHang_HopDong.Name = "mnt_KhachHang_HopDong";
            this.mnt_KhachHang_HopDong.Size = new System.Drawing.Size(192, 28);
            this.mnt_KhachHang_HopDong.Text = "Hợp đồng";
            this.mnt_KhachHang_HopDong.Click += new System.EventHandler(this.mnt_KhachHang_HopDong_Click);
            // 
            // mnt_KhachHang
            // 
            this.mnt_KhachHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnt_KhachHang_KhachHang,
            this.mnt_KhachHang_HopDong,
            this.mnt_KhachHang_PhieuThu});
            this.mnt_KhachHang.Name = "mnt_KhachHang";
            this.mnt_KhachHang.Size = new System.Drawing.Size(192, 28);
            this.mnt_KhachHang.Text = "Khách hàng";
            // 
            // mnt_KhachHang_KhachHang
            // 
            this.mnt_KhachHang_KhachHang.Name = "mnt_KhachHang_KhachHang";
            this.mnt_KhachHang_KhachHang.Size = new System.Drawing.Size(192, 28);
            this.mnt_KhachHang_KhachHang.Text = "Khách hàng";
            this.mnt_KhachHang_KhachHang.Click += new System.EventHandler(this.mnt_KhachHang_KhachHang_Click);
            // 
            // mnt_NhanSu_NhomTho
            // 
            this.mnt_NhanSu_NhomTho.Name = "mnt_NhanSu_NhomTho";
            this.mnt_NhanSu_NhomTho.Size = new System.Drawing.Size(176, 28);
            this.mnt_NhanSu_NhomTho.Text = "Nhóm thợ";
            this.mnt_NhanSu_NhomTho.Click += new System.EventHandler(this.mnt_NhanSu_NhomTho_Click);
            // 
            // mnt_NhanSu
            // 
            this.mnt_NhanSu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnt_NhanSu_NhomTho,
            this.mnt_NhanSu_Tho});
            this.mnt_NhanSu.Name = "mnt_NhanSu";
            this.mnt_NhanSu.Size = new System.Drawing.Size(192, 28);
            this.mnt_NhanSu.Text = "Nhân sự ";
            // 
            // mnt_NhanSu_Tho
            // 
            this.mnt_NhanSu_Tho.Name = "mnt_NhanSu_Tho";
            this.mnt_NhanSu_Tho.Size = new System.Drawing.Size(176, 28);
            this.mnt_NhanSu_Tho.Text = "Thợ";
            this.mnt_NhanSu_Tho.Click += new System.EventHandler(this.mnt_NhanSu_Tho_Click);
            // 
            // mnt_QuanLy
            // 
            this.mnt_QuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnt_NhanSu,
            this.mnt_CongViec,
            this.mnt_KhachHang,
            this.mnt_TraCuu});
            this.mnt_QuanLy.Enabled = false;
            this.mnt_QuanLy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnt_QuanLy.Name = "mnt_QuanLy";
            this.mnt_QuanLy.Size = new System.Drawing.Size(90, 27);
            this.mnt_QuanLy.Text = "Quản lý";
            // 
            // mnt_CongViec
            // 
            this.mnt_CongViec.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnt_CongViec_NhomCongViec,
            this.mnt_CongViec_CongViec});
            this.mnt_CongViec.Name = "mnt_CongViec";
            this.mnt_CongViec.Size = new System.Drawing.Size(192, 28);
            this.mnt_CongViec.Text = "Công việc";
            // 
            // mnt_CongViec_NhomCongViec
            // 
            this.mnt_CongViec_NhomCongViec.Name = "mnt_CongViec_NhomCongViec";
            this.mnt_CongViec_NhomCongViec.Size = new System.Drawing.Size(226, 28);
            this.mnt_CongViec_NhomCongViec.Text = "Nhóm công việc";
            this.mnt_CongViec_NhomCongViec.Click += new System.EventHandler(this.mnt_CongViec_NhomCongViec_Click);
            // 
            // mnt_CongViec_CongViec
            // 
            this.mnt_CongViec_CongViec.Name = "mnt_CongViec_CongViec";
            this.mnt_CongViec_CongViec.Size = new System.Drawing.Size(226, 28);
            this.mnt_CongViec_CongViec.Text = "Công việc";
            this.mnt_CongViec_CongViec.Click += new System.EventHandler(this.mnt_CongViec_CongViec_Click);
            // 
            // mnt_Thoat
            // 
            this.mnt_Thoat.Name = "mnt_Thoat";
            this.mnt_Thoat.Size = new System.Drawing.Size(183, 28);
            this.mnt_Thoat.Text = "Thoát";
            this.mnt_Thoat.Click += new System.EventHandler(this.mnt_Thoat_Click);
            // 
            // mnt_DangXuat
            // 
            this.mnt_DangXuat.Name = "mnt_DangXuat";
            this.mnt_DangXuat.Size = new System.Drawing.Size(183, 28);
            this.mnt_DangXuat.Text = "Đăng xuất";
            this.mnt_DangXuat.Click += new System.EventHandler(this.mnt_DangXuat_Click);
            // 
            // mnt_DangNhap
            // 
            this.mnt_DangNhap.Name = "mnt_DangNhap";
            this.mnt_DangNhap.Size = new System.Drawing.Size(183, 28);
            this.mnt_DangNhap.Text = "Đăng nhập";
            this.mnt_DangNhap.Click += new System.EventHandler(this.mnt_DangNhap_Click);
            // 
            // mnt_HeThong
            // 
            this.mnt_HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnt_DangNhap,
            this.mnt_DangXuat,
            this.mnt_Thoat});
            this.mnt_HeThong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnt_HeThong.Name = "mnt_HeThong";
            this.mnt_HeThong.Size = new System.Drawing.Size(101, 27);
            this.mnt_HeThong.Text = "Hệ thống";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnt_HeThong,
            this.mnt_QuanLy,
            this.mnt_TaiChinh,
            this.mnt_ThongBao});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnt_TaiChinh
            // 
            this.mnt_TaiChinh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnt_TaiChinh_DoanhThu,
            this.mnt_TaiChinh_LoiNhuan,
            this.mntTruyThu});
            this.mnt_TaiChinh.Enabled = false;
            this.mnt_TaiChinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnt_TaiChinh.Name = "mnt_TaiChinh";
            this.mnt_TaiChinh.Size = new System.Drawing.Size(102, 27);
            this.mnt_TaiChinh.Text = "Tài chính";
            // 
            // mnt_TaiChinh_DoanhThu
            // 
            this.mnt_TaiChinh_DoanhThu.Name = "mnt_TaiChinh_DoanhThu";
            this.mnt_TaiChinh_DoanhThu.Size = new System.Drawing.Size(180, 28);
            this.mnt_TaiChinh_DoanhThu.Text = "Doanh thu";
            this.mnt_TaiChinh_DoanhThu.Click += new System.EventHandler(this.mnt_TaiChinh_DoanhThu_Click);
            // 
            // mnt_TaiChinh_LoiNhuan
            // 
            this.mnt_TaiChinh_LoiNhuan.Name = "mnt_TaiChinh_LoiNhuan";
            this.mnt_TaiChinh_LoiNhuan.Size = new System.Drawing.Size(180, 28);
            this.mnt_TaiChinh_LoiNhuan.Text = "Lợi nhuận";
            this.mnt_TaiChinh_LoiNhuan.Click += new System.EventHandler(this.mnt_TaiChinh_LoiNhuan_Click);
            // 
            // mntTruyThu
            // 
            this.mntTruyThu.Name = "mntTruyThu";
            this.mntTruyThu.Size = new System.Drawing.Size(180, 28);
            this.mntTruyThu.Text = "Truy thu";
            this.mntTruyThu.Click += new System.EventHandler(this.mntTruyThu_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnl_main.Controls.Add(this.dtp_Time);
            this.pnl_main.Controls.Add(this.logo);
            this.pnl_main.Controls.Add(this.label3);
            this.pnl_main.Controls.Add(this.menuStrip1);
            this.pnl_main.Location = new System.Drawing.Point(10, 14);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1034, 624);
            this.pnl_main.TabIndex = 1;
            // 
            // dtp_Time
            // 
            this.dtp_Time.CustomFormat = "dd-MM-yyyy HH:MM:ss";
            this.dtp_Time.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Time.Location = new System.Drawing.Point(755, 584);
            this.dtp_Time.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.Size = new System.Drawing.Size(276, 34);
            this.dtp_Time.TabIndex = 7;
            this.dtp_Time.Value = new System.DateTime(2023, 6, 4, 16, 51, 25, 31);
            // 
            // logo
            // 
            this.logo.Image = global::QuanLySuaChuaXe_ADO.Properties.Resources._1200px_Hcmute_svg;
            this.logo.Location = new System.Drawing.Point(385, 73);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(264, 314);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1028, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "HỆ THỐNG QUẢN LÍ CỬA HÀNG SỬA CHỮA XE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FM_QuanLySuaChuaXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 644);
            this.Controls.Add(this.pnl_main);
            this.Name = "FM_QuanLySuaChuaXe";
            this.Text = "ADO_Version";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnt_ThongBao;
        private System.Windows.Forms.ToolStripMenuItem mnt_TraCuu_CongViec;
        private System.Windows.Forms.ToolStripMenuItem mnt_TracCuu_Tho;
        private System.Windows.Forms.ToolStripMenuItem mnt_TraCuu;
        private System.Windows.Forms.ToolStripMenuItem mnt_TraCuu_HopDong;
        private System.Windows.Forms.ToolStripMenuItem mnt_KhachHang_PhieuThu;
        private System.Windows.Forms.ToolStripMenuItem mnt_KhachHang_HopDong;
        private System.Windows.Forms.ToolStripMenuItem mnt_KhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnt_NhanSu_NhomTho;
        private System.Windows.Forms.ToolStripMenuItem mnt_NhanSu;
        private System.Windows.Forms.ToolStripMenuItem mnt_NhanSu_Tho;
        private System.Windows.Forms.ToolStripMenuItem mnt_QuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnt_Thoat;
        private System.Windows.Forms.ToolStripMenuItem mnt_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnt_DangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnt_HeThong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.ToolStripMenuItem mnt_ThongBao_Luong;
        private System.Windows.Forms.ToolStripMenuItem mnt_TaiChinh;
        private System.Windows.Forms.ToolStripMenuItem mnt_ThongBao_Thuong;
        private System.Windows.Forms.ToolStripMenuItem mnt_TaiChinh_DoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnt_TaiChinh_LoiNhuan;
        private System.Windows.Forms.ToolStripMenuItem mnt_CongViec;
        private System.Windows.Forms.ToolStripMenuItem mnt_CongViec_CongViec;
        private System.Windows.Forms.ToolStripMenuItem mnt_CongViec_NhomCongViec;
        private System.Windows.Forms.ToolStripMenuItem mntTruyThu;
        private System.Windows.Forms.ToolStripMenuItem mnt_TraCuu_KhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnt_KhachHang_KhachHang;
        private System.Windows.Forms.DateTimePicker dtp_Time;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}

