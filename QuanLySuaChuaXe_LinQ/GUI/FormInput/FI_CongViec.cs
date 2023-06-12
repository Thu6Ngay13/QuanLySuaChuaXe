using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using Tool;

namespace GUI
{
    public partial class FI_CongViec : Form
    {
        private int trangthai;

        public FI_CongViec()
        {
            InitializeComponent();
            trangthai = 1;

            BLL_CongViec bll = new BLL_CongViec();
            DataTable dataTable = bll.LayCongViec();

            if (dataTable.Rows.Count == 0)
                txt_ID_CongViec.Text = "T001";
            else
                txt_ID_CongViec.Text = ToolString.GetNextID(dataTable.Rows[dataTable.Rows.Count - 1]["ID_CongViec"].ToString());
        }
        public FI_CongViec(
            string id_CongViec, 
            string ten_CongViec, 
            string id_NhomCongViec)
        {
            InitializeComponent();
            trangthai = 2;

            this.txt_ID_CongViec.Text = id_CongViec;
            this.txt_Ten_CongViec.Text = ten_CongViec;
            this.txt_ID_NhomCongViec.Text = id_NhomCongViec;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string str = (trangthai == 1) ? "Thêm" : "Cập nhập";
            try
            {
                bool success = false;
                string strsucess = "không thành công";

                BLL_CongViec bll = new BLL_CongViec();
                switch (trangthai)
                {
                    case 1:
                        success = bll.ThemCongViec(
                            txt_ID_CongViec.Text,
                            txt_Ten_CongViec.Text,
                            txt_ID_NhomCongViec.Text);
                        break;

                    case 2:
                        success = bll.CapNhatCongViec(
                            txt_ID_CongViec.Text,
                            txt_Ten_CongViec.Text,
                            txt_ID_NhomCongViec.Text);
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
