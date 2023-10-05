using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesRetiro.Dominio
{
    public class DetalleOrden
    {
        public Material Material { get; set; }
        public int Cantidad { get; set; }

        public DetalleOrden()
        {
            Material = new Material();
            Cantidad = 0;
        }

        public DetalleOrden(Material material, int cantidad)
        {
            Material = material;
            Cantidad = cantidad;
        }
    }
}
