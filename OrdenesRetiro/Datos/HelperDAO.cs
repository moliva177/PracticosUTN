using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesRetiro.Datos
{
    public class HelperDAO
    {
        private static HelperDAO instancia = null;
        private string stringConeccion = @"Data Source=GAMING-STUDY\UTN_SSQL_LABO1;Initial Catalog=db_ordenes;Integrated Security=True";
        private SqlConnection cnn;

        private HelperDAO()
        {
            cnn = new SqlConnection(stringConeccion);
        }

        public static HelperDAO ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperDAO();
            return instancia;
        }

        public SqlConnection ObtenerConeccion() { return cnn; }

        public DataTable Consultar(string sp)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());

            return tabla;
        }
    }
}
