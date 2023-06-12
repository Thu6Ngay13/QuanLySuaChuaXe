using BLL;
using System;
using System.Data;
using System.Windows.Forms;
using Tool;

namespace GUI
{
    public partial class FI_PhieuThu : Form
    {
        private int trangthai;

        public FI_PhieuThu()
        {
            InitializeComponent();
            HienThiHopDong();
            trangthai = 1;

            BLL_PhieuThu bll = new BLL_PhieuThu();
            DataTable dataTable = bll.LayPhieuThu();

            if (dataTable.Rows.Count == 0)
                txt_ID_PhieuThu.Text = "T001";
            else
                txt_ID_PhieuThu.Text = ToolString.GetNextID(dataTable.Rows[dataTable.Rows.Count - 1]["ID_PhieuThu"].ToString());

        }

        public FI_PhieuThu(
            string id_HopDong,
            DateTime ngaythu_HopDong,
            string id_PhieuThu,
            string hotennguoithu_PhieuThu,
            string hotennguoinop_PhieuThu,
            float sotienthu_PhieuThu)
        {
            InitializeComponent();
            HienThiHopDong();
            trangthai = 2;

            dtp_NgayThu_PhieuThu.Enabled = true;

            dtp_NgayThu_PhieuThu.Value = ngaythu_HopDong;
            txt_ID_PhieuThu.Text = id_PhieuThu;
            txt_HoTenNguoiThu_PhieuThu.Text = hotennguoithu_PhieuThu;
            txt_HoTenNguoiNop_PhieuThu.Text = hotennguoinop_PhieuThu;
            txt_SoTienThu_PhieuThu.Text = sotienthu_PhieuThu.ToString();

            for (int i = 0; i < trv_HopDong.Nodes.Count; ++i)
                if (trv_HopDong.Nodes[i].Tag.ToString() == id_HopDong)
                {
                    trv_HopDong.Nodes[i].Checked = true;
                    break;
                }
        }

        public FI_PhieuThu(string id_HopDong)
        {
            InitializeComponent();
            HienThiHopDong();
            trangthai = 1;

            BLL_PhieuThu bll = new BLL_PhieuThu();
            DataTable dataTable = bll.LayPhieuThu();

            if (dataTable.Rows.Count == 0)
                txt_ID_PhieuThu.Text = "T001";
            else
                txt_ID_PhieuThu.Text = ToolString.GetNextID(dataTable.Rows[dataTable.Rows.Count - 1]["ID_PhieuThu"].ToString());

            for (int i = 0; i < trv_HopDong.Nodes.Count; ++i)
                if (trv_HopDong.Nodes[i].Tag.ToString() == id_HopDong)
                {
                    trv_HopDong.Nodes[i].Checked = true;
                    break;
                }
        }

        private void HienThiHopDong()
        {
            BLL_HopDong bll = new BLL_HopDong();
            DataTable dataTable = bll.LayHopDong();

            for (int i = 0; i < dataTable.Rows.Count; ++i)
            {
                string id_HopDong = dataTable.Rows[i]["ID_HopDong"].ToString();
                string ten_HopDong = dataTable.Rows[i]["Ten_HopDong"].ToString();

                TreeNode node = new TreeNode();
                node.Text = ten_HopDong;
                node.Tag = id_HopDong;

                trv_HopDong.Nodes.Add(node);
            }
        }

        private void trv_HopDong_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Checked == false) return;

            for (int i = 0; i < trv_HopDong.Nodes.Count; ++i)
                if (trv_HopDong.Nodes[i] != node && trv_HopDong.Nodes[i].Checked)
                    trv_HopDong.Nodes[i].Checked = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string str = (trangthai == 1) ? "Thêm" : "Cập nhập";
            try
            {
                bool success = false;
                string strsucess = "không thành công";

                string id_HopDong = "";
                for (int i = 0; i < trv_HopDong.Nodes.Count; ++i)
                    if (trv_HopDong.Nodes[i].Checked)
                        id_HopDong = trv_HopDong.Nodes[i].Tag.ToString();

                BLL_PhieuThu bll = new BLL_PhieuThu();
                switch (trangthai)
                {
                    case 1:
                        success = bll.ThemPhieuThu(
                            id_HopDong,
                            dtp_NgayThu_PhieuThu.Value,
                            txt_ID_PhieuThu.Text,
                            txt_HoTenNguoiThu_PhieuThu.Text,
                            txt_HoTenNguoiNop_PhieuThu.Text,
                            (float)Convert.ToDouble(txt_SoTienThu_PhieuThu.Text));
                        break;
                    case 2:
                        success = bll.CapNhatPhieuThu(
                            id_HopDong,
                            dtp_NgayThu_PhieuThu.Value,
                            txt_ID_PhieuThu.Text,
                            txt_HoTenNguoiThu_PhieuThu.Text,
                            txt_HoTenNguoiNop_PhieuThu.Text,
                            (float)Convert.ToDouble(txt_SoTienThu_PhieuThu.Text));
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

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}