using System;
using System.Windows.Forms;

namespace PryPerezFederico
{
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
        }
        //Creamos un vector
        String[] VnombreBC = new string[3];
        String[] VapellidoBC = new string[3];
        Int32[] VedadBC = new int[3];
        String[] VdniBC = new String[3];
        String[] VsexoBC = new string[3];
        String[] VdireccionBC = new string[3];
        string[] VtelefonoBC = new string[3];
        Int32[] VcodpostalBC = new Int32[3];
        Int32[] VnumeroClienteBC = new Int32[3];

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            //Cargamos datos en el vector cuando abre el fromulario
            VnombreBC = frmCargarCliente.VnombreC;
            VapellidoBC = frmCargarCliente.VapellidoC;
            VedadBC = frmCargarCliente.VedadC;
            VdniBC = frmCargarCliente.VdniC;
            VsexoBC = frmCargarCliente.VsexoC;
            VdireccionBC = frmCargarCliente.VdireccionC;
            VtelefonoBC = frmCargarCliente.VtelefonoC;
            VcodpostalBC = frmCargarCliente.VcodpostalC;
            VnumeroClienteBC = frmCargarCliente.VnumeroClienteC;
        }
        //buscar por dni
        private void button2_Click(object sender, EventArgs e)
        {
            var verificacion = false;
            for (int i = 0; i < VdniBC.Length; i++)
            {
                if (VdniBC[i] == txtDniBuscarC.Text)
                {
                    //si encuentra el dni, se cargan todos los datos en los .Text
                    txtNombreC.Text = VnombreBC[i];
                    txtApellidoC.Text = VapellidoBC[i];
                    txtCPostalC.Text = Convert.ToString(VcodpostalBC[i]);
                    txtEdadC.Text = Convert.ToString(VedadBC[i]);
                    txtSexoC.Text = Convert.ToString(VsexoBC[i]);
                    txtDireccionC.Text = VdireccionBC[i];
                    txtTelefonoC.Text = VtelefonoBC[i];
                    txtNumerClienteC.Text = Convert.ToString(VnumeroClienteBC[i]);
                    verificacion = true; break;
                }
            }
            if (verificacion == false)
            {
                //mostrar mesaje de que no existe el cliente
                DialogResult r = MessageBox.Show("El DNI de el cliente no existe en la base de datos, desea cargarlo?", "El DNI de el cliente no existe ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (r == DialogResult.Yes)
                {
                    //cerrar el formulario y abrir el frmCargarCliente
                    frmCargarCliente cargarCli = new frmCargarCliente();
                    cargarCli.Show();
                    Close();
                }
                else
                {
                    //borrar el texto escrito incorrectamente y datos anteriores tambien
                    txtDniBuscarC.Text = "";
                    txtNombreC.Text = "";
                    txtApellidoC.Text = "";
                    txtCPostalC.Text = "";
                    txtEdadC.Text = "";
                    txtSexoC.Text = "";
                    txtDireccionC.Text = "";
                    txtTelefonoC.Text = "";
                    txtNumerClienteC.Text = "";
                }
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //volvemos al menu principal
            frmMenuPrincipal frmMenuPrincipal9BC = new frmMenuPrincipal();
            frmMenuPrincipal9BC.Show();
            Close();
        }


    }
}
