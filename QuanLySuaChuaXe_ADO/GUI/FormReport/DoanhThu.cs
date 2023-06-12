using System;
using System.Windows.Forms;

namespace QuanLySuaChuaXe_ADO.GUI.FormReport
{
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySuaChuaXe.PhieuThu' table. You can move, or remove it, as needed.
            this.phieuThuTableAdapter.Fill(this.quanLySuaChuaXe.PhieuThu);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
