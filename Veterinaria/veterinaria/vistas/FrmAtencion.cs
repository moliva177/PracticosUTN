using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veterinaria.datos;
using veterinaria.dominio;

namespace veterinaria.vistas
{
    public partial class FrmAtencion : Form
    {
        private DBHelper dbo;
        private Mascota mascota;

        public FrmAtencion()
        {
            InitializeComponent();

            dbo = new DBHelper();
            mascota = new Mascota();
        }

        private void cbNuevaMascota_CheckedChanged(object sender, EventArgs e)
        {
            cboMascota.Enabled = !cboMascota.Enabled;
            gbMascota.Enabled = !gbMascota.Enabled;
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarAtencion())
            {
                Atencion atencion = new Atencion(txtDescripcion.Text, Convert.ToDouble(txtImporte.Text));
                mascota.AgregarAtencion(atencion);
                dgvAtencion.Rows.Add(atencion.Fecha.ToString("dd/MM/yyyy HH:mm"), atencion.Descripcion, atencion.Importe, "Quitar");

                txtDescripcion.Text = string.Empty;
                txtImporte.Text = string.Empty;
                txtDescripcion.Focus();
            }
        }

        private bool ValidarClienteMascota()
        {
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar uncliente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!cbNuevaMascota.Checked)
            {
                if (cboMascota.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una mascota o crear una nueva", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtEdad.Text))
                {
                    MessageBox.Show("Debe ingresar una edad", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEdad.Focus();
                    return false;
                }
                else
                {
                    double edad = Convert.ToDouble(txtEdad.Text);
                    if (edad < 0)
                    {
                        MessageBox.Show("Debe ingresar una edad valida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEdad.Focus();
                        return false;
                    }
                }

                if (cboTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un tipo de mascota", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private bool ValidarAtencion()
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar una descripcion", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtImporte.Text))
            {
                MessageBox.Show("Debe ingresar un importe", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtImporte.Focus();
                return false;
            }
            else
            {
                double importe = Convert.ToDouble(txtImporte.Text);
                if (importe < 0)
                {
                    MessageBox.Show("Debe ingresar un importe valido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtImporte.Focus();
                    return false;
                }
            }

            return true;
        }

        private void FrmAtencion_Load(object sender, EventArgs e)
        {
            Utiles.CargarCombo(cboCliente, "sp_clientes");
            cboCliente.SelectedIndex = -1;
            Utiles.CargarCombo(cboTipo, "sp_tipos_mascota");
            cboTipo.SelectedIndex = -1;

            txtDescripcion.Focus();
        }

        private void cboCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id", cboCliente.SelectedValue));
            Utiles.CargarCombo(cboMascota, "sp_mascotas_cliente", parametros);
            cboMascota.SelectedIndex = -1;
        }

        private void dgvAtencion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAtencion.Columns["ColAccion"].Index)
            {
                mascota.QuitarAtencion(e.RowIndex);
                dgvAtencion.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarClienteMascota())
            {
                if (dgvAtencion.Rows.Count == 0)
                {
                    MessageBox.Show("Debe ingresar al menos una atencion", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescripcion.Focus();
                    return;
                }

                if (!cbNuevaMascota.Checked)
                {
                    mascota.Id = (int)cboMascota.SelectedValue;
                }
                else
                {
                    mascota.Cliente = (long)cboCliente.SelectedValue;
                    mascota.Nombre = txtNombre.Text;
                    mascota.Edad = int.Parse(txtEdad.Text);
                    mascota.Tipo = (int)cboTipo.SelectedValue;
                }

                if (dbo.GrabarAtencion(mascota))
                {
                    MessageBox.Show("Se grabo la atencion correctamente", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                    MessageBox.Show("No se pudo grabar, intente nuevamente mas tarde", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
