using OrdenesRetiro.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesRetiro.Datos
{
    public class MaterialDAO : IDAOMaterial
    {
        public List<Material> ObtenerMateriales()
        {
            List<Material> materiales = new List<Material>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_CONSULTAR_MATERIALES");

            foreach (DataRow fila in tabla.Rows)
            {
                Material material = new Material();
                material.Codigo = int.Parse(fila["codigo"].ToString());
                material.Nombre = fila["nombre"].ToString();
                material.Stock = double.Parse(fila["stock"].ToString());
                materiales.Add(material);
            }

            return materiales;
        }
    }
}
