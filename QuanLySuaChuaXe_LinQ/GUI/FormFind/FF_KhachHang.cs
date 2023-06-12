using BLL;
using System.Data;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FF_KhachHang : Form
    {
        public FF_KhachHang()
        {
            InitializeComponent();
        }

        private void btn_TimKiem_Click(object sender, System.EventArgs e)
        {
            try
            {
                BLL_KhachHang bll = new BLL_KhachHang();
                dgv_KhachHang.DataSource = bll.TimKhachHang(
                    txt_ID_KhachHang.Text,
                    txt_HoTen_KhachHang.Text,
                    rdb_GioiTinh_KhachHang_Nam.Checked,
                    dtp_NgaySinh_KhachHang.Value,
                    txt_SoDienThoai_KhachHang.Text);
            }
            catch { }
        }

        private void btn_QuayLai_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void dgv_FF_KhachHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
