using System;

namespace PryPerezFederico
{
    partial class frmCargarVenta
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
            this.gBoxMenu = new System.Windows.Forms.GroupBox();
            this.btnCargarProductos = new System.Windows.Forms.Button();
            this.btnFinalizarVenta = new System.Windows.Forms.Button();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxTipoRetiro = new System.Windows.Forms.GroupBox();
            this.rbuttonNo = new System.Windows.Forms.RadioButton();
            this.rbuttonSi = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTotalCliente = new System.Windows.Forms.Label();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.lblTelCliente = new System.Windows.Forms.Label();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.gBoxDatos = new System.Windows.Forms.GroupBox();
            this.btnBuscarDniEmpleado = new System.Windows.Forms.Button();
            this.txtDniEmpleado = new System.Windows.Forms.TextBox();
            this.lblDniEmpleado = new System.Windows.Forms.Label();
            this.lblNombreEmpleadoRespuesta = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblNombreClienteRespuesta = new System.Windows.Forms.Label();
            this.lblApellidoClienteRespuesta = new System.Windows.Forms.Label();
            this.btnBuscarDniCliente = new System.Windows.Forms.Button();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.gBoxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBoxTipoRetiro.SuspendLayout();
            this.gBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxMenu
            // 
            this.gBoxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gBoxMenu.Controls.Add(this.btnCargarProductos);
            this.gBoxMenu.Controls.Add(this.btnFinalizarVenta);
            this.gBoxMenu.Controls.Add(this.cmbProducto);
            this.gBoxMenu.Controls.Add(this.nudCantidad);
            this.gBoxMenu.Controls.Add(this.dataGridView1);
            this.gBoxMenu.Controls.Add(this.gBoxTipoRetiro);
            this.gBoxMenu.Controls.Add(this.btnCancelar);
            this.gBoxMenu.Controls.Add(this.lblTotalCliente);
            this.gBoxMenu.Controls.Add(this.lblDireccionCliente);
            this.gBoxMenu.Controls.Add(this.lblTelCliente);
            this.gBoxMenu.Controls.Add(this.lblTotalCompra);
            this.gBoxMenu.Controls.Add(this.lblProducto);
            this.gBoxMenu.Controls.Add(this.lblCantidad);
            this.gBoxMenu.Controls.Add(this.lblTelefonoCliente);
            this.gBoxMenu.Controls.Add(this.lblDireccion);
            this.gBoxMenu.Location = new System.Drawing.Point(12, 192);
            this.gBoxMenu.Name = "gBoxMenu";
            this.gBoxMenu.Size = new System.Drawing.Size(928, 380);
            this.gBoxMenu.TabIndex = 49;
            this.gBoxMenu.TabStop = false;
            // 
            // btnCargarProductos
            // 
            this.btnCargarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCargarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargarProductos.Location = new System.Drawing.Point(265, 88);
            this.btnCargarProductos.Name = "btnCargarProductos";
            this.btnCargarProductos.Size = new System.Drawing.Size(197, 24);
            this.btnCargarProductos.TabIndex = 63;
            this.btnCargarProductos.Text = "Cargar Productos";
            this.btnCargarProductos.UseVisualStyleBackColor = false;
            this.btnCargarProductos.Click += new System.EventHandler(this.btnCargarProductos_Click);
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFinalizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalizarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinalizarVenta.Location = new System.Drawing.Point(249, 310);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(199, 49);
            this.btnFinalizarVenta.TabIndex = 63;
            this.btnFinalizarVenta.Text = "Finalizar Venta";
            this.btnFinalizarVenta.UseVisualStyleBackColor = false;
            this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click);
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.ForeColor = System.Drawing.Color.DarkGray;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Items.AddRange(new object[] {
            "Celular Samsung Galaxy M13",
            "Smart TV 40 Pulgadas Hitachi",
            "Auriculares Vincha Plegable",
            "Auriculares Bluetooth Tws Philips",
            "Soporte Tv 19 A 43 Pulgadas One",
            ""});
            this.cmbProducto.Location = new System.Drawing.Point(163, 42);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(298, 32);
            this.cmbProducto.TabIndex = 62;
            this.cmbProducto.Text = "Seleccione el Producto";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(163, 84);
            this.nudCantidad.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(82, 29);
            this.nudCantidad.TabIndex = 61;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProductos,
            this.ColCantidad,
            this.ColPrecio});
            this.dataGridView1.Location = new System.Drawing.Point(525, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(360, 216);
            this.dataGridView1.TabIndex = 60;
            // 
            // ColProductos
            // 
            this.ColProductos.Frozen = true;
            this.ColProductos.HeaderText = "Productos";
            this.ColProductos.Name = "ColProductos";
            this.ColProductos.ReadOnly = true;
            // 
            // ColCantidad
            // 
            this.ColCantidad.Frozen = true;
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            // 
            // ColPrecio
            // 
            this.ColPrecio.Frozen = true;
            this.ColPrecio.HeaderText = "Precio p/u";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            // 
            // gBoxTipoRetiro
            // 
            this.gBoxTipoRetiro.Controls.Add(this.rbuttonNo);
            this.gBoxTipoRetiro.Controls.Add(this.rbuttonSi);
            this.gBoxTipoRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxTipoRetiro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gBoxTipoRetiro.Location = new System.Drawing.Point(20, 127);
            this.gBoxTipoRetiro.Name = "gBoxTipoRetiro";
            this.gBoxTipoRetiro.Size = new System.Drawing.Size(442, 68);
            this.gBoxTipoRetiro.TabIndex = 59;
            this.gBoxTipoRetiro.TabStop = false;
            this.gBoxTipoRetiro.Text = "Envio de Producto a Domicilio?";
            // 
            // rbuttonNo
            // 
            this.rbuttonNo.AutoSize = true;
            this.rbuttonNo.Location = new System.Drawing.Point(229, 28);
            this.rbuttonNo.Name = "rbuttonNo";
            this.rbuttonNo.Size = new System.Drawing.Size(53, 28);
            this.rbuttonNo.TabIndex = 1;
            this.rbuttonNo.TabStop = true;
            this.rbuttonNo.Text = "No";
            this.rbuttonNo.UseVisualStyleBackColor = true;
            // 
            // rbuttonSi
            // 
            this.rbuttonSi.AutoSize = true;
            this.rbuttonSi.Location = new System.Drawing.Point(89, 28);
            this.rbuttonSi.Name = "rbuttonSi";
            this.rbuttonSi.Size = new System.Drawing.Size(44, 28);
            this.rbuttonSi.TabIndex = 0;
            this.rbuttonSi.TabStop = true;
            this.rbuttonSi.Text = "Si";
            this.rbuttonSi.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(510, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(176, 49);
            this.btnCancelar.TabIndex = 58;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTotalCliente
            // 
            this.lblTotalCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCliente.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotalCliente.Location = new System.Drawing.Point(661, 245);
            this.lblTotalCliente.Name = "lblTotalCliente";
            this.lblTotalCliente.Size = new System.Drawing.Size(114, 29);
            this.lblTotalCliente.TabIndex = 54;
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDireccionCliente.Location = new System.Drawing.Point(163, 245);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(299, 29);
            this.lblDireccionCliente.TabIndex = 52;
            // 
            // lblTelCliente
            // 
            this.lblTelCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelCliente.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTelCliente.Location = new System.Drawing.Point(163, 206);
            this.lblTelCliente.Name = "lblTelCliente";
            this.lblTelCliente.Size = new System.Drawing.Size(299, 29);
            this.lblTelCliente.TabIndex = 51;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalCompra.Location = new System.Drawing.Point(594, 246);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(61, 24);
            this.lblTotalCompra.TabIndex = 48;
            this.lblTotalCompra.Text = "Total :";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProducto.Location = new System.Drawing.Point(15, 42);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(86, 24);
            this.lblProducto.TabIndex = 42;
            this.lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidad.Location = new System.Drawing.Point(15, 89);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(84, 24);
            this.lblCantidad.TabIndex = 41;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTelefonoCliente.Location = new System.Drawing.Point(20, 206);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(133, 24);
            this.lblTelefonoCliente.TabIndex = 37;
            this.lblTelefonoCliente.Text = "Tel/Cel Cliente";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDireccion.Location = new System.Drawing.Point(21, 246);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(90, 24);
            this.lblDireccion.TabIndex = 36;
            this.lblDireccion.Text = "Direccion";
            // 
            // gBoxDatos
            // 
            this.gBoxDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gBoxDatos.Controls.Add(this.btnBuscarDniEmpleado);
            this.gBoxDatos.Controls.Add(this.txtDniEmpleado);
            this.gBoxDatos.Controls.Add(this.lblDniEmpleado);
            this.gBoxDatos.Controls.Add(this.lblNombreEmpleadoRespuesta);
            this.gBoxDatos.Controls.Add(this.lblNombreEmpleado);
            this.gBoxDatos.Controls.Add(this.lblNombreClienteRespuesta);
            this.gBoxDatos.Controls.Add(this.lblApellidoClienteRespuesta);
            this.gBoxDatos.Controls.Add(this.btnBuscarDniCliente);
            this.gBoxDatos.Controls.Add(this.txtDniCliente);
            this.gBoxDatos.Controls.Add(this.lblDniCliente);
            this.gBoxDatos.Controls.Add(this.lblApellidoCliente);
            this.gBoxDatos.Controls.Add(this.lblNombreCliente);
            this.gBoxDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gBoxDatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gBoxDatos.Location = new System.Drawing.Point(12, 10);
            this.gBoxDatos.Name = "gBoxDatos";
            this.gBoxDatos.Size = new System.Drawing.Size(928, 178);
            this.gBoxDatos.TabIndex = 48;
            this.gBoxDatos.TabStop = false;
            // 
            // btnBuscarDniEmpleado
            // 
            this.btnBuscarDniEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscarDniEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarDniEmpleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarDniEmpleado.Location = new System.Drawing.Point(745, 46);
            this.btnBuscarDniEmpleado.Name = "btnBuscarDniEmpleado";
            this.btnBuscarDniEmpleado.Size = new System.Drawing.Size(89, 24);
            this.btnBuscarDniEmpleado.TabIndex = 62;
            this.btnBuscarDniEmpleado.Text = "buscar";
            this.btnBuscarDniEmpleado.UseVisualStyleBackColor = false;
            this.btnBuscarDniEmpleado.Click += new System.EventHandler(this.btnBuscarDniEmpleado_Click);
            // 
            // txtDniEmpleado
            // 
            this.txtDniEmpleado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDniEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniEmpleado.Location = new System.Drawing.Point(559, 43);
            this.txtDniEmpleado.Name = "txtDniEmpleado";
            this.txtDniEmpleado.Size = new System.Drawing.Size(180, 29);
            this.txtDniEmpleado.TabIndex = 61;
            // 
            // lblDniEmpleado
            // 
            this.lblDniEmpleado.AutoSize = true;
            this.lblDniEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniEmpleado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDniEmpleado.Location = new System.Drawing.Point(602, 16);
            this.lblDniEmpleado.Name = "lblDniEmpleado";
            this.lblDniEmpleado.Size = new System.Drawing.Size(198, 24);
            this.lblDniEmpleado.TabIndex = 60;
            this.lblDniEmpleado.Text = "Numero de Empleado";
            // 
            // lblNombreEmpleadoRespuesta
            // 
            this.lblNombreEmpleadoRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreEmpleadoRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleadoRespuesta.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombreEmpleadoRespuesta.Location = new System.Drawing.Point(559, 121);
            this.lblNombreEmpleadoRespuesta.Name = "lblNombreEmpleadoRespuesta";
            this.lblNombreEmpleadoRespuesta.Size = new System.Drawing.Size(279, 29);
            this.lblNombreEmpleadoRespuesta.TabIndex = 59;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(616, 91);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(171, 24);
            this.lblNombreEmpleado.TabIndex = 56;
            this.lblNombreEmpleado.Text = "Nombre Empleado";
            // 
            // lblNombreClienteRespuesta
            // 
            this.lblNombreClienteRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreClienteRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreClienteRespuesta.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombreClienteRespuesta.Location = new System.Drawing.Point(163, 80);
            this.lblNombreClienteRespuesta.Name = "lblNombreClienteRespuesta";
            this.lblNombreClienteRespuesta.Size = new System.Drawing.Size(299, 29);
            this.lblNombreClienteRespuesta.TabIndex = 55;
            // 
            // lblApellidoClienteRespuesta
            // 
            this.lblApellidoClienteRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApellidoClienteRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoClienteRespuesta.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblApellidoClienteRespuesta.Location = new System.Drawing.Point(163, 121);
            this.lblApellidoClienteRespuesta.Name = "lblApellidoClienteRespuesta";
            this.lblApellidoClienteRespuesta.Size = new System.Drawing.Size(299, 29);
            this.lblApellidoClienteRespuesta.TabIndex = 52;
            // 
            // btnBuscarDniCliente
            // 
            this.btnBuscarDniCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscarDniCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarDniCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarDniCliente.Location = new System.Drawing.Point(349, 37);
            this.btnBuscarDniCliente.Name = "btnBuscarDniCliente";
            this.btnBuscarDniCliente.Size = new System.Drawing.Size(89, 24);
            this.btnBuscarDniCliente.TabIndex = 54;
            this.btnBuscarDniCliente.Text = "buscar";
            this.btnBuscarDniCliente.UseVisualStyleBackColor = false;
            this.btnBuscarDniCliente.Click += new System.EventHandler(this.btnBuscarDniCliente_Click_1);
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniCliente.Location = new System.Drawing.Point(163, 34);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(180, 29);
            this.txtDniCliente.TabIndex = 37;
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDniCliente.Location = new System.Drawing.Point(16, 39);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(101, 24);
            this.lblDniCliente.TabIndex = 36;
            this.lblDniCliente.Text = "Dni Cliente";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApellidoCliente.Location = new System.Drawing.Point(15, 122);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(142, 24);
            this.lblApellidoCliente.TabIndex = 6;
            this.lblApellidoCliente.Text = "Apellido Cliente";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombreCliente.Location = new System.Drawing.Point(15, 81);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(142, 24);
            this.lblNombreCliente.TabIndex = 0;
            this.lblNombreCliente.Text = "Nombre Cliente";
            // 
            // frmCargarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(952, 583);
            this.Controls.Add(this.gBoxMenu);
            this.Controls.Add(this.gBoxDatos);
            this.Name = "frmCargarVenta";
            this.Text = "CARGAR_VENTA";
            this.Load += new System.EventHandler(this.CARGAR_VENTA_Load);
            this.gBoxMenu.ResumeLayout(false);
            this.gBoxMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBoxTipoRetiro.ResumeLayout(false);
            this.gBoxTipoRetiro.PerformLayout();
            this.gBoxDatos.ResumeLayout(false);
            this.gBoxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxMenu;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTotalCliente;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.Label lblTelCliente;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.GroupBox gBoxDatos;
        private System.Windows.Forms.Label lblNombreClienteRespuesta;
        private System.Windows.Forms.Label lblApellidoClienteRespuesta;
        private System.Windows.Forms.Button btnBuscarDniCliente;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.GroupBox gBoxTipoRetiro;
        private System.Windows.Forms.Label lblNombreEmpleadoRespuesta;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.Button btnBuscarDniEmpleado;
        private System.Windows.Forms.TextBox txtDniEmpleado;
        private System.Windows.Forms.Label lblDniEmpleado;
        private System.Windows.Forms.Button btnFinalizarVenta;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.RadioButton rbuttonNo;
        private System.Windows.Forms.RadioButton rbuttonSi;
        private System.Windows.Forms.Button btnCargarProductos;
        private readonly EventHandler btnBuscarDniCliente_Click;
    }
}