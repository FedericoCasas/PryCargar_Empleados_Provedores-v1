using System;
using System.Windows.Forms;

namespace PryPerezFederico
{
    public partial class frmBuscarCompra : Form
    {
        public frmBuscarCompra()
        {
            InitializeComponent();
        }

        private void BUSCAR_COMPRAS_Load(object sender, EventArgs e)
        {
            VnombreBC = frmCargarCliente.VnombreC;
            VapellidoBC = frmCargarCliente.VapellidoC;
            VedadBC = frmCargarCliente.VedadC;
            VdniBC = frmCargarCliente.VdniC;
            VsexoBC = frmCargarCliente.VsexoC;
            VdireccionBC = frmCargarCliente.VdireccionC;
            VtelefonoBC = frmCargarCliente.VtelefonoC;
            VcodpostalBC = frmCargarCliente.VcodpostalC;
            VnumeroClienteBC = frmCargarCliente.VnumeroClienteC;
            VcomprasLogradasBC = frmCargarVenta.VIndiceCargaCompra;
        }
        String[] VnombreBC = new string[3];
        String[] VapellidoBC = new string[3];
        Int32[] VedadBC = new int[3];
        String[] VdniBC = new String[3];
        String[] VsexoBC = new string[3];
        String[] VdireccionBC = new string[3];
        string[] VtelefonoBC = new string[3];
        Int32[] VcodpostalBC = new Int32[3];
        Int32[] VnumeroClienteBC = new Int32[3];
        Double[] VcomprasLogradasBC = new Double[3];
        private void btnBuscarDniEmpleadobc_Click(object sender, EventArgs e)
        {
            var o = false;
            for (int i = 0; i < VnumeroClienteBC.Length; i++)
            {
                if (Convert.ToString(VnumeroClienteBC[i]) == txtDniClientebc.Text)
                {
                    if (VcomprasLogradasBC[i] > 0)
                    {
                        //si encuentra el Numero de cliente, se cargan todos los datos en los .Text
                        lblNombreClienteResbc.Text = VnombreBC[i];
                        lblApellidoClienteRespuestabc.Text = VapellidoBC[i];
                        lblEdadClientebc.Text = Convert.ToString(VedadBC[i]);
                        lblDniRespuestabc.Text = VdniBC[i];
                        lblSexobc.Text = VsexoBC[i];
                        lblDireccionbv.Text = VdireccionBC[i];
                        lblTelefonobv.Text = VtelefonoBC[i];
                        lblCodPostalbc.Text = Convert.ToString(VcodpostalBC[i]);
                        lblTotalbc.Text = "$" + VcomprasLogradasBC[i];
                    }
                    else
                    {
                        //si encuentra el Numero de cliente, se cargan todos los datos en los .Text
                        lblNombreClienteResbc.Text = VnombreBC[i];
                        lblApellidoClienteRespuestabc.Text = VapellidoBC[i];
                        lblEdadClientebc.Text = Convert.ToString(VedadBC[i]);
                        lblDniRespuestabc.Text = VdniBC[i];
                        lblSexobc.Text = VsexoBC[i];
                        lblDireccionbv.Text = VdireccionBC[i];
                        lblTelefonobv.Text = VtelefonoBC[i];
                        lblCodPostalbc.Text = Convert.ToString(VcodpostalBC[i]);
                        lblTotalbc.Text = "$ 0,0";
                    }
                    o = true; break;
                }
            }
            if (o == false)
            {
                //mostrar mesaje de que no existe el cliente
                MessageBox.Show("El Numero de el Cliente no existe en la base de datos, porfavor llame a un supervisor", "El DNI de el Cliente no existe ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDniClientebc.Text = "";
            }
        }

        private void btnCancelarbc_Click(object sender, EventArgs e)
        {
            //volvemos al menu principal
            frmMenuPrincipal frmMenuPrincipal13BC = new frmMenuPrincipal();
            frmMenuPrincipal13BC.Show();
            Close();
        }
    }
}
