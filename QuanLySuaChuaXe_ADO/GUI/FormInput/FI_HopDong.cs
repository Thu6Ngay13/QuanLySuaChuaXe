using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using Tool;


namespace GUI
{
    public partial class FI_HopDong : Form
    {
        private int trangthai;

        public FI_HopDong()
        {
            InitializeComponent();
            HienThiCongViec();
            trangthai = 1;

            BLL_HopDong bll_HopDong = new BLL_HopDong();
            DataSet dataSet_HopDong = bll_HopDong.LayHopDong();
            DataTable dataTable_HopDong = dataSet_HopDong.Tables[0];

            if (dataTable_HopDong.Rows.Count == 0)
                txt_ID_HopDong.Text = "T001";
            else
                txt_ID_HopDong.Text = ToolString.GetNextID(dataTable_HopDong.Rows[dataTable_HopDong.Rows.Count - 1]["ID_HopDong"].ToString());

            BLL_KhachHang bll_KhachHang = new BLL_KhachHang();
            DataSet dataSet_KhachHang = bll_KhachHang.LayKhachHang("");
            DataTable dataTable_KhachHang = dataSet_KhachHang.Tables[0];

            if (dataTable_KhachHang.Rows.Count == 0)
                txt_ID_KhachHang.Text = "T001";
            else
                txt_ID_KhachHang.Text = ToolString.GetNextID(dataTable_KhachHang.Rows[dataTable_KhachHang.Rows.Count - 1]["ID_KhachHang"].ToString());

            BLL_Xe bll_Xe = new BLL_Xe();
            DataSet dataSet_Xe = bll_Xe.LayXe();
            DataTable dataTable_Xe = dataSet_Xe.Tables[0];

            if (dataTable_Xe.Rows.Count == 0)
                txt_ID_Xe.Text = "T001";
            else
                txt_ID_Xe.Text = ToolString.GetNextID(dataTable_Xe.Rows[dataTable_Xe.Rows.Count - 1]["ID_Xe"].ToString());
        }

        public FI_HopDong(
            string id_HopDong, 
            string ten_HopDong, 
            DateTime ngaybatdau_HopDong,
            DateTime ngayketthuc_HopDong, 
            float giatri_HopDong, 
            string id_Xe,
            string loai_Xe, 
            string hang_Xe, 
            string id_KhachHang, 
            string hoten_KhachHang, 
            bool gioitinh_KhachHang, 
            DateTime ngaysinh_KhachHang, 
            string sodienthoai_KhachHang)
        {
            InitializeComponent();
            HienThiCongViec();
            trangthai = 2;

            this.txt_ID_HopDong.Text = id_HopDong;
            this.txt_Ten_HopDong.Text = ten_HopDong;
            this.dtp_NgayBatDau_HopDong.Value = Convert.ToDateTime(ngaybatdau_HopDong);
            this.dtp_NgayKetThuc_HopDong.Value = Convert.ToDateTime(ngayketthuc_HopDong);
            this.txt_GiaTri_HopDong.Text = giatri_HopDong.ToString();
            
            this.txt_ID_Xe.Text = id_Xe;
            this.txt_Loai_Xe.Text = loai_Xe;
            this.txt_Hang_Xe.Text = hang_Xe;

            this.txt_ID_KhachHang.Text = id_KhachHang;
            this.txt_HoTen_KhachHang.Text = hoten_KhachHang;
            this.rdb_GioiTinh_KhachHang_Nam.Checked = gioitinh_KhachHang;
            this.rdb_GioiTinh_KhachHang_Nu.Checked = !gioitinh_KhachHang;
            this.dtp_NgaySinh_KhachHang.Value = Convert.ToDateTime(ngaysinh_KhachHang);
            this.txt_SoDienThoai_KhachHang.Text = sodienthoai_KhachHang;

            BLL_ChiTietHopDong bll_ChiTietHopDong = new BLL_ChiTietHopDong();
            BLL_Tho bll_Tho = new BLL_Tho();

            DataSet dataset_ChiTietHopDong = bll_ChiTietHopDong.TimChiTietHopDong(" ", " ", id_HopDong);
            DataTable ChiTietHopDong_Table = dataset_ChiTietHopDong.Tables[0];

            for (int i = 0; i < ChiTietHopDong_Table.Rows.Count; ++i)
                for (int j = 0; j < trv_CongViec_Tho.Nodes.Count; ++j)
                    if (ChiTietHopDong_Table.Rows[i]["ID_CongViec"].ToString() == trv_CongViec_Tho.Nodes[j].Tag.ToString())
                        trv_CongViec_Tho.Nodes[j].Checked = true;

            for (int i = 0; i < trv_CongViec_Tho.Nodes.Count; ++i)
                for (int k = 0; k < trv_CongViec_Tho.Nodes[i].Nodes.Count; ++k)
                {
                    DataSet dataset_Tho = bll_Tho.LayTho_HopDong_CongViec(id_HopDong, trv_CongViec_Tho.Nodes[i].Tag.ToString());
                    DataTable tho_Table = dataset_Tho.Tables[0];

                    bool is_Selected = false;
                    for (int h = 0; h < tho_Table.Rows.Count && !is_Selected; ++h)
                        is_Selected = (trv_CongViec_Tho.Nodes[i].Nodes[k].Tag.ToString() == tho_Table.Rows[h]["ID_Tho"].ToString());
                    trv_CongViec_Tho.Nodes[i].Nodes[k].Checked = is_Selected;
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
                
                trv_CongViec_Tho.Nodes.Add(node_congviec);
            }
        }

        private void trv_CongViec_Tho_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            if (!trv_CongViec_Tho.Nodes.Contains(node)) return;

