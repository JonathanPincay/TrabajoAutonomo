using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaElextronica
{
    interface IDescuentoProducto
    {
        /*PRINCIPIO SUSTITUCION DE LISKOV
     * EL DESCUENTO VARIA SEGUN EL CASO DEL CLIENTE
        */
       
        
            decimal Descuento();
        
    }
}
