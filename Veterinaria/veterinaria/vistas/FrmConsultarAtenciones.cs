using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veterinaria.datos;

namespace veterinaria.vistas
{
    public partial class FrmConsultarAtenciones : Form
    {
        private DBHelper dbo;
        public FrmConsultarAtenciones()
        {
            InitializeComponent();

            dbo = new DBHelper();
        }

        private void FrmConsultarAtenciones_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.AddDays(-7);
            dtpHasta.Value = DateTime.Today;

            Utiles.CargarCombo(cboCliente, "sp_clientes");
            cboCliente.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@fecha_desde", dtpDesde.Value));
                parametros.Add(new SqlParameter("@fecha_hasta", dtpHasta.Value));
                if (cboCliente.SelectedIndex == -1)
                    parametros.Add(new SqlParameter("@cliente", -1));
                else
                    parametros.Add(new SqlParameter("@cliente", cboCliente.SelectedValue));

                DataTable dt = dbo.Consultar("sp_consultar_atenciones", parametros);

                dgvConsulta.Rows.Clear();
                foreach (DataRow fila in dt.Rows)
                {
                    dgvConsulta.Rows.Add(new object[] { fila["dni"].ToString(),
                                                        fila["cliente"].ToString(),
                                                        fila["sexo"].ToString(),
                                                        fila["mascota"].ToString(),
                                                        fila["edad"].ToString(),
                                                        fila["tipo"].ToString(),
                                                        "Ver Atenciones"});
                }
            }
        }

        private bool Validaciones()
        {
            if (dtpDesde.Value == dtpHasta.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la de fin", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvConsulta.Columns["ColAccion"].Index)
            {

            }
        }
    }
}
