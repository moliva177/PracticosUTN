using Microsoft.VisualBasic.Logging;
using OrdenesRetiro.Datos;
using OrdenesRetiro.Dominio;
using OrdenesRetiro.Servicios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OrdenesRetiro
{
    public partial class frmOrdenes : Form
    {
        private OrdenRetiro orden;
        private GestiorMaterial gMaterial;
        private GestorOrdenRetiro gOrden;
        public frmOrdenes()
        {
            InitializeComponent();
            orden = new OrdenRetiro();
            gMaterial = new GestiorMaterial(new MaterialDAO());
            gOrden = new GestorOrdenRetiro(new OrdenRetiroDAO());
        }

        private void frmOrdenes_Load(object sender, EventArgs e)
        {
            //Al cargar el formulario se deberá tener el combo de productos cargado según los registros de la tabla T_Materiales
            CargarComboMaterial();
            txtResponsable.Focus();
        }

        private void CargarComboMaterial()
        {
            List<Material> materiales = gMaterial.ObtenerMateriales();

            cboMaterial.DataSource = materiales;
            cboMaterial.ValueMember = "Codigo";
            cboMaterial.DisplayMember = "Nombre";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Validaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Material material = (Material)cboMaterial.SelectedItem;
            //Deberá controlar además que solo es posible confirmar una orden si todos los materiales incluidos tienen stock suficiente
            if ((int)numCantidad.Value > material.Stock)
            {
                MessageBox.Show("No hay stock suficiente para la cantidad ingresada", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numCantidad.Focus();
                return;
            }

            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {
                if (material.Codigo == (int)fila.Cells["ColID"].Value)
                {
                    //Deberá controlar que no se pueden grabar dos veces el mismo material como detalle
                    //MessageBox.Show("No puede ingresar 2 veces el mismo material", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //Agrega la cantidad al detalle
                    orden.ModificarCantidadDetalle(fila.Index, (int)numCantidad.Value);
                    fila.Cells["ColCantidad"].Value = (int)fila.Cells["ColCantidad"].Value + (int)numCantidad.Value;
                    return;
                }
            }

            DetalleOrden detalle = new DetalleOrden(material, (int)numCantidad.Value);
            orden.AgregarDetalle(detalle);
            dgvDetalles.Rows.Add(material.Codigo, material.Nombre, material.Stock, (int)numCantidad.Value, "Quitar");
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                orden.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResponsable.Text))
            {
                MessageBox.Show("Debe ingresar un responsable", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtResponsable.Focus();
                return;
            }

            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("debe ingresar al menos un detalle..", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int nroOrden = gOrden.RegistrarOrden(orden);
            if (nroOrden == 0)
            {
                MessageBox.Show("Ocurrio un error deurante la carga, intente nuevamente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Se registro correctamente su orden con el Numero: " + nroOrden, "Orden Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}