namespace GUI
{
    partial class FI_NhomTho
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
            this.pnl_NhomTho = new System.Windows.Forms.Panel();
            this.txt_Ten_NhomTho = new System.Windows.Forms.TextBox();
            this.txt_ID_NhomTho = new System.Windows.Forms.TextBox();
            this.lbl_Ten_NhomTho = new System.Windows.Forms.Label();
            this.lbl_ID_NhomTho = new System.Windows.Forms.Label();
            this.lbl_NhomTho = new System.Windows.Forms.Label();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Tho = new System.Windows.Forms.Label();
            this.trv_Tho = new System.Windows.Forms.TreeView();
            this.pnl_NhomTho.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_NhomTho
            // 
            this.pnl_NhomTho.Controls.Add(this.txt_Ten_NhomTho);
            this.pnl_NhomTho.Controls.Add(this.txt_ID_NhomTho);
            this.pnl_NhomTho.Controls.Add(this.lbl_Ten_NhomTho);
            this.pnl_NhomTho.Controls.Add(this.lbl_ID_NhomTho);
            this.pnl_NhomTho.Controls.Add(this.lbl_NhomTho);
            this.pnl_NhomTho.Location = new System.Drawing.Point(11, 11);
            this.pnl_NhomTho.Name = "pnl_NhomTho";
            this.pnl_NhomTho.Size = new System.Drawing.Size(1000, 205);
            this.pnl_NhomTho.TabIndex = 1;
            // 
            // txt_Ten_NhomTho
            // 
            this.txt_Ten_NhomTho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten_NhomTho.Location = new System.Drawing.Point(442, 149);
            this.txt_Ten_NhomTho.Name = "txt_Ten_NhomTho";
            this.txt_Ten_NhomTho.Size = new System.Drawing.Size(282, 30);
            this.txt_Ten_NhomTho.TabIndex = 6;
            // 
            // txt_ID_NhomTho
            // 
            this.txt_ID_NhomTho.Enabled = false;
            this.txt_ID_NhomTho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID_NhomTho.Location = new System.Drawing.Point(442, 101);
            this.txt_ID_NhomTho.Name = "txt_ID_NhomTho";
            this.txt_ID_NhomTho.Size = new System.Drawing.Size(282, 30);
            this.txt_ID_NhomTho.TabIndex = 5;
            // 
            // lbl_Ten_NhomTho
            // 
            this.lbl_Ten_NhomTho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten_NhomTho.Location = new System.Drawing.Point(237, 148);
            this.lbl_Ten_NhomTho.Name = "lbl_Ten_NhomTho";
            this.lbl_Ten_NhomTho.Size = new System.Drawing.Size(162, 30);
            this.lbl_Ten_NhomTho.TabIndex = 2;
            this.lbl_Ten_NhomTho.Text = "Tên nhóm thợ";
            this.lbl_Ten_NhomTho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ID_NhomTho
            // 
            this.lbl_ID_NhomTho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_NhomTho.Location = new System.Drawing.Point(237, 100);
            this.lbl_ID_NhomTho.Name = "lbl_ID_NhomTho";
            this.lbl_ID_NhomTho.Size = new System.Drawing.Size(162, 30);
            this.lbl_ID_NhomTho.TabIndex = 1;
            this.lbl_ID_NhomTho.Text = "ID nhóm thợ";
            this.lbl_ID_NhomTho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_NhomTho
            // 
            this.lbl_NhomTho.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhomTho.Location = new System.Drawing.Point(3, 2);
            this.lbl_NhomTho.Name = "lbl_NhomTho";
            this.lbl_NhomTho.Size = new System.Drawing.Size(994, 35);
            this.lbl_NhomTho.TabIndex = 0;
            this.lbl_NhomTho.Text = "NHẬP THÔNG TIN NHÓM THỢ";
            this.lbl_NhomTho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLai.Location = new System.Drawing.Point(694, 236);
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
            this.btn_Luu.Location = new System.Drawing.Point(533, 236);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(136, 37);
            this.btn_Luu.TabIndex = 3;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Tho);
            this.panel1.Controls.Add(this.trv_Tho);
            this.panel1.Location = new System.Drawing.Point(1014, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 203);
            this.panel1.TabIndex = 25;
            // 
            // lbl_Tho
            // 
            this.lbl_Tho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Tho.Location = new System.Drawing.Point(3, 1);
            this.lbl_Tho.Name = "lbl_Tho";
            this.lbl_Tho.Size = new System.Drawing.Size(328, 35);
            this.lbl_Tho.TabIndex = 31;
            this.lbl_Tho.Text = "TRƯỞNG NHÓM";
            this.lbl_Tho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trv_Tho
            // 
            this.trv_Tho.CheckBoxes = true;
            this.trv_Tho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trv_Tho.Location = new System.Drawing.Point(3, 39);
            this.trv_Tho.Name = "trv_Tho";
            this.trv_Tho.Size = new System.Drawing.Size(328, 161);
            this.trv_Tho.TabIndex = 30;
            this.trv_Tho.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trv_Tho_AfterCheck);
            // 
            // FI_NhomTho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 293);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_NhomTho);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.btn_Luu);
            this.Name = "FI_NhomTho";
            this.Text = "FINhomTho";
            this.pnl_NhomTho.ResumeLayout(false);
            this.pnl_NhomTho.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_NhomTho;
        private System.Windows.Forms.TextBox txt_Ten_NhomTho;
        private System.Windows.Forms.TextBox txt_ID_NhomTho;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label lbl_Ten_NhomTho;
        private System.Windows.Forms.Label lbl_ID_NhomTho;
        private System.Windows.Forms.Label lbl_NhomTho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Tho;
        private System.Windows.Forms.TreeView trv_Tho;
    }
}