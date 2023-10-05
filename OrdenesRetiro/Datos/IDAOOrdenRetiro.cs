using OrdenesRetiro.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesRetiro.Datos
{
    public interface IDAOOrdenRetiro
    {
        int RegistrarOrden(OrdenRetiro orden);
    }
}
