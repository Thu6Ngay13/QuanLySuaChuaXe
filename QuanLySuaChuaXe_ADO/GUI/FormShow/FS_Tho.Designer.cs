namespace GUI
{
    partial class FS_Tho
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
            this.dgv_Tho = new System.Windows.Forms.DataGridView();
            this.col_ID_Tho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoTen_Tho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh_Tho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgaySinh_Tho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChi_Tho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Luong_Tho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ID_NhomTho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.lbl_Tho = new System.Windows.Forms.Label();
            this.btn_TaiLai = new System.Windows.Forms.Button();
            this.pnl_Tho = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tho)).BeginInit();
            this.pnl_Tho.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Tho.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Tho.Location = new System.Drawing.Point(3, 65);
            this.dgv_Tho.Name = "dgv_Tho";
            this.dgv_Tho.ReadOnly = true;
            this.dgv_Tho.RowHeadersWidth = 51;
            this.dgv_Tho.RowTemplate.Height = 24;
            this.dgv_Tho.Size = new System.Drawing.Size(995, 349);
            this.dgv_Tho.TabIndex = 0;
            this.dgv_Tho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FSTho_CellClick);
            this.dgv_Tho.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_FSTho_CellFormatting);
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
            this.col_GioiTinh_Tho.HeaderText = "Giới tính ";
            this.col_GioiTinh_Tho.MinimumWidth = 6;
            this.col_GioiTinh_Tho.Name = "col_GioiTinh_Tho";
            this.col_GioiTinh_Tho.ReadOnly = true;
            // 
            // col_NgaySinh_Tho
            // 
            this.col_NgaySinh_Tho.DataPropertyName = "NgaySinh_Tho";
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
            // lbl_Tho
            // 
            this.lbl_Tho.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tho.Location = new System.Drawing.Point(2, 5);
            this.lbl_Tho.Name = "lbl_Tho";
            this.lbl_Tho.Size = new System.Drawing.Size(995, 35);
            this.lbl_Tho.TabIndex = 5;
            this.lbl_Tho.Text = "DANH SÁCH THỢ";
            this.lbl_Tho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // pnl_Tho
            // 
            this.pnl_Tho.Controls.Add(this.btn_QuayLai);
            this.pnl_Tho.Controls.Add(this.lbl_Tho);
            this.pnl_Tho.Controls.Add(this.dgv_Tho);
            this.pnl_Tho.Location = new System.Drawing.Point(10, 10);
            this.pnl_Tho.Name = "pnl_Tho";
            this.pnl_Tho.Size = new System.Drawing.Size(1000, 488);
            this.pnl_Tho.TabIndex = 7;
            // 
            // FS_Tho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 507);
            this.Controls.Add(this.btn_TaiLai);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.pnl_Tho);
            this.Name = "FS_Tho";
            this.Text = "FSTho";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tho)).EndInit();
            this.pnl_Tho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Tho;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Label lbl_Tho;
        private System.Windows.Forms.Button btn_TaiLai;
        private System.Windows.Forms.Panel pnl_Tho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_Tho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoTen_Tho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioiTinh_Tho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgaySinh_Tho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaChi_Tho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Luong_Tho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_NhomTho;
    }
}