using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FS_PhieuThu : Form
    {
        private int idx = -1;
        private string id_phieuthu = "";
        private string hotennguoithu_phieuthu = "";
        private string hotennguoinop_phieuthu = "";
        private DateTime ngaythu_phieuthu;
        private float sotienthu_phieuthu = 0;
        private string id_hopdong = "";

        public FS_PhieuThu()
        {
            InitializeComponent();
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            BLL_PhieuThu bll = new BLL_PhieuThu();
            dgv_PhieuThu.DataSource = bll.LayPhieuThu();

            dgv_FSPhieuThu_CellClick(null, null);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            FI_PhieuThu form = new FI_PhieuThu();
            form.ShowDialog();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (idx < 0) return;
                if (dgv_PhieuThu.Rows[idx].Cells[0].Value == null) return;

                BLL_PhieuThu bll = new BLL_PhieuThu();
                if (DialogResult.No == MessageBox.Show(
                                        "Bạn có muốn xóa không?",
                                        "Thông báo",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)) return;
                if (bll.XoaPhieuThu(id_phieuthu))
                {
                    MessageBox.Show(
                        "Xóa thành công.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Xóa không thành công.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (SqlException)
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
            FI_PhieuThu form = new FI_PhieuThu(
                id_hopdong,
                ngaythu_phieuthu,
                hotennguoithu_phieuthu,
                hotennguoinop_phieuthu,
                id_phieuthu,
                sotienthu_phieuthu);
            form.ShowDialog();
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_FSPhieuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_PhieuThu.CurrentCell == null) return;

                idx = dgv_PhieuThu.CurrentCell.RowIndex;
                if (dgv_PhieuThu.Rows[idx].Cells[0].Value == null) return;

                id_phieuthu = dgv_PhieuThu.Rows[idx].Cells[0].Value.ToString();
                hotennguoithu_phieuthu = dgv_PhieuThu.Rows[idx].Cells[1].Value.ToString();
                hotennguoinop_phieuthu = dgv_PhieuThu.Rows[idx].Cells[2].Value.ToString();
                ngaythu_phieuthu = Convert.ToDateTime(dgv_PhieuThu.Rows[idx].Cells[3].Value);
                sotienthu_phieuthu = (float)Convert.ToDouble(dgv_PhieuThu.Rows[idx].Cells[4].Value);
                id_hopdong = dgv_PhieuThu.Rows[idx].Cells[5].Value.ToString();
            }
            catch { }
        }

    }
}
