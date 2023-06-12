using BLL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FF_Tho : Form
    {
        public FF_Tho()
        {
            InitializeComponent();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_Tho bll = new BLL_Tho();
                dgv_Tho.DataSource = bll.TimKiemTho(
                    txt_ID_Tho.Text,
                    txt_HoTen_Tho.Text,
                    rdb_GioiTinh_Tho_Nam.Checked,
                    dtp_NgaySinh_Tho.Value,
                    txt_DiaChi_Tho.Text,
                    mnt_DieuKien.SelectedItem.ToString(),
                    (float)Convert.ToDouble(txt_Luong_Tho.Text),
                    txt_IDNhom_Tho.Text); ;
            }
            catch { }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_FF_Tho_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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