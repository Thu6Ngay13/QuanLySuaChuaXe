using BLL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI
{
    public partial class FS_HopDong : Form
    {
        private int idx = -1;

        private string id_hopdong = "";
        private string ten_hopdong = "";
        private DateTime ngaybatdau_hopdong;
        private DateTime ngayketthuc_hopdong;
        private float giatri_hopdong = 0;
        private string id_xe = "";

        public FS_HopDong()
        {
            InitializeComponent();
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            BLL_HopDong bll = new BLL_HopDong();
            dgv_HopDong.DataSource = bll.LayHopDong();

            dgv_HopDong_CellClick(null, null);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            FI_HopDong form = new FI_HopDong();
            form.ShowDialog();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (idx < 0) return;
                if (dgv_HopDong.Rows[idx].Cells[0].Value == null) return;

                BLL_HopDong bll_HopDong = new BLL_HopDong();
                BLL_ChiTietHopDong bll_ChiTietHopDong = new BLL_ChiTietHopDong();
                BLL_PhieuThu bll_PhieuThu = new BLL_PhieuThu();

                if (DialogResult.No == MessageBox.Show(
                                        "Bạn có muốn xóa không?",
                                        "Thông báo",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)) return;

                DataTable dataTable_ChiTietHopDong = bll_ChiTietHopDong.TimChiTietHopDong("", "", id_hopdong);
                for (int k = 0; k < dataTable_ChiTietHopDong.Rows.Count; ++k)
                {
                    if (!bll_ChiTietHopDong.XoaChiTietHopDong(
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

                DataTable dataTable_PhieuThu = bll_PhieuThu.TimPhieuThu_HopDong(id_hopdong);
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

                if (!bll_HopDong.XoaHopDong(id_hopdong))
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
            if (idx < 0) return;
            if (id_xe == "") return;

            BLL_Xe bll_xe = new BLL_Xe();
            BLL_KhachHang bll_khachhang = new BLL_KhachHang();

            DataTable datatable_xe = bll_xe.TimXe(id_xe);
            DataTable datatable_khachhang = bll_khachhang.LayKhachHang(datatable_xe.Rows[0].ItemArray[3].ToString());

            string loai_Xe = datatable_xe.Rows[0]["Loai_Xe"].ToString();
            string hang_xe = datatable_xe.Rows[0]["Hang_Xe"].ToString();

            string id_khachhang = datatable_khachhang.Rows[0]["ID_KhachHang"].ToString();
            string hoten_KhachHang = datatable_khachhang.Rows[0]["HoTen_KhachHang"].ToString(); ;
            bool gioiTinh_khachhang = Convert.ToBoolean(datatable_khachhang.Rows[0]["GioiTinh_KhachHang"]);
            DateTime ngaySinh_khachhang = Convert.ToDateTime(datatable_khachhang.Rows[0]["NgaySinh_KhachHang"]);
            string sodienthoai_khachhang = datatable_khachhang.Rows[0]["SoDienThoai_KhachHang"].ToString(); ;

            FI_HopDong form = new FI_HopDong(
                    id_hopdong,
                    ten_hopdong,
                    ngaybatdau_hopdong,
                    ngayketthuc_hopdong,
                    giatri_hopdong,
                    id_xe,
                    loai_Xe,
                    hang_xe,
                    id_khachhang,
                    hoten_KhachHang,
                    gioiTinh_khachhang,
                    ngaySinh_khachhang,
                    sodienthoai_khachhang);
                form.ShowDialog();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_HopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_HopDong.CurrentCell == null) return;

                idx = dgv_HopDong.CurrentCell.RowIndex;
                if (dgv_HopDong.Rows[idx].Cells[0].Value == null) return;

                id_hopdong = dgv_HopDong.Rows[idx].Cells[0].Value.ToString();
                ten_hopdong = dgv_HopDong.Rows[idx].Cells[1].Value.ToString();
                ngaybatdau_hopdong = Convert.ToDateTime(dgv_HopDong.Rows[idx].Cells[2].Value);
                ngayketthuc_hopdong = Convert.ToDateTime(dgv_HopDong.Rows[idx].Cells[3].Value);
                giatri_hopdong = (float)Convert.ToDouble(dgv_HopDong.Rows[idx].Cells[4].Value);
                id_xe = dgv_HopDong.Rows[idx].Cells[5].Value.ToString();
            }
            catch { }
        }
    }
}
