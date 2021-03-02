using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Entity;

namespace BL.Rentas
{
    public class RegistrarVueloBL
    {
        Contexto _contexto;

        public BindingList<RegistrarVuelo> ListaRegistroVuelo { get; set; } //Propiedad con acceso publico

        public RegistrarVueloBL() //ctor y doble tap , constructor 
        {
            _contexto = new Contexto();
            ListaRegistroVuelo = new BindingList<RegistrarVuelo>();

        }

        public object GuardarVuelo(object vuelo)
       {
           throw new NotImplementedException();
       }

        public BindingList<RegistrarVuelo> ObtenerRegistroVuelo()
        {
            _contexto.RegistrarVuelo.Load();
            ListaRegistroVuelo = _contexto.RegistrarVuelo.Local.ToBindingList();


            return ListaRegistroVuelo;
        }

        public Resultado GuardarVuelo(RegistrarVuelo vuelo)
        {
            var resultado = Validar(vuelo);
            if (resultado.Exitoso == false)
            {
                return resultado; 
            }

            if (vuelo.idvuelo == 0)
            {
                vuelo.idvuelo = ListaRegistroVuelo.Max(item => item.idvuelo) + 1; //Max busca el id máximo, para poder agregar el siguiente.
            }

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarVuelo()
        {
            var NuevoVuelo = new RegistrarVuelo();
            ListaRegistroVuelo.Add(NuevoVuelo);
        }

        public bool EliminarVuelo(int id)
        {
            foreach (var vuelo in ListaRegistroVuelo) //foreach sirve para recorrer lista de objetos
            {
                if (vuelo.idvuelo == id)
                {
                    ListaRegistroVuelo.Remove(vuelo);
                    return true;
                }
           }

            return false;
        }

        private Resultado Validar (RegistrarVuelo vuelo)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty (vuelo.idclase ) == true)
            {
                resultado.Mensaje = "Ingrese una clase";
                resultado.Exitoso = false;
            }

            if (vuelo.horasvuelo < 0)
            {
                resultado.Mensaje = "Las horas de vuelo deben ser mayor que 0";
                resultado.Exitoso = false;
            }

            if (vuelo.ciudaddestino == "")
            {
                resultado.Mensaje = "Debe ingresar una Ciudad Destino";
                resultado.Exitoso = false;
            }

            return resultado;
        }
            
    }
    public class RegistrarVuelo
    {
        public int idvuelo { get; set; }
        public string idclase { get; set; }
        public int horasvuelo { get; set; }
        public string ciudaddestino { get; set; }
        public string ciudadorigen { get; set; }
        public DateTime fechavuelo { get; set; }
        public bool activo { get; set; }

    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
