namespace GUI
{
    partial class FI_NhomCongViec
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
            this.pnl_NhomCongViec = new System.Windows.Forms.Panel();
            this.txt_Ten_NhomCongViec = new System.Windows.Forms.TextBox();
            this.txt_ID_NhomCongViec = new System.Windows.Forms.TextBox();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.lbl_Ten_NhomCongViec = new System.Windows.Forms.Label();
            this.lbl_ID_NhomCongViec = new System.Windows.Forms.Label();
            this.lbl_NhomCongViec = new System.Windows.Forms.Label();
            this.pnl_NhomCongViec.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_NhomCongViec
            // 
            this.pnl_NhomCongViec.Controls.Add(this.txt_Ten_NhomCongViec);
            this.pnl_NhomCongViec.Controls.Add(this.txt_ID_NhomCongViec);
            this.pnl_NhomCongViec.Controls.Add(this.btn_QuayLai);
            this.pnl_NhomCongViec.Controls.Add(this.btn_Luu);
            this.pnl_NhomCongViec.Controls.Add(this.lbl_Ten_NhomCongViec);
            this.pnl_NhomCongViec.Controls.Add(this.lbl_ID_NhomCongViec);
            this.pnl_NhomCongViec.Controls.Add(this.lbl_NhomCongViec);
            this.pnl_NhomCongViec.Location = new System.Drawing.Point(10, 10);
            this.pnl_NhomCongViec.Name = "pnl_NhomCongViec";
            this.pnl_NhomCongViec.Size = new System.Drawing.Size(1000, 300);
            this.pnl_NhomCongViec.TabIndex = 0;
            // 
            // txt_Ten_NhomCongViec
            // 
            this.txt_Ten_NhomCongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten_NhomCongViec.Location = new System.Drawing.Point(454, 163);
            this.txt_Ten_NhomCongViec.Name = "txt_Ten_NhomCongViec";
            this.txt_Ten_NhomCongViec.Size = new System.Drawing.Size(282, 30);
            this.txt_Ten_NhomCongViec.TabIndex = 6;
            // 
            // txt_ID_NhomCongViec
            // 
            this.txt_ID_NhomCongViec.Enabled = false;
            this.txt_ID_NhomCongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID_NhomCongViec.Location = new System.Drawing.Point(454, 112);
            this.txt_ID_NhomCongViec.Name = "txt_ID_NhomCongViec";
            this.txt_ID_NhomCongViec.Size = new System.Drawing.Size(282, 30);
            this.txt_ID_NhomCongViec.TabIndex = 5;
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLai.Location = new System.Drawing.Point(511, 228);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(140, 37);
            this.btn_QuayLai.TabIndex = 4;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(350, 228);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(136, 37);
            this.btn_Luu.TabIndex = 3;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // lbl_Ten_NhomCongViec
            // 
            this.lbl_Ten_NhomCongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten_NhomCongViec.Location = new System.Drawing.Point(249, 162);
            this.lbl_Ten_NhomCongViec.Name = "lbl_Ten_NhomCongViec";
            this.lbl_Ten_NhomCongViec.Size = new System.Drawing.Size(190, 29);
            this.lbl_Ten_NhomCongViec.TabIndex = 2;
            this.lbl_Ten_NhomCongViec.Text = "Tên nhóm công việc";
            this.lbl_Ten_NhomCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ID_NhomCongViec
            // 
            this.lbl_ID_NhomCongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_NhomCongViec.Location = new System.Drawing.Point(249, 111);
            this.lbl_ID_NhomCongViec.Name = "lbl_ID_NhomCongViec";
            this.lbl_ID_NhomCongViec.Size = new System.Drawing.Size(190, 30);
            this.lbl_ID_NhomCongViec.TabIndex = 1;
            this.lbl_ID_NhomCongViec.Text = "ID nhóm công việc";
            this.lbl_ID_NhomCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_NhomCongViec
            // 
            this.lbl_NhomCongViec.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhomCongViec.Location = new System.Drawing.Point(3, 1);
            this.lbl_NhomCongViec.Name = "lbl_NhomCongViec";
            this.lbl_NhomCongViec.Size = new System.Drawing.Size(994, 35);
            this.lbl_NhomCongViec.TabIndex = 0;
            this.lbl_NhomCongViec.Text = "NHẬP THÔNG TIN NHÓM CÔNG VIỆC ";
            this.lbl_NhomCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FI_NhomCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 323);
            this.Controls.Add(this.pnl_NhomCongViec);
            this.Name = "FI_NhomCongViec";
            this.Text = "FINhomCongViec";
            this.pnl_NhomCongViec.ResumeLayout(false);
            this.pnl_NhomCongViec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_NhomCongViec;
        private System.Windows.Forms.Label lbl_NhomCongViec;
        private System.Windows.Forms.TextBox txt_Ten_NhomCongViec;
        private System.Windows.Forms.TextBox txt_ID_NhomCongViec;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label lbl_Ten_NhomCongViec;
        private System.Windows.Forms.Label lbl_ID_NhomCongViec;
    }
}