namespace GUI
{
    partial class FF_CongViec
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
            this.pnl_CongViec = new System.Windows.Forms.Panel();
            this.dgv_CongViec = new System.Windows.Forms.DataGridView();
            this.col_ID_CongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ten_CongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ID_NhomCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.lbl_CongViec = new System.Windows.Forms.Label();
            this.txt_ID_NhomCongViec = new System.Windows.Forms.TextBox();
            this.txt_Ten_CongViec = new System.Windows.Forms.TextBox();
            this.txt_ID_CongViec = new System.Windows.Forms.TextBox();
            this.lbl_ID_NhomCongViec = new System.Windows.Forms.Label();
            this.lbl_Ten_CongViec = new System.Windows.Forms.Label();
            this.lbl_ID_CongViec = new System.Windows.Forms.Label();
            this.pnl_CongViec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CongViec)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_CongViec
            // 
            this.pnl_CongViec.Controls.Add(this.dgv_CongViec);
            this.pnl_CongViec.Controls.Add(this.btn_QuayLai);
            this.pnl_CongViec.Controls.Add(this.btn_TimKiem);
            this.pnl_CongViec.Controls.Add(this.lbl_CongViec);
            this.pnl_CongViec.Controls.Add(this.txt_ID_NhomCongViec);
            this.pnl_CongViec.Controls.Add(this.txt_Ten_CongViec);
            this.pnl_CongViec.Controls.Add(this.txt_ID_CongViec);
            this.pnl_CongViec.Controls.Add(this.lbl_ID_NhomCongViec);
            this.pnl_CongViec.Controls.Add(this.lbl_Ten_CongViec);
            this.pnl_CongViec.Controls.Add(this.lbl_ID_CongViec);
            this.pnl_CongViec.Location = new System.Drawing.Point(11, 11);
            this.pnl_CongViec.Name = "pnl_CongViec";
            this.pnl_CongViec.Size = new System.Drawing.Size(1000, 668);
            this.pnl_CongViec.TabIndex = 1;
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
            this.dgv_CongViec.Location = new System.Drawing.Point(1, 283);
            this.dgv_CongViec.Name = "dgv_CongViec";
            this.dgv_CongViec.ReadOnly = true;
            this.dgv_CongViec.RowHeadersWidth = 51;
            this.dgv_CongViec.RowTemplate.Height = 24;
            this.dgv_CongViec.Size = new System.Drawing.Size(996, 315);
            this.dgv_CongViec.TabIndex = 14;
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
            // btn_QuayLai
            // 
            this.btn_QuayLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_QuayLai.Location = new System.Drawing.Point(422, 614);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(130, 40);
            this.btn_QuayLai.TabIndex = 13;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TimKiem.Location = new System.Drawing.Point(422, 224);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(130, 40);
            this.btn_TimKiem.TabIndex = 12;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // lbl_CongViec
            // 
            this.lbl_CongViec.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_CongViec.Location = new System.Drawing.Point(3, 5);
            this.lbl_CongViec.Name = "lbl_CongViec";
            this.lbl_CongViec.Size = new System.Drawing.Size(994, 35);
            this.lbl_CongViec.TabIndex = 6;
            this.lbl_CongViec.Text = "TÌM THÔNG TIN CÔNG VIỆC";
            this.lbl_CongViec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ID_NhomCongViec
            // 
            this.txt_ID_NhomCongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID_NhomCongViec.Location = new System.Drawing.Point(391, 181);
            this.txt_ID_NhomCongViec.Name = "txt_ID_NhomCongViec";
            this.txt_ID_NhomCongViec.Size = new System.Drawing.Size(405, 30);
            this.txt_ID_NhomCongViec.TabIndex = 5;
            // 
            // txt_Ten_CongViec
            // 
            this.txt_Ten_CongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten_CongViec.Location = new System.Drawing.Point(391, 136);
            this.txt_Ten_CongViec.Name = "txt_Ten_CongViec";
            this.txt_Ten_CongViec.Size = new System.Drawing.Size(405, 30);
            this.txt_Ten_CongViec.TabIndex = 4;
            // 
            // txt_ID_CongViec
            // 
            this.txt_ID_CongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID_CongViec.Location = new System.Drawing.Point(391, 92);
            this.txt_ID_CongViec.Name = "txt_ID_CongViec";
            this.txt_ID_CongViec.Size = new System.Drawing.Size(405, 30);
            this.txt_ID_CongViec.TabIndex = 3;
            // 
            // lbl_ID_NhomCongViec
            // 
            this.lbl_ID_NhomCongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_NhomCongViec.Location = new System.Drawing.Point(198, 181);
            this.lbl_ID_NhomCongViec.Name = "lbl_ID_NhomCongViec";
            this.lbl_ID_NhomCongViec.Size = new System.Drawing.Size(188, 23);
            this.lbl_ID_NhomCongViec.TabIndex = 2;
            this.lbl_ID_NhomCongViec.Text = "ID nhóm công việc ";
            // 
            // lbl_Ten_CongViec
            // 
            this.lbl_Ten_CongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten_CongViec.Location = new System.Drawing.Point(198, 136);
            this.lbl_Ten_CongViec.Name = "lbl_Ten_CongViec";
            this.lbl_Ten_CongViec.Size = new System.Drawing.Size(184, 23);
            this.lbl_Ten_CongViec.TabIndex = 1;
            this.lbl_Ten_CongViec.Text = "Tên công việc ";
            // 
            // lbl_ID_CongViec
            // 
            this.lbl_ID_CongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_CongViec.Location = new System.Drawing.Point(198, 91);
            this.lbl_ID_CongViec.Name = "lbl_ID_CongViec";
            this.lbl_ID_CongViec.Size = new System.Drawing.Size(180, 23);
            this.lbl_ID_CongViec.TabIndex = 0;
            this.lbl_ID_CongViec.Text = "ID công việc ";
            // 
            // FF_CongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 686);
            this.Controls.Add(this.pnl_CongViec);
            this.Name = "FF_CongViec";
            this.Text = "FF_CongViec";
            this.pnl_CongViec.ResumeLayout(false);
            this.pnl_CongViec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CongViec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_CongViec;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label lbl_CongViec;
        private System.Windows.Forms.TextBox txt_ID_NhomCongViec;
        private System.Windows.Forms.TextBox txt_Ten_CongViec;
        private System.Windows.Forms.TextBox txt_ID_CongViec;
        private System.Windows.Forms.Label lbl_ID_NhomCongViec;
        private System.Windows.Forms.Label lbl_Ten_CongViec;
        private System.Windows.Forms.Label lbl_ID_CongViec;
        private System.Windows.Forms.DataGridView dgv_CongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_CongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ten_CongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_NhomCongViec;
    }
}