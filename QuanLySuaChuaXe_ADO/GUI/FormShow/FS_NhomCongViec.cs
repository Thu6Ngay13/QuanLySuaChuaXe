using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class FS_NhomCongViec : Form
    {
        private int idx = -1;
        private string id_nhomcongviec = "";
        private string ten_nhomcongviec = "";

        public FS_NhomCongViec()
        {
            InitializeComponent();
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            datatable.Clear();

            BLL_NhomCongViec bll = new BLL_NhomCongViec();
            DataSet dataset = bll.LayNhomCongViec();
            
            datatable = dataset.Tables[0];
            dgv_NhomCongViec.DataSource = datatable;

            dgv_FS_NhomCongViec_CellClick(null, null);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            FI_NhomCongViec form = new FI_NhomCongViec();
            form.ShowDialog();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (idx < 0) return;
            FI_NhomCongViec form = new FI_NhomCongViec(
                id_nhomcongviec, 
                ten_nhomcongviec);
            form.ShowDialog();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_FS_NhomCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_NhomCongViec.CurrentCell == null) return;

                idx = dgv_NhomCongViec.CurrentCell.RowIndex;
                if (dgv_NhomCongViec.Rows[idx].Cells[0].Value == null) return;

                id_nhomcongviec = dgv_NhomCongViec.Rows[idx].Cells[0].Value.ToString();
                ten_nhomcongviec = dgv_NhomCongViec.Rows[idx].Cells[1].Value.ToString();
            }
            catch { }
        }
    }
}
