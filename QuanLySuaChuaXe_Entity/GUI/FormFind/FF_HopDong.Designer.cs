using System;
using System.Windows.Forms;

namespace GUI
{
    partial class FF_HopDong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_SoDienThoai_KhachHang = new System.Windows.Forms.TextBox();
            this.txt_HoTen_KhachHang = new System.Windows.Forms.TextBox();
            this.lbl_SoDienThoai_KhachHang = new System.Windows.Forms.Label();
            this.lbl_HoTen_KhachHang = new System.Windows.Forms.Label();
            this.lbl_ID_Xe = new System.Windows.Forms.Label();
            this.txt_ID_Xe = new System.Windows.Forms.TextBox();
            this.dgv_HopDong = new System.Windows.Forms.DataGridView();
            this.col_ID_HopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ten_HopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayBatDau_HopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayKetThuc_HopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GiaTri_HopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ID_Xe_inHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_GiaTri_HopDong = new System.Windows.Forms.Label();
            this.lbl_TimKiem_HopDong = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_Ten_HopDong = new System.Windows.Forms.TextBox();
            this.lbl_Ten_HopDong = new System.Windows.Forms.Label();
            this.dtp_NgayBatDau_HopDong = new System.Windows.Forms.DateTimePicker();
            this.lbl_NgayBatDau_HopDong = new System.Windows.Forms.Label();
            this.lbl_NgaySinh_KhachHang = new System.Windows.Forms.Label();
            this.rdb_GioiTinh_KhachHang_Nam = new System.Windows.Forms.RadioButton();
            this.rdb_GioiTinh_KhachHang_Nu = new System.Windows.Forms.RadioButton();
            this.lbl_GioiTinh_KhachHang = new System.Windows.Forms.Label();
            this.dtp_NgaySinh_KhachHang = new System.Windows.Forms.DateTimePicker();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.col_ID_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoTen_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgaySinh_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoDienThoai_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_KhachHang = new System.Windows.Forms.GroupBox();
            this.grb_Xe = new System.Windows.Forms.GroupBox();
            this.dgv_Xe = new System.Windows.Forms.DataGridView();
            this.col_ID_Xe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Loai_Xe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Hang_Xe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ID_KhachHang_inXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.pnl_HopDong = new System.Windows.Forms.Panel();
            this.pnl_DieuKien = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnt_DieuKien = new System.Windows.Forms.ToolStripComboBox();
            this.txt_GiaTri_HopDong = new System.Windows.Forms.TextBox();
            this.btn_TruyXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.grb_KhachHang.SuspendLayout();
            this.grb_Xe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Xe)).BeginInit();
            this.pnl_HopDong.SuspendLayout();
            this.pnl_DieuKien.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_SoDienThoai_KhachHang
            // 
            this.txt_SoDienThoai_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDienThoai_KhachHang.Location = new System.Drawing.Point(745, 170);
            this.txt_SoDienThoai_KhachHang.Name = "txt_SoDienThoai_KhachHang";
            this.txt_SoDienThoai_KhachHang.Size = new System.Drawing.Size(291, 30);
            this.txt_SoDienThoai_KhachHang.TabIndex = 6;
            // 
            // txt_HoTen_KhachHang
            // 
            this.txt_HoTen_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen_KhachHang.Location = new System.Drawing.Point(203, 114);
            this.txt_HoTen_KhachHang.Name = "txt_HoTen_KhachHang";
            this.txt_HoTen_KhachHang.Size = new System.Drawing.Size(291, 30);
            this.txt_HoTen_KhachHang.TabIndex = 2;
            // 
            // lbl_SoDienThoai_KhachHang
            // 
            this.lbl_SoDienThoai_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoDienThoai_KhachHang.Location = new System.Drawing.Point(564, 169);
            this.lbl_SoDienThoai_KhachHang.Name = "lbl_SoDienThoai_KhachHang";
            this.lbl_SoDienThoai_KhachHang.Size = new System.Drawing.Size(148, 23);
            this.lbl_SoDienThoai_KhachHang.TabIndex = 5;
            this.lbl_SoDienThoai_KhachHang.Text = "Số điện thoại ";
            this.lbl_SoDienThoai_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_HoTen_KhachHang
            // 
            this.lbl_HoTen_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen_KhachHang.Location = new System.Drawing.Point(25, 114);
            this.lbl_HoTen_KhachHang.Name = "lbl_HoTen_KhachHang";
            this.lbl_HoTen_KhachHang.Size = new System.Drawing.Size(148, 23);
            this.lbl_HoTen_KhachHang.TabIndex = 2;
            this.lbl_HoTen_KhachHang.Text = "Tên khách hàng";
            this.lbl_HoTen_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ID_Xe
            // 
            this.lbl_ID_Xe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_Xe.Location = new System.Drawing.Point(25, 169);
            this.lbl_ID_Xe.Name = "lbl_ID_Xe";
            this.lbl_ID_Xe.Size = new System.Drawing.Size(148, 23);
            this.lbl_ID_Xe.TabIndex = 1;
            this.lbl_ID_Xe.Text = "ID xe";
            this.lbl_ID_Xe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ID_Xe
            // 
            this.txt_ID_Xe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID_Xe.Location = new System.Drawing.Point(203, 170);
            this.txt_ID_Xe.Name = "txt_ID_Xe";
            this.txt_ID_Xe.Size = new System.Drawing.Size(291, 30);
            this.txt_ID_Xe.TabIndex = 3;
            // 
            // dgv_HopDong
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_HopDong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_HopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Format = "dd-MM-yyyy";
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HopDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_HopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID_HopDong,
            this.col_Ten_HopDong,
            this.col_NgayBatDau_HopDong,
            this.col_NgayKetThuc_HopDong,
            this.col_GiaTri_HopDong,
            this.col_ID_Xe_inHopDong});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_HopDong.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_HopDong.Location = new System.Drawing.Point(29, 215);
            this.dgv_HopDong.Name = "dgv_HopDong";
            this.dgv_HopDong.ReadOnly = true;
            this.dgv_HopDong.RowHeadersWidth = 51;
            this.dgv_HopDong.RowTemplate.Height = 24;
            this.dgv_HopDong.Size = new System.Drawing.Size(1548, 222);
            this.dgv_HopDong.TabIndex = 11;
            this.dgv_HopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FF_HopDong_CellClick);
            // 
            // col_ID_HopDong
            // 
            this.col_ID_HopDong.DataPropertyName = "ID_HopDong";
            this.col_ID_HopDong.HeaderText = "ID hợp đồng";
            this.col_ID_HopDong.MinimumWidth = 6;
            this.col_ID_HopDong.Name = "col_ID_HopDong";
            this.col_ID_HopDong.ReadOnly = true;
            // 
            // col_Ten_HopDong
            // 
            this.col_Ten_HopDong.DataPropertyName = "Ten_HopDong";
            this.col_Ten_HopDong.HeaderText = "Tên hợp đồng";
            this.col_Ten_HopDong.MinimumWidth = 6;
            this.col_Ten_HopDong.Name = "col_Ten_HopDong";
            this.col_Ten_HopDong.ReadOnly = true;
            // 
            // col_NgayBatDau_HopDong
            // 
            this.col_NgayBatDau_HopDong.DataPropertyName = "NgayBatDau_HopDong";
            dataGridViewCellStyle11.Format = "dd-MM-yyyy";
            this.col_NgayBatDau_HopDong.DefaultCellStyle = dataGridViewCellStyle11;
            this.col_NgayBatDau_HopDong.HeaderText = "Ngày bắt đầu";
            this.col_NgayBatDau_HopDong.MinimumWidth = 6;
            this.col_NgayBatDau_HopDong.Name = "col_NgayBatDau_HopDong";
            this.col_NgayBatDau_HopDong.ReadOnly = true;
            // 
            // col_NgayKetThuc_HopDong
            // 
            this.col_NgayKetThuc_HopDong.DataPropertyName = "NgayKetThuc_HopDong";
            dataGridViewCellStyle12.Format = "dd-MM-yyyy";
            this.col_NgayKetThuc_HopDong.DefaultCellStyle = dataGridViewCellStyle12;
            this.col_NgayKetThuc_HopDong.HeaderText = "Ngày kết thúc";
            this.col_NgayKetThuc_HopDong.MinimumWidth = 6;
            this.col_NgayKetThuc_HopDong.Name = "col_NgayKetThuc_HopDong";
            this.col_NgayKetThuc_HopDong.ReadOnly = true;
            // 
            // col_GiaTri_HopDong
            // 
            this.col_GiaTri_HopDong.DataPropertyName = "GiaTri_HopDong";
            this.col_GiaTri_HopDong.HeaderText = "Giá trị hợp đồng";
            this.col_GiaTri_HopDong.MinimumWidth = 6;
            this.col_GiaTri_HopDong.Name = "col_GiaTri_HopDong";
            this.col_GiaTri_HopDong.ReadOnly = true;
            // 
            // col_ID_Xe_inHopDong
            // 
            this.col_ID_Xe_inHopDong.DataPropertyName = "ID_Xe";
            this.col_ID_Xe_inHopDong.HeaderText = "ID xe";
            this.col_ID_Xe_inHopDong.MinimumWidth = 6;
            this.col_ID_Xe_inHopDong.Name = "col_ID_Xe_inHopDong";
            this.col_ID_Xe_inHopDong.ReadOnly = true;
            // 
            // lbl_GiaTri_HopDong
            // 
            this.lbl_GiaTri_HopDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaTri_HopDong.Location = new System.Drawing.Point(1105, 56);
            this.lbl_GiaTri_HopDong.Name = "lbl_GiaTri_HopDong";
            this.lbl_GiaTri_HopDong.Size = new System.Drawing.Size(148, 23);
            this.lbl_GiaTri_HopDong.TabIndex = 22;
            this.lbl_GiaTri_HopDong.Text = "Giá trị hợp đồng";
            this.lbl_GiaTri_HopDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_TimKiem_HopDong
            // 
            this.lbl_TimKiem_HopDong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TimKiem_HopDong.Location = new System.Drawing.Point(3, 5);
            this.lbl_TimKiem_HopDong.Name = "lbl_TimKiem_HopDong";
            this.lbl_TimKiem_HopDong.Size = new System.Drawing.Size(1594, 35);
            this.lbl_TimKiem_HopDong.TabIndex = 23;
            this.lbl_TimKiem_HopDong.Text = "TÌM KIẾM HỢP ĐỒNG";
            this.lbl_TimKiem_HopDong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(1105, 165);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(148, 32);
            this.btn_TimKiem.TabIndex = 10;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_Ten_HopDong
            // 
            this.txt_Ten_HopDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten_HopDong.Location = new System.Drawing.Point(203, 57);
            this.txt_Ten_HopDong.Name = "txt_Ten_HopDong";
            this.txt_Ten_HopDong.Size = new System.Drawing.Size(291, 30);
            this.txt_Ten_HopDong.TabIndex = 1;
            // 
            // lbl_Ten_HopDong
            // 
            this.lbl_Ten_HopDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten_HopDong.Location = new System.Drawing.Point(25, 56);
            this.lbl_Ten_HopDong.Name = "lbl_Ten_HopDong";
            this.lbl_Ten_HopDong.Size = new System.Drawing.Size(148, 23);
            this.lbl_Ten_HopDong.TabIndex = 25;
            this.lbl_Ten_HopDong.Text = "Tên hợp đồng";
            this.lbl_Ten_HopDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_NgayBatDau_HopDong
            // 
            this.dtp_NgayBatDau_HopDong.CustomFormat = "dd-MM-yyyy";
            this.dtp_NgayBatDau_HopDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayBatDau_HopDong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayBatDau_HopDong.Location = new System.Drawing.Point(745, 51);
            this.dtp_NgayBatDau_HopDong.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayBatDau_HopDong.Name = "dtp_NgayBatDau_HopDong";
            this.dtp_NgayBatDau_HopDong.Size = new System.Drawing.Size(291, 30);
            this.dtp_NgayBatDau_HopDong.TabIndex = 4;
            this.dtp_NgayBatDau_HopDong.Value = DateTime.Now;
            // 
            // lbl_NgayBatDau_HopDong
            // 
            this.lbl_NgayBatDau_HopDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayBatDau_HopDong.Location = new System.Drawing.Point(564, 56);
            this.lbl_NgayBatDau_HopDong.Name = "lbl_NgayBatDau_HopDong";
            this.lbl_NgayBatDau_HopDong.Size = new System.Drawing.Size(148, 23);
            this.lbl_NgayBatDau_HopDong.TabIndex = 28;
            this.lbl_NgayBatDau_HopDong.Text = "Ngày bắt đầu";
            this.lbl_NgayBatDau_HopDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_NgaySinh_KhachHang
            // 
            this.lbl_NgaySinh_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh_KhachHang.Location = new System.Drawing.Point(564, 111);
            this.lbl_NgaySinh_KhachHang.Name = "lbl_NgaySinh_KhachHang";
            this.lbl_NgaySinh_KhachHang.Size = new System.Drawing.Size(148, 23);
            this.lbl_NgaySinh_KhachHang.TabIndex = 29;
            this.lbl_NgaySinh_KhachHang.Text = "Ngày sinh";
            this.lbl_NgaySinh_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdb_GioiTinh_KhachHang_Nam
            // 
            this.rdb_GioiTinh_KhachHang_Nam.AutoSize = true;
            this.rdb_GioiTinh_KhachHang_Nam.Checked = true;
            this.rdb_GioiTinh_KhachHang_Nam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_GioiTinh_KhachHang_Nam.Location = new System.Drawing.Point(1286, 108);
            this.rdb_GioiTinh_KhachHang_Nam.Name = "rdb_GioiTinh_KhachHang_Nam";
            this.rdb_GioiTinh_KhachHang_Nam.Size = new System.Drawing.Size(70, 27);
            this.rdb_GioiTinh_KhachHang_Nam.TabIndex = 8;
            this.rdb_GioiTinh_KhachHang_Nam.TabStop = true;
            this.rdb_GioiTinh_KhachHang_Nam.Text = "Nam";
            this.rdb_GioiTinh_KhachHang_Nam.UseVisualStyleBackColor = true;
            // 
            // rdb_GioiTinh_KhachHang_Nu
            // 
            this.rdb_GioiTinh_KhachHang_Nu.AutoSize = true;
            this.rdb_GioiTinh_KhachHang_Nu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_GioiTinh_KhachHang_Nu.Location = new System.Drawing.Point(1390, 108);
            this.rdb_GioiTinh_KhachHang_Nu.Name = "rdb_GioiTinh_KhachHang_Nu";
            this.rdb_GioiTinh_KhachHang_Nu.Size = new System.Drawing.Size(57, 27);
            this.rdb_GioiTinh_KhachHang_Nu.TabIndex = 9;
            this.rdb_GioiTinh_KhachHang_Nu.Text = "Nữ";
            this.rdb_GioiTinh_KhachHang_Nu.UseVisualStyleBackColor = true;
            // 
            // lbl_GioiTinh_KhachHang
            // 
            this.lbl_GioiTinh_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh_KhachHang.Location = new System.Drawing.Point(1105, 108);
            this.lbl_GioiTinh_KhachHang.Name = "lbl_GioiTinh_KhachHang";
            this.lbl_GioiTinh_KhachHang.Size = new System.Drawing.Size(148, 23);
            this.lbl_GioiTinh_KhachHang.TabIndex = 33;
            this.lbl_GioiTinh_KhachHang.Text = "Giới tính";
            this.lbl_GioiTinh_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_NgaySinh_KhachHang
            // 
            this.dtp_NgaySinh_KhachHang.CustomFormat = "dd-MM-yyyy";
            this.dtp_NgaySinh_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh_KhachHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh_KhachHang.Location = new System.Drawing.Point(745, 108);
            this.dtp_NgaySinh_KhachHang.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtp_NgaySinh_KhachHang.Name = "dtp_NgaySinh_KhachHang";
            this.dtp_NgaySinh_KhachHang.Size = new System.Drawing.Size(291, 30);
            this.dtp_NgaySinh_KhachHang.TabIndex = 5;
            this.dtp_NgaySinh_KhachHang.Value = DateTime.Now;
            // 
            // dgv_KhachHang
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_KhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID_KhachHang,
            this.col_HoTen_KhachHang,
            this.col_GioiTinh_KhachHang,
            this.col_NgaySinh_KhachHang,
            this.col_SoDienThoai_KhachHang});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.Format = "dd-MM-yyyy";
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_KhachHang.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_KhachHang.Location = new System.Drawing.Point(29, 29);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.ReadOnly = true;
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.RowTemplate.Height = 24;
            this.dgv_KhachHang.Size = new System.Drawing.Size(1249, 120);
            this.dgv_KhachHang.TabIndex = 13;
            this.dgv_KhachHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_KhachHang_CellFormatting);
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
            // grb_KhachHang
            // 
            this.grb_KhachHang.Controls.Add(this.dgv_KhachHang);
            this.grb_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_KhachHang.Location = new System.Drawing.Point(12, 482);
            this.grb_KhachHang.Name = "grb_KhachHang";
            this.grb_KhachHang.Size = new System.Drawing.Size(1278, 149);
            this.grb_KhachHang.TabIndex = 37;
            this.grb_KhachHang.TabStop = false;
            this.grb_KhachHang.Text = "Khách hàng";
            // 
            // grb_Xe
            // 
            this.grb_Xe.Controls.Add(this.dgv_Xe);
            this.grb_Xe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_Xe.Location = new System.Drawing.Point(12, 649);
            this.grb_Xe.Name = "grb_Xe";
            this.grb_Xe.Size = new System.Drawing.Size(1278, 149);
            this.grb_Xe.TabIndex = 38;
            this.grb_Xe.TabStop = false;
            this.grb_Xe.Text = "Xe";
            // 
            // dgv_Xe
            // 
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Xe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_Xe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Xe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID_Xe,
            this.col_Loai_Xe,
            this.col_Hang_Xe,
            this.col_ID_KhachHang_inXe});
            this.dgv_Xe.Location = new System.Drawing.Point(29, 29);
            this.dgv_Xe.Name = "dgv_Xe";
            this.dgv_Xe.ReadOnly = true;
            this.dgv_Xe.RowHeadersWidth = 51;
            this.dgv_Xe.RowTemplate.Height = 24;
            this.dgv_Xe.Size = new System.Drawing.Size(1249, 120);
            this.dgv_Xe.TabIndex = 37;
            // 
            // col_ID_Xe
            // 
            this.col_ID_Xe.DataPropertyName = "ID_Xe";
            this.col_ID_Xe.HeaderText = "ID xe";
            this.col_ID_Xe.MinimumWidth = 6;
            this.col_ID_Xe.Name = "col_ID_Xe";
            this.col_ID_Xe.ReadOnly = true;
            // 
            // col_Loai_Xe
            // 
            this.col_Loai_Xe.DataPropertyName = "Loai_Xe";
            this.col_Loai_Xe.HeaderText = "Loại xe";
            this.col_Loai_Xe.MinimumWidth = 6;
            this.col_Loai_Xe.Name = "col_Loai_Xe";
            this.col_Loai_Xe.ReadOnly = true;
            // 
            // col_Hang_Xe
            // 
            this.col_Hang_Xe.DataPropertyName = "Hang_Xe";
            this.col_Hang_Xe.HeaderText = "Hãng xe";
            this.col_Hang_Xe.MinimumWidth = 6;
            this.col_Hang_Xe.Name = "col_Hang_Xe";
            this.col_Hang_Xe.ReadOnly = true;
            // 
            // col_ID_KhachHang_inXe
            // 
            this.col_ID_KhachHang_inXe.DataPropertyName = "ID_KhachHang";
            this.col_ID_KhachHang_inXe.HeaderText = "ID khách hàng";
            this.col_ID_KhachHang_inXe.MinimumWidth = 6;
            this.col_ID_KhachHang_inXe.Name = "col_ID_KhachHang_inXe";
            this.col_ID_KhachHang_inXe.ReadOnly = true;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ThanhToan.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThanhToan.Location = new System.Drawing.Point(1382, 678);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(148, 32);
            this.btn_ThanhToan.TabIndex = 14;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.BackColor = System.Drawing.SystemColors.Control;
            this.btn_QuayLai.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_QuayLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_QuayLai.Location = new System.Drawing.Point(1382, 722);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(148, 32);
            this.btn_QuayLai.TabIndex = 15;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = false;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // pnl_HopDong
            // 
            this.pnl_HopDong.Controls.Add(this.pnl_DieuKien);
            this.pnl_HopDong.Controls.Add(this.txt_GiaTri_HopDong);
            this.pnl_HopDong.Controls.Add(this.btn_TimKiem);
            this.pnl_HopDong.Controls.Add(this.txt_ID_Xe);
            this.pnl_HopDong.Controls.Add(this.dgv_HopDong);
            this.pnl_HopDong.Controls.Add(this.lbl_GiaTri_HopDong);
            this.pnl_HopDong.Controls.Add(this.lbl_TimKiem_HopDong);
            this.pnl_HopDong.Controls.Add(this.txt_Ten_HopDong);
            this.pnl_HopDong.Controls.Add(this.dtp_NgayBatDau_HopDong);
            this.pnl_HopDong.Controls.Add(this.lbl_Ten_HopDong);
            this.pnl_HopDong.Controls.Add(this.lbl_NgayBatDau_HopDong);
            this.pnl_HopDong.Controls.Add(this.dtp_NgaySinh_KhachHang);
            this.pnl_HopDong.Controls.Add(this.lbl_ID_Xe);
            this.pnl_HopDong.Controls.Add(this.lbl_NgaySinh_KhachHang);
            this.pnl_HopDong.Controls.Add(this.rdb_GioiTinh_KhachHang_Nu);
            this.pnl_HopDong.Controls.Add(this.lbl_GioiTinh_KhachHang);
            this.pnl_HopDong.Controls.Add(this.rdb_GioiTinh_KhachHang_Nam);
            this.pnl_HopDong.Controls.Add(this.txt_HoTen_KhachHang);
            this.pnl_HopDong.Controls.Add(this.lbl_SoDienThoai_KhachHang);
            this.pnl_HopDong.Controls.Add(this.lbl_HoTen_KhachHang);
            this.pnl_HopDong.Controls.Add(this.txt_SoDienThoai_KhachHang);
            this.pnl_HopDong.Location = new System.Drawing.Point(12, 12);
            this.pnl_HopDong.Name = "pnl_HopDong";
            this.pnl_HopDong.Size = new System.Drawing.Size(1600, 450);
            this.pnl_HopDong.TabIndex = 41;
            // 
            // pnl_DieuKien
            // 
            this.pnl_DieuKien.Controls.Add(this.menuStrip1);
            this.pnl_DieuKien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_DieuKien.Location = new System.Drawing.Point(1286, 52);
            this.pnl_DieuKien.Name = "pnl_DieuKien";
            this.pnl_DieuKien.Size = new System.Drawing.Size(62, 31);
            this.pnl_DieuKien.TabIndex = 36;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnt_DieuKien});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(62, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnt_DieuKien
            // 
            this.mnt_DieuKien.AutoSize = false;
            this.mnt_DieuKien.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.mnt_DieuKien.Name = "mnt_DieuKien";
            this.mnt_DieuKien.Size = new System.Drawing.Size(50, 28);
            this.mnt_DieuKien.Text = ">";
            // 
            // txt_GiaTri_HopDong
            // 
            this.txt_GiaTri_HopDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaTri_HopDong.Location = new System.Drawing.Point(1390, 56);
            this.txt_GiaTri_HopDong.Name = "txt_GiaTri_HopDong";
            this.txt_GiaTri_HopDong.Size = new System.Drawing.Size(187, 30);
            this.txt_GiaTri_HopDong.TabIndex = 7;
            this.txt_GiaTri_HopDong.Text = "0";
            this.txt_GiaTri_HopDong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_TruyXuat
            // 
            this.btn_TruyXuat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_TruyXuat.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_TruyXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TruyXuat.Location = new System.Drawing.Point(1382, 511);
            this.btn_TruyXuat.Name = "btn_TruyXuat";
            this.btn_TruyXuat.Size = new System.Drawing.Size(148, 32);
            this.btn_TruyXuat.TabIndex = 12;
            this.btn_TruyXuat.Text = "Truy xuất";
            this.btn_TruyXuat.UseVisualStyleBackColor = false;
            this.btn_TruyXuat.Click += new System.EventHandler(this.btn_TruyXuat_Click);
            // 
            // FF_HopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1622, 823);
            this.Controls.Add(this.btn_TruyXuat);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.grb_Xe);
            this.Controls.Add(this.grb_KhachHang);
            this.Controls.Add(this.pnl_HopDong);
            this.Name = "FF_HopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.grb_KhachHang.ResumeLayout(false);
            this.grb_Xe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Xe)).EndInit();
            this.pnl_HopDong.ResumeLayout(false);
            this.pnl_HopDong.PerformLayout();
            this.pnl_DieuKien.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SoDienThoai_KhachHang;
        private System.Windows.Forms.TextBox txt_HoTen_KhachHang;
        private System.Windows.Forms.Label lbl_SoDienThoai_KhachHang;
        private System.Windows.Forms.Label lbl_HoTen_KhachHang;
        private System.Windows.Forms.Label lbl_ID_Xe;
        private System.Windows.Forms.TextBox txt_ID_Xe;
        private System.Windows.Forms.DataGridView dgv_HopDong;
        private System.Windows.Forms.Label lbl_GiaTri_HopDong;
        private System.Windows.Forms.Label lbl_TimKiem_HopDong;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_Ten_HopDong;
        private System.Windows.Forms.Label lbl_Ten_HopDong;
        private System.Windows.Forms.DateTimePicker dtp_NgayBatDau_HopDong;
        private System.Windows.Forms.Label lbl_NgayBatDau_HopDong;
        private System.Windows.Forms.Label lbl_NgaySinh_KhachHang;
        private System.Windows.Forms.RadioButton rdb_GioiTinh_KhachHang_Nam;
        private System.Windows.Forms.RadioButton rdb_GioiTinh_KhachHang_Nu;
        private System.Windows.Forms.Label lbl_GioiTinh_KhachHang;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.GroupBox grb_KhachHang;
        private System.Windows.Forms.GroupBox grb_Xe;
        private System.Windows.Forms.DataGridView dgv_Xe;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Panel pnl_HopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoTen_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioiTinh_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgaySinh_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoDienThoai_KhachHang;
        private System.Windows.Forms.Button btn_TruyXuat;
        private System.Windows.Forms.TextBox txt_GiaTri_HopDong;
        private System.Windows.Forms.Panel pnl_DieuKien;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox mnt_DieuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_Xe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Loai_Xe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Hang_Xe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_KhachHang_inXe;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh_KhachHang;
        private DataGridViewTextBoxColumn col_ID_HopDong;
        private DataGridViewTextBoxColumn col_Ten_HopDong;
        private DataGridViewTextBoxColumn col_NgayBatDau_HopDong;
        private DataGridViewTextBoxColumn col_NgayKetThuc_HopDong;
        private DataGridViewTextBoxColumn col_GiaTri_HopDong;
        private DataGridViewTextBoxColumn col_ID_Xe_inHopDong;
    }
}