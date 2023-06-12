using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySuaChuaXe_ADO.GUI.FormReport
{
    public partial class TruyThu : Form
    {
        public TruyThu()
        {
            InitializeComponent();
        }

        private void TruyThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySuaChuaXe.TruyThu' table. You can move, or remove it, as needed.
            this.truyThuTableAdapter.Fill(this.quanLySuaChuaXe.TruyThu);

            this.reportViewer1.RefreshReport();
        }
    }
}
