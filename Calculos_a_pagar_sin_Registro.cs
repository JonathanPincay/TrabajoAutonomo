using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaElextronica
{
    class Calculos_a_pagar_sin_Registro:IProcesosTranssaccionales
        

    {
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

        // Aqui se esta implementando la interfaz IProcesosTranssaccionales
        public decimal CalcularSubtotal()
        {
            return Subtotal;
          
        }


        public decimal CalcularDescuento()
        {
            if (this.Subtotal >= 100)
            { this.Descuento = this.Subtotal * 0.05M; }
            else { this.Descuento = 0; }
            return Descuento;
         }
        public decimal CalcularTotal()
        {
            this.Total = Subtotal - Descuento;
            return Total;
        }

       
    }

}
