using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaElextronica
{
    public class  FacturaCarrito
    {

        public FacturaCarrito()
        {
            this.Detalle = new List<DetalleFactura>();
        }
       

        public List<DetalleFactura> Detalle { get; set; }
        


    }
}

