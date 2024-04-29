using System;
using System.Windows.Forms;

namespace PryPerezFederico
{
    public partial class frmCargarCliente : Form
    {
        public frmCargarCliente()
        {
            InitializeComponent();
        }
        private void CargarCliente_Load(object sender, EventArgs e)
        {
        }

        public static String[] VnombreC = new String[3];
        public static String[] VapellidoC = new String[3];
        public static Int32[] VedadC = new Int32[3];
        public static String[] VdniC = new String[3];
        public static String[] VsexoC = new String[3];
        public static String[] VdireccionC = new String[3];
        public static String[] VtelefonoC = new String[3];
        public static Int32[] VcodpostalC = new Int32[3];
        public static Int32[] VnumeroClienteC = new Int32[3];
        public static Int32 iC = 0;
        public static Int32 icli = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            if (icli <= VnombreC.Length)
            {
                if (txtNombreC.Text == "" && txtApellidoC.Text == "" && txtEdadC.Text == "" && txtDniC.Text == "" && txtDireccionC.Text == "" && txtTelefonoC.Text == "" && txtCoPostalC.Text == "")
                {
                    MessageBox.Show("Usted no completo ningun dato, imposible continuar");
                }
                else if (txtNombreC.Text == "" || txtApellidoC.Text == "" || txtEdadC.Text == "" || txtDniC.Text == "" || txtDireccionC.Text == "" || txtTelefonoC.Text == "" || txtCoPostalC.Text == "")
                {
                    DialogResult r = MessageBox.Show("Desea continuar agragando los datos del cliente?", "Faltan datos por completar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (r == DialogResult.No)
                    {
                        //cerrar el formulario y abrir el frmMenuPrincipal
                        frmMenuPrincipal frmMenuPrincipal1CC = new frmMenuPrincipal();
                        frmMenuPrincipal1CC.Show();
                        Close();
                    }
                }
                else
                {
                    //nombre
                    VnombreC[iC] = txtNombreC.Text;
                    VnumeroClienteC[iC] = iC + 1;
                    //apellido
                    VapellidoC[iC] = txtApellidoC.Text;
                    //edad
                    VedadC[iC] = Convert.ToInt32(txtEdadC.Text);
                    //dni
                    VdniC[iC] = txtDniC.Text;
                    //sexo
                    if (rbFemC.Checked == true)
                    {
                        VsexoC[iC] = "Femenino";
                    }
                    else if (rbMascC.Checked == true)
                    {
                        VsexoC[iC] = "Masculino";
                    }
                    else
                    {
                        VsexoC[iC] = "Indefinido";
                    }
                    //direccion
                    VdireccionC[iC] = txtDireccionC.Text;
                    //telefono
                    VtelefonoC[iC] = txtTelefonoC.Text;
                    //codPostal
                    VcodpostalC[iC] = Convert.ToInt32(txtCoPostalC.Text);

                    MessageBox.Show("Los datos del nuevo usuario, han sido gurdados");
                    txtNombreC.Clear();
                    txtApellidoC.Clear();
                    txtEdadC.Clear();
                    txtDniC.Clear();
                    txtDireccionC.Clear();
                    txtTelefonoC.Clear();
                    txtCoPostalC.Clear();
                    iC++;
                    icli++;

                }
            }
            else
            {
                MessageBox.Show("LLego a su limite de usuarios guardados, porfavor consulte su analista sistemas para aumentar su carga de datos *carita facherita*");
                frmMenuPrincipal frmMenuPrincipal2CC = new frmMenuPrincipal();
                frmMenuPrincipal2CC.Show();
                Close();
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal3CC = new frmMenuPrincipal();
            frmMenuPrincipal3CC.Show();
            Close();
        }
    }
}
