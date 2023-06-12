using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class FS_NhomTho : Form
    {
        private int idx = -1;
        private string id_nhomtho = "";
        private string ten_nhomtho = "";
        private string id_nhomtruong = "";

        public FS_NhomTho()
        {
            InitializeComponent();
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            datatable.Clear();

            BLL_NhomTho bll = new BLL_NhomTho();
            DataSet dataset = bll.LayNhomTho();

            datatable = dataset.Tables[0];
            dgv_NhomTho.DataSource = datatable;

            dgv_FS_NhomTho_CellClick(null, null);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            FI_NhomTho form = new FI_NhomTho();
            form.ShowDialog();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (idx < 0) return;
                if (dgv_NhomTho.Rows[idx].Cells[0].Value == null) return;

                BLL_NhomTho bll = new BLL_NhomTho();
                BLL_Tho bll_Tho = new BLL_Tho();

                if (DialogResult.No == MessageBox.Show(
                                        "Bạn có muốn xóa không?",
                                        "Thông báo",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)) return;
                
                DataSet dataSet_Tho = bll_Tho.LayTho_NhomTho(id_nhomtho);
                DataTable dataTable_Tho = dataSet_Tho.Tables[0];

                for (int i = 0; i < dataTable_Tho.Rows.Count; ++i)
                    if (!bll_Tho.CapNhatTho_ID_Tho(dataTable_Tho.Rows[i]["ID_Tho"].ToString()))
                    {
                        MessageBox.Show(
                            "Xóa không thành công.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                if (!bll.CapNhapNhomTho(id_nhomtho, "", ""))
                {
                    MessageBox.Show(
                        "Xóa không thành công.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (!bll.XoaNhomTho(id_nhomtho))
                {
                    MessageBox.Show(
                        "Xóa không thành công.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(
                        "Xóa thành công.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(
                        "Xóa không thành công, gặp lỗi.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (idx < 0) return;
            FI_NhomTho form = new FI_NhomTho(id_nhomtho, ten_nhomtho, id_nhomtruong);
            form.ShowDialog();                
        }                                     

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_FS_NhomTho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_NhomTho.CurrentCell == null) return;

                idx = dgv_NhomTho.CurrentCell.RowIndex;
                if (dgv_NhomTho.Rows[idx].Cells[0].Value == null) return;

                id_nhomtho = dgv_NhomTho.Rows[idx].Cells[0].Value.ToString();
                ten_nhomtho = dgv_NhomTho.Rows[idx].Cells[1].Value.ToString();
                id_nhomtruong = dgv_NhomTho.Rows[idx].Cells[2].Value.ToString();
            }
            catch { }
        }
    }
}
