namespace OrdenesRetiro
{
    partial class frmOrdenes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dtpFecha = new DateTimePicker();
            txtResponsable = new TextBox();
            cboMaterial = new ComboBox();
            numCantidad = new NumericUpDown();
            dgvDetalles = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColMaterial = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColQuitar = new DataGridViewButtonColumn();
            btnAgregar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(91, 9);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(252, 23);
            dtpFecha.TabIndex = 1;
            // 
            // txtResponsable
            // 
            txtResponsable.Location = new Point(91, 45);
            txtResponsable.MaxLength = 100;
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(352, 23);
            txtResponsable.TabIndex = 2;
            // 
            // cboMaterial
            // 
            cboMaterial.FormattingEnabled = true;
            cboMaterial.Location = new Point(12, 130);
            cboMaterial.Name = "cboMaterial";
            cboMaterial.Size = new Size(274, 23);
            cboMaterial.TabIndex = 3;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(292, 130);
            numCantidad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(120, 23);
            numCantidad.TabIndex = 4;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { ColID, ColMaterial, ColStock, ColCantidad, ColQuitar });
            dgvDetalles.Location = new Point(12, 159);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowTemplate.Height = 25;
            dgvDetalles.Size = new Size(643, 250);
            dgvDetalles.TabIndex = 5;
            dgvDetalles.CellContentClick += dgvDetalles_CellContentClick;
            // 
            // ColID
            // 
            ColID.HeaderText = "";
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.Visible = false;
            // 
            // ColMaterial
            // 
            ColMaterial.HeaderText = "Material";
            ColMaterial.Name = "ColMaterial";
            ColMaterial.ReadOnly = true;
            ColMaterial.Width = 300;
            // 
            // ColStock
            // 
            ColStock.HeaderText = "Stock";
            ColStock.Name = "ColStock";
            ColStock.ReadOnly = true;
            // 
            // ColCantidad
            // 
            ColCantidad.HeaderText = "Cantidad";
            ColCantidad.Name = "ColCantidad";
            ColCantidad.ReadOnly = true;
            // 
            // ColQuitar
            // 
            ColQuitar.HeaderText = "";
            ColQuitar.Name = "ColQuitar";
            ColQuitar.ReadOnly = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(547, 130);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 7;
            label2.Text = "Responsable";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 8;
            label3.Text = "Material";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 112);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 9;
            label4.Text = "Cantidad";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(178, 415);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(108, 23);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(378, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmOrdenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(dgvDetalles);
            Controls.Add(numCantidad);
            Controls.Add(cboMaterial);
            Controls.Add(txtResponsable);
            Controls.Add(dtpFecha);
            Controls.Add(label1);
            Name = "frmOrdenes";
            Text = "Registrar Orden";
            Load += frmOrdenes_Load;
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpFecha;
        private TextBox txtResponsable;
        private ComboBox cboMaterial;
        private NumericUpDown numCantidad;
        private DataGridView dgvDetalles;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColMaterial;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewButtonColumn ColQuitar;
        private Button btnAgregar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}