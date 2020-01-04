using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaElextronica
{

    interface IUsuario
    {
        //PRINCIPIO SEGREGACION DE INTERFACES


        string Cedula();
        string Nombres();
        string Apellidos();
        string Email();
        string Contrasena();

    }
}
