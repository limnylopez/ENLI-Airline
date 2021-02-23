using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Practicas
{
    public class ProductoBL // manipular Producto
    {
        public BindingList<Producto> ListaProductos { get; set; } // Permite crear propiedad de lista de producto y hacer un Enlace

        public ProductoBL()
        {
            ListaProductos = new BindingList<Producto>(); // Inicializamos nuestra lista

            var producto1 = new Producto(); // llenamos de productos nuestra lista
            producto1.Id = 1;
            producto1.Descripcion = "Iphone X";
            producto1.Precio = 25000;
            producto1.Existencia = 15;
            producto1.Activo = true;

            ListaProductos.Add(producto1); // Agrega a nuestra lista ListaProductos

            var producto2 = new Producto(); // llenamos de productos nuestra lista
            producto2.Id = 2;
            producto2.Descripcion = "Samsung S20";
            producto2.Precio = 20000;
            producto2.Existencia = 18;
            producto2.Activo = true;

            ListaProductos.Add(producto2); // Agrega a nuestra lista ListaProductos

            var producto3 = new Producto(); // llenamos de productos nuestra lista
            producto3.Id = 3;
            producto3.Descripcion = "LG V60";
            producto3.Precio = 18000;
            producto3.Existencia = 12;
            producto3.Activo = true;

            ListaProductos.Add(producto3); // Agrega a nuestra lista ListaProductos
        }

        public BindingList<Producto> ObtenerProductos() // Funcion para el retorno de productos
        {
            return ListaProductos;
        }

        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }
                
            if(producto.Id == 0)
            {
                producto.Id = ListaProductos.Max(item => item.Id) + 1; // Max busca en la lista producto el item id para el ultimo de la lista y sumarle 1, dando asi un nuevo item
            }
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProducto()
        {
            var nuevoProducto = new Producto();

            ListaProductos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int id) // Para configurar el boton eliminar 
        {
            foreach (var producto in ListaProductos) // crea ciclo que recorre lista de productos
            {
                if(producto.Id == id) // De ser verdadero
                {
                    ListaProductos.Remove(producto); // Elimina el item
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Producto producto)
        {
            var resultado = new Resultado(); 
            resultado.Exitoso = true; // si sale bien

            if (string.IsNullOrEmpty(producto.Descripcion) == true) // si no, entra cambia el valor, y retorna con resultado
            {
                resultado.Mensaje = "Ingrese una descripción";
                resultado.Exitoso = false; 
            }

            if (producto.Existencia < 0) 
            {
                resultado.Mensaje = "La existencia debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (producto.Precio < 0)
            {
                resultado.Mensaje = "El precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }
    
    public class Producto // Representa una tabla en una base de datos 
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }

    //validar los datos ingresados en los campos del formulario
    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}
