using System;
using System.Windows.Forms;

namespace PryPerezFederico
{
    public partial class frmMostrarEmpleados : Form
    {
        public frmMostrarEmpleados()
        {
            InitializeComponent();
        }
        //Creamos un vector
        String[] VnombreME = new string[3];
        String[] VapellidoME = new string[3];
        Int32[] VedadME = new int[3];
        String[] VdniME = new String[3];
        String[] VsexoME = new string[3];
        String[] VdireccionME = new string[3];
        string[] VtelefonoME = new string[3];
        Int32[] VcodpostalME = new Int32[3];
        Int32[] VnumeroEmpleadoME = new Int32[3];
        private void MOSTRAR_EMPLEADOS_Load(object sender, EventArgs e)
        {
            //Cargamos datos en el vector cuando abre el fromulario
            VnombreME = frmCargarEmpleado.VnombreE;
            VapellidoME = frmCargarEmpleado.VapellidoE;
            VedadME = frmCargarEmpleado.VedadE;
            VdniME = frmCargarEmpleado.VdniE;
            VsexoME = frmCargarEmpleado.VsexoE;
            VdireccionME = frmCargarEmpleado.VdireccionE;
            VtelefonoME = frmCargarEmpleado.VtelefonoE;
            VcodpostalME = frmCargarEmpleado.VcodpostalE;
            VnumeroEmpleadoME = frmCargarEmpleado.VnumeroEmpleadoE;
        }

        private void btnCargarEmpleado_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < VnombreME.Length; i++)
            {
                if (VnumeroEmpleadoME[i] > 0)
                {

                    grilla.Rows.Add(VnombreME[i], VapellidoME[i], VedadME[i], VdniME[i], VsexoME[i], VdireccionME[i], VtelefonoME[i], VcodpostalME[i], VnumeroEmpleadoME[i]);

                }
                else
                {
                    string r = "";
                    grilla.Rows.Add(VnombreME[i], VapellidoME[i], VedadME[i], VdniME[i], VsexoME[i], VdireccionME[i], VtelefonoME[i], VcodpostalME[i], r);

                }

            }
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            frmCargarEmpleado cargarEmpME = new frmCargarEmpleado();
            cargarEmpME.Show();
            Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal8ME = new frmMenuPrincipal();
            frmMenuPrincipal8ME.Show();
            Close();
        }
    }
}
