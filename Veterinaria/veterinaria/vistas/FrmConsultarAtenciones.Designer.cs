namespace veterinaria.vistas
{
    partial class FrmConsultarAtenciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbFiltros = new GroupBox();
            cboCliente = new ComboBox();
            btnBuscar = new Button();
            label3 = new Label();
            dtpHasta = new DateTimePicker();
            label2 = new Label();
            dtpDesde = new DateTimePicker();
            label1 = new Label();
            dgvConsulta = new DataGridView();
            ColDNI = new DataGridViewTextBoxColumn();
            ColCliente = new DataGridViewTextBoxColumn();
            ColSexo = new DataGridViewTextBoxColumn();
            ColMascota = new DataGridViewTextBoxColumn();
            ColEdad = new DataGridViewTextBoxColumn();
            ColTipo = new DataGridViewTextBoxColumn();
            ColAccion = new DataGridViewButtonColumn();
            btnSalir = new Button();
            gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // gbFiltros
            // 
            gbFiltros.Controls.Add(cboCliente);
            gbFiltros.Controls.Add(btnBuscar);
            gbFiltros.Controls.Add(label3);
            gbFiltros.Controls.Add(dtpHasta);
            gbFiltros.Controls.Add(label2);
            gbFiltros.Controls.Add(dtpDesde);
            gbFiltros.Controls.Add(label1);
            gbFiltros.Location = new Point(12, 12);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(776, 102);
            gbFiltros.TabIndex = 0;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtros";
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(64, 64);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(312, 23);
            cboCliente.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(686, 64);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 67);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Cliente";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(382, 13);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(236, 23);
            dtpHasta.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 19);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Hasta";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(64, 13);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(236, 23);
            dtpDesde.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Desde";
            // 
            // dgvConsulta
            // 
            dgvConsulta.AllowUserToAddRows = false;
            dgvConsulta.AllowUserToDeleteRows = false;
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Columns.AddRange(new DataGridViewColumn[] { ColDNI, ColCliente, ColSexo, ColMascota, ColEdad, ColTipo, ColAccion });
            dgvConsulta.Location = new Point(12, 120);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.ReadOnly = true;
            dgvConsulta.RowTemplate.Height = 25;
            dgvConsulta.Size = new Size(770, 230);
            dgvConsulta.TabIndex = 1;
            dgvConsulta.CellContentClick += dgvConsulta_CellContentClick;
            // 
            // ColDNI
            // 
            ColDNI.HeaderText = "DNI";
            ColDNI.Name = "ColDNI";
            ColDNI.ReadOnly = true;
            // 
            // ColCliente
            // 
            ColCliente.HeaderText = "Cliente";
            ColCliente.Name = "ColCliente";
            ColCliente.ReadOnly = true;
            // 
            // ColSexo
            // 
            ColSexo.HeaderText = "Sexo";
            ColSexo.Name = "ColSexo";
            ColSexo.ReadOnly = true;
            // 
            // ColMascota
            // 
            ColMascota.HeaderText = "Mascota";
            ColMascota.Name = "ColMascota";
            ColMascota.ReadOnly = true;
            // 
            // ColEdad
            // 
            ColEdad.HeaderText = "Edad";
            ColEdad.Name = "ColEdad";
            ColEdad.ReadOnly = true;
            // 
            // ColTipo
            // 
            ColTipo.HeaderText = "Tipo";
            ColTipo.Name = "ColTipo";
            ColTipo.ReadOnly = true;
            // 
            // ColAccion
            // 
            ColAccion.HeaderText = "Accion";
            ColAccion.Name = "ColAccion";
            ColAccion.ReadOnly = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(698, 415);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmConsultarAtenciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(dgvConsulta);
            Controls.Add(gbFiltros);
            Name = "FrmConsultarAtenciones";
            Text = "FrmConsultarAtenciones";
            Load += FrmConsultarAtenciones_Load;
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbFiltros;
        private ComboBox cboCliente;
        private Button btnBuscar;
        private Label label3;
        private DateTimePicker dtpHasta;
        private Label label2;
        private DateTimePicker dtpDesde;
        private Label label1;
        private DataGridView dgvConsulta;
        private DataGridViewTextBoxColumn ColDNI;
        private DataGridViewTextBoxColumn ColCliente;
        private DataGridViewTextBoxColumn ColSexo;
        private DataGridViewTextBoxColumn ColMascota;
        private DataGridViewTextBoxColumn ColEdad;
        private DataGridViewTextBoxColumn ColTipo;
        private DataGridViewButtonColumn ColAccion;
        private Button btnSalir;
    }
}