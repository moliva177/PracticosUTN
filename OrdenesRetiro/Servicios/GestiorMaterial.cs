using OrdenesRetiro.Datos;
using OrdenesRetiro.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesRetiro.Servicios
{
    public class GestiorMaterial
    {
        private IDAOMaterial dao;

        public GestiorMaterial(IDAOMaterial dao)
        {
            this.dao = dao;
        }

        public List<Material> ObtenerMateriales() { return dao.ObtenerMateriales(); }
    }
}
