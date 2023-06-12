namespace GUI
{
    partial class FS_HopDong
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
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgv_HopDong = new System.Windows.Forms.DataGridView();
            this.col_ID_HopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ten_HopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayBatDau_HopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayKetThuc_HopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GiaTri_HopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ID_Xe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_TaiLai = new System.Windows.Forms.Button();
            this.lbl_HopDong = new System.Windows.Forms.Label();
            this.pnl_HopDong = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HopDong)).BeginInit();
            this.pnl_HopDong.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_QuayLai.Location = new System.Drawing.Point(844, 398);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(124, 43);
            this.btn_QuayLai.TabIndex = 9;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(636, 395);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(124, 43);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(428, 398);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(124, 43);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.Location = new System.Drawing.Point(220, 398);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(124, 43);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgv_HopDong
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_HopDong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_HopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HopDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_HopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID_HopDong,
            this.col_Ten_HopDong,
            this.col_NgayBatDau_HopDong,
            this.col_NgayKetThuc_HopDong,
            this.col_GiaTri_HopDong,
            this.col_ID_Xe});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_HopDong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_HopDong.Location = new System.Drawing.Point(0, 72);
            this.dgv_HopDong.Name = "dgv_HopDong";
            this.dgv_HopDong.ReadOnly = true;
            this.dgv_HopDong.RowHeadersWidth = 51;
            this.dgv_HopDong.RowTemplate.Height = 24;
            this.dgv_HopDong.Size = new System.Drawing.Size(974, 306);
            this.dgv_HopDong.TabIndex = 5;
            this.dgv_HopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HopDong_CellClick);
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
            this.col_NgayBatDau_HopDong.HeaderText = "Ngày bắt đầu";
            this.col_NgayBatDau_HopDong.MinimumWidth = 6;
            this.col_NgayBatDau_HopDong.Name = "col_NgayBatDau_HopDong";
            this.col_NgayBatDau_HopDong.ReadOnly = true;
            // 
            // col_NgayKetThuc_HopDong
            // 
            this.col_NgayKetThuc_HopDong.DataPropertyName = "NgayKetThuc_HopDong";
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
            // col_ID_Xe
            // 
            this.col_ID_Xe.DataPropertyName = "ID_Xe";
            this.col_ID_Xe.HeaderText = "ID xe";
            this.col_ID_Xe.MinimumWidth = 6;
            this.col_ID_Xe.Name = "col_ID_Xe";
            this.col_ID_Xe.ReadOnly = true;
            // 
            // btn_TaiLai
            // 
            this.btn_TaiLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TaiLai.Location = new System.Drawing.Point(12, 398);
            this.btn_TaiLai.Name = "btn_TaiLai";
            this.btn_TaiLai.Size = new System.Drawing.Size(124, 43);
            this.btn_TaiLai.TabIndex = 10;
            this.btn_TaiLai.Text = "Tải lại";
            this.btn_TaiLai.UseVisualStyleBackColor = true;
            this.btn_TaiLai.Click += new System.EventHandler(this.btn_TaiLai_Click);
            // 
            // lbl_HopDong
            // 
            this.lbl_HopDong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_HopDong.Location = new System.Drawing.Point(3, 5);
            this.lbl_HopDong.Name = "lbl_HopDong";
            this.lbl_HopDong.Size = new System.Drawing.Size(971, 35);
            this.lbl_HopDong.TabIndex = 11;
            this.lbl_HopDong.Text = "HỢP ĐỒNG";
            this.lbl_HopDong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_HopDong
            // 
            this.pnl_HopDong.Controls.Add(this.lbl_HopDong);
            this.pnl_HopDong.Controls.Add(this.btn_Sua);
            this.pnl_HopDong.Controls.Add(this.dgv_HopDong);
            this.pnl_HopDong.Location = new System.Drawing.Point(3, 3);
            this.pnl_HopDong.Name = "pnl_HopDong";
            this.pnl_HopDong.Size = new System.Drawing.Size(974, 446);
            this.pnl_HopDong.TabIndex = 12;
            // 
            // FS_HopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.btn_TaiLai);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.pnl_HopDong);
            this.Name = "FS_HopDong";
            this.Text = "FSHopDong";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HopDong)).EndInit();
            this.pnl_HopDong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_HopDong;
        private System.Windows.Forms.Button btn_TaiLai;
        private System.Windows.Forms.Label lbl_HopDong;
        private System.Windows.Forms.Panel pnl_HopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_HopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ten_HopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayBatDau_HopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayKetThuc_HopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GiaTri_HopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_Xe;
    }
}