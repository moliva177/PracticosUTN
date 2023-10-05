using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veterinaria.datos;

namespace veterinaria
{
    internal static class Utiles
    {
        public static void CargarCombo(ComboBox combo, string sp)
        {
            DBHelper dbo = new DBHelper();

            DataTable dt = dbo.Consultar(sp);
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ToString();
            combo.DisplayMember = dt.Columns[1].ToString();
        }

        public static void CargarCombo(ComboBox combo, string sp, List<SqlParameter> parametros)
        {
            DBHelper dbo = new DBHelper();

            DataTable dt = dbo.Consultar(sp, parametros);
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ToString();
            combo.DisplayMember = dt.Columns[1].ToString();
        }

    }
}
