﻿namespace QuanLySuaChuaXe_ADO.GUI.FormReport
{
    partial class DoanhThu
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
            this.phieuThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLySuaChuaXe = new QuanLySuaChuaXe_ADO.QuanLySuaChuaXe();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.phieuThuTableAdapter = new QuanLySuaChuaXe_ADO.QuanLySuaChuaXeTableAdapters.PhieuThuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.phieuThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySuaChuaXe)).BeginInit();
            this.SuspendLayout();
            // 
            // phieuThuBindingSource
            // 
            this.phieuThuBindingSource.DataMember = "PhieuThu";
            this.phieuThuBindingSource.DataSource = this.quanLySuaChuaXe;
            // 
            // quanLySuaChuaXe
            // 
            this.quanLySuaChuaXe.DataSetName = "QuanLySuaChuaXe";
            this.quanLySuaChuaXe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PhieuThu";
            reportDataSource1.Value = this.phieuThuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySuaChuaXe_ADO.REPORT.DoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // phieuThuTableAdapter
            // 
            this.phieuThuTableAdapter.ClearBeforeFill = true;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phieuThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySuaChuaXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLySuaChuaXe quanLySuaChuaXe;
        private System.Windows.Forms.BindingSource phieuThuBindingSource;
        private QuanLySuaChuaXeTableAdapters.PhieuThuTableAdapter phieuThuTableAdapter;
    }
}