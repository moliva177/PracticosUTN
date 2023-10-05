using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesRetiro.Dominio
{
    public class OrdenRetiro
    {
        public int NroOrden { get; set; }
        public DateTime Fecha { get; set; }
        public string Responsable { get; set; }
        public List<DetalleOrden> Detalles { get; set; }

        public OrdenRetiro()
        {
            NroOrden = 0;
            Fecha = DateTime.Now;
            Responsable = string.Empty;
            Detalles = new List<DetalleOrden>();
        }

        public OrdenRetiro(int nro, DateTime fecha, string responsable, List<DetalleOrden> detalles)
        {
            NroOrden = nro;
            Fecha = fecha;
            Responsable = responsable;
            Detalles = detalles;
        }

        public void AgregarDetalle(DetalleOrden detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            Detalles.RemoveAt(indice);
        }

        public void ModificarCantidadDetalle(int indice, int cantidad)
        {
            Detalles[indice].Cantidad += cantidad;
        }
    }
}
