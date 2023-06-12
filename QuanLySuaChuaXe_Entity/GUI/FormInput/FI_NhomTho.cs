using BLL;
using System;
using System.Data;
using System.Windows.Forms;
using Tool;

namespace GUI
{
    public partial class FI_NhomTho : Form
    {
        private int trangthai;

        public FI_NhomTho()
        {
            InitializeComponent();
            HienThiNhomTho();
            trangthai = 1;

            BLL_NhomTho bll = new BLL_NhomTho();
            DataTable dataTable = bll.LayNhomTho();

            if (dataTable.Rows.Count == 0)
                txt_ID_NhomTho.Text = "T001";
            else
                txt_ID_NhomTho.Text = ToolString.GetNextID(dataTable.Rows[dataTable.Rows.Count - 1]["ID_NhomTho"].ToString());

        }

        public FI_NhomTho(string id_NhomTho, string ten_NhomTho, string id_TruongNhom)
        {
            InitializeComponent();
            HienThiNhomTho();
            trangthai = 2;

            this.txt_ID_NhomTho.Text = id_NhomTho;
            this.txt_Ten_NhomTho.Text = ten_NhomTho;

            for (int i = 0; i < trv_Tho.Nodes.Count; ++i)
                if (trv_Tho.Nodes[i].Tag.ToString() == id_TruongNhom)
                {
                    trv_Tho.Nodes[i].Checked = true;
                    break;
                }
        }

        private void HienThiNhomTho()
        {
            BLL_Tho bll_Tho = new BLL_Tho();
            DataTable tho_Table = bll_Tho.LayTho();

            for (int i = 0; i < tho_Table.Rows.Count; ++i)
            {
                string id_Tho = tho_Table.Rows[i]["ID_Tho"].ToString();
                string ten_Tho = tho_Table.Rows[i]["HoTen_Tho"].ToString();

                TreeNode node_tho = new TreeNode();
                node_tho.Text = ten_Tho;
                node_tho.Tag = id_Tho;

                trv_Tho.Nodes.Add(node_tho);
            }
        }

        private void trv_Tho_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Checked == false) return;

            for (int i = 0; i < trv_Tho.Nodes.Count; ++i)
                if (trv_Tho.Nodes[i] != node && trv_Tho.Nodes[i].Checked)
                    trv_Tho.Nodes[i].Checked = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string str = (trangthai == 1) ? "Thêm" : "Cập nhập";
            try
            {
                bool success = false;
                string strsucess = "không thành công";

                string id_Tho = "";
                for (int i = 0; i < trv_Tho.Nodes.Count; ++i)
                    if (trv_Tho.Nodes[i].Checked)
                        id_Tho = trv_Tho.Nodes[i].Tag.ToString();

                BLL_NhomTho bll = new BLL_NhomTho();
                switch (trangthai)
                {
                    case 1:
                        success = bll.ThemNhomTho(
                            this.txt_ID_NhomTho.Text,
                            this.txt_Ten_NhomTho.Text,
                            id_Tho);
                        break;

                    case 2:
                        success = bll.CapNhapNhomTho(
                            this.txt_ID_NhomTho.Text,
                            this.txt_Ten_NhomTho.Text,
                            id_Tho);
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
