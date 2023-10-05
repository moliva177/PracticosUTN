using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria.dominio
{
    internal class Atencion
    {
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public double Importe { get; set; }

        public Atencion(string descripcion, double importe)
        {
            Fecha = DateTime.Now;
            Descripcion = descripcion;
            Importe = importe;
        }
    }
}
