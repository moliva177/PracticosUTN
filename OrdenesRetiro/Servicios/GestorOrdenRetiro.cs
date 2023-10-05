using OrdenesRetiro.Datos;
using OrdenesRetiro.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesRetiro.Servicios
{
    public class GestorOrdenRetiro
    {
        private IDAOOrdenRetiro dao;

        public GestorOrdenRetiro(IDAOOrdenRetiro dao)
        {
            this.dao = dao;
        }

        public int RegistrarOrden(OrdenRetiro orden) { return dao.RegistrarOrden(orden); }
    }
}
