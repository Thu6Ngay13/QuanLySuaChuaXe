﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySuaChuaXe_LINQ.GUI.FormReport
{
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySuaChuaXe.PhieuThu' table. You can move, or remove it, as needed.
            this.phieuThuTableAdapter.Fill(this.quanLySuaChuaXe.PhieuThu);

            this.reportViewer1.RefreshReport();
        }
    }
}