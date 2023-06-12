using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using Tool;

namespace GUI
{
    public partial class FI_NhomCongViec : Form
    {
        private int trangthai;

        public FI_NhomCongViec()
        {
            InitializeComponent();
            trangthai = 1;

            BLL_NhomCongViec bll = new BLL_NhomCongViec();
            DataSet dataSet = bll.LayNhomCongViec();
            DataTable dataTable = dataSet.Tables[0];

            if (dataTable.Rows.Count == 0)
                txt_ID_NhomCongViec.Text = "T001";
            else
                txt_ID_NhomCongViec.Text = ToolString.GetNextID(dataTable.Rows[dataTable.Rows.Count - 1]["ID_NhomCongViec"].ToString());
        }

        public FI_NhomCongViec(
            string id_NhomCongViec, 
            string ten_NhomCongViec)
        {
            InitializeComponent();
            trangthai = 2;
            this.txt_ID_NhomCongViec.Enabled = false;
            this.txt_ID_NhomCongViec.Text = id_NhomCongViec;
            this.txt_Ten_NhomCongViec.Text = ten_NhomCongViec;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string str = (trangthai == 1) ? "Thêm" : "Cập nhập";
            try
            {
                bool success = false;
                string strsucess = "không thành công";

                BLL_NhomCongViec bll = new BLL_NhomCongViec();
                switch (trangthai)
                {
                    case 1:
                        success = bll.ThemNhomCongViec(
                            this.txt_ID_NhomCongViec.Text, 
                            this.txt_Ten_NhomCongViec.Text);
                        break;
                        
                    case 2:
                        success = bll.CapNhapNhomCongViec(
                            this.txt_ID_NhomCongViec.Text, 
                            this.txt_Ten_NhomCongViec.Text);
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
