namespace veterinaria.vistas
{
    partial class FrmMenu
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
            menuStrip1 = new MenuStrip();
            atencionToolStripMenuItem = new ToolStripMenuItem();
            nuevaAtencionToolStripMenuItem = new ToolStripMenuItem();
            consultarAtencionesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { atencionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // atencionToolStripMenuItem
            // 
            atencionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaAtencionToolStripMenuItem, consultarAtencionesToolStripMenuItem });
            atencionToolStripMenuItem.Name = "atencionToolStripMenuItem";
            atencionToolStripMenuItem.Size = new Size(67, 20);
            atencionToolStripMenuItem.Text = "Atencion";
            // 
            // nuevaAtencionToolStripMenuItem
            // 
            nuevaAtencionToolStripMenuItem.Name = "nuevaAtencionToolStripMenuItem";
            nuevaAtencionToolStripMenuItem.Size = new Size(187, 22);
            nuevaAtencionToolStripMenuItem.Text = "Nueva Atencion";
            nuevaAtencionToolStripMenuItem.Click += nuevaAtencionToolStripMenuItem_Click;
            // 
            // consultarAtencionesToolStripMenuItem
            // 
            consultarAtencionesToolStripMenuItem.Name = "consultarAtencionesToolStripMenuItem";
            consultarAtencionesToolStripMenuItem.Size = new Size(187, 22);
            consultarAtencionesToolStripMenuItem.Text = "Consultar Atenciones";
            consultarAtencionesToolStripMenuItem.Click += consultarAtencionesToolStripMenuItem_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "FrmMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem atencionToolStripMenuItem;
        private ToolStripMenuItem nuevaAtencionToolStripMenuItem;
        private ToolStripMenuItem consultarAtencionesToolStripMenuItem;
    }
}