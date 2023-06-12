using System;

namespace GUI
{
    partial class FI_PhieuThu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grb_ThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.txt_SoTienThu_PhieuThu = new System.Windows.Forms.TextBox();
            this.lbl_SoTienThu_PhieuThu = new System.Windows.Forms.Label();
            this.txt_HoTenNguoiNop_PhieuThu = new System.Windows.Forms.TextBox();
            this.txt_HoTenNguoiThu_PhieuThu = new System.Windows.Forms.TextBox();
            this.lbl_HoTenNguoiNop_PhieuThu = new System.Windows.Forms.Label();
            this.lbl_HoTenNguoiThu_PhieuThu = new System.Windows.Forms.Label();
            this.btn_Quaylai = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.lbl_PhieuThu = new System.Windows.Forms.Label();
            this.grb_ThongTinChung = new System.Windows.Forms.GroupBox();
            this.dtp_NgayThu_PhieuThu = new System.Windows.Forms.DateTimePicker();
            this.lbl_NgayThu_PhieuThu = new System.Windows.Forms.Label();
            this.pnl_HopDong = new System.Windows.Forms.Panel();
            this.lbl_HopDong = new System.Windows.Forms.Label();
            this.trv_HopDong = new System.Windows.Forms.TreeView();
            this.txt_ID_PhieuThu = new System.Windows.Forms.TextBox();
            this.lbl_ID_PhieuThu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grb_ThongTinChiTiet.SuspendLayout();
            this.grb_ThongTinChung.SuspendLayout();
            this.pnl_HopDong.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grb_ThongTinChiTiet);
            this.panel1.Controls.Add(this.lbl_PhieuThu);
            this.panel1.Controls.Add(this.grb_ThongTinChung);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 438);
            this.panel1.TabIndex = 0;
            // 
            // grb_ThongTinChiTiet
            // 
            this.grb_ThongTinChiTiet.Controls.Add(this.txt_SoTienThu_PhieuThu);
            this.grb_ThongTinChiTiet.Controls.Add(this.lbl_SoTienThu_PhieuThu);
            this.grb_ThongTinChiTiet.Controls.Add(this.txt_HoTenNguoiNop_PhieuThu);
            this.grb_ThongTinChiTiet.Controls.Add(this.txt_HoTenNguoiThu_PhieuThu);
            this.grb_ThongTinChiTiet.Controls.Add(this.lbl_HoTenNguoiNop_PhieuThu);
            this.grb_ThongTinChiTiet.Controls.Add(this.lbl_HoTenNguoiThu_PhieuThu);
            this.grb_ThongTinChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_ThongTinChiTiet.Location = new System.Drawing.Point(9, 213);
            this.grb_ThongTinChiTiet.Name = "grb_ThongTinChiTiet";
            this.grb_ThongTinChiTiet.Size = new System.Drawing.Size(775, 222);
            this.grb_ThongTinChiTiet.TabIndex = 12;
            this.grb_ThongTinChiTiet.TabStop = false;
            this.grb_ThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // txt_SoTienThu_PhieuThu
            // 
            this.txt_SoTienThu_PhieuThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoTienThu_PhieuThu.Location = new System.Drawing.Point(271, 161);
            this.txt_SoTienThu_PhieuThu.Name = "txt_SoTienThu_PhieuThu";
            this.txt_SoTienThu_PhieuThu.Size = new System.Drawing.Size(373, 30);
            this.txt_SoTienThu_PhieuThu.TabIndex = 7;
            // 
            // lbl_SoTienThu_PhieuThu
            // 
            this.lbl_SoTienThu_PhieuThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoTienThu_PhieuThu.Location = new System.Drawing.Point(84, 161);
            this.lbl_SoTienThu_PhieuThu.Name = "lbl_SoTienThu_PhieuThu";
            this.lbl_SoTienThu_PhieuThu.Size = new System.Drawing.Size(155, 23);
            this.lbl_SoTienThu_PhieuThu.TabIndex = 6;
            this.lbl_SoTienThu_PhieuThu.Text = "Số tiền thu";
            // 
            // txt_HoTenNguoiNop_PhieuThu
            // 
            this.txt_HoTenNguoiNop_PhieuThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTenNguoiNop_PhieuThu.Location = new System.Drawing.Point(271, 106);
            this.txt_HoTenNguoiNop_PhieuThu.Name = "txt_HoTenNguoiNop_PhieuThu";
            this.txt_HoTenNguoiNop_PhieuThu.Size = new System.Drawing.Size(373, 30);
            this.txt_HoTenNguoiNop_PhieuThu.TabIndex = 5;
            // 
            // txt_HoTenNguoiThu_PhieuThu
            // 
            this.txt_HoTenNguoiThu_PhieuThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTenNguoiThu_PhieuThu.Location = new System.Drawing.Point(271, 47);
            this.txt_HoTenNguoiThu_PhieuThu.Name = "txt_HoTenNguoiThu_PhieuThu";
            this.txt_HoTenNguoiThu_PhieuThu.Size = new System.Drawing.Size(373, 30);
            this.txt_HoTenNguoiThu_PhieuThu.TabIndex = 3;
            // 
            // lbl_HoTenNguoiNop_PhieuThu
            // 
            this.lbl_HoTenNguoiNop_PhieuThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTenNguoiNop_PhieuThu.Location = new System.Drawing.Point(84, 106);
            this.lbl_HoTenNguoiNop_PhieuThu.Name = "lbl_HoTenNguoiNop_PhieuThu";
            this.lbl_HoTenNguoiNop_PhieuThu.Size = new System.Drawing.Size(181, 23);
            this.lbl_HoTenNguoiNop_PhieuThu.TabIndex = 4;
            this.lbl_HoTenNguoiNop_PhieuThu.Text = "Họ tên người nộp";
            // 
            // lbl_HoTenNguoiThu_PhieuThu
            // 
            this.lbl_HoTenNguoiThu_PhieuThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTenNguoiThu_PhieuThu.Location = new System.Drawing.Point(84, 54);
            this.lbl_HoTenNguoiThu_PhieuThu.Name = "lbl_HoTenNguoiThu_PhieuThu";
            this.lbl_HoTenNguoiThu_PhieuThu.Size = new System.Drawing.Size(155, 23);
            this.lbl_HoTenNguoiThu_PhieuThu.TabIndex = 1;
            this.lbl_HoTenNguoiThu_PhieuThu.Text = "Họ tên người thu";
            // 
            // btn_Quaylai
            // 
            this.btn_Quaylai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quaylai.Location = new System.Drawing.Point(627, 456);
            this.btn_Quaylai.Name = "btn_Quaylai";
            this.btn_Quaylai.Size = new System.Drawing.Size(136, 42);
            this.btn_Quaylai.TabIndex = 10;
            this.btn_Quaylai.Text = "Quay lại";
            this.btn_Quaylai.UseVisualStyleBackColor = true;
            this.btn_Quaylai.Click += new System.EventHandler(this.btn_Quaylai_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(358, 456);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(136, 42);
            this.btn_Luu.TabIndex = 9;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // lbl_PhieuThu
            // 
            this.lbl_PhieuThu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_PhieuThu.Location = new System.Drawing.Point(3, 6);
            this.lbl_PhieuThu.Name = "lbl_PhieuThu";
            this.lbl_PhieuThu.Size = new System.Drawing.Size(787, 35);
            this.lbl_PhieuThu.TabIndex = 8;
            this.lbl_PhieuThu.Text = "PHIẾU THU";
            this.lbl_PhieuThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grb_ThongTinChung
            // 
            this.grb_ThongTinChung.Controls.Add(this.txt_ID_PhieuThu);
            this.grb_ThongTinChung.Controls.Add(this.lbl_ID_PhieuThu);
            this.grb_ThongTinChung.Controls.Add(this.dtp_NgayThu_PhieuThu);
            this.grb_ThongTinChung.Controls.Add(this.lbl_NgayThu_PhieuThu);
            this.grb_ThongTinChung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_ThongTinChung.Location = new System.Drawing.Point(9, 41);
            this.grb_ThongTinChung.Name = "grb_ThongTinChung";
            this.grb_ThongTinChung.Size = new System.Drawing.Size(775, 166);
            this.grb_ThongTinChung.TabIndex = 11;
            this.grb_ThongTinChung.TabStop = false;
            this.grb_ThongTinChung.Text = "Thông tin chung";
            // 
            // dtp_NgayThu_PhieuThu
            // 
            this.dtp_NgayThu_PhieuThu.CustomFormat = "dd-MM-yyyy";
            this.dtp_NgayThu_PhieuThu.Enabled = false;
            this.dtp_NgayThu_PhieuThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayThu_PhieuThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayThu_PhieuThu.Location = new System.Drawing.Point(271, 109);
            this.dtp_NgayThu_PhieuThu.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayThu_PhieuThu.Name = "dtp_NgayThu_PhieuThu";
            this.dtp_NgayThu_PhieuThu.Size = new System.Drawing.Size(373, 30);
            this.dtp_NgayThu_PhieuThu.TabIndex = 5;
            this.dtp_NgayThu_PhieuThu.Value = DateTime.Now;
            // 
            // lbl_NgayThu_PhieuThu
            // 
            this.lbl_NgayThu_PhieuThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayThu_PhieuThu.Location = new System.Drawing.Point(84, 114);
            this.lbl_NgayThu_PhieuThu.Name = "lbl_NgayThu_PhieuThu";
            this.lbl_NgayThu_PhieuThu.Size = new System.Drawing.Size(135, 23);
            this.lbl_NgayThu_PhieuThu.TabIndex = 4;
            this.lbl_NgayThu_PhieuThu.Text = "Ngày thu";
            // 
            // pnl_HopDong
            // 
            this.pnl_HopDong.Controls.Add(this.lbl_HopDong);
            this.pnl_HopDong.Controls.Add(this.trv_HopDong);
            this.pnl_HopDong.Location = new System.Drawing.Point(803, 3);
            this.pnl_HopDong.Name = "pnl_HopDong";
            this.pnl_HopDong.Size = new System.Drawing.Size(334, 438);
            this.pnl_HopDong.TabIndex = 26;
            // 
            // lbl_HopDong
            // 
            this.lbl_HopDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_HopDong.Location = new System.Drawing.Point(3, 1);
            this.lbl_HopDong.Name = "lbl_HopDong";
            this.lbl_HopDong.Size = new System.Drawing.Size(328, 35);
            this.lbl_HopDong.TabIndex = 31;
            this.lbl_HopDong.Text = "HỢP ĐỒNG";
            this.lbl_HopDong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trv_HopDong
            // 
            this.trv_HopDong.CheckBoxes = true;
            this.trv_HopDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trv_HopDong.Location = new System.Drawing.Point(3, 39);
            this.trv_HopDong.Name = "trv_HopDong";
            this.trv_HopDong.Size = new System.Drawing.Size(328, 396);
            this.trv_HopDong.TabIndex = 30;
            this.trv_HopDong.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trv_HopDong_AfterCheck);
            // 
            // txt_ID_PhieuThu
            // 
            this.txt_ID_PhieuThu.Enabled = false;
            this.txt_ID_PhieuThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID_PhieuThu.Location = new System.Drawing.Point(271, 52);
            this.txt_ID_PhieuThu.Name = "txt_ID_PhieuThu";
            this.txt_ID_PhieuThu.Size = new System.Drawing.Size(373, 30);
            this.txt_ID_PhieuThu.TabIndex = 7;
            // 
            // lbl_ID_PhieuThu
            // 
            this.lbl_ID_PhieuThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_PhieuThu.Location = new System.Drawing.Point(84, 56);
            this.lbl_ID_PhieuThu.Name = "lbl_ID_PhieuThu";
            this.lbl_ID_PhieuThu.Size = new System.Drawing.Size(155, 23);
            this.lbl_ID_PhieuThu.TabIndex = 6;
            this.lbl_ID_PhieuThu.Text = "ID phiếu thu";
            // 
            // FI_PhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 514);
            this.Controls.Add(this.pnl_HopDong);
            this.Controls.Add(this.btn_Quaylai);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.panel1);
            this.Name = "FI_PhieuThu";
            this.Text = "Thanh Toán";
            this.panel1.ResumeLayout(false);
            this.grb_ThongTinChiTiet.ResumeLayout(false);
            this.grb_ThongTinChiTiet.PerformLayout();
            this.grb_ThongTinChung.ResumeLayout(false);
            this.grb_ThongTinChung.PerformLayout();
            this.pnl_HopDong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grb_ThongTinChiTiet;
        private System.Windows.Forms.TextBox txt_SoTienThu_PhieuThu;
        private System.Windows.Forms.Label lbl_SoTienThu_PhieuThu;
        private System.Windows.Forms.TextBox txt_HoTenNguoiNop_PhieuThu;
        private System.Windows.Forms.TextBox txt_HoTenNguoiThu_PhieuThu;
        private System.Windows.Forms.Label lbl_HoTenNguoiNop_PhieuThu;
        private System.Windows.Forms.Label lbl_HoTenNguoiThu_PhieuThu;
        private System.Windows.Forms.Button btn_Quaylai;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label lbl_PhieuThu;
        private System.Windows.Forms.GroupBox grb_ThongTinChung;
        private System.Windows.Forms.DateTimePicker dtp_NgayThu_PhieuThu;
        private System.Windows.Forms.Label lbl_NgayThu_PhieuThu;
        private System.Windows.Forms.Panel pnl_HopDong;
        private System.Windows.Forms.Label lbl_HopDong;
        private System.Windows.Forms.TreeView trv_HopDong;
        private System.Windows.Forms.TextBox txt_ID_PhieuThu;
        private System.Windows.Forms.Label lbl_ID_PhieuThu;
    }
}