namespace PryPerezFederico
{
    partial class frmBuscarEmpleado
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
            this.txtDniBuscarE = new System.Windows.Forms.TextBox();
            this.btnBuscarDni = new System.Windows.Forms.Button();
            this.lblDniInfo = new System.Windows.Forms.Label();
            this.gBoxDatos = new System.Windows.Forms.GroupBox();
            this.lblNumeroEmpleadobe = new System.Windows.Forms.Label();
            this.lblCodPostalbe = new System.Windows.Forms.Label();
            this.lblTelefonobe = new System.Windows.Forms.Label();
            this.lblDireccionbe = new System.Windows.Forms.Label();
            this.lblSexobe = new System.Windows.Forms.Label();
            this.lblEdadbe = new System.Windows.Forms.Label();
            this.lblApellidobe = new System.Windows.Forms.Label();
            this.lblNombrebe = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblNuEmpleado = new System.Windows.Forms.Label();
            this.lblCoPostalbe = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lbLSexo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gBoxMenu.SuspendLayout();
            this.gBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxMenu
            // 
            this.gBoxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gBoxMenu.Controls.Add(this.txtDniBuscarE);
            this.gBoxMenu.Controls.Add(this.btnBuscarDni);
            this.gBoxMenu.Controls.Add(this.lblDniInfo);
            this.gBoxMenu.Location = new System.Drawing.Point(12, 9);
            this.gBoxMenu.Name = "gBoxMenu";
            this.gBoxMenu.Size = new System.Drawing.Size(928, 139);
            this.gBoxMenu.TabIndex = 37;
            this.gBoxMenu.TabStop = false;
            // 
            // txtDniBuscarE
            // 
            this.txtDniBuscarE.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDniBuscarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniBuscarE.Location = new System.Drawing.Point(236, 36);
            this.txtDniBuscarE.Name = "txtDniBuscarE";
            this.txtDniBuscarE.Size = new System.Drawing.Size(450, 35);
            this.txtDniBuscarE.TabIndex = 35;
            // 
            // btnBuscarDni
            // 
            this.btnBuscarDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscarDni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarDni.Location = new System.Drawing.Point(358, 77);
            this.btnBuscarDni.Name = "btnBuscarDni";
            this.btnBuscarDni.Size = new System.Drawing.Size(217, 33);
            this.btnBuscarDni.TabIndex = 33;
            this.btnBuscarDni.Text = "Buscar";
            this.btnBuscarDni.UseVisualStyleBackColor = false;
            this.btnBuscarDni.Click += new System.EventHandler(this.btnBuscarDni_Click);
            // 
            // lblDniInfo
            // 
            this.lblDniInfo.AutoSize = true;
            this.lblDniInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDniInfo.Location = new System.Drawing.Point(376, 7);
            this.lblDniInfo.Name = "lblDniInfo";
            this.lblDniInfo.Size = new System.Drawing.Size(206, 29);
            this.lblDniInfo.TabIndex = 30;
            this.lblDniInfo.Text = "Dni del Empleado";
            // 
            // gBoxDatos
            // 
            this.gBoxDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gBoxDatos.Controls.Add(this.lblNumeroEmpleadobe);
            this.gBoxDatos.Controls.Add(this.lblCodPostalbe);
            this.gBoxDatos.Controls.Add(this.lblTelefonobe);
            this.gBoxDatos.Controls.Add(this.lblDireccionbe);
            this.gBoxDatos.Controls.Add(this.lblSexobe);
            this.gBoxDatos.Controls.Add(this.lblEdadbe);
            this.gBoxDatos.Controls.Add(this.lblApellidobe);
            this.gBoxDatos.Controls.Add(this.lblNombrebe);
            this.gBoxDatos.Controls.Add(this.btnVolver);
            this.gBoxDatos.Controls.Add(this.lblNuEmpleado);
            this.gBoxDatos.Controls.Add(this.lblCoPostalbe);
            this.gBoxDatos.Controls.Add(this.lblTelefono);
            this.gBoxDatos.Controls.Add(this.lblApellido);
            this.gBoxDatos.Controls.Add(this.lblEdad);
            this.gBoxDatos.Controls.Add(this.lbLSexo);
            this.gBoxDatos.Controls.Add(this.lblDireccion);
            this.gBoxDatos.Controls.Add(this.lblNombre);
            this.gBoxDatos.Location = new System.Drawing.Point(12, 154);
            this.gBoxDatos.Name = "gBoxDatos";
            this.gBoxDatos.Size = new System.Drawing.Size(928, 420);
            this.gBoxDatos.TabIndex = 36;
            this.gBoxDatos.TabStop = false;
            // 
            // lblNumeroEmpleadobe
            // 
            this.lblNumeroEmpleadobe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumeroEmpleadobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroEmpleadobe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumeroEmpleadobe.Location = new System.Drawing.Point(401, 325);
            this.lblNumeroEmpleadobe.Name = "lblNumeroEmpleadobe";
            this.lblNumeroEmpleadobe.Size = new System.Drawing.Size(281, 23);
            this.lblNumeroEmpleadobe.TabIndex = 43;
            // 
            // lblCodPostalbe
            // 
            this.lblCodPostalbe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodPostalbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPostalbe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodPostalbe.Location = new System.Drawing.Point(358, 267);
            this.lblCodPostalbe.Name = "lblCodPostalbe";
            this.lblCodPostalbe.Size = new System.Drawing.Size(281, 23);
            this.lblCodPostalbe.TabIndex = 42;
            // 
            // lblTelefonobe
            // 
            this.lblTelefonobe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTelefonobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonobe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTelefonobe.Location = new System.Drawing.Point(358, 228);
            this.lblTelefonobe.Name = "lblTelefonobe";
            this.lblTelefonobe.Size = new System.Drawing.Size(281, 23);
            this.lblTelefonobe.TabIndex = 41;
            // 
            // lblDireccionbe
            // 
            this.lblDireccionbe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDireccionbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionbe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDireccionbe.Location = new System.Drawing.Point(358, 187);
            this.lblDireccionbe.Name = "lblDireccionbe";
            this.lblDireccionbe.Size = new System.Drawing.Size(281, 23);
            this.lblDireccionbe.TabIndex = 40;
            // 
            // lblSexobe
            // 
            this.lblSexobe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSexobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexobe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSexobe.Location = new System.Drawing.Point(358, 148);
            this.lblSexobe.Name = "lblSexobe";
            this.lblSexobe.Size = new System.Drawing.Size(281, 23);
            this.lblSexobe.TabIndex = 39;
            // 
            // lblEdadbe
            // 
            this.lblEdadbe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEdadbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadbe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEdadbe.Location = new System.Drawing.Point(358, 105);
            this.lblEdadbe.Name = "lblEdadbe";
            this.lblEdadbe.Size = new System.Drawing.Size(281, 23);
            this.lblEdadbe.TabIndex = 38;
            // 
            // lblApellidobe
            // 
            this.lblApellidobe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApellidobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidobe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApellidobe.Location = new System.Drawing.Point(358, 67);
            this.lblApellidobe.Name = "lblApellidobe";
            this.lblApellidobe.Size = new System.Drawing.Size(281, 23);
            this.lblApellidobe.TabIndex = 37;
            // 
            // lblNombrebe
            // 
            this.lblNombrebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombrebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrebe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombrebe.Location = new System.Drawing.Point(358, 22);
            this.lblNombrebe.Name = "lblNombrebe";
            this.lblNombrebe.Size = new System.Drawing.Size(281, 23);
            this.lblNombrebe.TabIndex = 36;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkGray;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolver.Location = new System.Drawing.Point(373, 368);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(202, 36);
            this.btnVolver.TabIndex = 34;
            this.btnVolver.Text = "Cancelar";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblNuEmpleado
            // 
            this.lblNuEmpleado.AutoSize = true;
            this.lblNuEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuEmpleado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNuEmpleado.Location = new System.Drawing.Point(228, 325);
            this.lblNuEmpleado.Name = "lblNuEmpleado";
            this.lblNuEmpleado.Size = new System.Drawing.Size(167, 25);
            this.lblNuEmpleado.TabIndex = 24;
            this.lblNuEmpleado.Text = "N° de Empleado";
            // 
            // lblCoPostalbe
            // 
            this.lblCoPostalbe.AutoSize = true;
            this.lblCoPostalbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoPostalbe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCoPostalbe.Location = new System.Drawing.Point(232, 268);
            this.lblCoPostalbe.Name = "lblCoPostalbe";
            this.lblCoPostalbe.Size = new System.Drawing.Size(105, 24);
            this.lblCoPostalbe.TabIndex = 16;
            this.lblCoPostalbe.Text = "Cod. Postal";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTelefono.Location = new System.Drawing.Point(232, 227);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(85, 24);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellido.Location = new System.Drawing.Point(232, 66);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(79, 24);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEdad.Location = new System.Drawing.Point(232, 104);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(55, 24);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // lbLSexo
            // 
            this.lbLSexo.AutoSize = true;
            this.lbLSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLSexo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbLSexo.Location = new System.Drawing.Point(232, 147);
            this.lbLSexo.Name = "lbLSexo";
            this.lbLSexo.Size = new System.Drawing.Size(54, 24);
            this.lbLSexo.TabIndex = 2;
            this.lbLSexo.Text = "Sexo";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDireccion.Location = new System.Drawing.Point(232, 188);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(90, 24);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Location = new System.Drawing.Point(232, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // frmBuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(952, 583);
            this.Controls.Add(this.gBoxMenu);
            this.Controls.Add(this.gBoxDatos);
            this.Name = "frmBuscarEmpleado";
            this.Text = "BUSCAR_EMPLEADO";
            this.Load += new System.EventHandler(this.BUSCAR_EMPLEADO_Load);
            this.gBoxMenu.ResumeLayout(false);
            this.gBoxMenu.PerformLayout();
            this.gBoxDatos.ResumeLayout(false);
            this.gBoxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxMenu;
        private System.Windows.Forms.TextBox txtDniBuscarE;
        private System.Windows.Forms.Button btnBuscarDni;
        private System.Windows.Forms.Label lblDniInfo;
        private System.Windows.Forms.GroupBox gBoxDatos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNuEmpleado;
        private System.Windows.Forms.Label lblCoPostalbe;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lbLSexo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumeroEmpleadobe;
        private System.Windows.Forms.Label lblCodPostalbe;
        private System.Windows.Forms.Label lblTelefonobe;
        private System.Windows.Forms.Label lblDireccionbe;
        private System.Windows.Forms.Label lblSexobe;
        private System.Windows.Forms.Label lblEdadbe;
        private System.Windows.Forms.Label lblApellidobe;
        private System.Windows.Forms.Label lblNombrebe;
    }
}