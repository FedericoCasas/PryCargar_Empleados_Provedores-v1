
namespace PryPerezFederico
{
    partial class frmMenuPrincipal
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
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apellidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dNIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.apellidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.numeroDeEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buacarVentarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.SeaGreen;
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripMenuItem,
            this.apellidoToolStripMenuItem,
            this.dNIToolStripMenuItem});
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nombreToolStripMenuItem
            // 
            this.nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            this.nombreToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.nombreToolStripMenuItem.Text = "Cargar Cliente";
            this.nombreToolStripMenuItem.Click += new System.EventHandler(this.nombreToolStripMenuItem_Click);
            // 
            // apellidoToolStripMenuItem
            // 
            this.apellidoToolStripMenuItem.Name = "apellidoToolStripMenuItem";
            this.apellidoToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.apellidoToolStripMenuItem.Text = "Buscar Cliente";
            this.apellidoToolStripMenuItem.Click += new System.EventHandler(this.apellidoToolStripMenuItem_Click);
            // 
            // dNIToolStripMenuItem
            // 
            this.dNIToolStripMenuItem.Name = "dNIToolStripMenuItem";
            this.dNIToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.dNIToolStripMenuItem.Text = "Mostrar Cliente";
            this.dNIToolStripMenuItem.Click += new System.EventHandler(this.dNIToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.BackColor = System.Drawing.Color.SeaGreen;
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripMenuItem1,
            this.apellidoToolStripMenuItem1,
            this.numeroDeEmpleadoToolStripMenuItem});
            this.empleadosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadosToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nombreToolStripMenuItem1
            // 
            this.nombreToolStripMenuItem1.Name = "nombreToolStripMenuItem1";
            this.nombreToolStripMenuItem1.Size = new System.Drawing.Size(207, 24);
            this.nombreToolStripMenuItem1.Text = "Cargar Empleado";
            this.nombreToolStripMenuItem1.Click += new System.EventHandler(this.nombreToolStripMenuItem1_Click);
            // 
            // apellidoToolStripMenuItem1
            // 
            this.apellidoToolStripMenuItem1.Name = "apellidoToolStripMenuItem1";
            this.apellidoToolStripMenuItem1.Size = new System.Drawing.Size(207, 24);
            this.apellidoToolStripMenuItem1.Text = "Buscar Empleado";
            this.apellidoToolStripMenuItem1.Click += new System.EventHandler(this.apellidoToolStripMenuItem1_Click);
            // 
            // numeroDeEmpleadoToolStripMenuItem
            // 
            this.numeroDeEmpleadoToolStripMenuItem.Name = "numeroDeEmpleadoToolStripMenuItem";
            this.numeroDeEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.numeroDeEmpleadoToolStripMenuItem.Text = "Mostrar Empleado";
            this.numeroDeEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.numeroDeEmpleadoToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.BackColor = System.Drawing.Color.SeaGreen;
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarVentaToolStripMenuItem,
            this.buacarVentarToolStripMenuItem,
            this.mostrarVentaToolStripMenuItem,
            this.mostrarTotalToolStripMenuItem});
            this.ventasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventasToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cargarVentaToolStripMenuItem
            // 
            this.cargarVentaToolStripMenuItem.Name = "cargarVentaToolStripMenuItem";
            this.cargarVentaToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.cargarVentaToolStripMenuItem.Text = "Cargar Venta";
            this.cargarVentaToolStripMenuItem.Click += new System.EventHandler(this.cargarVentaToolStripMenuItem_Click);
            // 
            // buacarVentarToolStripMenuItem
            // 
            this.buacarVentarToolStripMenuItem.Name = "buacarVentarToolStripMenuItem";
            this.buacarVentarToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.buacarVentarToolStripMenuItem.Text = "Buscar Venta";
            this.buacarVentarToolStripMenuItem.Click += new System.EventHandler(this.buacarVentarToolStripMenuItem_Click);
            // 
            // mostrarVentaToolStripMenuItem
            // 
            this.mostrarVentaToolStripMenuItem.Name = "mostrarVentaToolStripMenuItem";
            this.mostrarVentaToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.mostrarVentaToolStripMenuItem.Text = "Buscar Compra";
            this.mostrarVentaToolStripMenuItem.Click += new System.EventHandler(this.mostrarVentaToolStripMenuItem_Click);
            // 
            // mostrarTotalToolStripMenuItem
            // 
            this.mostrarTotalToolStripMenuItem.Name = "mostrarTotalToolStripMenuItem";
            this.mostrarTotalToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.mostrarTotalToolStripMenuItem.Text = "Mostrar Total";
            this.mostrarTotalToolStripMenuItem.Click += new System.EventHandler(this.mostrarTotalToolStripMenuItem_Click);
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStripMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripMenu.Size = new System.Drawing.Size(126, 583);
            this.menuStripMenu.TabIndex = 0;
            this.menuStripMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.SeaGreen;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(952, 583);
            this.Controls.Add(this.menuStripMenu);
            this.MainMenuStrip = this.menuStripMenu;
            this.Name = "frmMenuPrincipal";
            this.Text = "MENU PRINCIPAL";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStripMenu.ResumeLayout(false);
            this.menuStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apellidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dNIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem apellidoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem numeroDeEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buacarVentarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarVentaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTotalToolStripMenuItem;
    }
}

