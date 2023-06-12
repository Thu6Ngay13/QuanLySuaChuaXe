using System;

namespace GUI
{
    partial class FF_Tho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.rdb_GioiTinh_Tho_Nam = new System.Windows.Forms.RadioButton();
            this.rdb_GioiTinh_Tho_Nu = new System.Windows.Forms.RadioButton();
            this.txt_IDNhom_Tho = new System.Windows.Forms.TextBox();
            this.txt_Luong_Tho = new System.Windows.Forms.TextBox();
            this.dtp_NgaySinh_Tho = new System.Windows.Forms.DateTimePicker();
            this.txt_DiaChi_Tho = new System.Windows.Forms.TextBox();
            this.txt_HoTen_Tho = new System.Windows.Forms.TextBox();
            this.txt_ID_Tho = new System.Windows.Forms.TextBox();
            this.lbl_NgaySinh_Tho = new System.Windows.Forms.Label();
            this.lbl_GioiTinh_Tho = new System.Windows.Forms.Label();
            this.lbl_IDNhom_Tho = new System.Windows.Forms.Label();
            this.lbl_Luong_Tho = new System.Windows.Forms.Label();
            this.lbl_DiaChi_Tho = new System.Windows.Forms.Label();
            this.lbl_HoTen_Tho = new System.Windows.Forms.Label();
            this.lbl_ID_Tho = new System.Windows.Forms.Label();
            this.lbl_Tho = new System.Windows.Forms.Label();
            this.pnl_FF_Tho = new System.Windows.Forms.Panel();
            this.dgv_Tho = new System.Windows.Forms.DataGridView();
            this.col_ID_Tho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoTen_Tho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh_Tho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgaySinh_Tho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChi_Tho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Luong_Tho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ID_NhomTho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_DieuKien = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnt_DieuKien = new System.Windows.Forms.ToolStripComboBox();
            this.pnl_FF_Tho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tho)).BeginInit();
            this.pnl_DieuKien.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLai.Location = new System.Drawing.Point(441, 719);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(146, 36);
            this.btn_QuayLai.TabIndex = 23;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(441, 402);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(146, 36);
            this.btn_TimKiem.TabIndex = 22;
            this.btn_TimKiem.Text = "TÌM KIẾM";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // rdb_GioiTinh_Tho_Nam
            // 
            this.rdb_GioiTinh_Tho_Nam.AutoSize = true;
            this.rdb_GioiTinh_Tho_Nam.Checked = true;
            this.rdb_GioiTinh_Tho_Nam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_GioiTinh_Tho_Nam.Location = new System.Drawing.Point(379, 166);
            this.rdb_GioiTinh_Tho_Nam.Name = "rdb_GioiTinh_Tho_Nam";
            this.rdb_GioiTinh_Tho_Nam.Size = new System.Drawing.Size(70, 27);
            this.rdb_GioiTinh_Tho_Nam.TabIndex = 21;
            this.rdb_GioiTinh_Tho_Nam.TabStop = true;
            this.rdb_GioiTinh_Tho_Nam.Text = "Nam";
            this.rdb_GioiTinh_Tho_Nam.UseVisualStyleBackColor = true;
            // 
            // rdb_GioiTinh_Tho_Nu
            // 
            this.rdb_GioiTinh_Tho_Nu.AutoSize = true;
            this.rdb_GioiTinh_Tho_Nu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_GioiTinh_Tho_Nu.Location = new System.Drawing.Point(589, 166);
            this.rdb_GioiTinh_Tho_Nu.Name = "rdb_GioiTinh_Tho_Nu";
            this.rdb_GioiTinh_Tho_Nu.Size = new System.Drawing.Size(57, 27);
            this.rdb_GioiTinh_Tho_Nu.TabIndex = 20;
            this.rdb_GioiTinh_Tho_Nu.Text = "Nữ";
            this.rdb_GioiTinh_Tho_Nu.UseVisualStyleBackColor = true;
            // 
            // txt_IDNhom_Tho
            // 
            this.txt_IDNhom_Tho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDNhom_Tho.Location = new System.Drawing.Point(304, 352);
            this.txt_IDNhom_Tho.Name = "txt_IDNhom_Tho";
            this.txt_IDNhom_Tho.Size = new System.Drawing.Size(443, 30);
            this.txt_IDNhom_Tho.TabIndex = 19;
            // 
            // txt_Luong_Tho
            // 
            this.txt_Luong_Tho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Luong_Tho.Location = new System.Drawing.Point(379, 303);
            this.txt_Luong_Tho.Name = "txt_Luong_Tho";
            this.txt_Luong_Tho.Size = new System.Drawing.Size(368, 30);
            this.txt_Luong_Tho.TabIndex = 18;
            this.txt_Luong_Tho.Text = "0";
            this.txt_Luong_Tho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_NgaySinh_Tho
            // 
            this.dtp_NgaySinh_Tho.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh_Tho.CustomFormat = "dd-MM-yyyy";
            this.dtp_NgaySinh_Tho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh_Tho.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh_Tho.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_NgaySinh_Tho.Location = new System.Drawing.Point(304, 210);
            this.dtp_NgaySinh_Tho.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtp_NgaySinh_Tho.Name = "dtp_NgaySinh_Tho";
            this.dtp_NgaySinh_Tho.Size = new System.Drawing.Size(443, 30);
            this.dtp_NgaySinh_Tho.TabIndex = 17;
            this.dtp_NgaySinh_Tho.Value = DateTime.Now;
            // 
            // txt_DiaChi_Tho
            // 
            this.txt_DiaChi_Tho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi_Tho.Location = new System.Drawing.Point(304, 253);
            this.txt_DiaChi_Tho.Name = "txt_DiaChi_Tho";
            this.txt_DiaChi_Tho.Size = new System.Drawing.Size(443, 30);
            this.txt_DiaChi_Tho.TabIndex = 16;
            // 
            // txt_HoTen_Tho
            // 
            this.txt_HoTen_Tho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen_Tho.Location = new System.Drawing.Point(304, 114);
            this.txt_HoTen_Tho.Name = "txt_HoTen_Tho";
            this.txt_HoTen_Tho.Size = new System.Drawing.Size(443, 30);
            this.txt_HoTen_Tho.TabIndex = 15;
            // 
            // txt_ID_Tho
            // 
            this.txt_ID_Tho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID_Tho.Location = new System.Drawing.Point(304, 64);
            this.txt_ID_Tho.Name = "txt_ID_Tho";
            this.txt_ID_Tho.Size = new System.Drawing.Size(443, 30);
            this.txt_ID_Tho.TabIndex = 14;
            // 
            // lbl_NgaySinh_Tho
            // 
            this.lbl_NgaySinh_Tho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh_Tho.Location = new System.Drawing.Point(162, 215);
            this.lbl_NgaySinh_Tho.Name = "lbl_NgaySinh_Tho";
            this.lbl_NgaySinh_Tho.Size = new System.Drawing.Size(136, 23);
            this.lbl_NgaySinh_Tho.TabIndex = 13;
            this.lbl_NgaySinh_Tho.Text = "Ngày sinh";
            // 
            // lbl_GioiTinh_Tho
            // 
            this.lbl_GioiTinh_Tho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh_Tho.Location = new System.Drawing.Point(162, 167);
            this.lbl_GioiTinh_Tho.Name = "lbl_GioiTinh_Tho";
            this.lbl_GioiTinh_Tho.Size = new System.Drawing.Size(136, 23);
            this.lbl_GioiTinh_Tho.TabIndex = 12;
            this.lbl_GioiTinh_Tho.Text = "Giới tính";
            // 
            // lbl_IDNhom_Tho
            // 
            this.lbl_IDNhom_Tho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDNhom_Tho.Location = new System.Drawing.Point(162, 359);
            this.lbl_IDNhom_Tho.Name = "lbl_IDNhom_Tho";
            this.lbl_IDNhom_Tho.Size = new System.Drawing.Size(136, 23);
            this.lbl_IDNhom_Tho.TabIndex = 11;
            this.lbl_IDNhom_Tho.Text = "ID nhóm thợ";
            // 
            // lbl_Luong_Tho
            // 
            this.lbl_Luong_Tho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Luong_Tho.Location = new System.Drawing.Point(162, 311);
            this.lbl_Luong_Tho.Name = "lbl_Luong_Tho";
            this.lbl_Luong_Tho.Size = new System.Drawing.Size(136, 23);
            this.lbl_Luong_Tho.TabIndex = 10;
            this.lbl_Luong_Tho.Text = "Lương";
            // 
            // lbl_DiaChi_Tho
            // 
            this.lbl_DiaChi_Tho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi_Tho.Location = new System.Drawing.Point(162, 263);
            this.lbl_DiaChi_Tho.Name = "lbl_DiaChi_Tho";
            this.lbl_DiaChi_Tho.Size = new System.Drawing.Size(136, 23);
            this.lbl_DiaChi_Tho.TabIndex = 9;
            this.lbl_DiaChi_Tho.Text = "Địa chỉ";
            // 
            // lbl_HoTen_Tho
            // 
            this.lbl_HoTen_Tho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen_Tho.Location = new System.Drawing.Point(162, 119);
            this.lbl_HoTen_Tho.Name = "lbl_HoTen_Tho";
            this.lbl_HoTen_Tho.Size = new System.Drawing.Size(136, 23);
            this.lbl_HoTen_Tho.TabIndex = 8;
            this.lbl_HoTen_Tho.Text = "Họ tên";
            // 
            // lbl_ID_Tho
            // 
            this.lbl_ID_Tho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_Tho.Location = new System.Drawing.Point(162, 71);
            this.lbl_ID_Tho.Name = "lbl_ID_Tho";
            this.lbl_ID_Tho.Size = new System.Drawing.Size(136, 23);
            this.lbl_ID_Tho.TabIndex = 1;
            this.lbl_ID_Tho.Text = "ID thợ";
            // 
            // lbl_Tho
            // 
            this.lbl_Tho.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tho.Location = new System.Drawing.Point(3, 5);
            this.lbl_Tho.Name = "lbl_Tho";
            this.lbl_Tho.Size = new System.Drawing.Size(994, 35);
            this.lbl_Tho.TabIndex = 0;
            this.lbl_Tho.Text = "TÌM THÔNG TIN THỢ";
            this.lbl_Tho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_FF_Tho
            // 
            this.pnl_FF_Tho.Controls.Add(this.dgv_Tho);
            this.pnl_FF_Tho.Controls.Add(this.pnl_DieuKien);
            this.pnl_FF_Tho.Controls.Add(this.btn_QuayLai);
            this.pnl_FF_Tho.Controls.Add(this.btn_TimKiem);
            this.pnl_FF_Tho.Controls.Add(this.rdb_GioiTinh_Tho_Nam);
            this.pnl_FF_Tho.Controls.Add(this.rdb_GioiTinh_Tho_Nu);
            this.pnl_FF_Tho.Controls.Add(this.txt_IDNhom_Tho);
            this.pnl_FF_Tho.Controls.Add(this.txt_Luong_Tho);
            this.pnl_FF_Tho.Controls.Add(this.dtp_NgaySinh_Tho);
            this.pnl_FF_Tho.Controls.Add(this.txt_DiaChi_Tho);
            this.pnl_FF_Tho.Controls.Add(this.txt_HoTen_Tho);
            this.pnl_FF_Tho.Controls.Add(this.txt_ID_Tho);
            this.pnl_FF_Tho.Controls.Add(this.lbl_NgaySinh_Tho);
            this.pnl_FF_Tho.Controls.Add(this.lbl_GioiTinh_Tho);
            this.pnl_FF_Tho.Controls.Add(this.lbl_IDNhom_Tho);
            this.pnl_FF_Tho.Controls.Add(this.lbl_Luong_Tho);
            this.pnl_FF_Tho.Controls.Add(this.lbl_DiaChi_Tho);
            this.pnl_FF_Tho.Controls.Add(this.lbl_HoTen_Tho);
            this.pnl_FF_Tho.Controls.Add(this.lbl_ID_Tho);
            this.pnl_FF_Tho.Controls.Add(this.lbl_Tho);
            this.pnl_FF_Tho.Location = new System.Drawing.Point(10, 10);
            this.pnl_FF_Tho.Name = "pnl_FF_Tho";
            this.pnl_FF_Tho.Size = new System.Drawing.Size(1000, 771);
            this.pnl_FF_Tho.TabIndex = 1;
            // 
            // dgv_Tho
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Tho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Tho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Tho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Tho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID_Tho,
            this.col_HoTen_Tho,
            this.col_GioiTinh_Tho,
            this.col_NgaySinh_Tho,
            this.col_DiaChi_Tho,
            this.col_Luong_Tho,
            this.col_ID_NhomTho});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Tho.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Tho.Location = new System.Drawing.Point(3, 460);
            this.dgv_Tho.Name = "dgv_Tho";
            this.dgv_Tho.ReadOnly = true;
            this.dgv_Tho.RowHeadersWidth = 51;
            this.dgv_Tho.RowTemplate.Height = 24;
            this.dgv_Tho.Size = new System.Drawing.Size(997, 241);
            this.dgv_Tho.TabIndex = 27;
            this.dgv_Tho.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_FF_Tho_CellFormatting);
            // 
            // col_ID_Tho
            // 
            this.col_ID_Tho.DataPropertyName = "ID_Tho";
            this.col_ID_Tho.HeaderText = "ID thợ";
            this.col_ID_Tho.MinimumWidth = 6;
            this.col_ID_Tho.Name = "col_ID_Tho";
            this.col_ID_Tho.ReadOnly = true;
            // 
            // col_HoTen_Tho
            // 
            this.col_HoTen_Tho.DataPropertyName = "HoTen_Tho";
            this.col_HoTen_Tho.HeaderText = "Họ tên";
            this.col_HoTen_Tho.MinimumWidth = 6;
            this.col_HoTen_Tho.Name = "col_HoTen_Tho";
            this.col_HoTen_Tho.ReadOnly = true;
            // 
            // col_GioiTinh_Tho
            // 
            this.col_GioiTinh_Tho.DataPropertyName = "GioiTinh_Tho";
            this.col_GioiTinh_Tho.HeaderText = "Giới tính";
            this.col_GioiTinh_Tho.MinimumWidth = 6;
            this.col_GioiTinh_Tho.Name = "col_GioiTinh_Tho";
            this.col_GioiTinh_Tho.ReadOnly = true;
            this.col_GioiTinh_Tho.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_NgaySinh_Tho
            // 
            this.col_NgaySinh_Tho.DataPropertyName = "NgaySinh_Tho";
            dataGridViewCellStyle3.Format = "dd-MM-yyyy";
            this.col_NgaySinh_Tho.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_NgaySinh_Tho.HeaderText = "Ngày sinh";
            this.col_NgaySinh_Tho.MinimumWidth = 6;
            this.col_NgaySinh_Tho.Name = "col_NgaySinh_Tho";
            this.col_NgaySinh_Tho.ReadOnly = true;
            // 
            // col_DiaChi_Tho
            // 
            this.col_DiaChi_Tho.DataPropertyName = "DiaChi_Tho";
            this.col_DiaChi_Tho.HeaderText = "Địa chỉ";
            this.col_DiaChi_Tho.MinimumWidth = 6;
            this.col_DiaChi_Tho.Name = "col_DiaChi_Tho";
            this.col_DiaChi_Tho.ReadOnly = true;
            // 
            // col_Luong_Tho
            // 
            this.col_Luong_Tho.DataPropertyName = "Luong_Tho";
            this.col_Luong_Tho.HeaderText = "Lương";
            this.col_Luong_Tho.MinimumWidth = 6;
            this.col_Luong_Tho.Name = "col_Luong_Tho";
            this.col_Luong_Tho.ReadOnly = true;
            // 
            // col_ID_NhomTho
            // 
            this.col_ID_NhomTho.DataPropertyName = "ID_NhomTho";
            this.col_ID_NhomTho.HeaderText = "ID nhóm thợ";
            this.col_ID_NhomTho.MinimumWidth = 6;
            this.col_ID_NhomTho.Name = "col_ID_NhomTho";
            this.col_ID_NhomTho.ReadOnly = true;
            // 
            // pnl_DieuKien
            // 
            this.pnl_DieuKien.Controls.Add(this.menuStrip1);
            this.pnl_DieuKien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_DieuKien.Location = new System.Drawing.Point(304, 303);
            this.pnl_DieuKien.Name = "pnl_DieuKien";
            this.pnl_DieuKien.Size = new System.Drawing.Size(63, 31);
            this.pnl_DieuKien.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnt_DieuKien});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(63, 32);
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
            // FF_Tho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 787);
            this.Controls.Add(this.pnl_FF_Tho);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FF_Tho";
            this.Text = "FF_Tho";
            this.pnl_FF_Tho.ResumeLayout(false);
            this.pnl_FF_Tho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tho)).EndInit();
            this.pnl_DieuKien.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.RadioButton rdb_GioiTinh_Tho_Nam;
        private System.Windows.Forms.RadioButton rdb_GioiTinh_Tho_Nu;
        private System.Windows.Forms.TextBox txt_IDNhom_Tho;
        private System.Windows.Forms.TextBox txt_Luong_Tho;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh_Tho;
        private System.Windows.Forms.TextBox txt_DiaChi_Tho;
        private System.Windows.Forms.TextBox txt_HoTen_Tho;
        private System.Windows.Forms.TextBox txt_ID_Tho;
        private System.Windows.Forms.Label lbl_NgaySinh_Tho;
        private System.Windows.Forms.Label lbl_GioiTinh_Tho;
        private System.Windows.Forms.Label lbl_IDNhom_Tho;
        private System.Windows.Forms.Label lbl_Luong_Tho;
        private System.Windows.Forms.Label lbl_DiaChi_Tho;
        private System.Windows.Forms.Label lbl_HoTen_Tho;
        private System.Windows.Forms.Label lbl_ID_Tho;
        private System.Windows.Forms.Label lbl_Tho;
        private System.Windows.Forms.Panel pnl_FF_Tho;
        private System.Windows.Forms.Panel pnl_DieuKien;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox mnt_DieuKien;
        private System.Windows.Forms.DataGridView dgv_Tho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_Tho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoTen_Tho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioiTinh_Tho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgaySinh_Tho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaChi_Tho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Luong_Tho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_NhomTho;
    }
}