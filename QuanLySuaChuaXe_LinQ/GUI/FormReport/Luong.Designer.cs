﻿using QuanLySuaChuaXe_LinQ;
using QuanLySuaChuaXe_LinQ.QuanLySuaChuaXeTableAdapters;

namespace QuanLySuaChuaXe_LINQ.GUI.FormReport
{
    partial class Luong
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
            this.thoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLySuaChuaXe = new QuanLySuaChuaXe_LinQ.QuanLySuaChuaXe();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.thoTableAdapter = new QuanLySuaChuaXe_LinQ.QuanLySuaChuaXeTableAdapters.ThoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.thoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySuaChuaXe)).BeginInit();
            this.SuspendLayout();
            // 
            // thoBindingSource
            // 
            this.thoBindingSource.DataMember = "Tho";
            this.thoBindingSource.DataSource = this.quanLySuaChuaXe;
            // 
            // quanLySuaChuaXe
            // 
            this.quanLySuaChuaXe.DataSetName = "QuanLySuaChuaXe";
            this.quanLySuaChuaXe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Tho";
            reportDataSource1.Value = this.thoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySuaChuaXe_LinQ.REPORT.Luong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // thoTableAdapter
            // 
            this.thoTableAdapter.ClearBeforeFill = true;
            // 
            // Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Luong";
            this.Text = "Luong";
            this.Load += new System.EventHandler(this.Luong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySuaChuaXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLySuaChuaXe quanLySuaChuaXe;
        private System.Windows.Forms.BindingSource thoBindingSource;
        private ThoTableAdapter thoTableAdapter;
    }
}