using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using veterinaria.dominio;

namespace veterinaria.datos
{
    internal class DBHelper
    {
        private SqlConnection cnn;

        public DBHelper()
        {
            cnn = new SqlConnection(@"Data Source=GAMING-STUDY\UTN_SSQL_LABO1;Initial Catalog=veterinaria;Integrated Security=True");
        }

        public DataTable Consultar(string sp)
        {
            DataTable dt = new DataTable();

            cnn.Open();

            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            dt.Load(cmd.ExecuteReader());

            cnn.Close();

            return dt;
        }

        public DataTable Consultar(string sp, List<SqlParameter> parametros)
        {
            DataTable dt = new DataTable();

            cnn.Open();

            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter param in parametros)
                cmd.Parameters.AddWithValue(param.ParameterName, param.Value);

            dt.Load(cmd.ExecuteReader());

            cnn.Close();

            return dt;
        }

        public bool GrabarAtencion(Mascota mascota)
        {
            bool res = true;
            SqlTransaction t = null;

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                if (mascota.Id == -1)
                {
                    SqlCommand cmd = new SqlCommand("sp_insert_mascota", cnn, t);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //param entrada
                    cmd.Parameters.AddWithValue("@cliente", mascota.Cliente);
                    cmd.Parameters.AddWithValue("@nombre", mascota.Nombre);
                    cmd.Parameters.AddWithValue("@edad", mascota.Edad);
                    cmd.Parameters.AddWithValue("@tipo", mascota.Tipo);

                    //param salida
                    SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
                    param.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(param);
                    cmd.ExecuteNonQuery();
                    mascota.Id = (int)param.Value;
                }
                    

                foreach (Atencion atencion in mascota.Atenciones)
                {
                    SqlCommand cmd = new SqlCommand("sp_insert_atencion", cnn, t);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //param entrada
                    cmd.Parameters.AddWithValue("@mascota", mascota.Id);
                    cmd.Parameters.AddWithValue("@fecha", atencion.Fecha);
                    cmd.Parameters.AddWithValue("@descripcion", atencion.Descripcion);
                    cmd.Parameters.AddWithValue("@importe", atencion.Importe);
                    cmd.ExecuteNonQuery();
                }

                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback();
                res = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return res;
        }


    }
}
