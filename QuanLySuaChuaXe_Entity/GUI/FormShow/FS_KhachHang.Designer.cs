namespace GUI
{
    partial class FS_KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.lbl_KhachHang = new System.Windows.Forms.Label();
            this.btn_TaiLai = new System.Windows.Forms.Button();
            this.pnl_KhachHang = new System.Windows.Forms.Panel();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.col_ID_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoTen_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgaySinh_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoDienThoai_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_KhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(242, 440);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(121, 41);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(439, 440);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(121, 41);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(636, 440);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(121, 41);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLai.Location = new System.Drawing.Point(836, 430);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(121, 41);
            this.btn_QuayLai.TabIndex = 4;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // lbl_KhachHang
            // 
            this.lbl_KhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KhachHang.Location = new System.Drawing.Point(2, 5);
            this.lbl_KhachHang.Name = "lbl_KhachHang";
            this.lbl_KhachHang.Size = new System.Drawing.Size(995, 35);
            this.lbl_KhachHang.TabIndex = 5;
            this.lbl_KhachHang.Text = "DANH KHÁCH HÀNG";
            this.lbl_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_TaiLai
            // 
            this.btn_TaiLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaiLai.Location = new System.Drawing.Point(45, 440);
            this.btn_TaiLai.Name = "btn_TaiLai";
            this.btn_TaiLai.Size = new System.Drawing.Size(121, 41);
            this.btn_TaiLai.TabIndex = 6;
            this.btn_TaiLai.Text = "Tải lại";
            this.btn_TaiLai.UseVisualStyleBackColor = true;
            this.btn_TaiLai.Click += new System.EventHandler(this.btn_TaiLai_Click);
            // 
            // pnl_KhachHang
            // 
            this.pnl_KhachHang.Controls.Add(this.dgv_KhachHang);
            this.pnl_KhachHang.Controls.Add(this.btn_QuayLai);
            this.pnl_KhachHang.Controls.Add(this.lbl_KhachHang);
            this.pnl_KhachHang.Location = new System.Drawing.Point(10, 10);
            this.pnl_KhachHang.Name = "pnl_KhachHang";
            this.pnl_KhachHang.Size = new System.Drawing.Size(1000, 488);
            this.pnl_KhachHang.TabIndex = 7;
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
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_KhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_KhachHang.Location = new System.Drawing.Point(0, 60);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.ReadOnly = true;
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.RowTemplate.Height = 24;
            this.dgv_KhachHang.Size = new System.Drawing.Size(994, 350);
            this.dgv_KhachHang.TabIndex = 16;
            this.dgv_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FSKhachHang_CellClick);
            this.dgv_KhachHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_FSKhachHang_CellFormatting);
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
            // FS_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 507);
            this.Controls.Add(this.btn_TaiLai);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.pnl_KhachHang);
            this.Name = "FS_KhachHang";
            this.Text = "FSKhachHang";
            this.pnl_KhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Label lbl_KhachHang;
        private System.Windows.Forms.Button btn_TaiLai;
        private System.Windows.Forms.Panel pnl_KhachHang;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoTen_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioiTinh_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgaySinh_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoDienThoai_KhachHang;
    }
}