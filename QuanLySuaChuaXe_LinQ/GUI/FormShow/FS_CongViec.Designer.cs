namespace GUI
{
    partial class FS_CongViec
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_CongViec = new System.Windows.Forms.Label();
            this.btn_TaiLai = new System.Windows.Forms.Button();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgv_CongViec = new System.Windows.Forms.DataGridView();
            this.col_ID_CongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ten_CongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ID_NhomCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CongViec)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_CongViec);
            this.panel1.Controls.Add(this.btn_TaiLai);
            this.panel1.Controls.Add(this.btn_QuayLai);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.dgv_CongViec);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 432);
            this.panel1.TabIndex = 0;
            // 
            // lbl_CongViec
            // 
            this.lbl_CongViec.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_CongViec.Location = new System.Drawing.Point(0, 2);
            this.lbl_CongViec.Name = "lbl_CongViec";
            this.lbl_CongViec.Size = new System.Drawing.Size(998, 35);
            this.lbl_CongViec.TabIndex = 19;
            this.lbl_CongViec.Text = "Công Việc";
            this.lbl_CongViec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_TaiLai
            // 
            this.btn_TaiLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TaiLai.Location = new System.Drawing.Point(15, 372);
            this.btn_TaiLai.Name = "btn_TaiLai";
            this.btn_TaiLai.Size = new System.Drawing.Size(124, 43);
            this.btn_TaiLai.TabIndex = 18;
            this.btn_TaiLai.Text = "Tải lại";
            this.btn_TaiLai.UseVisualStyleBackColor = true;
            this.btn_TaiLai.Click += new System.EventHandler(this.btn_TaiLai_Click);
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_QuayLai.Location = new System.Drawing.Point(846, 372);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(124, 43);
            this.btn_QuayLai.TabIndex = 17;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(569, 372);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(124, 43);
            this.btn_Sua.TabIndex = 16;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.Location = new System.Drawing.Point(292, 372);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(124, 43);
            this.btn_Them.TabIndex = 14;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgv_CongViec
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_CongViec.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CongViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CongViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID_CongViec,
            this.col_Ten_CongViec,
            this.col_ID_NhomCongViec});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CongViec.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_CongViec.Location = new System.Drawing.Point(0, 61);
            this.dgv_CongViec.Name = "dgv_CongViec";
            this.dgv_CongViec.ReadOnly = true;
            this.dgv_CongViec.RowHeadersWidth = 51;
            this.dgv_CongViec.RowTemplate.Height = 24;
            this.dgv_CongViec.Size = new System.Drawing.Size(998, 290);
            this.dgv_CongViec.TabIndex = 13;
            this.dgv_CongViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CongViec_CellClick);
            // 
            // col_ID_CongViec
            // 
            this.col_ID_CongViec.DataPropertyName = "ID_CongViec";
            this.col_ID_CongViec.HeaderText = "ID công việc";
            this.col_ID_CongViec.MinimumWidth = 6;
            this.col_ID_CongViec.Name = "col_ID_CongViec";
            this.col_ID_CongViec.ReadOnly = true;
            // 
            // col_Ten_CongViec
            // 
            this.col_Ten_CongViec.DataPropertyName = "Ten_CongViec";
            this.col_Ten_CongViec.HeaderText = "Tên công việc";
            this.col_Ten_CongViec.MinimumWidth = 6;
            this.col_Ten_CongViec.Name = "col_Ten_CongViec";
            this.col_Ten_CongViec.ReadOnly = true;
            // 
            // col_ID_NhomCongViec
            // 
            this.col_ID_NhomCongViec.DataPropertyName = "ID_NhomCongViec";
            this.col_ID_NhomCongViec.HeaderText = "ID nhóm công việc";
            this.col_ID_NhomCongViec.MinimumWidth = 6;
            this.col_ID_NhomCongViec.Name = "col_ID_NhomCongViec";
            this.col_ID_NhomCongViec.ReadOnly = true;
            // 
            // FS_CongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 456);
            this.Controls.Add(this.panel1);
            this.Name = "FS_CongViec";
            this.Text = "FSCongViec";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CongViec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_CongViec;
        private System.Windows.Forms.Button btn_TaiLai;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_CongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_CongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ten_CongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_NhomCongViec;
    }
}