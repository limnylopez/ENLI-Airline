using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BL.Rentas
{
    public class RegistrarVueloBL
    {
        public BindingList<RegistrarVuelo> ListaRegistroVuelo { get; set; } //Propiedad con acceso publico

        public RegistrarVueloBL() //ctor y doble tap , constructor 
        {
            ListaRegistroVuelo = new BindingList<RegistrarVuelo>();

            var vuelo1 = new RegistrarVuelo();
            vuelo1.idavion = 1;
            vuelo1.matriculaavion = "ABC123";
            vuelo1.capacidadpasajero = 800;
            vuelo1.capacidadcarga = 2500;
            vuelo1.activo = true;

            ListaRegistroVuelo.Add(vuelo1);


            var vuelo2 = new RegistrarVuelo();
            vuelo2.idavion = 2;
            vuelo2.matriculaavion = "DEF456";
            vuelo2.capacidadpasajero = 900;
            vuelo2.capacidadcarga = 5000;
            vuelo2.activo = true;

            ListaRegistroVuelo.Add(vuelo2);


            var vuelo3 = new RegistrarVuelo();
            vuelo3.idavion = 3;
            vuelo3.matriculaavion = "GHI789";
            vuelo3.capacidadpasajero = 200;
            vuelo3.capacidadcarga = 1000;
            vuelo3.activo = true;

            ListaRegistroVuelo.Add(vuelo3);

        }

        public BindingList<RegistrarVuelo> ObtenerRegistroVuelo()
        {
            return ListaRegistroVuelo;
        }
    }
    public class RegistrarVuelo
    {
        public int idavion { get; set; }
        public string matriculaavion { get; set; }
        public int capacidadpasajero { get; set; }
        public int capacidadcarga { get; set; }
        public bool activo { get; set; }

    }
}
