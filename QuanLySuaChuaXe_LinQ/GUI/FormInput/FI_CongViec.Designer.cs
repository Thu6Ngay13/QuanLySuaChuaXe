namespace GUI
{
    partial class FI_CongViec
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
            this.pnl_CongViec = new System.Windows.Forms.Panel();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.lbl_CongViec = new System.Windows.Forms.Label();
            this.txt_ID_NhomCongViec = new System.Windows.Forms.TextBox();
            this.txt_Ten_CongViec = new System.Windows.Forms.TextBox();
            this.txt_ID_CongViec = new System.Windows.Forms.TextBox();
            this.lbl_ID_NhomCongViec = new System.Windows.Forms.Label();
            this.lbl_Ten_CongViec = new System.Windows.Forms.Label();
            this.lbl_ID_CongViec = new System.Windows.Forms.Label();
            this.pnl_CongViec.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_CongViec
            // 
            this.pnl_CongViec.Controls.Add(this.btn_QuayLai);
            this.pnl_CongViec.Controls.Add(this.btn_Luu);
            this.pnl_CongViec.Controls.Add(this.lbl_CongViec);
            this.pnl_CongViec.Controls.Add(this.txt_ID_NhomCongViec);
            this.pnl_CongViec.Controls.Add(this.txt_Ten_CongViec);
            this.pnl_CongViec.Controls.Add(this.txt_ID_CongViec);
            this.pnl_CongViec.Controls.Add(this.lbl_ID_NhomCongViec);
            this.pnl_CongViec.Controls.Add(this.lbl_Ten_CongViec);
            this.pnl_CongViec.Controls.Add(this.lbl_ID_CongViec);
            this.pnl_CongViec.Location = new System.Drawing.Point(12, 12);
            this.pnl_CongViec.Name = "pnl_CongViec";
            this.pnl_CongViec.Size = new System.Drawing.Size(1000, 350);
            this.pnl_CongViec.TabIndex = 0;
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_QuayLai.Location = new System.Drawing.Point(530, 276);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(130, 40);
            this.btn_QuayLai.TabIndex = 13;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Luu.Location = new System.Drawing.Point(322, 276);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(130, 40);
            this.btn_Luu.TabIndex = 12;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // lbl_CongViec
            // 
            this.lbl_CongViec.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_CongViec.Location = new System.Drawing.Point(3, 3);
            this.lbl_CongViec.Name = "lbl_CongViec";
            this.lbl_CongViec.Size = new System.Drawing.Size(997, 35);
            this.lbl_CongViec.TabIndex = 6;
            this.lbl_CongViec.Text = "NHẬP CÔNG VIỆC";
            this.lbl_CongViec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ID_NhomCongViec
            // 
            this.txt_ID_NhomCongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID_NhomCongViec.Location = new System.Drawing.Point(392, 210);
            this.txt_ID_NhomCongViec.Name = "txt_ID_NhomCongViec";
            this.txt_ID_NhomCongViec.Size = new System.Drawing.Size(405, 30);
            this.txt_ID_NhomCongViec.TabIndex = 5;
            // 
            // txt_Ten_CongViec
            // 
            this.txt_Ten_CongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten_CongViec.Location = new System.Drawing.Point(392, 150);
            this.txt_Ten_CongViec.Name = "txt_Ten_CongViec";
            this.txt_Ten_CongViec.Size = new System.Drawing.Size(405, 30);
            this.txt_Ten_CongViec.TabIndex = 4;
            // 
            // txt_ID_CongViec
            // 
            this.txt_ID_CongViec.Enabled = false;
            this.txt_ID_CongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID_CongViec.Location = new System.Drawing.Point(391, 92);
            this.txt_ID_CongViec.Name = "txt_ID_CongViec";
            this.txt_ID_CongViec.Size = new System.Drawing.Size(405, 30);
            this.txt_ID_CongViec.TabIndex = 3;
            // 
            // lbl_ID_NhomCongViec
            // 
            this.lbl_ID_NhomCongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_NhomCongViec.Location = new System.Drawing.Point(205, 210);
            this.lbl_ID_NhomCongViec.Name = "lbl_ID_NhomCongViec";
            this.lbl_ID_NhomCongViec.Size = new System.Drawing.Size(172, 23);
            this.lbl_ID_NhomCongViec.TabIndex = 2;
            this.lbl_ID_NhomCongViec.Text = "ID nhóm công việc ";
            // 
            // lbl_Ten_CongViec
            // 
            this.lbl_Ten_CongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten_CongViec.Location = new System.Drawing.Point(205, 150);
            this.lbl_Ten_CongViec.Name = "lbl_Ten_CongViec";
            this.lbl_Ten_CongViec.Size = new System.Drawing.Size(129, 23);
            this.lbl_Ten_CongViec.TabIndex = 1;
            this.lbl_Ten_CongViec.Text = "Tên công việc ";
            // 
            // lbl_ID_CongViec
            // 
            this.lbl_ID_CongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_CongViec.Location = new System.Drawing.Point(205, 87);
            this.lbl_ID_CongViec.Name = "lbl_ID_CongViec";
            this.lbl_ID_CongViec.Size = new System.Drawing.Size(119, 23);
            this.lbl_ID_CongViec.TabIndex = 0;
            this.lbl_ID_CongViec.Text = "ID công việc ";
            // 
            // FI_CongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 373);
            this.Controls.Add(this.pnl_CongViec);
            this.Name = "FI_CongViec";
            this.Text = "FICongViec";
            this.pnl_CongViec.ResumeLayout(false);
            this.pnl_CongViec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_CongViec;
        private System.Windows.Forms.Label lbl_CongViec;
        private System.Windows.Forms.TextBox txt_ID_NhomCongViec;
        private System.Windows.Forms.TextBox txt_Ten_CongViec;
        private System.Windows.Forms.TextBox txt_ID_CongViec;
        private System.Windows.Forms.Label lbl_ID_NhomCongViec;
        private System.Windows.Forms.Label lbl_Ten_CongViec;
        private System.Windows.Forms.Label lbl_ID_CongViec;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_Luu;
    }
}