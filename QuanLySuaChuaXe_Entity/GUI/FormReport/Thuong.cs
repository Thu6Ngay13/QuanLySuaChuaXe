using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySuaChuaXe_Entity.GUI.FormReport
{
    public partial class Thuong : Form
    {
        public Thuong()
        {
            InitializeComponent();
        }

        private void Thuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySuaChuaXe.Tho' table. You can move, or remove it, as needed.
            this.thoTableAdapter.Fill(this.quanLySuaChuaXe.Tho);

            this.reportViewer1.RefreshReport();
        }
    }
}
