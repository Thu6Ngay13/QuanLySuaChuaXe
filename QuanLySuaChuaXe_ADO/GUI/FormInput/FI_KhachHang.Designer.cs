using System;

namespace GUI
{
    partial class FI_KhachHang
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
        /// Required meKhachHangd for Designer support - do not modify
        /// the contents of this meKhachHangd with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_KhachHang = new System.Windows.Forms.Panel();
            this.rdb_GioiTinh_KhachHang_Nu = new System.Windows.Forms.RadioButton();
            this.rdb_GioiTinh_KhachHang_Nam = new System.Windows.Forms.RadioButton();
            this.dtp_NgaySinh_KhachHang = new System.Windows.Forms.DateTimePicker();
            this.txt_SoDienThoai_KhachHang = new System.Windows.Forms.TextBox();
            this.txt_HoTen_KhachHang = new System.Windows.Forms.TextBox();
            this.txt_ID_KhachHang = new System.Windows.Forms.TextBox();
            this.lbl_SoDienThoai_KhachHang = new System.Windows.Forms.Label();
            this.lbl_NgaySinh_KhachHang = new System.Windows.Forms.Label();
            this.lbl_GioiTinh_KhachHang = new System.Windows.Forms.Label();
            this.lbl_HoTen_KhachHang = new System.Windows.Forms.Label();
            this.lbl_ID_KhachHang = new System.Windows.Forms.Label();
            this.lbl_KhachHang = new System.Windows.Forms.Label();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.pnl_KhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_KhachHang
            // 
            this.pnl_KhachHang.Controls.Add(this.rdb_GioiTinh_KhachHang_Nu);
            this.pnl_KhachHang.Controls.Add(this.rdb_GioiTinh_KhachHang_Nam);
            this.pnl_KhachHang.Controls.Add(this.dtp_NgaySinh_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.txt_SoDienThoai_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.txt_HoTen_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.txt_ID_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.lbl_SoDienThoai_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.lbl_NgaySinh_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.lbl_GioiTinh_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.lbl_HoTen_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.lbl_ID_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.lbl_KhachHang);
            this.pnl_KhachHang.Location = new System.Drawing.Point(12, 12);
            this.pnl_KhachHang.Name = "pnl_KhachHang";
            this.pnl_KhachHang.Size = new System.Drawing.Size(1018, 408);
            this.pnl_KhachHang.TabIndex = 0;
            // 
            // rdb_GioiTinh_KhachHang_Nu
            // 
            this.rdb_GioiTinh_KhachHang_Nu.AutoSize = true;
            this.rdb_GioiTinh_KhachHang_Nu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_GioiTinh_KhachHang_Nu.Location = new System.Drawing.Point(626, 191);
            this.rdb_GioiTinh_KhachHang_Nu.Name = "rdb_GioiTinh_KhachHang_Nu";
            this.rdb_GioiTinh_KhachHang_Nu.Size = new System.Drawing.Size(57, 27);
            this.rdb_GioiTinh_KhachHang_Nu.TabIndex = 25;
            this.rdb_GioiTinh_KhachHang_Nu.Text = "Nữ";
            this.rdb_GioiTinh_KhachHang_Nu.UseVisualStyleBackColor = true;
            // 
            // rdb_GioiTinh_KhachHang_Nam
            // 
            this.rdb_GioiTinh_KhachHang_Nam.AutoSize = true;
            this.rdb_GioiTinh_KhachHang_Nam.Checked = true;
            this.rdb_GioiTinh_KhachHang_Nam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_GioiTinh_KhachHang_Nam.Location = new System.Drawing.Point(427, 191);
            this.rdb_GioiTinh_KhachHang_Nam.Name = "rdb_GioiTinh_KhachHang_Nam";
            this.rdb_GioiTinh_KhachHang_Nam.Size = new System.Drawing.Size(70, 27);
            this.rdb_GioiTinh_KhachHang_Nam.TabIndex = 24;
            this.rdb_GioiTinh_KhachHang_Nam.TabStop = true;
            this.rdb_GioiTinh_KhachHang_Nam.Text = "Nam";
            this.rdb_GioiTinh_KhachHang_Nam.UseVisualStyleBackColor = true;
            // 
            // dtp_NgaySinh_KhachHang
            // 
            this.dtp_NgaySinh_KhachHang.CustomFormat = "dd-MM-yyyy";
            this.dtp_NgaySinh_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh_KhachHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh_KhachHang.Location = new System.Drawing.Point(424, 244);
            this.dtp_NgaySinh_KhachHang.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtp_NgaySinh_KhachHang.Name = "dtp_NgaySinh_KhachHang";
            this.dtp_NgaySinh_KhachHang.Size = new System.Drawing.Size(422, 30);
            this.dtp_NgaySinh_KhachHang.TabIndex = 23;
            this.dtp_NgaySinh_KhachHang.Value = DateTime.Now;
            // 
            // txt_SoDienThoai_KhachHang
            // 
            this.txt_SoDienThoai_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDienThoai_KhachHang.Location = new System.Drawing.Point(424, 300);
            this.txt_SoDienThoai_KhachHang.Name = "txt_SoDienThoai_KhachHang";
            this.txt_SoDienThoai_KhachHang.Size = new System.Drawing.Size(422, 30);
            this.txt_SoDienThoai_KhachHang.TabIndex = 22;
            // 
            // txt_HoTen_KhachHang
            // 
            this.txt_HoTen_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen_KhachHang.Location = new System.Drawing.Point(424, 135);
            this.txt_HoTen_KhachHang.Name = "txt_HoTen_KhachHang";
            this.txt_HoTen_KhachHang.Size = new System.Drawing.Size(422, 30);
            this.txt_HoTen_KhachHang.TabIndex = 21;
            // 
            // txt_ID_KhachHang
            // 
            this.txt_ID_KhachHang.Enabled = false;
            this.txt_ID_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID_KhachHang.Location = new System.Drawing.Point(422, 79);
            this.txt_ID_KhachHang.Name = "txt_ID_KhachHang";
            this.txt_ID_KhachHang.Size = new System.Drawing.Size(422, 30);
            this.txt_ID_KhachHang.TabIndex = 20;
            // 
            // lbl_SoDienThoai_KhachHang
            // 
            this.lbl_SoDienThoai_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoDienThoai_KhachHang.Location = new System.Drawing.Point(172, 299);
            this.lbl_SoDienThoai_KhachHang.Name = "lbl_SoDienThoai_KhachHang";
            this.lbl_SoDienThoai_KhachHang.Size = new System.Drawing.Size(187, 30);
            this.lbl_SoDienThoai_KhachHang.TabIndex = 19;
            this.lbl_SoDienThoai_KhachHang.Text = "Số điện thoại";
            this.lbl_SoDienThoai_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NgaySinh_KhachHang
            // 
            this.lbl_NgaySinh_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh_KhachHang.Location = new System.Drawing.Point(172, 244);
            this.lbl_NgaySinh_KhachHang.Name = "lbl_NgaySinh_KhachHang";
            this.lbl_NgaySinh_KhachHang.Size = new System.Drawing.Size(187, 30);
            this.lbl_NgaySinh_KhachHang.TabIndex = 18;
            this.lbl_NgaySinh_KhachHang.Text = "Ngày sinh";
            this.lbl_NgaySinh_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GioiTinh_KhachHang
            // 
            this.lbl_GioiTinh_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh_KhachHang.Location = new System.Drawing.Point(172, 189);
            this.lbl_GioiTinh_KhachHang.Name = "lbl_GioiTinh_KhachHang";
            this.lbl_GioiTinh_KhachHang.Size = new System.Drawing.Size(187, 30);
            this.lbl_GioiTinh_KhachHang.TabIndex = 17;
            this.lbl_GioiTinh_KhachHang.Text = "Giới tính";
            this.lbl_GioiTinh_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_HoTen_KhachHang
            // 
            this.lbl_HoTen_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen_KhachHang.Location = new System.Drawing.Point(172, 134);
            this.lbl_HoTen_KhachHang.Name = "lbl_HoTen_KhachHang";
            this.lbl_HoTen_KhachHang.Size = new System.Drawing.Size(187, 30);
            this.lbl_HoTen_KhachHang.TabIndex = 16;
            this.lbl_HoTen_KhachHang.Text = "Họ tên khách hàng";
            this.lbl_HoTen_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ID_KhachHang
            // 
            this.lbl_ID_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_KhachHang.Location = new System.Drawing.Point(172, 79);
            this.lbl_ID_KhachHang.Name = "lbl_ID_KhachHang";
            this.lbl_ID_KhachHang.Size = new System.Drawing.Size(187, 30);
            this.lbl_ID_KhachHang.TabIndex = 15;
            this.lbl_ID_KhachHang.Text = "ID khách hàng";
            this.lbl_ID_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_KhachHang
            // 
            this.lbl_KhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KhachHang.Location = new System.Drawing.Point(3, 6);
            this.lbl_KhachHang.Name = "lbl_KhachHang";
            this.lbl_KhachHang.Size = new System.Drawing.Size(1012, 35);
            this.lbl_KhachHang.TabIndex = 0;
            this.lbl_KhachHang.Text = "NHẬP THÔNG KHÁCH HÀNG";
            this.lbl_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLai.Location = new System.Drawing.Point(576, 438);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(146, 36);
            this.btn_QuayLai.TabIndex = 23;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLaiKhachHang_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(353, 438);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(146, 36);
            this.btn_Luu.TabIndex = 22;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_LuuKhachHang_Click);
            // 
            // FI_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 486);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.pnl_KhachHang);
            this.Name = "FI_KhachHang";
            this.Text = "FI_KhachHang";
            this.pnl_KhachHang.ResumeLayout(false);
            this.pnl_KhachHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_KhachHang;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label lbl_KhachHang;
        private System.Windows.Forms.RadioButton rdb_GioiTinh_KhachHang_Nu;
        private System.Windows.Forms.RadioButton rdb_GioiTinh_KhachHang_Nam;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh_KhachHang;
        private System.Windows.Forms.TextBox txt_SoDienThoai_KhachHang;
        private System.Windows.Forms.TextBox txt_HoTen_KhachHang;
        private System.Windows.Forms.TextBox txt_ID_KhachHang;
        private System.Windows.Forms.Label lbl_SoDienThoai_KhachHang;
        private System.Windows.Forms.Label lbl_NgaySinh_KhachHang;
        private System.Windows.Forms.Label lbl_GioiTinh_KhachHang;
        private System.Windows.Forms.Label lbl_HoTen_KhachHang;
        private System.Windows.Forms.Label lbl_ID_KhachHang;
    }
}