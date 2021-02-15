using BL.Rentas;
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
    public partial class RegistrarVuelo : Form
    {
      RegistrarVueloBL _vuelos;

        public RegistrarVuelo()
        {
            InitializeComponent();

            _vuelos = new RegistrarVueloBL();
            listaRegistroVueloBindingSource.DataSource = _vuelos.ObtenerRegistroVuelo();
        }

        private void listaRegistroVueloDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
