using Microsoft.AspNetCore.Mvc;

namespace APIFechas.Models
{
    public class Fecha
    {
        public int Numero { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public int DiaSemana { get; set; }

        public Fecha()
        {
            DateTime f = DateTime.Now;
            Numero = f.Day;
            Mes = f.Month;
            Anio = f.Year;
            DiaSemana = (int)f.DayOfWeek;
        }
    }
}
