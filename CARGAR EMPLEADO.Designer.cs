namespace PryPerezFederico
{
    partial class frmCargarEmpleado
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.gBoxDatos = new System.Windows.Forms.GroupBox();
            this.txtCoPostalE = new System.Windows.Forms.TextBox();
            this.txtTelefonoE = new System.Windows.Forms.TextBox();
            this.txtDireccionE = new System.Windows.Forms.TextBox();
            this.gBoxSexo = new System.Windows.Forms.GroupBox();
            this.rButtonFemE = new System.Windows.Forms.RadioButton();
            this.rButtonMascE = new System.Windows.Forms.RadioButton();
            this.txtDniE = new System.Windows.Forms.TextBox();
            this.txtEdadE = new System.Windows.Forms.TextBox();
            this.txtApellidoE = new System.Windows.Forms.TextBox();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gBoxMenu.SuspendLayout();
            this.gBoxDatos.SuspendLayout();
            this.gBoxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxMenu
            // 
            this.gBoxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gBoxMenu.Controls.Add(this.btnVolver);
            this.gBoxMenu.Controls.Add(this.btnCargar);
            this.gBoxMenu.Location = new System.Drawing.Point(12, 403);
            this.gBoxMenu.Name = "gBoxMenu";
            this.gBoxMenu.Size = new System.Drawing.Size(928, 160);
            this.gBoxMenu.TabIndex = 36;
            this.gBoxMenu.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolver.Location = new System.Drawing.Point(503, 51);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(176, 49);
            this.btnVolver.TabIndex = 29;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargar.Location = new System.Drawing.Point(262, 51);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(176, 49);
            this.btnCargar.TabIndex = 28;
            this.btnCargar.Text = "Guardar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // gBoxDatos
            // 
            this.gBoxDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gBoxDatos.Controls.Add(this.txtCoPostalE);
            this.gBoxDatos.Controls.Add(this.txtTelefonoE);
            this.gBoxDatos.Controls.Add(this.txtDireccionE);
            this.gBoxDatos.Controls.Add(this.gBoxSexo);
            this.gBoxDatos.Controls.Add(this.txtDniE);
            this.gBoxDatos.Controls.Add(this.txtEdadE);
            this.gBoxDatos.Controls.Add(this.txtApellidoE);
            this.gBoxDatos.Controls.Add(this.txtNombreE);
            this.gBoxDatos.Controls.Add(this.lblCodigoPostal);
            this.gBoxDatos.Controls.Add(this.lblTelefono);
            this.gBoxDatos.Controls.Add(this.lblApellido);
            this.gBoxDatos.Controls.Add(this.lblDni);
            this.gBoxDatos.Controls.Add(this.lblEdad);
            this.gBoxDatos.Controls.Add(this.lblSexo);
            this.gBoxDatos.Controls.Add(this.lblDireccion);
            this.gBoxDatos.Controls.Add(this.lblNombre);
            this.gBoxDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gBoxDatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gBoxDatos.Location = new System.Drawing.Point(12, 19);
            this.gBoxDatos.Name = "gBoxDatos";
            this.gBoxDatos.Size = new System.Drawing.Size(928, 376);
            this.gBoxDatos.TabIndex = 35;
            this.gBoxDatos.TabStop = false;
            // 
            // txtCoPostalE
            // 
            this.txtCoPostalE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCoPostalE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoPostalE.Location = new System.Drawing.Point(403, 318);
            this.txtCoPostalE.Name = "txtCoPostalE";
            this.txtCoPostalE.Size = new System.Drawing.Size(92, 29);
            this.txtCoPostalE.TabIndex = 35;
            // 
            // txtTelefonoE
            // 
            this.txtTelefonoE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTelefonoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoE.Location = new System.Drawing.Point(403, 273);
            this.txtTelefonoE.Name = "txtTelefonoE";
            this.txtTelefonoE.Size = new System.Drawing.Size(276, 29);
            this.txtTelefonoE.TabIndex = 34;
            // 
            // txtDireccionE
            // 
            this.txtDireccionE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDireccionE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionE.Location = new System.Drawing.Point(403, 229);
            this.txtDireccionE.Name = "txtDireccionE";
            this.txtDireccionE.Size = new System.Drawing.Size(276, 29);
            this.txtDireccionE.TabIndex = 33;
            // 
            // gBoxSexo
            // 
            this.gBoxSexo.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.gBoxSexo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gBoxSexo.Controls.Add(this.rButtonFemE);
            this.gBoxSexo.Controls.Add(this.rButtonMascE);
            this.gBoxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxSexo.Location = new System.Drawing.Point(403, 182);
            this.gBoxSexo.Name = "gBoxSexo";
            this.gBoxSexo.Size = new System.Drawing.Size(276, 38);
            this.gBoxSexo.TabIndex = 30;
            this.gBoxSexo.TabStop = false;
            // 
            // rButtonFemE
            // 
            this.rButtonFemE.AutoSize = true;
            this.rButtonFemE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonFemE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rButtonFemE.Location = new System.Drawing.Point(150, 7);
            this.rButtonFemE.Name = "rButtonFemE";
            this.rButtonFemE.Size = new System.Drawing.Size(98, 24);
            this.rButtonFemE.TabIndex = 25;
            this.rButtonFemE.TabStop = true;
            this.rButtonFemE.Text = "Femenino";
            this.rButtonFemE.UseVisualStyleBackColor = true;
            // 
            // rButtonMascE
            // 
            this.rButtonMascE.AutoSize = true;
            this.rButtonMascE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonMascE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rButtonMascE.Location = new System.Drawing.Point(26, 7);
            this.rButtonMascE.Name = "rButtonMascE";
            this.rButtonMascE.Size = new System.Drawing.Size(98, 24);
            this.rButtonMascE.TabIndex = 24;
            this.rButtonMascE.TabStop = true;
            this.rButtonMascE.Text = "Masculino";
            this.rButtonMascE.UseVisualStyleBackColor = true;
            // 
            // txtDniE
            // 
            this.txtDniE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDniE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniE.Location = new System.Drawing.Point(403, 137);
            this.txtDniE.Name = "txtDniE";
            this.txtDniE.Size = new System.Drawing.Size(276, 29);
            this.txtDniE.TabIndex = 29;
            // 
            // txtEdadE
            // 
            this.txtEdadE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtEdadE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadE.Location = new System.Drawing.Point(403, 96);
            this.txtEdadE.Name = "txtEdadE";
            this.txtEdadE.Size = new System.Drawing.Size(92, 29);
            this.txtEdadE.TabIndex = 28;
            // 
            // txtApellidoE
            // 
            this.txtApellidoE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtApellidoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoE.Location = new System.Drawing.Point(403, 55);
            this.txtApellidoE.Name = "txtApellidoE";
            this.txtApellidoE.Size = new System.Drawing.Size(276, 29);
            this.txtApellidoE.TabIndex = 27;
            // 
            // txtNombreE
            // 
            this.txtNombreE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNombreE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreE.Location = new System.Drawing.Point(403, 14);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(276, 29);
            this.txtNombreE.TabIndex = 26;
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPostal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigoPostal.Location = new System.Drawing.Point(269, 318);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(105, 24);
            this.lblCodigoPostal.TabIndex = 16;
            this.lblCodigoPostal.Text = "Cod. Postal";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTelefono.Location = new System.Drawing.Point(269, 276);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 24);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Tel/Cel";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApellido.Location = new System.Drawing.Point(269, 61);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(79, 24);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDni.Location = new System.Drawing.Point(269, 143);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(38, 24);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "Dni";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEdad.Location = new System.Drawing.Point(269, 99);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(55, 24);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSexo.Location = new System.Drawing.Point(269, 187);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(74, 24);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Genero";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDireccion.Location = new System.Drawing.Point(269, 235);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(90, 24);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombre.Location = new System.Drawing.Point(269, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // frmCargarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(952, 583);
            this.Controls.Add(this.gBoxMenu);
            this.Controls.Add(this.gBoxDatos);
            this.Name = "frmCargarEmpleado";
            this.Text = "CARGAR_EMPLEADO";
            this.gBoxMenu.ResumeLayout(false);
            this.gBoxDatos.ResumeLayout(false);
            this.gBoxDatos.PerformLayout();
            this.gBoxSexo.ResumeLayout(false);
            this.gBoxSexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxMenu;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox gBoxDatos;
        private System.Windows.Forms.TextBox txtCoPostalE;
        private System.Windows.Forms.TextBox txtTelefonoE;
        private System.Windows.Forms.TextBox txtDireccionE;
        private System.Windows.Forms.GroupBox gBoxSexo;
        private System.Windows.Forms.RadioButton rButtonFemE;
        private System.Windows.Forms.RadioButton rButtonMascE;
        private System.Windows.Forms.TextBox txtDniE;
        private System.Windows.Forms.TextBox txtEdadE;
        private System.Windows.Forms.TextBox txtApellidoE;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
    }
}