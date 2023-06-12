namespace GUI
{
    partial class FS_NhomTho
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
            this.pnl_NhomTho = new System.Windows.Forms.Panel();
            this.dgv_NhomTho = new System.Windows.Forms.DataGridView();
            this.col_ID_NhomTho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ten_NhomTho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ID_TruongNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_TaiLai = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lbl_NhomTho = new System.Windows.Forms.Label();
            this.pnl_NhomTho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhomTho)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_NhomTho
            // 
            this.pnl_NhomTho.Controls.Add(this.dgv_NhomTho);
            this.pnl_NhomTho.Controls.Add(this.btn_QuayLai);
            this.pnl_NhomTho.Controls.Add(this.btn_TaiLai);
            this.pnl_NhomTho.Controls.Add(this.btn_Sua);
            this.pnl_NhomTho.Controls.Add(this.btn_Xoa);
            this.pnl_NhomTho.Controls.Add(this.btn_Them);
            this.pnl_NhomTho.Controls.Add(this.lbl_NhomTho);
            this.pnl_NhomTho.Location = new System.Drawing.Point(11, 11);
            this.pnl_NhomTho.Name = "pnl_NhomTho";
            this.pnl_NhomTho.Size = new System.Drawing.Size(1000, 485);
            this.pnl_NhomTho.TabIndex = 1;
            // 
            // dgv_NhomTho
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_NhomTho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_NhomTho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhomTho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_NhomTho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhomTho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID_NhomTho,
            this.col_Ten_NhomTho,
            this.col_ID_TruongNhom});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NhomTho.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_NhomTho.Location = new System.Drawing.Point(6, 61);
            this.dgv_NhomTho.Name = "dgv_NhomTho";
            this.dgv_NhomTho.ReadOnly = true;
            this.dgv_NhomTho.RowHeadersWidth = 51;
            this.dgv_NhomTho.RowTemplate.Height = 24;
            this.dgv_NhomTho.Size = new System.Drawing.Size(994, 350);
            this.dgv_NhomTho.TabIndex = 2;
            this.dgv_NhomTho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FS_NhomTho_CellClick);
            // 
            // col_ID_NhomTho
            // 
            this.col_ID_NhomTho.DataPropertyName = "ID_NhomTho";
            this.col_ID_NhomTho.HeaderText = "ID nhóm thợ";
            this.col_ID_NhomTho.MinimumWidth = 6;
            this.col_ID_NhomTho.Name = "col_ID_NhomTho";
            this.col_ID_NhomTho.ReadOnly = true;
            // 
            // col_Ten_NhomTho
            // 
            this.col_Ten_NhomTho.DataPropertyName = "Ten_NhomTho";
            this.col_Ten_NhomTho.HeaderText = "Tên nhóm thợ";
            this.col_Ten_NhomTho.MinimumWidth = 6;
            this.col_Ten_NhomTho.Name = "col_Ten_NhomTho";
            this.col_Ten_NhomTho.ReadOnly = true;
            // 
            // col_ID_TruongNhom
            // 
            this.col_ID_TruongNhom.DataPropertyName = "ID_TruongNhom";
            this.col_ID_TruongNhom.HeaderText = "ID trưởng nhóm";
            this.col_ID_TruongNhom.MinimumWidth = 6;
            this.col_ID_TruongNhom.Name = "col_ID_TruongNhom";
            this.col_ID_TruongNhom.ReadOnly = true;
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLai.Location = new System.Drawing.Point(848, 430);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(124, 36);
            this.btn_QuayLai.TabIndex = 7;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // btn_TaiLai
            // 
            this.btn_TaiLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaiLai.Location = new System.Drawing.Point(24, 430);
            this.btn_TaiLai.Name = "btn_TaiLai";
            this.btn_TaiLai.Size = new System.Drawing.Size(124, 36);
            this.btn_TaiLai.TabIndex = 6;
            this.btn_TaiLai.Text = "Tải lại";
            this.btn_TaiLai.UseVisualStyleBackColor = true;
            this.btn_TaiLai.Click += new System.EventHandler(this.btn_TaiLai_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(642, 430);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(124, 36);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(436, 430);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(124, 36);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(230, 430);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(124, 36);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lbl_NhomTho
            // 
            this.lbl_NhomTho.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhomTho.Location = new System.Drawing.Point(0, 5);
            this.lbl_NhomTho.Name = "lbl_NhomTho";
            this.lbl_NhomTho.Size = new System.Drawing.Size(997, 35);
            this.lbl_NhomTho.TabIndex = 1;
            this.lbl_NhomTho.Text = "NHÓM THỢ";
            this.lbl_NhomTho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FS_NhomTho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 507);
            this.Controls.Add(this.pnl_NhomTho);
            this.Name = "FS_NhomTho";
            this.Text = "FSNhomTho";
            this.pnl_NhomTho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhomTho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_NhomTho;
        private System.Windows.Forms.DataGridView dgv_NhomTho;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_TaiLai;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lbl_NhomTho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_NhomTho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ten_NhomTho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_TruongNhom;
    }
}