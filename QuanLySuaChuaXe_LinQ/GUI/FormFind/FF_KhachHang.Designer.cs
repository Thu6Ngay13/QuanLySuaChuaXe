using System;

namespace GUI
{
    partial class FF_KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_KhachHang = new System.Windows.Forms.Panel();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.col_ID_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoTen_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgaySinh_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoDienThoai_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdb_GioiTinh_KhachHang_Nu = new System.Windows.Forms.RadioButton();
            this.rdb_GioiTinh_KhachHang_Nam = new System.Windows.Forms.RadioButton();
            this.dtp_NgaySinh_KhachHang = new System.Windows.Forms.DateTimePicker();
            this.txt_SoDienThoai_KhachHang = new System.Windows.Forms.TextBox();
            this.txt_HoTen_KhachHang = new System.Windows.Forms.TextBox();
            this.txt_ID_KhachHang = new System.Windows.Forms.TextBox();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.lbl_SoDienThoai_KhachHang = new System.Windows.Forms.Label();
            this.lbl_NgaySinh_KhachHang = new System.Windows.Forms.Label();
            this.lbl_GioiTinh_KhachHang = new System.Windows.Forms.Label();
            this.lbl_HoTen_KhachHang = new System.Windows.Forms.Label();
            this.lbl_ID_KhachHang = new System.Windows.Forms.Label();
            this.lbl_KhachHang = new System.Windows.Forms.Label();
            this.pnl_KhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_KhachHang
            // 
            this.pnl_KhachHang.Controls.Add(this.dgv_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.rdb_GioiTinh_KhachHang_Nu);
            this.pnl_KhachHang.Controls.Add(this.rdb_GioiTinh_KhachHang_Nam);
            this.pnl_KhachHang.Controls.Add(this.dtp_NgaySinh_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.txt_SoDienThoai_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.txt_HoTen_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.txt_ID_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.btn_QuayLai);
            this.pnl_KhachHang.Controls.Add(this.btn_TimKiem);
            this.pnl_KhachHang.Controls.Add(this.lbl_SoDienThoai_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.lbl_NgaySinh_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.lbl_GioiTinh_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.lbl_HoTen_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.lbl_ID_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.lbl_KhachHang);
            this.pnl_KhachHang.Location = new System.Drawing.Point(10, 6);
            this.pnl_KhachHang.Name = "pnl_KhachHang";
            this.pnl_KhachHang.Size = new System.Drawing.Size(1000, 668);
            this.pnl_KhachHang.TabIndex = 0;
            // 
            // dgv_KhachHang
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_KhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID_KhachHang,
            this.col_HoTen_KhachHang,
            this.col_GioiTinh_KhachHang,
            this.col_NgaySinh_KhachHang,
            this.col_SoDienThoai_KhachHang});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "dd-MM-yyyy";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_KhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_KhachHang.Location = new System.Drawing.Point(0, 387);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.ReadOnly = true;
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.RowTemplate.Height = 24;
            this.dgv_KhachHang.Size = new System.Drawing.Size(994, 214);
            this.dgv_KhachHang.TabIndex = 15;
            this.dgv_KhachHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_FF_KhachHang_CellFormatting);
            // 
            // col_ID_KhachHang
            // 
            this.col_ID_KhachHang.DataPropertyName = "ID_KhachHang";
            this.col_ID_KhachHang.HeaderText = "ID khách hàng";
            this.col_ID_KhachHang.MinimumWidth = 6;
            this.col_ID_KhachHang.Name = "col_ID_KhachHang";
            this.col_ID_KhachHang.ReadOnly = true;
            // 
            // col_HoTen_KhachHang
            // 
            this.col_HoTen_KhachHang.DataPropertyName = "HoTen_KhachHang";
            this.col_HoTen_KhachHang.HeaderText = "Họ tên";
            this.col_HoTen_KhachHang.MinimumWidth = 6;
            this.col_HoTen_KhachHang.Name = "col_HoTen_KhachHang";
            this.col_HoTen_KhachHang.ReadOnly = true;
            // 
            // col_GioiTinh_KhachHang
            // 
            this.col_GioiTinh_KhachHang.DataPropertyName = "GioiTinh_KhachHang";
            this.col_GioiTinh_KhachHang.HeaderText = "Giới tính";
            this.col_GioiTinh_KhachHang.MinimumWidth = 6;
            this.col_GioiTinh_KhachHang.Name = "col_GioiTinh_KhachHang";
            this.col_GioiTinh_KhachHang.ReadOnly = true;
            // 
            // col_NgaySinh_KhachHang
            // 
            this.col_NgaySinh_KhachHang.DataPropertyName = "NgaySinh_KhachHang";
            this.col_NgaySinh_KhachHang.HeaderText = "Ngày sinh";
            this.col_NgaySinh_KhachHang.MinimumWidth = 6;
            this.col_NgaySinh_KhachHang.Name = "col_NgaySinh_KhachHang";
            this.col_NgaySinh_KhachHang.ReadOnly = true;
            // 
            // col_SoDienThoai_KhachHang
            // 
            this.col_SoDienThoai_KhachHang.DataPropertyName = "SoDienThoai_KhachHang";
            this.col_SoDienThoai_KhachHang.HeaderText = "Số điện thoại";
            this.col_SoDienThoai_KhachHang.MinimumWidth = 6;
            this.col_SoDienThoai_KhachHang.Name = "col_SoDienThoai_KhachHang";
            this.col_SoDienThoai_KhachHang.ReadOnly = true;
            // 
            // rdb_GioiTinh_KhachHang_Nu
            // 
            this.rdb_GioiTinh_KhachHang_Nu.AutoSize = true;
            this.rdb_GioiTinh_KhachHang_Nu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_GioiTinh_KhachHang_Nu.Location = new System.Drawing.Point(603, 164);
            this.rdb_GioiTinh_KhachHang_Nu.Name = "rdb_GioiTinh_KhachHang_Nu";
            this.rdb_GioiTinh_KhachHang_Nu.Size = new System.Drawing.Size(57, 27);
            this.rdb_GioiTinh_KhachHang_Nu.TabIndex = 14;
            this.rdb_GioiTinh_KhachHang_Nu.Text = "Nữ";
            this.rdb_GioiTinh_KhachHang_Nu.UseVisualStyleBackColor = true;
            // 
            // rdb_GioiTinh_KhachHang_Nam
            // 
            this.rdb_GioiTinh_KhachHang_Nam.AutoSize = true;
            this.rdb_GioiTinh_KhachHang_Nam.Checked = true;
            this.rdb_GioiTinh_KhachHang_Nam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_GioiTinh_KhachHang_Nam.Location = new System.Drawing.Point(404, 164);
            this.rdb_GioiTinh_KhachHang_Nam.Name = "rdb_GioiTinh_KhachHang_Nam";
            this.rdb_GioiTinh_KhachHang_Nam.Size = new System.Drawing.Size(70, 27);
            this.rdb_GioiTinh_KhachHang_Nam.TabIndex = 13;
            this.rdb_GioiTinh_KhachHang_Nam.TabStop = true;
            this.rdb_GioiTinh_KhachHang_Nam.Text = "Nam";
            this.rdb_GioiTinh_KhachHang_Nam.UseVisualStyleBackColor = true;
            // 
            // dtp_NgaySinh_KhachHang
            // 
            this.dtp_NgaySinh_KhachHang.CustomFormat = "dd-MM-yyyy";
            this.dtp_NgaySinh_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh_KhachHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh_KhachHang.Location = new System.Drawing.Point(401, 217);
            this.dtp_NgaySinh_KhachHang.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtp_NgaySinh_KhachHang.Name = "dtp_NgaySinh_KhachHang";
            this.dtp_NgaySinh_KhachHang.Size = new System.Drawing.Size(422, 30);
            this.dtp_NgaySinh_KhachHang.TabIndex = 12;
            this.dtp_NgaySinh_KhachHang.Value = DateTime.Now;
            // 
            // txt_SoDienThoai_KhachHang
            // 
            this.txt_SoDienThoai_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDienThoai_KhachHang.Location = new System.Drawing.Point(401, 273);
            this.txt_SoDienThoai_KhachHang.Name = "txt_SoDienThoai_KhachHang";
            this.txt_SoDienThoai_KhachHang.Size = new System.Drawing.Size(422, 30);
            this.txt_SoDienThoai_KhachHang.TabIndex = 11;
            // 
            // txt_HoTen_KhachHang
            // 
            this.txt_HoTen_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen_KhachHang.Location = new System.Drawing.Point(401, 108);
            this.txt_HoTen_KhachHang.Name = "txt_HoTen_KhachHang";
            this.txt_HoTen_KhachHang.Size = new System.Drawing.Size(422, 30);
            this.txt_HoTen_KhachHang.TabIndex = 10;
            // 
            // txt_ID_KhachHang
            // 
            this.txt_ID_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID_KhachHang.Location = new System.Drawing.Point(399, 52);
            this.txt_ID_KhachHang.Name = "txt_ID_KhachHang";
            this.txt_ID_KhachHang.Size = new System.Drawing.Size(422, 30);
            this.txt_ID_KhachHang.TabIndex = 9;
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLai.Location = new System.Drawing.Point(439, 614);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(130, 40);
            this.btn_QuayLai.TabIndex = 7;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(439, 329);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(130, 40);
            this.btn_TimKiem.TabIndex = 6;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // lbl_SoDienThoai_KhachHang
            // 
            this.lbl_SoDienThoai_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoDienThoai_KhachHang.Location = new System.Drawing.Point(149, 272);
            this.lbl_SoDienThoai_KhachHang.Name = "lbl_SoDienThoai_KhachHang";
            this.lbl_SoDienThoai_KhachHang.Size = new System.Drawing.Size(187, 30);
            this.lbl_SoDienThoai_KhachHang.TabIndex = 5;
            this.lbl_SoDienThoai_KhachHang.Text = "Số điện thoại";
            this.lbl_SoDienThoai_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NgaySinh_KhachHang
            // 
            this.lbl_NgaySinh_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh_KhachHang.Location = new System.Drawing.Point(149, 217);
            this.lbl_NgaySinh_KhachHang.Name = "lbl_NgaySinh_KhachHang";
            this.lbl_NgaySinh_KhachHang.Size = new System.Drawing.Size(187, 30);
            this.lbl_NgaySinh_KhachHang.TabIndex = 4;
            this.lbl_NgaySinh_KhachHang.Text = "Ngày sinh";
            this.lbl_NgaySinh_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GioiTinh_KhachHang
            // 
            this.lbl_GioiTinh_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh_KhachHang.Location = new System.Drawing.Point(149, 162);
            this.lbl_GioiTinh_KhachHang.Name = "lbl_GioiTinh_KhachHang";
            this.lbl_GioiTinh_KhachHang.Size = new System.Drawing.Size(187, 30);
            this.lbl_GioiTinh_KhachHang.TabIndex = 3;
            this.lbl_GioiTinh_KhachHang.Text = "Giới tính";
            this.lbl_GioiTinh_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_HoTen_KhachHang
            // 
            this.lbl_HoTen_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen_KhachHang.Location = new System.Drawing.Point(149, 107);
            this.lbl_HoTen_KhachHang.Name = "lbl_HoTen_KhachHang";
            this.lbl_HoTen_KhachHang.Size = new System.Drawing.Size(187, 30);
            this.lbl_HoTen_KhachHang.TabIndex = 2;
            this.lbl_HoTen_KhachHang.Text = "Họ tên khách hàng";
            this.lbl_HoTen_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ID_KhachHang
            // 
            this.lbl_ID_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_KhachHang.Location = new System.Drawing.Point(149, 52);
            this.lbl_ID_KhachHang.Name = "lbl_ID_KhachHang";
            this.lbl_ID_KhachHang.Size = new System.Drawing.Size(187, 30);
            this.lbl_ID_KhachHang.TabIndex = 1;
            this.lbl_ID_KhachHang.Text = "ID khách hàng";
            this.lbl_ID_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_KhachHang
            // 
            this.lbl_KhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KhachHang.Location = new System.Drawing.Point(2, 6);
            this.lbl_KhachHang.Name = "lbl_KhachHang";
            this.lbl_KhachHang.Size = new System.Drawing.Size(994, 35);
            this.lbl_KhachHang.TabIndex = 0;
            this.lbl_KhachHang.Text = "TÌM KHÁCH HÀNG";
            this.lbl_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FF_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 686);
            this.Controls.Add(this.pnl_KhachHang);
            this.Name = "FF_KhachHang";
            this.Text = "FF_KhachHang";
            this.pnl_KhachHang.ResumeLayout(false);
            this.pnl_KhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_KhachHang;
        private System.Windows.Forms.Label lbl_KhachHang;
        private System.Windows.Forms.Label lbl_ID_KhachHang;
        private System.Windows.Forms.Label lbl_HoTen_KhachHang;
        private System.Windows.Forms.Label lbl_GioiTinh_KhachHang;
        private System.Windows.Forms.Label lbl_SoDienThoai_KhachHang;
        private System.Windows.Forms.Label lbl_NgaySinh_KhachHang;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.TextBox txt_ID_KhachHang;
        private System.Windows.Forms.TextBox txt_SoDienThoai_KhachHang;
        private System.Windows.Forms.TextBox txt_HoTen_KhachHang;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh_KhachHang;
        private System.Windows.Forms.RadioButton rdb_GioiTinh_KhachHang_Nu;
        private System.Windows.Forms.RadioButton rdb_GioiTinh_KhachHang_Nam;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoTen_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioiTinh_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgaySinh_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoDienThoai_KhachHang;
    }
}