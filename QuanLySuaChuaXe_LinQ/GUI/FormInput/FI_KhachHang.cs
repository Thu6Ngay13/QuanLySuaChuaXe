using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using BLL;
using Tool;

namespace GUI
{
    public partial class FI_KhachHang : Form
    {
        private int trangthai;

        public FI_KhachHang()
        {
            InitializeComponent();
            trangthai = 1;

            BLL_KhachHang bll = new BLL_KhachHang();
            DataTable dataTable = bll.LayKhachHang("");

            if (dataTable.Rows.Count == 0)
                txt_ID_KhachHang.Text = "T001";
            else
                txt_ID_KhachHang.Text = ToolString.GetNextID(dataTable.Rows[dataTable.Rows.Count - 1]["ID_KhachHang"].ToString());
        }
        public FI_KhachHang(
            string id_KhachHang, 
            string hoten_KhachHang, 
            bool gioitinh_KhachHang, 
            DateTime ngaysinh_KhachHang, 
            string sodienthoai_KhachHang)
        {
            InitializeComponent();
            trangthai = 2;
            
            txt_ID_KhachHang.Text = id_KhachHang;
            txt_HoTen_KhachHang.Text = hoten_KhachHang;
            dtp_NgaySinh_KhachHang.Value = ngaysinh_KhachHang;
            rdb_GioiTinh_KhachHang_Nam.Checked = gioitinh_KhachHang;
            rdb_GioiTinh_KhachHang_Nu.Checked = !gioitinh_KhachHang;
            txt_SoDienThoai_KhachHang.Text = sodienthoai_KhachHang;
        }

        private void btn_LuuKhachHang_Click(object sender, EventArgs e)
        {
            string str = (trangthai == 1) ? "Thêm" : "Cập nhập";
            try
            {
                bool success = false;
                string strsucess = "không thành công";

                BLL_KhachHang bll_KhachHang = new BLL_KhachHang();

                switch (trangthai)
                {
                    case 1:
                        success = bll_KhachHang.ThemKhachHang(
                            txt_ID_KhachHang.Text,
                            txt_HoTen_KhachHang.Text,
                            rdb_GioiTinh_KhachHang_Nam.Checked,
                            dtp_NgaySinh_KhachHang.Value,
                            txt_SoDienThoai_KhachHang.Text);

                        break;

                    case 2:
                        success = bll_KhachHang.CapNhatKhachHang(
                            txt_ID_KhachHang.Text,
                            txt_HoTen_KhachHang.Text,
                            rdb_GioiTinh_KhachHang_Nam.Checked,
                            dtp_NgaySinh_KhachHang.Value,
                            txt_SoDienThoai_KhachHang.Text);

                        break;
                }

                if (success) strsucess = "thành công";
                MessageBox.Show(
                        $"{str} {strsucess}.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(
                        $"{str} không thành công, gặp lỗi.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
}

        private void btn_QuayLaiKhachHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
