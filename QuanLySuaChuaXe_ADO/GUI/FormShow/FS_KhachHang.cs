using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FS_KhachHang : Form
    {
        private int idx = -1;
        private string id_KhachHang = "";
        private string hoten_KhachHang = "";
        private bool gioitinh_KhachHang;
        private DateTime ngaysinh_KhachHang;
        private string sodienthoai_KhachHang;

        public FS_KhachHang()
        {
            InitializeComponent();
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            datatable.Clear();

            BLL_KhachHang bll = new BLL_KhachHang();
            DataSet dataset = bll.LayKhachHang("");

            datatable = dataset.Tables[0];
            dgv_KhachHang.DataSource = datatable;

            dgv_FSKhachHang_CellClick(null, null);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            FI_KhachHang form = new FI_KhachHang();
            form.ShowDialog();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (idx < 0) return;
                if (dgv_KhachHang.Rows[idx].Cells[0].Value == null) return;

                BLL_KhachHang bll_KhachHang = new BLL_KhachHang();
                BLL_Xe bll_Xe = new BLL_Xe();
                BLL_HopDong bll_HopDong = new BLL_HopDong();
                BLL_ChiTietHopDong bll_ChiTietHopDong = new BLL_ChiTietHopDong();
                BLL_PhieuThu bll_PhieuThu = new BLL_PhieuThu();

                if (DialogResult.No == MessageBox.Show(
                                        "Bạn có muốn xóa không?",
                                        "Thông báo",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)) return;

                DataSet dataSet_Xe = bll_Xe.TimXe_KhachHang(id_KhachHang);
                DataTable dataTable_Xe = dataSet_Xe.Tables[0];

                for (int i = 0; i < dataTable_Xe.Rows.Count; ++i)
                {
                    DataSet dataSet_HopDong = bll_HopDong.TimHopDong_Xe(
                        dataTable_Xe.Rows[i]["ID_Xe"].ToString());
                    DataTable dataTable_HopDong = dataSet_HopDong.Tables[0];

                    for (int j = 0; j < dataTable_HopDong.Rows.Count; ++j)
                    {
                        DataSet dataSet_ChiTietHopDong = bll_ChiTietHopDong.TimChiTietHopDong("", "",
                            dataTable_HopDong.Rows[j]["ID_HopDong"].ToString());
                        DataTable dataTable_ChiTietHopDong = dataSet_ChiTietHopDong.Tables[0];
                        for (int k = 0; k < dataTable_ChiTietHopDong.Rows.Count; ++k)
                        {
                            if(!bll_ChiTietHopDong.XoaChiTietHopDong(
                                dataTable_ChiTietHopDong.Rows[k]["ID_Tho"].ToString(),
                                dataTable_ChiTietHopDong.Rows[k]["ID_CongViec"].ToString(),
                                dataTable_ChiTietHopDong.Rows[k]["ID_HopDong"].ToString()))
                            {
                                MessageBox.Show(
                                    "Xóa không thành công.",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                                return;
                            }
                        }

                        DataSet dataSet_PhieuThu = bll_PhieuThu.TimPhieuThu_HopDong(
                            dataTable_HopDong.Rows[j]["ID_HopDong"].ToString());
                        DataTable dataTable_PhieuThu = dataSet_PhieuThu.Tables[0];
                        for (int k = 0; k < dataTable_PhieuThu.Rows.Count; ++k)
                        {
                            if (!bll_PhieuThu.XoaPhieuThu(
                                dataTable_PhieuThu.Rows[k]["ID_PhieuThu"].ToString()))
                            {
                                MessageBox.Show(
                                    "Xóa không thành công.",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                                return;
                            }
                        }

                        if(!bll_HopDong.XoaHopDong(dataTable_HopDong.Rows[j]["ID_HopDong"].ToString()))
                        {
                            MessageBox.Show(
                                "Xóa không thành công.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if(!bll_Xe.XoaXe(dataTable_Xe.Rows[i]["ID_Xe"].ToString()))
                    {
                        MessageBox.Show(
                            "Xóa không thành công.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }

                if(!bll_KhachHang.XoaKhachHang(id_KhachHang))
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

            FI_KhachHang form = new FI_KhachHang(
                id_KhachHang,
                hoten_KhachHang,
                gioitinh_KhachHang,
                ngaysinh_KhachHang,
                sodienthoai_KhachHang);
            form.ShowDialog();
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_FSKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_KhachHang.CurrentCell == null) return;

                idx = dgv_KhachHang.CurrentCell.RowIndex;
                if (dgv_KhachHang.Rows[idx].Cells[0].Value == null) return;

                id_KhachHang = dgv_KhachHang.Rows[idx].Cells[0].Value.ToString();
                hoten_KhachHang = dgv_KhachHang.Rows[idx].Cells[1].Value.ToString();
                gioitinh_KhachHang = dgv_KhachHang.Rows[idx].Cells[2].Value.ToString() == "Nam";
                ngaysinh_KhachHang = Convert.ToDateTime(dgv_KhachHang.Rows[idx].Cells[3].Value);
                sodienthoai_KhachHang = dgv_KhachHang.Rows[idx].Cells[4].Value.ToString();
            }
            catch { }
        }

        private void dgv_FSKhachHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
