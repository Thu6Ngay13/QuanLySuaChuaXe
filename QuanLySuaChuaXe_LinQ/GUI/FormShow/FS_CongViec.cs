using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FS_CongViec : Form
    {
        private int idx = -1;
        string id_congviec = "";
        string ten_congviec = "";
        string id_nhomcongviec = "";

        public FS_CongViec()
        {
            InitializeComponent();
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            BLL_CongViec bll = new BLL_CongViec();
            dgv_CongViec.DataSource = bll.LayCongViec();

            dgv_CongViec_CellClick(null, null);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            FI_CongViec form = new FI_CongViec();
            form.ShowDialog();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (idx < 0) return;
            FI_CongViec form = new FI_CongViec(
                id_congviec,
                ten_congviec,
                id_nhomcongviec);
            form.ShowDialog();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_CongViec.CurrentCell == null) return;

                idx = dgv_CongViec.CurrentCell.RowIndex;
                if (dgv_CongViec.Rows[idx].Cells[0].Value == null) return;

                id_congviec = dgv_CongViec.Rows[idx].Cells[0].Value.ToString();
                ten_congviec = dgv_CongViec.Rows[idx].Cells[1].Value.ToString();
                id_nhomcongviec = dgv_CongViec.Rows[idx].Cells[2].Value.ToString();

            }
            catch { }   
        }
    }
}
