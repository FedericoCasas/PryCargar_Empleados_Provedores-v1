namespace PryPerezFederico
{
    partial class frmMostrarTotales
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
            this.gBoxTodo = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCompras = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblT1 = new System.Windows.Forms.Label();
            this.btnMostrarTo = new System.Windows.Forms.Button();
            this.lblT0 = new System.Windows.Forms.Label();
            this.gBoxTodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxTodo
            // 
            this.gBoxTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gBoxTodo.Controls.Add(this.btnCancel);
            this.gBoxTodo.Controls.Add(this.lblCompras);
            this.gBoxTodo.Controls.Add(this.lblVentas);
            this.gBoxTodo.Controls.Add(this.lblT2);
            this.gBoxTodo.Controls.Add(this.lblT1);
            this.gBoxTodo.Controls.Add(this.btnMostrarTo);
            this.gBoxTodo.Controls.Add(this.lblT0);
            this.gBoxTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gBoxTodo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gBoxTodo.Location = new System.Drawing.Point(12, 12);
            this.gBoxTodo.Name = "gBoxTodo";
            this.gBoxTodo.Size = new System.Drawing.Size(928, 559);
            this.gBoxTodo.TabIndex = 50;
            this.gBoxTodo.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(374, 478);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(166, 36);
            this.btnCancel.TabIndex = 67;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCompras
            // 
            this.lblCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCompras.Location = new System.Drawing.Point(600, 223);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(196, 24);
            this.lblCompras.TabIndex = 66;
            // 
            // lblVentas
            // 
            this.lblVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVentas.Location = new System.Drawing.Point(95, 223);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(196, 24);
            this.lblVentas.TabIndex = 65;
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblT2.Location = new System.Drawing.Point(618, 156);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(152, 24);
            this.lblT2.TabIndex = 64;
            this.lblT2.Text = "Compras Totales";
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblT1.Location = new System.Drawing.Point(124, 156);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(134, 24);
            this.lblT1.TabIndex = 63;
            this.lblT1.Text = "Ventas Totales";
            // 
            // btnMostrarTo
            // 
            this.btnMostrarTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMostrarTo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarTo.Location = new System.Drawing.Point(386, 62);
            this.btnMostrarTo.Name = "btnMostrarTo";
            this.btnMostrarTo.Size = new System.Drawing.Size(128, 36);
            this.btnMostrarTo.TabIndex = 62;
            this.btnMostrarTo.Text = "Mostrar";
            this.btnMostrarTo.UseVisualStyleBackColor = false;
            this.btnMostrarTo.Click += new System.EventHandler(this.btnMostrarTo_Click);
            // 
            // lblT0
            // 
            this.lblT0.AutoSize = true;
            this.lblT0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblT0.Location = new System.Drawing.Point(341, 24);
            this.lblT0.Name = "lblT0";
            this.lblT0.Size = new System.Drawing.Size(229, 24);
            this.lblT0.TabIndex = 60;
            this.lblT0.Text = "Ventas y Compras Totales";
            // 
            // frmMostrarTotales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(952, 583);
            this.Controls.Add(this.gBoxTodo);
            this.Name = "frmMostrarTotales";
            this.Text = "MOSTRAR_VENTAS_Y_COMPRAS_TOTALES";
            this.Load += new System.EventHandler(this.MOSTRAR_VENTAS_Y_COMPRAS_TOTALES_Load);
            this.gBoxTodo.ResumeLayout(false);
            this.gBoxTodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxTodo;
        private System.Windows.Forms.Button btnMostrarTo;
        private System.Windows.Forms.Label lblT0;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Button btnCancel;
    }
}