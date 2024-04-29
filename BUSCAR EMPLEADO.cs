using System;
using System.Windows.Forms;

namespace PryPerezFederico
{
    public partial class frmBuscarEmpleado : Form
    {
        public frmBuscarEmpleado()
        {
            InitializeComponent();
        }
        //Creamos un vector
        String[] VnombreBE = new string[3];
        String[] VapellidoBE = new string[3];
        Int32[] VedadBE = new int[3];
        String[] VdniBE = new String[3];
        String[] VsexoBE = new string[3];
        String[] VdireccionBE = new string[3];
        string[] VtelefonoBE = new string[3];
        Int32[] VcodpostalBE = new Int32[3];
        Int32[] VnumeroEmpleadoBE = new Int32[3];
        private void BUSCAR_EMPLEADO_Load(object sender, EventArgs e)
        {
            //Cargamos datos en el vector cuando abre el fromulario
            VnombreBE = frmCargarEmpleado.VnombreE;
            VapellidoBE = frmCargarEmpleado.VapellidoE;
            VedadBE = frmCargarEmpleado.VedadE;
            VdniBE = frmCargarEmpleado.VdniE;
            VsexoBE = frmCargarEmpleado.VsexoE;
            VdireccionBE = frmCargarEmpleado.VdireccionE;
            VtelefonoBE = frmCargarEmpleado.VtelefonoE;
            VcodpostalBE = frmCargarEmpleado.VcodpostalE;
            VnumeroEmpleadoBE = frmCargarEmpleado.VnumeroEmpleadoE;
        }
        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            var o = false;
            for (int i = 0; i < VdniBE.Length; i++)
            {
                if (VdniBE[i] == txtDniBuscarE.Text)
                {
                    //si encuentra el dni, se cargan todos los datos en los .Text
                    lblNombrebe.Text = VnombreBE[i];
                    lblApellidobe.Text = VapellidoBE[i];
                    lblCodPostalbe.Text = Convert.ToString(VcodpostalBE[i]);
                    lblEdadbe.Text = Convert.ToString(VedadBE[i]);
                    lblSexobe.Text = Convert.ToString(VsexoBE[i]);
                    lblDireccionbe.Text = VdireccionBE[i];
                    lblTelefonobe.Text = VtelefonoBE[i];
                    lblNumeroEmpleadobe.Text = Convert.ToString(VnumeroEmpleadoBE[i]);
                    o = true; break;
                }
            }
            if (o == false)
            {
                //mostrar mesaje de que no existe el Empleado
                DialogResult r = MessageBox.Show("El DNI de el empleado no existe en la base de datos, desea cargarlo?", "El DNI de el empleado no existe ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (r == DialogResult.Yes)
                {
                    //cerrar el formulario y abrir el frmCargarEmpleado
                    frmCargarEmpleado cargarEmp = new frmCargarEmpleado();
                    cargarEmp.Show();
                    Close();
                }
                else
                {
                    //borrar el texto escrito incorrectamente y datos anteriores tambien
                    txtDniBuscarE.Text = "";
                    lblNombrebe.Text = "";
                    lblApellidobe.Text = "";
                    lblCodPostalbe.Text = "";
                    lblEdadbe.Text = "";
                    lblSexobe.Text = "";
                    lblDireccionbe.Text = "";
                    lblTelefonobe.Text = "";
                    lblNumeroEmpleadobe.Text = "";
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //volvemos al menu principal
            frmMenuPrincipal frmMenuPrincipal10BE = new frmMenuPrincipal();
            frmMenuPrincipal10BE.Show();
            Close();
        }
    }
}
