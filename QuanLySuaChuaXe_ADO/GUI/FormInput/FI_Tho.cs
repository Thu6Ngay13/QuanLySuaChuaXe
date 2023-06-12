using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using Tool;

namespace GUI
{
    public partial class FI_Tho : Form
    {
        private int trangthai;

        public FI_Tho()
        {
            InitializeComponent();
            HienThiCongViec();
            HienThiNhomTho();

            BLL_Tho bll = new BLL_Tho();
            DataSet dataSet = bll.LayTho();
            DataTable dataTable = dataSet.Tables[0];

            if (dataTable.Rows.Count == 0)
                txt_ID_Tho.Text = "T001";
            else
                txt_ID_Tho.Text = ToolString.GetNextID(dataTable.Rows[dataTable.Rows.Count - 1]["ID_Tho"].ToString());

            trangthai = 1;
        }
        public FI_Tho(
            string id_Tho, 
            string hoten_Tho, 
            bool gioitinh_Tho, 
            DateTime ngaysinh_Tho, 
            string diachi_Tho, 
            float luong_Tho, 
            string id_NhomTho)
        {
            InitializeComponent();
            HienThiCongViec();
            HienThiNhomTho();

            trangthai = 2;
            txt_ID_Tho.Text = id_Tho;
            txt_HoTen_Tho.Text = hoten_Tho;
            dtp_NgaySinh_Tho.Value = ngaysinh_Tho;
            rdb_GioiTinh_Tho_Nam.Checked = gioitinh_Tho;
            rdb_GioiTinh_Tho_Nu.Checked = !gioitinh_Tho;
            txt_DiaChi_Tho.Text = diachi_Tho;
            txt_Luong_Tho.Text = luong_Tho.ToString();

            BLL_KhaNang bll_KhaNang = new BLL_KhaNang();
            DataSet dataset_KhaNang = bll_KhaNang.TimKhaNang(id_Tho, "");
            DataTable KhaNang_Table = dataset_KhaNang.Tables[0];

            for (int i = 0; i < KhaNang_Table.Rows.Count; ++i)
                for (int j = 0; j < trv_CongViec.Nodes.Count; ++j)
                    if (KhaNang_Table.Rows[i]["ID_CongViec"].ToString() == trv_CongViec.Nodes[j].Tag.ToString())
                        trv_CongViec.Nodes[j].Checked = true;

            for (int i = 0; i < trv_NhomTho.Nodes.Count; ++i)
                if (trv_NhomTho.Nodes[i].Tag.ToString() == id_NhomTho)
                {
                    trv_NhomTho.Nodes[i].Checked = true;
                    break;
                }
        }

        private void HienThiCongViec()
        {
            BLL_CongViec bll_CongViec = new BLL_CongViec();
            DataSet dataset_CongViec = bll_CongViec.LayCongViec();
            DataTable congviec_Table = dataset_CongViec.Tables[0];

            for (int i = 0; i < congviec_Table.Rows.Count; ++i)
            {
                string id_CongViec = congviec_Table.Rows[i]["ID_CongViec"].ToString();
                string ten_CongViec = congviec_Table.Rows[i]["Ten_CongViec"].ToString();

                TreeNode node_congviec = new TreeNode();
                node_congviec.Text = ten_CongViec;
                node_congviec.Tag = id_CongViec;

                trv_CongViec.Nodes.Add(node_congviec);
            }
        }

        private void HienThiNhomTho()
        {
            BLL_NhomTho bll_NhomTho = new BLL_NhomTho();
            DataSet dataset_NhomTho = bll_NhomTho.LayNhomTho();
            DataTable nhomtho_Table = dataset_NhomTho.Tables[0];

            for (int i = 0; i < nhomtho_Table.Rows.Count; ++i)
            {
                string id_NhomTho = nhomtho_Table.Rows[i]["ID_NhomTho"].ToString();
                string ten_NhomTho = nhomtho_Table.Rows[i]["Ten_NhomTho"].ToString();

                TreeNode node_nhomtho = new TreeNode();
                node_nhomtho.Text = ten_NhomTho;
                node_nhomtho.Tag = id_NhomTho;

                trv_NhomTho.Nodes.Add(node_nhomtho);
            }
        }

        private void trv_NhomTho_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Checked == false) return;

            for (int i = 0; i < trv_NhomTho.Nodes.Count; ++i)
                if (trv_NhomTho.Nodes[i] != node && trv_NhomTho.Nodes[i].Checked)
                    trv_NhomTho.Nodes[i].Checked = false;
        }

        private void btn_LuuTho_Click(object sender, EventArgs e)
        {
            string str = (trangthai == 1) ? "Thêm" : "Cập nhập";
            try
            {
                bool success = false;
                string strsucess = "không thành công";

                BLL_Tho bll_Tho = new BLL_Tho();
                BLL_KhaNang bll_KhaNang = new BLL_KhaNang();

                string id_NhomTho = "";
                for (int i = 0; i < trv_NhomTho.Nodes.Count; ++i)
                    if (trv_NhomTho.Nodes[i].Checked)
                        id_NhomTho = trv_NhomTho.Nodes[i].Tag.ToString();

                switch (trangthai)
                {
                    case 1:
                        success = bll_Tho.ThemTho(
                            txt_ID_Tho.Text,
                            txt_HoTen_Tho.Text,
                            rdb_GioiTinh_Tho_Nam.Checked,
                            dtp_NgaySinh_Tho.Value,
                            txt_DiaChi_Tho.Text,
                            (float)Convert.ToDouble(txt_Luong_Tho.Text),
                            id_NhomTho);

                        for (int i = 0; i < trv_CongViec.Nodes.Count; ++i)
                            if (trv_CongViec.Nodes[i].Checked)
                                success = bll_KhaNang.ThemKhaNang(
                                    txt_ID_Tho.Text,
                                    (string)trv_CongViec.Nodes[i].Tag) || success;

                        break;
                    case 2:
                        success = bll_Tho.CapNhatTho(
                            txt_ID_Tho.Text,
                            txt_HoTen_Tho.Text,
                            rdb_GioiTinh_Tho_Nam.Checked,
                            dtp_NgaySinh_Tho.Value,
                            txt_DiaChi_Tho.Text,
                            (float)Convert.ToDouble(txt_Luong_Tho.Text),
                            id_NhomTho);

                        DataSet dataset_KhaNang = bll_KhaNang.TimKhaNang(txt_ID_Tho.Text, "");
                        DataTable KhaNang_Table = dataset_KhaNang.Tables[0];

                        for (int i = 0; i < KhaNang_Table.Rows.Count; ++i)
                            bll_KhaNang.XoaKhaNang(txt_ID_Tho.Text, KhaNang_Table.Rows[i]["ID_CongViec"].ToString());

                        for (int i = 0; i < trv_CongViec.Nodes.Count; ++i)
                                if (trv_CongViec.Nodes[i].Checked)
                                success = bll_KhaNang.ThemKhaNang(
                                    txt_ID_Tho.Text,
                                    (string)trv_CongViec.Nodes[i].Tag) || success;

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

        private void btn_QuayLaiTho_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
