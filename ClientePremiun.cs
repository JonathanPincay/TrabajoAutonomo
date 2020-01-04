using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaElextronica
{
    class ClientePremiun:Cliente , IUsuario ,IDescuentoProducto
    {
        public int PuntageCom { get; set; }
        public DateTime FechaInscriccion{ get; set; }

        public string Apellidos()
        {
            throw new NotImplementedException();
        }

        public string Contrasena()
        {
            throw new NotImplementedException();
        }
        /*PRINCIPIO SUSTITUCION DE LISKOV
            EL DESCUENTO VARIA SEGUN EL CASO DEL CLIENTE
        */
        public decimal Descuento()
        {
            throw new NotImplementedException();
        }

        public decimal FechaDeInscre()
        {
            TimeSpan timeSpan = DateTime.Today - this.FechaInscriccion;
            int dias = timeSpan.Days;
            int fecha = dias / 365;
            return fecha;
        }

        string IUsuario.Cedula()
        {
            throw new NotImplementedException();
        }

        string IUsuario.Email()
        {
            throw new NotImplementedException();
        }

        string IUsuario.Nombres()
        {
            throw new NotImplementedException();
        }
    }
}
