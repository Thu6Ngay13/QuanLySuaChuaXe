using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FS_Tho : Form
    {
        private int idx = -1;
        private string id_tho = "";
        private string hoten_tho = "";
        private bool gioitinh_tho;
        private DateTime ngaysinh_tho;
        private string diachi_tho = "";
        private float luong_tho = 0;
        private string id_nhomtho = "";

        public FS_Tho()
        {
            InitializeComponent();
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            BLL_Tho bll = new BLL_Tho();
            dgv_Tho.DataSource = bll.LayTho();

            dgv_FSTho_CellClick(null, null);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            FI_Tho form = new FI_Tho();
            form.ShowDialog();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (idx < 0) return;
                if (dgv_Tho.Rows[idx].Cells[0].Value == null) return;

                BLL_Tho bll_Tho = new BLL_Tho();
                BLL_KhaNang bll_KhaNang = new BLL_KhaNang();
                BLL_ChiTietHopDong bll_ChiTietHopDong = new BLL_ChiTietHopDong();

                if (DialogResult.No == MessageBox.Show(
                                        "Bạn có muốn xóa không?",
                                        "Thông báo",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)) return;

                DataTable dataTable_KhaNang = bll_KhaNang.TimKhaNang(id_tho, "");

                for (int i = 0; i < dataTable_KhaNang.Rows.Count; ++i)
                    if (!bll_KhaNang.XoaKhaNang(
                        id_tho,
                        dataTable_KhaNang.Rows[i]["ID_CongViec"].ToString()))
                    {
                        MessageBox.Show(
                            "Xóa không thành công.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                DataTable dataTable_ChiTietHopDong = bll_ChiTietHopDong.TimChiTietHopDong(id_tho, "", "");

                for (int i = 0; i < dataTable_ChiTietHopDong.Rows.Count; ++i)
                    if (!bll_ChiTietHopDong.CapNhatChiTietHopDong(
                        "",
                        dataTable_ChiTietHopDong.Rows[i]["ID_CongViec"].ToString(),
                        dataTable_ChiTietHopDong.Rows[i]["ID_HopDong"].ToString()))
                    {
                        MessageBox.Show(
                            "Xóa không thành công.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                if (!bll_Tho.XoaTho(id_tho))
                {
                    MessageBox.Show(
                            "Xóa không thành công.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(
                            "Xóa thành công.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show(
                        "Xóa không thành công, gặp lỗi.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(idx < 0) return;

            FI_Tho form = new FI_Tho(
                id_tho,
                hoten_tho,
                gioitinh_tho,
                ngaysinh_tho,
                diachi_tho,
                luong_tho,
                id_nhomtho);
            form.ShowDialog();
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_FSTho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_Tho.CurrentCell == null) return;

                idx = dgv_Tho.CurrentCell.RowIndex;
                if (dgv_Tho.Rows[idx].Cells[0].Value == null) return;

                id_tho = dgv_Tho.Rows[idx].Cells[0].Value.ToString();
                hoten_tho = dgv_Tho.Rows[idx].Cells[1].Value.ToString();
                gioitinh_tho = dgv_Tho.Rows[idx].Cells[2].Value.ToString() == "Nam";
                ngaysinh_tho = Convert.ToDateTime(dgv_Tho.Rows[idx].Cells[3].Value);
                diachi_tho = dgv_Tho.Rows[idx].Cells[4].Value.ToString();
                luong_tho = Convert.ToInt32(dgv_Tho.Rows[idx].Cells[5].Value);
                id_nhomtho = dgv_Tho.Rows[idx].Cells[6].Value.ToString();
            }
            catch { }
        }

        private void dgv_FSTho_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
