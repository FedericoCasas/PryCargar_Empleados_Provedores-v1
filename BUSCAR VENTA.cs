using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPerezFederico
{
    public partial class BUSCAR_VENTA : Form
    {
        public BUSCAR_VENTA()
        {
            InitializeComponent();
        }
        //Creamos un vector
        String[] Vnombre = new string[3];
        String[] Vapellido = new string[3];
        Int32[] Vedad = new int[3];
        String[] Vdni = new String[3];
        String[] Vsexo = new string[3];
        String[] Vdireccion = new string[3];
        string[] Vtelefono = new string[3];
        Int32[] Vcodpostal = new Int32[3];
        Int32[] Vnumeroempleado = new Int32[3];
        Int32[] VTotalVentasE = new Int32[3];
        private void BUSCAR_VENTA_Load(object sender, EventArgs e)
        {
            //Cargamos datos en el vector cuando abre el fromulario
            Vnombre = frmCargarEmpleado.VnombreE;
            Vapellido = frmCargarEmpleado.VapellidoE;
            Vedad = frmCargarEmpleado.VedadE;
            Vdni = frmCargarEmpleado.VdniE;
            Vsexo = frmCargarEmpleado.VsexoE;
            Vdireccion = frmCargarEmpleado.VdireccionE;
            Vtelefono = frmCargarEmpleado.VtelefonoE;
            Vcodpostal = frmCargarEmpleado.VcodpostalE;
            Vnumeroempleado = frmCargarEmpleado.VnumeroEmpleadoE;
            VTotalVentasE = frmCrgarVenta.VTotalVentas;
        }
        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {

        }

        
    }
}
