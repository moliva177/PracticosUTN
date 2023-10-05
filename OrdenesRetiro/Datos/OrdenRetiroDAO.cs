using OrdenesRetiro.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesRetiro.Datos
{
    public class OrdenRetiroDAO : IDAOOrdenRetiro
    {
        public int RegistrarOrden(OrdenRetiro orden)
        {
            int resultado = 0;
            SqlConnection cnn = HelperDAO.ObtenerInstancia().ObtenerConeccion();
            SqlTransaction trans = null;

            try
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                trans = cnn.BeginTransaction();

                SqlCommand cmdOrden = new SqlCommand("SP_INSERTAR_ORDEN", cnn, trans);
                cmdOrden.CommandType = CommandType.StoredProcedure;
                SqlParameter nroOrden = new SqlParameter("@nro", SqlDbType.Int);
                nroOrden.Direction = ParameterDirection.Output;
                cmdOrden.Parameters.Add(nroOrden);
                cmdOrden.Parameters.AddWithValue("@responsable", orden.Responsable);
                cmdOrden.ExecuteNonQuery();
                resultado = (int)nroOrden.Value;

                int i = 1;
                foreach (DetalleOrden detalle in orden.Detalles)
                {
                    SqlCommand cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES", cnn, trans);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@nro_orden", resultado);
                    cmdDetalle.Parameters.AddWithValue("@detalle", i++);
                    cmdDetalle.Parameters.AddWithValue("@codigo", detalle.Material.Codigo);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                }
                trans.Commit();
            }
            catch
            {
                if (trans != null)
                    trans.Rollback();
                resultado = 0;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return resultado;
        }
    }
}
