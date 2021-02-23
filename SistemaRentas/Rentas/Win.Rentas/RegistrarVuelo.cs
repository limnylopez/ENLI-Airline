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
   
        private void listaRegistroVueloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaRegistroVueloBindingSource.EndEdit();
             

            var vuelo = (RegistrarVuelo)listaRegistroVueloBindingSource.Current;

            var resultado = _vuelos.GuardarVuelo(vuelo);

            if (resultado.Exitoso == true)
            
            {
                listaRegistroVueloBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
            }   
            else 
            {
              MessageBox.Show(resultado.Mensaje);
            } 
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _vuelos.AgregarVuelo();
            listaRegistroVueloBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            cancelar.Visible = !valor;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            if (idvueloTextBox.Text != "")
                {
                var resultado = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idvueloTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {
            var resultado = _vuelos.EliminarVuelo(id);

            if (resultado == true)
            {
                listaRegistroVueloBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al eliminar el vuelo");
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }
    }
}
