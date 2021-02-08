using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormLogin();
            frm.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormProductos();
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormClientes();
            frm.Show();
        }

        private void rentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormRentar();
            frm.Show();
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormRepProductos();
            frm.Show();
        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormRepClientes();
            frm.Show();
        }

        private void reporteDeRentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormRepRentas();
            frm.Show();
        }
    }
}
