namespace veterinaria.vistas
{
    partial class FrmAtencion
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
            cboCliente = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cboMascota = new ComboBox();
            cbNuevaMascota = new CheckBox();
            txtNombre = new TextBox();
            gbMascota = new GroupBox();
            label6 = new Label();
            cboTipo = new ComboBox();
            label5 = new Label();
            txtEdad = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtImporte = new TextBox();
            btnAgregar = new Button();
            dgvAtencion = new DataGridView();
            ColFecha = new DataGridViewTextBoxColumn();
            ColDescripcion = new DataGridViewTextBoxColumn();
            ColImporte = new DataGridViewTextBoxColumn();
            ColAccion = new DataGridViewButtonColumn();
            btnGuardar = new Button();
            btnCancelar = new Button();
            gbMascota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAtencion).BeginInit();
            SuspendLayout();
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(86, 24);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(348, 23);
            cboCliente.TabIndex = 0;
            cboCliente.SelectionChangeCommitted += cboCliente_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Mascota";
            // 
            // cboMascota
            // 
            cboMascota.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMascota.FormattingEnabled = true;
            cboMascota.Location = new Point(86, 76);
            cboMascota.Name = "cboMascota";
            cboMascota.Size = new Size(348, 23);
            cboMascota.TabIndex = 3;
            // 
            // cbNuevaMascota
            // 
            cbNuevaMascota.AutoSize = true;
            cbNuevaMascota.Location = new Point(457, 78);
            cbNuevaMascota.Name = "cbNuevaMascota";
            cbNuevaMascota.Size = new Size(113, 19);
            cbNuevaMascota.TabIndex = 4;
            cbNuevaMascota.Text = "Mascota Nueva?";
            cbNuevaMascota.UseVisualStyleBackColor = true;
            cbNuevaMascota.CheckedChanged += cbNuevaMascota_CheckedChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(74, 37);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(348, 23);
            txtNombre.TabIndex = 5;
            // 
            // gbMascota
            // 
            gbMascota.Controls.Add(label6);
            gbMascota.Controls.Add(cboTipo);
            gbMascota.Controls.Add(label5);
            gbMascota.Controls.Add(txtEdad);
            gbMascota.Controls.Add(label4);
            gbMascota.Controls.Add(label3);
            gbMascota.Controls.Add(txtNombre);
            gbMascota.Enabled = false;
            gbMascota.Location = new Point(12, 122);
            gbMascota.Name = "gbMascota";
            gbMascota.Size = new Size(743, 129);
            gbMascota.TabIndex = 6;
            gbMascota.TabStop = false;
            gbMascota.Text = "Datos de Mascota";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1, 90);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 11;
            label6.Text = "Tipo";
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(76, 87);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(348, 23);
            cboTipo.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(564, 40);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 9;
            label5.Text = "Años";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(484, 37);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(74, 23);
            txtEdad.TabIndex = 8;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(445, 40);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 40);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(88, 273);
            txtDescripcion.MaxLength = 250;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(348, 23);
            txtDescripcion.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 276);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 8;
            label7.Text = "Descripcion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(457, 276);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 9;
            label8.Text = "Importe";
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(512, 273);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(98, 23);
            txtImporte.TabIndex = 10;
            txtImporte.KeyPress += txtImporte_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(680, 273);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvAtencion
            // 
            dgvAtencion.AllowUserToAddRows = false;
            dgvAtencion.AllowUserToDeleteRows = false;
            dgvAtencion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtencion.Columns.AddRange(new DataGridViewColumn[] { ColFecha, ColDescripcion, ColImporte, ColAccion });
            dgvAtencion.Location = new Point(12, 302);
            dgvAtencion.Name = "dgvAtencion";
            dgvAtencion.ReadOnly = true;
            dgvAtencion.RowTemplate.Height = 25;
            dgvAtencion.Size = new Size(743, 222);
            dgvAtencion.TabIndex = 12;
            dgvAtencion.CellContentClick += dgvAtencion_CellContentClick;
            // 
            // ColFecha
            // 
            ColFecha.HeaderText = "Fecha";
            ColFecha.Name = "ColFecha";
            ColFecha.ReadOnly = true;
            ColFecha.Width = 150;
            // 
            // ColDescripcion
            // 
            ColDescripcion.HeaderText = "Descripcion";
            ColDescripcion.Name = "ColDescripcion";
            ColDescripcion.ReadOnly = true;
            ColDescripcion.Width = 350;
            // 
            // ColImporte
            // 
            ColImporte.HeaderText = "Importe";
            ColImporte.Name = "ColImporte";
            ColImporte.ReadOnly = true;
            // 
            // ColAccion
            // 
            ColAccion.HeaderText = "Accion";
            ColAccion.Name = "ColAccion";
            ColAccion.ReadOnly = true;
            ColAccion.Text = "Quitar";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(576, 530);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(680, 530);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 565);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvAtencion);
            Controls.Add(btnAgregar);
            Controls.Add(txtImporte);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtDescripcion);
            Controls.Add(gbMascota);
            Controls.Add(cbNuevaMascota);
            Controls.Add(cboMascota);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboCliente);
            Name = "FrmAtencion";
            Text = "Atencion";
            Load += FrmAtencion_Load;
            gbMascota.ResumeLayout(false);
            gbMascota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAtencion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCliente;
        private Label label1;
        private Label label2;
        private ComboBox cboMascota;
        private CheckBox cbNuevaMascota;
        private TextBox txtNombre;
        private GroupBox gbMascota;
        private Label label6;
        private ComboBox cboTipo;
        private Label label5;
        private TextBox txtEdad;
        private Label label4;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label7;
        private Label label8;
        private TextBox txtImporte;
        private Button btnAgregar;
        private DataGridView dgvAtencion;
        private Button btnGuardar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn ColDescripcion;
        private DataGridViewTextBoxColumn ColImporte;
        private DataGridViewButtonColumn ColAccion;
    }
}