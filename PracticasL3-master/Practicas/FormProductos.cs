using BL.Practicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas
{
    public partial class FormProductos : Form
    {
        ProductoBL _productos; // variable para usar en el constructor del formulario
        CategoriasBL _categorias;
        TiposBL _tiposBL;

        public FormProductos()
        {
            InitializeComponent();

            _productos = new ProductoBL();
            listaProductosBindingSource.DataSource = _productos.ObtenerProductos(); // Llamanos nuestra lista de productos de BL para visualizarse en el FormProductos

            _categorias = new CategoriasBL();
            listaCategoriasBindingSource.DataSource = _categorias.ObtenerCategorias();

            _tiposBL = new TiposBL();
            listaTiposBindingSource.DataSource = _tiposBL.ObtenerTipos();
           
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void listaProductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listaProductosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaProductosBindingSource.EndEdit(); //termina de editar para guardar
            var producto = (Producto)listaProductosBindingSource.Current; // muestra el producto actual que proviene de producto

            if (fotoPictureBox.Image != null)
            {
                producto.foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                producto.foto = null;
            }

            var resultado = _productos.GuardarProducto(producto);

            if (resultado.Exitoso == true)
            {
                listaProductosBindingSource.ResetBindings(false); //Resetea lo que vemos en pantalla porque hubo un cambio
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Producto guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _productos.AgregarProducto(); // agregamos metodo para agregar
            listaProductosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false); // agregamos metodo para deshabilitar y habilitar botonesss
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
           
            if (idTextBox.Text != "") // Indica que si es diferente de vacio contiene un valor y puede iniciar a eliminar
            {
                var resultado = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text); // convertimos de un entero el id y relacionamos el texbox de id
                    Eliminar(id);
                }
                 
            }
        }

        private void Eliminar(int id) //metodo para eliminar
        {
            
            var resultado = _productos.EliminarProducto(id);

            if (resultado == true)
            {
                listaProductosBindingSource.ResetBindings(false); // Resetea la vista cuando se elimina un producto
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto");
            }
        }

        private void toolStripButton1Cancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true); //para cancelar una accion que no se habilito pero no se realizo
            Eliminar(0); //elimina el valor creado del id
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var producto = (Producto)listaProductosBindingSource.Current;

            if(producto != null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo); //Obtiene informacion del archivo (ruta)
                    var filesStream = fileInfo.OpenRead(); //carga el archivo por partes (bytes)

                    fotoPictureBox.Image = Image.FromStream(filesStream); //Lo asigna al PictureBox
                }
            }
            else
            {
                MessageBox.Show("Cree un producto antes de asignar una imagen");
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void categoriaIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
