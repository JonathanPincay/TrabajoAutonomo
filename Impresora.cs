using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaElextronica 
{
    class Impresora
    {
        public Impresora()
        {
        }

        /*
         Dependencia unica
         Imprimir datos del cliente
         */

        public void ImprimirDatosCliente(IUsuario cliente)
        {
            Console.WriteLine(cliente.Apellidos() + cliente.Nombres());

            //return cliente.Nombres + " " + cliente.Apellidos;   
        }
    }
}
