using System;
using System.Windows.Forms;

namespace PryPerezFederico
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abre el frmCargarcliente
            frmCargarCliente cargarCli = new frmCargarCliente();
            cargarCli.Show();
            Hide();
        }

        private void apellidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abre el frmBUscarCliente
            frmBuscarCliente BuscarCli = new frmBuscarCliente();
            BuscarCli.Show();
            Hide();
        }

        private void dNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abre el frmMostrarClientes
            frmMostrarCliente mostrarCli = new frmMostrarCliente();
            mostrarCli.Show();
            Hide();

        }
        private void nombreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCargarEmpleado cargarEmpl = new frmCargarEmpleado();
            cargarEmpl.Show();
            Hide();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cierra el programa
            Close();
        }

        private void apellidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmBuscarEmpleado buscarEmpl = new frmBuscarEmpleado();
            buscarEmpl.Show();
            Hide();
        }

        private void numeroDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmMostrarEmpleados mostrarEmpl = new frmMostrarEmpleados();
            mostrarEmpl.Show();
            Hide();
        }

        private void cargarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarVenta frmCarVenta = new frmCargarVenta();
            frmCarVenta.Show();
            Hide();
        }

        private void buacarVentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarVenta frmBuscVenta = new frmBuscarVenta();
            frmBuscVenta.Show();
            Hide();
        }

        private void mostrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCompra frmBuscCompra = new frmBuscarCompra();
            frmBuscCompra.Show();
            Hide();
        }

        private void mostrarTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarTotales mostTotales = new frmMostrarTotales();
            mostTotales.Show();
            Hide();
        }
    }
}
