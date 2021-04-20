using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Practicas
{
    public class FacturaBL
    {
        Contexto _contexto;

        public BindingList<Factura> ListaFacturas { get; set; }

        public FacturaBL()
        {
            _contexto = new Contexto();
        }

        public BindingList<Factura> ObtenerFacturas()
        {
            _contexto.Facturas.Include("FacturaDetalle").Load();
            ListaFacturas = _contexto.Facturas.Local.ToBindingList();

            return ListaFacturas;
        }

        public void AgregarFactura()
        {
            var nuevaFactura = new Factura();
            _contexto.Facturas.Add(nuevaFactura);
        }

        public void AgregarFacturaDetalle(Factura factura)
        {
            if (factura != null)
            {
                var nuevoDetalle = new FacturaDetalle();
                factura.FacturaDetalle.Add(nuevoDetalle); //agrega una lista tipo BindingSource y se agrega a nuevo detalle
            }
        }

        public void RemoverFacturaDetalle(Factura factura, FacturaDetalle facturaDetalle) //recibimos factura y que fila de la factura se eliminara
        {
            if (factura != null && facturaDetalle != null) //si la factura y detalle no son nulos
            {
                factura.FacturaDetalle.Remove(facturaDetalle); //procede a remover
            }
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarFactura(Factura factura)
        {
            var resultado = Validar(factura);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            CalcularExistencia(factura);
               
            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        private void CalcularExistencia(Factura factura)
        {
            foreach (var detalle in factura.FacturaDetalle)//recorre la clase facturadetalle
            {
                var producto = _contexto.Productos.Find(detalle.ProductoId); //busca en la base de datos el producto Id
                if (producto != null)
                {
                    if (factura.Activo == true)
                    {
                        producto.Existencia = producto.Existencia - detalle.Cantidad; //resta cuando se realiza una factura
                    }
                    else
                    {
                        producto.Existencia = producto.Existencia + detalle.Cantidad;
                    }
                    
                }
            }

        }

        private Resultado Validar(Factura factura)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (factura == null) //mensaje para agregar factura y salvar
            {
                resultado.Mensaje = "Agregue una factura para salvar";
                resultado.Exitoso = false;

                return resultado;
            }

            if (factura.id != 0 && factura.Activo == true)
            {
                resultado.Mensaje = "La factura fue emitida y no se pueden realizar cambios";
                resultado.Exitoso = false;
            }

            if (factura.Activo == false)
            {
                resultado.Mensaje = "La Factura esta anulada y no se puede modificar";
                resultado.Exitoso = false;
            }

            if (factura.ClienteId == 0)
            {
                resultado.Mensaje = "Seleccione un cliente";
                resultado.Exitoso = false;
            }

            if (factura.FacturaDetalle.Count == 0)
            {
                resultado.Mensaje = "Agregue productos a la factura";
                resultado.Exitoso = false;
            }

            foreach (var detalle in factura.FacturaDetalle)
            {
                if (detalle.ProductoId ==0)
                {
                    resultado.Mensaje = "Selecciones productos válidos";
                    resultado.Exitoso = false;
                }
            }

            return resultado;
        }

        public void CalcularFactura(Factura factura) //calculo para facturacion
        {
            if (factura != null) //consultar que factura no sea nula
            {
                double subtotal = 0;

                foreach (var detalle in factura.FacturaDetalle)//recorre la clase facturadetalle
                {
                    var producto = _contexto.Productos.Find(detalle.ProductoId); //busca en la base de datos el producto Id
                    if (producto != null)
                    {
                        detalle.Precio = producto.Precio;

                        detalle.Total = detalle.Cantidad * producto.Precio;

                        subtotal += detalle.Total;
                    }
                }

                factura.Subtotal = subtotal;
                factura.Impuesto = subtotal * 0.15;
                factura.Total = subtotal + factura.Impuesto;
            }

        }

        public bool AnularFactura(int id)
        {
            foreach (var factura in ListaFacturas)
            {
                if (factura.id == id)
                {
                    factura.Activo = false;
                    CalcularExistencia(factura);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }
    
    public class Factura
    {
        public int id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public BindingList<FacturaDetalle> FacturaDetalle { get; set; }
        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        public Factura()
        {
            Fecha = DateTime.Now;
            FacturaDetalle = new BindingList<FacturaDetalle>();
            Activo = true;
        }
    }

    public class FacturaDetalle
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }

        public FacturaDetalle()
        {
            Cantidad = 1;
        }
    }
}
