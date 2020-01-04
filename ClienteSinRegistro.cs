using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaElextronica
{
    class ClienteSinRegistro:Cliente ,IUsuario ,IDescuentoProducto
    {
        public string Telefono { get; set; }

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
