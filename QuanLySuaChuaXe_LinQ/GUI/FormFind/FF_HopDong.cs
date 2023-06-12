﻿using System;
using System.Data;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FF_HopDong : Form
    {
        private int idx = -1;

        private string id_hopdong = "";
        private string id_xe = "";

        public FF_HopDong()
        {
            InitializeComponent();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_HopDong bll = new BLL_HopDong();
                dgv_HopDong.DataSource = bll.TimHopDong_Xe_KhachHang(
                    txt_Ten_HopDong.Text,
                    dtp_NgayBatDau_HopDong.Value,
                    mnt_DieuKien.SelectedItem.ToString(),
                    (float)Convert.ToDouble(txt_GiaTri_HopDong.Text),
                    txt_HoTen_KhachHang.Text,
                    dtp_NgaySinh_KhachHang.Value,
                    rdb_GioiTinh_KhachHang_Nam.Checked,
                    txt_ID_Xe.Text,
                    txt_SoDienThoai_KhachHang.Text);

                dgv_FF_HopDong_CellClick(null, null);   
            }
            catch { }

        }

        private void btn_TruyXuat_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_Xe bll_xe = new BLL_Xe();
                BLL_KhachHang bll_khachhang = new BLL_KhachHang();

                DataTable datatable_xe = bll_xe.TimXe(id_xe);
                DataTable datatable_khachhang = bll_khachhang.LayKhachHang(datatable_xe.Rows[0].ItemArray[3].ToString());

                dgv_Xe.DataSource = datatable_xe;
                dgv_KhachHang.DataSource = datatable_khachhang;
            }
            catch { }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                FI_PhieuThu form = new FI_PhieuThu(id_hopdong);
                form.ShowDialog();
            }
            catch { }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_FF_HopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_HopDong.CurrentCell == null) return;

                idx = dgv_HopDong.CurrentCell.RowIndex;
                if (dgv_HopDong.Rows[idx].Cells[0].Value == null) return;

                id_hopdong = dgv_HopDong.Rows[idx].Cells[0].Value.ToString();
                id_xe = dgv_HopDong.Rows[idx].Cells[5].Value.ToString();
            }
            catch { }
        }

        private void dgv_KhachHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int genderColumnIndex = 2;
            if (e.ColumnIndex != genderColumnIndex) return;

            if (e.Value != null && e.Value != DBNull.Value)
            {
                bool genderValue = (bool)e.Value;

                if (genderValue)
                    e.Value = "Nam";
                else
                    e.Value = "Nữ";

                e.FormattingApplied = true;
            }
        }
    }
}