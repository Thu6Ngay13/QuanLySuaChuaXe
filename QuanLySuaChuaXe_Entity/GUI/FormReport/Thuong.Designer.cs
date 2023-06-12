namespace QuanLySuaChuaXe_Entity.GUI.FormReport
{
    partial class Thuong
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLySuaChuaXe = new QuanLySuaChuaXe_Entity.QuanLySuaChuaXe();
            this.quanLySuaChuaXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thoTableAdapter = new QuanLySuaChuaXe_Entity.QuanLySuaChuaXeTableAdapters.ThoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySuaChuaXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySuaChuaXeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Tho";
            reportDataSource1.Value = this.thoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySuaChuaXe_Entity.REPORT.Thuong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // quanLySuaChuaXe
            // 
            this.quanLySuaChuaXe.DataSetName = "QuanLySuaChuaXe";
            this.quanLySuaChuaXe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLySuaChuaXeBindingSource
            // 
            this.quanLySuaChuaXeBindingSource.DataSource = this.quanLySuaChuaXe;
            this.quanLySuaChuaXeBindingSource.Position = 0;
            // 
            // thoBindingSource
            // 
            this.thoBindingSource.DataMember = "Tho";
            this.thoBindingSource.DataSource = this.quanLySuaChuaXe;
            // 
            // thoTableAdapter
            // 
            this.thoTableAdapter.ClearBeforeFill = true;
            // 
            // Thuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Thuong";
            this.Text = "Thuong";
            this.Load += new System.EventHandler(this.Thuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLySuaChuaXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySuaChuaXeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLySuaChuaXe quanLySuaChuaXe;
        private System.Windows.Forms.BindingSource quanLySuaChuaXeBindingSource;
        private System.Windows.Forms.BindingSource thoBindingSource;
        private QuanLySuaChuaXeTableAdapters.ThoTableAdapter thoTableAdapter;
    }
}