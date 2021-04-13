using BL.Practicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas
{
    public partial class FormFactura : Form
    {
        FacturaBL _facturaBL;
        ClientesBL _clientesBL;
        ProductoBL _productoBL;


        public FormFactura()
        {
            InitializeComponent();

            _facturaBL = new FacturaBL();
            listaFacturasBindingSource.DataSource = _facturaBL.ObtenerFacturas();

            _clientesBL = new ClientesBL();
            listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();

            _productoBL = new ProductoBL();
            listaProductosBindingSource.DataSource = _productoBL.ObtenerProductos();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _facturaBL.AgregarFactura();
            listaFacturasBindingSource.MoveLast(); // cuando agrega uno nuevo se va al final de la lista

            DeshabilitarHabilitarBotones(false);
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {

        }

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void activoLabel_Click(object sender, EventArgs e)
        {

        }

        private void clienteIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void clienteIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void DeshabilitarHabilitarBotones(bool valor)
        {
            //botones de navegacion
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            //botones de agregar y eliminar
            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButton1Cancelar.Visible = !valor; //boton que creamos de eliminar con negacion de un bool
        }

        private void toolStripButton1ButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            _facturaBL.CancelarCambios();
        }

        private void listaFacturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaFacturasBindingSource.EndEdit(); // indica que guarde y termine de editar

            var factura = (Factura)listaFacturasBindingSource.Current; //indica cual es item actual en barra de navegacion
            var resultado = _facturaBL.GuardarFactura(factura); //guarda factura

            if (resultado.Exitoso == true)
            {
                listaFacturasBindingSource.ResetBindings(false); //actualiza la lista
                DeshabilitarHabilitarBotones(true); //habilita los botones de navegacion y deshabilita guarda y cancelar
                MessageBox.Show("Factura Guardada");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current; //toma de la factura, la factura actual del BindingSource
            _facturaBL.AgregarFacturaDetalle(factura);
            DeshabilitarHabilitarBotones(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current; //toma de la factura, la factura actual del BindingSource
            var facturaDetalle = (FacturaDetalle)facturaDetalleBindingSource.Current; //

            _facturaBL.RemoverFacturaDetalle(factura, facturaDetalle); //selecciona factura y fila de factura para eliminar
            DeshabilitarHabilitarBotones(false); //para evitar los cambios en cancelar y guardar
        }

        private void facturaDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false; //corrige el error en el datagrid
        }

        private void fechaLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            _facturaBL.CalcularFactura(factura);

            listaFacturasBindingSource.ResetBindings(false); //traer datos de facturaBL

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea anular factura", "Anular", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes);
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Anular(id);
                }
            }
        }

        private void Anular(int id)
        {
            var resultado = _facturaBL.AnularFactura(id);

            if (resultado == true)
            {
                listaFacturasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al anular la factura");
            }
        }

        private void listaFacturasBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            if (factura != null && factura.id != 0 && factura.Activo == false)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void impuestoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
