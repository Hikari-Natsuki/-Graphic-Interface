namespace GimasioMDI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.tsmArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.msiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.msiServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSalida = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbClientes = new System.Windows.Forms.ToolStripButton();
            this.tsbServicios = new System.Windows.Forms.ToolStripButton();
            this.mspMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArchivo,
            this.tsmAyuda});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(800, 24);
            this.mspMenu.TabIndex = 1;
            this.mspMenu.Text = "menuStrip1";
            // 
            // tsmArchivo
            // 
            this.tsmArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiClientes,
            this.msiServicios,
            this.msiSalida,
            this.toolStripMenuItem1});
            this.tsmArchivo.Name = "tsmArchivo";
            this.tsmArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsmArchivo.Text = "&Archivo";
            // 
            // tsmAyuda
            // 
            this.tsmAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAcerca});
            this.tsmAyuda.Name = "tsmAyuda";
            this.tsmAyuda.Size = new System.Drawing.Size(53, 20);
            this.tsmAyuda.Text = "A&yuda";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // msiClientes
            // 
            this.msiClientes.Image = global::GimasioMDI.Properties.Resources.icons8_clientes_50;
            this.msiClientes.Name = "msiClientes";
            this.msiClientes.Size = new System.Drawing.Size(180, 22);
            this.msiClientes.Text = "Gestión de C&lientes";
            this.msiClientes.Click += new System.EventHandler(this.msiClientes_Click);
            // 
            // msiServicios
            // 
            this.msiServicios.Image = global::GimasioMDI.Properties.Resources.icons8_servicios_50;
            this.msiServicios.Name = "msiServicios";
            this.msiServicios.Size = new System.Drawing.Size(180, 22);
            this.msiServicios.Text = "Gestión de &Servicios";
            this.msiServicios.Click += new System.EventHandler(this.msiServicios_Click);
            // 
            // msiSalida
            // 
            this.msiSalida.Image = global::GimasioMDI.Properties.Resources.icons8_salida_de_incendios_50;
            this.msiSalida.Name = "msiSalida";
            this.msiSalida.Size = new System.Drawing.Size(180, 22);
            this.msiSalida.Text = "&Salir";
            this.msiSalida.Click += new System.EventHandler(this.msiSalida_Click);
            // 
            // msiAcerca
            // 
            this.msiAcerca.Image = global::GimasioMDI.Properties.Resources.icons8_acerca_de_50;
            this.msiAcerca.Name = "msiAcerca";
            this.msiAcerca.Size = new System.Drawing.Size(135, 22);
            this.msiAcerca.Text = "A&cerca de...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClientes,
            this.tsbServicios});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbClientes
            // 
            this.tsbClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClientes.Image = global::GimasioMDI.Properties.Resources.icons8_clientes_50;
            this.tsbClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClientes.Name = "tsbClientes";
            this.tsbClientes.Size = new System.Drawing.Size(23, 22);
            this.tsbClientes.Text = "toolStripButton1";
            this.tsbClientes.ToolTipText = "Gestón de clientes";
            this.tsbClientes.Click += new System.EventHandler(this.tsbClientes_Click);
            // 
            // tsbServicios
            // 
            this.tsbServicios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbServicios.Image = global::GimasioMDI.Properties.Resources.icons8_servicios_50;
            this.tsbServicios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbServicios.Name = "tsbServicios";
            this.tsbServicios.Size = new System.Drawing.Size(23, 22);
            this.tsbServicios.Text = "toolStripButton1";
            this.tsbServicios.ToolTipText = "Gestión de servicios";
            this.tsbServicios.Click += new System.EventHandler(this.tsbServicios_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mspMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mspMenu;
            this.Name = "frmPrincipal";
            this.Text = "Gimnasio Don Chucho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmArchivo;
        private System.Windows.Forms.ToolStripMenuItem msiClientes;
        private System.Windows.Forms.ToolStripMenuItem msiServicios;
        private System.Windows.Forms.ToolStripMenuItem msiSalida;
        private System.Windows.Forms.ToolStripMenuItem tsmAyuda;
        private System.Windows.Forms.ToolStripMenuItem msiAcerca;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClientes;
        private System.Windows.Forms.ToolStripButton tsbServicios;
    }
}

