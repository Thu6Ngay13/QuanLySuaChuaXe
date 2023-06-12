namespace GUI
{
    partial class FS_PhieuThu
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
            this.dgv_PhieuThu = new System.Windows.Forms.DataGridView();
            this.col_ID_PhieuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoTenNguoiThu_PhieuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoTenNguoiNop_PhieuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayThu_PhieuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoTienThu_PhieuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ID_HopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_TroVe = new System.Windows.Forms.Button();
            this.btn_TaiLai = new System.Windows.Forms.Button();
            this.pnl_PhieuThu = new System.Windows.Forms.Panel();
            this.lbl_PhieuThu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuThu)).BeginInit();
            this.pnl_PhieuThu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_PhieuThu
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_PhieuThu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PhieuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PhieuThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_PhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID_PhieuThu,
            this.col_HoTenNguoiThu_PhieuThu,
            this.col_HoTenNguoiNop_PhieuThu,
            this.col_NgayThu_PhieuThu,
            this.col_SoTienThu_PhieuThu,
            this.col_ID_HopDong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PhieuThu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_PhieuThu.Location = new System.Drawing.Point(2, 63);
            this.dgv_PhieuThu.Name = "dgv_PhieuThu";
            this.dgv_PhieuThu.ReadOnly = true;
            this.dgv_PhieuThu.RowHeadersWidth = 51;
            this.dgv_PhieuThu.RowTemplate.Height = 24;
            this.dgv_PhieuThu.Size = new System.Drawing.Size(994, 375);
            this.dgv_PhieuThu.TabIndex = 0;
            this.dgv_PhieuThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FSPhieuThu_CellClick);
            // 
            // col_ID_PhieuThu
            // 
            this.col_ID_PhieuThu.DataPropertyName = "ID_PhieuThu";
            this.col_ID_PhieuThu.HeaderText = "ID phiếu thu";
            this.col_ID_PhieuThu.MinimumWidth = 6;
            this.col_ID_PhieuThu.Name = "col_ID_PhieuThu";
            this.col_ID_PhieuThu.ReadOnly = true;
            // 
            // col_HoTenNguoiThu_PhieuThu
            // 
            this.col_HoTenNguoiThu_PhieuThu.DataPropertyName = "HoTenNguoiThu_PhieuThu";
            this.col_HoTenNguoiThu_PhieuThu.HeaderText = "Ho tên người thu";
            this.col_HoTenNguoiThu_PhieuThu.MinimumWidth = 6;
            this.col_HoTenNguoiThu_PhieuThu.Name = "col_HoTenNguoiThu_PhieuThu";
            this.col_HoTenNguoiThu_PhieuThu.ReadOnly = true;
            // 
            // col_HoTenNguoiNop_PhieuThu
            // 
            this.col_HoTenNguoiNop_PhieuThu.DataPropertyName = "HoTenNguoiNop_PhieuThu";
            this.col_HoTenNguoiNop_PhieuThu.HeaderText = "Ho tên người nộp";
            this.col_HoTenNguoiNop_PhieuThu.MinimumWidth = 6;
            this.col_HoTenNguoiNop_PhieuThu.Name = "col_HoTenNguoiNop_PhieuThu";
            this.col_HoTenNguoiNop_PhieuThu.ReadOnly = true;
            // 
            // col_NgayThu_PhieuThu
            // 
            this.col_NgayThu_PhieuThu.DataPropertyName = "NgayThu_PhieuThu";
            this.col_NgayThu_PhieuThu.HeaderText = "Ngày thu";
            this.col_NgayThu_PhieuThu.MinimumWidth = 6;
            this.col_NgayThu_PhieuThu.Name = "col_NgayThu_PhieuThu";
            this.col_NgayThu_PhieuThu.ReadOnly = true;
            // 
            // col_SoTienThu_PhieuThu
            // 
            this.col_SoTienThu_PhieuThu.DataPropertyName = "SoTienThu_PhieuThu";
            this.col_SoTienThu_PhieuThu.HeaderText = "Số tiền thu";
            this.col_SoTienThu_PhieuThu.MinimumWidth = 6;
            this.col_SoTienThu_PhieuThu.Name = "col_SoTienThu_PhieuThu";
            this.col_SoTienThu_PhieuThu.ReadOnly = true;
            // 
            // col_ID_HopDong
            // 
            this.col_ID_HopDong.DataPropertyName = "ID_HopDong";
            this.col_ID_HopDong.HeaderText = "ID hợp đồng";
            this.col_ID_HopDong.MinimumWidth = 6;
            this.col_ID_HopDong.Name = "col_ID_HopDong";
            this.col_ID_HopDong.ReadOnly = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(232, 456);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(111, 38);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(443, 456);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(111, 38);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(654, 456);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(111, 38);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe.Location = new System.Drawing.Point(865, 456);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(111, 38);
            this.btn_TroVe.TabIndex = 4;
            this.btn_TroVe.Text = "Quay lại";
            this.btn_TroVe.UseVisualStyleBackColor = true;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // btn_TaiLai
            // 
            this.btn_TaiLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaiLai.Location = new System.Drawing.Point(21, 456);
            this.btn_TaiLai.Name = "btn_TaiLai";
            this.btn_TaiLai.Size = new System.Drawing.Size(111, 38);
            this.btn_TaiLai.TabIndex = 5;
            this.btn_TaiLai.Text = "Tải lại";
            this.btn_TaiLai.UseVisualStyleBackColor = true;
            this.btn_TaiLai.Click += new System.EventHandler(this.btn_TaiLai_Click);
            // 
            // pnl_PhieuThu
            // 
            this.pnl_PhieuThu.Controls.Add(this.lbl_PhieuThu);
            this.pnl_PhieuThu.Controls.Add(this.btn_TaiLai);
            this.pnl_PhieuThu.Controls.Add(this.btn_TroVe);
            this.pnl_PhieuThu.Controls.Add(this.dgv_PhieuThu);
            this.pnl_PhieuThu.Controls.Add(this.btn_Sua);
            this.pnl_PhieuThu.Controls.Add(this.btn_Them);
            this.pnl_PhieuThu.Controls.Add(this.btn_Xoa);
            this.pnl_PhieuThu.Location = new System.Drawing.Point(10, 10);
            this.pnl_PhieuThu.Name = "pnl_PhieuThu";
            this.pnl_PhieuThu.Size = new System.Drawing.Size(1000, 511);
            this.pnl_PhieuThu.TabIndex = 6;
            // 
            // lbl_PhieuThu
            // 
            this.lbl_PhieuThu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhieuThu.Location = new System.Drawing.Point(3, 6);
            this.lbl_PhieuThu.Name = "lbl_PhieuThu";
            this.lbl_PhieuThu.Size = new System.Drawing.Size(993, 35);
            this.lbl_PhieuThu.TabIndex = 6;
            this.lbl_PhieuThu.Text = "DANH SÁCH PHIẾU THU";
            this.lbl_PhieuThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FS_PhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 529);
            this.Controls.Add(this.pnl_PhieuThu);
            this.Name = "FS_PhieuThu";
            this.Text = "FSPhieuThu";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuThu)).EndInit();
            this.pnl_PhieuThu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PhieuThu;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.Button btn_TaiLai;
        private System.Windows.Forms.Panel pnl_PhieuThu;
        private System.Windows.Forms.Label lbl_PhieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_PhieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoTenNguoiThu_PhieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoTenNguoiNop_PhieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayThu_PhieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoTienThu_PhieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_HopDong;
    }
}