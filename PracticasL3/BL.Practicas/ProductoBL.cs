using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Practicas
{
    public class ProductoBL // manipular Producto
    {
        Contexto _contexto; // declaramos la variable contexto
        public BindingList<Producto> ListaProductos { get; set; } // Permite crear propiedad de lista de producto y hacer un Enlace

        public ProductoBL()
        {
            _contexto = new Contexto(); //creamos una instancia el constructor 
            ListaProductos = new BindingList<Producto>(); // Inicializamos nuestra lista
                
        }

        public BindingList<Producto> ObtenerProductos() // Funcion para el retorno de productos
        {
            _contexto.Productos.Load(); //carga los productos de DbSet<Producto> que creamos en Contexto 
            ListaProductos = _contexto.Productos.Local.ToBindingList(); //transforma todos los datos de producto a bindinglist

            return ListaProductos;
        }

        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges(); //guarda los cambios en el formulario productos en la base de datos 

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
                    _contexto.SaveChanges();
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

            if (producto.Tipoid == 0)
            {
                resultado.Mensaje = "Seleccione un Tipo";
                resultado.Exitoso = false;
            }

            if (producto.CategoriaId == 0)
            {
                resultado.Mensaje = "Seleccione una categoria";
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
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int Tipoid { get; set; }
        public Tipo Tipo { get; set; }
        public byte[] foto { get; set; }
        public bool Activo { get; set; }
    }

    //validar los datos ingresados en los campos del formulario
    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}
