using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria.dominio
{
    internal class Mascota
    {
        public int Id { get; set; }
        public long Cliente { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Tipo { get; set; } //1-perro, 2-gato, 3-araña, 4-iguana
        public List<Atencion> Atenciones { get; set; }

        public Mascota()
        {
            Id = -1; //por defecto para nueva mascota
            Atenciones = new List<Atencion>();
        }

        public void AgregarAtencion(Atencion atencion)
        {
            Atenciones.Add(atencion);
        }

        public void QuitarAtencion(int indice)
        {
            Atenciones.RemoveAt(indice);
        }
    }
}
