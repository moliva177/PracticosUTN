using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veterinaria.vistas
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void nuevaAtencionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtencion frmAtencion = new FrmAtencion();
            frmAtencion.ShowDialog();
        }

        private void consultarAtencionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarAtenciones frmConsultarAtenciones = new FrmConsultarAtenciones();
            frmConsultarAtenciones.ShowDialog();
        }
    }
}
