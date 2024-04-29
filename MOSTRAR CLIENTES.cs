using System;
using System.Windows.Forms;

namespace PryPerezFederico
{
    public partial class frmMostrarCliente : Form
    {
        public frmMostrarCliente()
        {
            InitializeComponent();
        }

        String[] VnombreCMC = new string[3];
        String[] VapellidoCMC = new string[3];
        Int32[] VedadCMC = new int[3];
        String[] VdniCMC = new String[3];
        String[] VsexoCMC = new string[3];
        String[] VdireccionCMC = new string[3];
        string[] VtelefonoCMC = new string[3];
        Int32[] VcodpostalCMC = new Int32[3];
        Int32[] VnumeroClienteCMC = new Int32[3];

        private void frmMostrarCliente_Load(object sender, EventArgs e)
        {

            VnombreCMC = frmCargarCliente.VnombreC;
            VapellidoCMC = frmCargarCliente.VapellidoC;
            VedadCMC = frmCargarCliente.VedadC;
            VdniCMC = frmCargarCliente.VdniC;
            VsexoCMC = frmCargarCliente.VsexoC;
            VdireccionCMC = frmCargarCliente.VdireccionC;
            VtelefonoCMC = frmCargarCliente.VtelefonoC;
            VcodpostalCMC = frmCargarCliente.VcodpostalC;
            VnumeroClienteCMC = frmCargarCliente.VnumeroClienteC;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < VnombreCMC.Length; i++)
            {
                if (VnumeroClienteCMC[i] > 0)
                {

                    grilla.Rows.Add(VnombreCMC[i], VapellidoCMC[i], VedadCMC[i], VdniCMC[i], VsexoCMC[i], VdireccionCMC[i], VtelefonoCMC[i], VcodpostalCMC[i], VnumeroClienteCMC[i]);

                }
                else
                {
                    string r = "";
                    grilla.Rows.Add(VnombreCMC[i], VapellidoCMC[i], VedadCMC[i], VdniCMC[i], VsexoCMC[i], VdireccionCMC[i], VtelefonoCMC[i], VcodpostalCMC[i], r);

                }

            }

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            frmCargarCliente cargarCliMC = new frmCargarCliente();
            cargarCliMC.Show();
            Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal7MC = new frmMenuPrincipal();
            frmMenuPrincipal7MC.Show();
            Close();
        }

        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
