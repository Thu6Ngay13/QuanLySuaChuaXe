using System;
using System.Windows.Forms;
using System.Data;
using BLL;

namespace GUI
{
    public partial class FF_CongViec : Form
    {
        public FF_CongViec()
        {
            InitializeComponent();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable datatable = new DataTable();
                datatable.Clear();

                BLL_CongViec bll = new BLL_CongViec();
                DataSet dataset = bll.TimCongViec(
                    txt_ID_CongViec.Text,
                    txt_Ten_CongViec.Text,
                    txt_ID_NhomCongViec.Text);

                datatable = dataset.Tables[0];
                dgv_CongViec.DataSource = datatable;
            }
            catch { }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
