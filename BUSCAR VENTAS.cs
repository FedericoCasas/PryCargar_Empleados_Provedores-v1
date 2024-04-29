using System;
using System.Windows.Forms;

namespace PryPerezFederico
{
    public partial class frmBuscarVenta : Form
    {
        public frmBuscarVenta()
        {
            InitializeComponent();
        }
        private void BUSCAR_VENTAS_Load(object sender, EventArgs e)
        {
            VnombreBV = frmCargarEmpleado.VnombreE;
            VapellidoBV = frmCargarEmpleado.VapellidoE;
            VedadBV = frmCargarEmpleado.VedadE;
            VdniBV = frmCargarEmpleado.VdniE;
            VsexoBV = frmCargarEmpleado.VsexoE;
            VdireccionBV = frmCargarEmpleado.VdireccionE;
            VtelefonoBV = frmCargarEmpleado.VtelefonoE;
            VcodpostalBV = frmCargarEmpleado.VcodpostalE;
            VnumeroEmpleadoBV = frmCargarEmpleado.VnumeroEmpleadoE;
            VventasLogradasBV = frmCargarVenta.VIndiceCargaVenta;
        }
        String[] VnombreBV = new string[3];
        String[] VapellidoBV = new string[3];
        Int32[] VedadBV = new int[3];
        String[] VdniBV = new String[3];
        String[] VsexoBV = new string[3];
        String[] VdireccionBV = new string[3];
        string[] VtelefonoBV = new string[3];
        Int32[] VcodpostalBV = new Int32[3];
        Int32[] VnumeroEmpleadoBV = new Int32[3];
        Double[] VventasLogradasBV = new Double[3];
        private void btnBuscarDniEmpleadobv_Click(object sender, EventArgs e)
        {
            var verificacion = false;
            for (int i = 0; i < VnumeroEmpleadoBV.Length; i++)
            {
                if (Convert.ToString(VnumeroEmpleadoBV[i]) == txtDniEmpleadobv.Text)
                {
                    if (VventasLogradasBV[i] > 0)
                    {
                        //si encuentra el Numero de empleado, se cargan todos los datos en los .Text
                        lblNombreEmpleadoRespuestabv.Text = VnombreBV[i];
                        lblNombreClienteRespuesta.Text = VapellidoBV[i];
                        lblEdadEmpleadobv.Text = Convert.ToString(VedadBV[i]);
                        lblDniRespuestabv.Text = VdniBV[i];
                        lblSexoRbv.Text = VsexoBV[i];
                        lblDireccionbv.Text = VdireccionBV[i];
                        lblTelefnoNum.Text = VtelefonoBV[i];
                        lblCodPostalbv.Text = Convert.ToString(VcodpostalBV[i]);
                        lblTotalbv.Text = "$" + VventasLogradasBV[i];
                    }
                    else
                    {
                        //si encuentra el Numero de empleado, se cargan todos los datos en los .Text
                        lblNombreEmpleadoRespuestabv.Text = VnombreBV[i];
                        lblNombreClienteRespuesta.Text = VapellidoBV[i];
                        lblEdadEmpleadobv.Text = Convert.ToString(VedadBV[i]);
                        lblDniRespuestabv.Text = VdniBV[i];
                        lbLSexobv.Text = VsexoBV[i];
                        lblDireccionbv.Text = VdireccionBV[i];
                        lblTelefnoNum.Text = VtelefonoBV[i];
                        lblCodPostalbv.Text = Convert.ToString(VcodpostalBV[i]);
                        lblTotalbv.Text = "$ 0,0";
                    }
                    verificacion = true; break;
                }
            }
            if (verificacion == false)
            {
                //mostrar mesaje de que no existe el cliente
                MessageBox.Show("El Numero de el empleado no existe en la base de datos, porfavor llame a un supervisor", "El DNI de el empleado no existe ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDniEmpleadobv.Text = "";
            }

        }

        private void btnCancelarbv_Click(object sender, EventArgs e)
        {
            //volvemos al menu principal
            frmMenuPrincipal frmMenuPrincipal12BV = new frmMenuPrincipal();
            frmMenuPrincipal12BV.Show();
            Close();
        }

        private void txtDniEmpleadobv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
