using System;
using System.Windows.Forms;

namespace PryPerezFederico
{
    public partial class frmCargarEmpleado : Form
    {
        public frmCargarEmpleado()
        {
            InitializeComponent();
        }
        public static String[] VnombreE = new string[3];
        public static String[] VapellidoE = new string[3];
        public static Int32[] VedadE = new int[3];
        public static String[] VdniE = new String[3];
        public static String[] VsexoE = new string[3];
        public static String[] VdireccionE = new string[3];
        public static string[] VtelefonoE = new string[3];
        public static Int32[] VcodpostalE = new Int32[3];
        public static Int32[] VnumeroEmpleadoE = new Int32[3];
        public Int32 iE = 0;
        public Int32 iem = 1;
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (iem <= VnombreE.Length)
            {
                if (txtNombreE.Text == "" && txtApellidoE.Text == "" && txtEdadE.Text == "" && txtDniE.Text == "" && txtDireccionE.Text == "" && txtTelefonoE.Text == "" && txtCoPostalE.Text == "")
                {
                    MessageBox.Show("Usted no completo ningun dato, imposible continuar");
                }
                else if (txtNombreE.Text == "" || txtApellidoE.Text == "" || txtEdadE.Text == "" || txtDniE.Text == "" || txtDireccionE.Text == "" || txtTelefonoE.Text == "" || txtCoPostalE.Text == "")
                {
                    DialogResult r = MessageBox.Show("Desea continuar agragando los datos del empleado?", "Faltan datos por completar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.No)
                    {
                        //cerrar el formulario y abrir el frmMenuPrincipal
                        frmMenuPrincipal frmMenuPrincipal4CE = new frmMenuPrincipal();
                        frmMenuPrincipal4CE.Show();
                        this.Hide();
                    }
                }
                else
                {
                    //nombre
                    VnombreE[iE] = txtNombreE.Text;
                    VnumeroEmpleadoE[iE] = iE + 1;
                    //apellido
                    VapellidoE[iE] = txtApellidoE.Text;
                    //edad
                    VedadE[iE] = Convert.ToInt32(txtEdadE.Text);
                    //dni
                    VdniE[iE] = txtDniE.Text;
                    //sexo
                    if (rButtonFemE.Checked == true)
                    {
                        VsexoE[iE] = "Femenino";
                    }
                    else if (rButtonMascE.Checked == true)
                    {
                        VsexoE[iE] = "Masculino";
                    }
                    else
                    {
                        VsexoE[iE] = "Indefinido";
                    }
                    //direccion
                    VdireccionE[iE] = txtDireccionE.Text;
                    //telefono
                    VtelefonoE[iE] = txtTelefonoE.Text;
                    //codPostal
                    VcodpostalE[iE] = Convert.ToInt32(txtCoPostalE.Text);

                    MessageBox.Show("Los datos del nuevo empleado, han sido gurdados");
                    txtNombreE.Clear();
                    txtApellidoE.Clear();
                    txtEdadE.Clear();
                    txtDniE.Clear();
                    txtDireccionE.Clear();
                    txtTelefonoE.Clear();
                    txtCoPostalE.Clear();
                    iE++;
                    iem++;

                }
            }
            else
            {
                MessageBox.Show("LLego a su limite de empleados guardados, porfavor consulte su analista sistemas para aumentar su carga de datos *carita facherita*");
                frmMenuPrincipal frmMenuPrincipal5CE = new frmMenuPrincipal();
                frmMenuPrincipal5CE.Show();
                this.Hide();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //volvemos al menu principal
            frmMenuPrincipal frmMenuPrincipal6CE = new frmMenuPrincipal();
            frmMenuPrincipal6CE.Show();
            this.Hide();
        }
    }

}