            BLL_Tho bLL_Tho = new BLL_Tho();
            for (int i = 0; i < trv_CongViec_Tho.Nodes.Count; ++i)
                if (trv_CongViec_Tho.Nodes[i] == node && node.Checked)
                {
                    DataSet dataset_Tho = bLL_Tho.LayTho_CongViec(trv_CongViec_Tho.Nodes[i].Tag.ToString());
                    DataTable tho_Table = dataset_Tho.Tables[0];

                    for (int j = 0; j < tho_Table.Rows.Count; ++j)
                    {
                        string id_Tho = tho_Table.Rows[j]["ID_Tho"].ToString();
                        string hoten_Tho = tho_Table.Rows[j]["HoTen_Tho"].ToString();

                        TreeNode node_tho = new TreeNode();
                        node_tho.Text = hoten_Tho;
                        node_tho.Tag = id_Tho;

                        trv_CongViec_Tho.Nodes[i].Nodes.Add(node_tho);
                    }

                    for (int j = 0; j < trv_CongViec_Tho.Nodes[i].Nodes.Count; ++j)
                        trv_CongViec_Tho.Nodes[i].Nodes[j].Checked = node.Checked;
                }
                else if(trv_CongViec_Tho.Nodes[i] == node)
                    trv_CongViec_Tho.Nodes[i].Nodes.Clear();

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string str = (trangthai == 1) ? "Thêm" : "Cập nhập";
            try
            {
                bool success = false;
                string strsucess = "không thành công";

                BLL_HopDong bll_HopDong = new BLL_HopDong();
                BLL_Xe bll_Xe = new BLL_Xe();
                BLL_KhachHang bll_Khach = new BLL_KhachHang();
                BLL_ChiTietHopDong bLL_ChiTietHopDong = new BLL_ChiTietHopDong();

                switch (trangthai)
                {
                    case 1:
                        success = bll_Khach.ThemKhachHang(
                            txt_ID_KhachHang.Text,
                            txt_HoTen_KhachHang.Text,
                            rdb_GioiTinh_KhachHang_Nam.Checked,
                            dtp_NgaySinh_KhachHang.Value,
                            txt_SoDienThoai_KhachHang.Text) || success;

                        success = bll_Xe.ThemXe(txt_ID_Xe.Text,
                            txt_Loai_Xe.Text,
                            txt_Hang_Xe.Text,
                            txt_ID_KhachHang.Text) || success;

                        success = bll_HopDong.ThemHopDong(
                            txt_ID_HopDong.Text,
                            txt_Ten_HopDong.Text,
                            dtp_NgayBatDau_HopDong.Value,
                            dtp_NgayKetThuc_HopDong.Value,
                            (float)Convert.ToDouble(txt_GiaTri_HopDong.Text),
                            txt_ID_Xe.Text) || success;

                        for(int i = 0; i < trv_CongViec_Tho.Nodes.Count; ++i)
                            if (trv_CongViec_Tho.Nodes[i].Checked)
                                for(int j = 0; j < trv_CongViec_Tho.Nodes[i].Nodes.Count; ++j)
                                    if (trv_CongViec_Tho.Nodes[i].Nodes[j].Checked)
                                        success = bLL_ChiTietHopDong.ThemChiTietHopDong(
                                        trv_CongViec_Tho.Nodes[i].Tag.ToString(),
                                        trv_CongViec_Tho.Nodes[i].Nodes[j].Tag.ToString(),
                                        txt_ID_HopDong.Text) || success;
                        break;
                    case 2:

                        success = bll_Khach.CapNhatKhachHang(
                            txt_ID_KhachHang.Text,
                            txt_HoTen_KhachHang.Text,
                            rdb_GioiTinh_KhachHang_Nam.Checked,
                            dtp_NgaySinh_KhachHang.Value,
                            txt_SoDienThoai_KhachHang.Text) || success;

                        success = bll_Xe.CapnhatXe(
                            txt_ID_Xe.Text,
                            txt_Loai_Xe.Text,
                            txt_Hang_Xe.Text,
                            txt_ID_KhachHang.Text) || success;

                        success = bll_HopDong.CapNhatHopDong(
                            txt_ID_HopDong.Text,
                            txt_Ten_HopDong.Text,
                            dtp_NgayBatDau_HopDong.Value,
                            dtp_NgayKetThuc_HopDong.Value,
                            (float)Convert.ToDouble(txt_GiaTri_HopDong.Text),
                            txt_ID_Xe.Text) || success;

                        DataSet dataSet_ChiTietHopDong = bLL_ChiTietHopDong.TimChiTietHopDong("", "", txt_ID_HopDong.Text);
                        DataTable ChiTietHopDong_Table = dataSet_ChiTietHopDong.Tables[0];

                        for (int i = 0; i < ChiTietHopDong_Table.Rows.Count; ++i)
                            bLL_ChiTietHopDong.XoaChiTietHopDong(
                                ChiTietHopDong_Table.Rows[i]["ID_Tho"].ToString(),
                                ChiTietHopDong_Table.Rows[i]["ID_CongViec"].ToString(),
                                txt_ID_HopDong.Text);

                        for (int i = 0; i < trv_CongViec_Tho.Nodes.Count; ++i)
                            if (trv_CongViec_Tho.Nodes[i].Checked)
                                for (int j = 0; j < trv_CongViec_Tho.Nodes[i].Nodes.Count; ++j)
                                    if (trv_CongViec_Tho.Nodes[i].Nodes[j].Checked)
                                        success = bLL_ChiTietHopDong.ThemChiTietHopDong(
                                            trv_CongViec_Tho.Nodes[i].Nodes[j].Tag.ToString(),
                                            trv_CongViec_Tho.Nodes[i].Tag.ToString(),
                                            txt_ID_HopDong.Text) || success;
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

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
