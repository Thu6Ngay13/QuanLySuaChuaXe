namespace GUI
{
    partial class FS_NhomCongViec
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
            this.pnl_NhomCongViec = new System.Windows.Forms.Panel();
            this.dgv_NhomCongViec = new System.Windows.Forms.DataGridView();
            this.col_ID_NhomCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ten_NhomCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_TaiLai = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lbl_NhomCongViec = new System.Windows.Forms.Label();
            this.pnl_NhomCongViec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhomCongViec)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_NhomCongViec
            // 
            this.pnl_NhomCongViec.Controls.Add(this.dgv_NhomCongViec);
            this.pnl_NhomCongViec.Controls.Add(this.btn_QuayLai);
            this.pnl_NhomCongViec.Controls.Add(this.btn_TaiLai);
            this.pnl_NhomCongViec.Controls.Add(this.btn_Sua);
            this.pnl_NhomCongViec.Controls.Add(this.btn_Them);
            this.pnl_NhomCongViec.Controls.Add(this.lbl_NhomCongViec);
            this.pnl_NhomCongViec.Location = new System.Drawing.Point(10, 10);
            this.pnl_NhomCongViec.Name = "pnl_NhomCongViec";
            this.pnl_NhomCongViec.Size = new System.Drawing.Size(1000, 488);
            this.pnl_NhomCongViec.TabIndex = 0;
            // 
            // dgv_NhomCongViec
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_NhomCongViec.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_NhomCongViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhomCongViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_NhomCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhomCongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID_NhomCongViec,
            this.col_Ten_NhomCongViec});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NhomCongViec.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_NhomCongViec.Location = new System.Drawing.Point(3, 60);
            this.dgv_NhomCongViec.Name = "dgv_NhomCongViec";
            this.dgv_NhomCongViec.ReadOnly = true;
            this.dgv_NhomCongViec.RowHeadersWidth = 51;
            this.dgv_NhomCongViec.RowTemplate.Height = 24;
            this.dgv_NhomCongViec.Size = new System.Drawing.Size(994, 350);
            this.dgv_NhomCongViec.TabIndex = 2;
            this.dgv_NhomCongViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FS_NhomCongViec_CellClick);
            // 
            // col_ID_NhomCongViec
            // 
            this.col_ID_NhomCongViec.DataPropertyName = "ID_NhomCongViec";
            this.col_ID_NhomCongViec.HeaderText = "ID nhóm công việc";
            this.col_ID_NhomCongViec.MinimumWidth = 6;
            this.col_ID_NhomCongViec.Name = "col_ID_NhomCongViec";
            this.col_ID_NhomCongViec.ReadOnly = true;
            // 
            // col_Ten_NhomCongViec
            // 
            this.col_Ten_NhomCongViec.DataPropertyName = "Ten_NhomCongViec";
            this.col_Ten_NhomCongViec.HeaderText = "Tên nhóm công việc";
            this.col_Ten_NhomCongViec.MinimumWidth = 6;
            this.col_Ten_NhomCongViec.Name = "col_Ten_NhomCongViec";
            this.col_Ten_NhomCongViec.ReadOnly = true;
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLai.Location = new System.Drawing.Point(846, 431);
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
            this.btn_TaiLai.Location = new System.Drawing.Point(24, 431);
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
            this.btn_Sua.Location = new System.Drawing.Point(572, 431);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(124, 36);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(298, 431);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(124, 36);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lbl_NhomCongViec
            // 
            this.lbl_NhomCongViec.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhomCongViec.Location = new System.Drawing.Point(3, 6);
            this.lbl_NhomCongViec.Name = "lbl_NhomCongViec";
            this.lbl_NhomCongViec.Size = new System.Drawing.Size(994, 35);
            this.lbl_NhomCongViec.TabIndex = 1;
            this.lbl_NhomCongViec.Text = "NHÓM CÔNG VIỆC";
            this.lbl_NhomCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FS_NhomCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 512);
            this.Controls.Add(this.pnl_NhomCongViec);
            this.Name = "FS_NhomCongViec";
            this.Text = "FSNhomCongViec";
            this.pnl_NhomCongViec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhomCongViec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_NhomCongViec;
        private System.Windows.Forms.Label lbl_NhomCongViec;
        private System.Windows.Forms.DataGridView dgv_NhomCongViec;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_TaiLai;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_NhomCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ten_NhomCongViec;
    }
}