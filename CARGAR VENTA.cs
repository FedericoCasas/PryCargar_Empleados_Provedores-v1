using System;
using System.Windows.Forms;

namespace PryPerezFederico
{
    public partial class frmCargarVenta : Form
    {
        public frmCargarVenta()
        {
            InitializeComponent();
        }

        //creo vectores publicos de ventas y referencia -------------------------ESTO DEBO BUSCAR DESDE BUSCAR VENTAS Y COMPRAS
        public static Double[] VIndiceCargaCompra = new double[3];
        int indiceCompra = 0;
        //lo mismo para el empleado
        public static Double[] VIndiceCargaVenta = new Double[3];
        int indiceVenta = 0;
        //-----------------------------------------------------------------------ESTO DEBO BUSCAR DESDE BUSCAR VENTAS Y COMPRAS

        //Creamos un vector para el Cliente
        String[] VnombreCV = new string[3];
        String[] VapellidoCCV = new string[3];
        String[] VdniCCV = new String[3];
        String[] VdireccionCCV = new string[3];
        string[] VtelefonoCCV = new string[3];
        Int32[] VnumeroClienteCCV = new Int32[3];
        //Creamos un vector para el Empleado
        String[] VnombreECV = new string[3];
        Int32[] VnumeroECV = new Int32[3];
        double ValorTotalTotal = 0;

        private void CARGAR_VENTA_Load(object sender, EventArgs e)
        {
            //Cargamos datos en el vector Cliente cuando abre el frm
            VnombreCV = frmCargarCliente.VnombreC;
            VapellidoCCV = frmCargarCliente.VapellidoC;
            VdniCCV = frmCargarCliente.VdniC;
            VdireccionCCV = frmCargarCliente.VdireccionC;
            VtelefonoCCV = frmCargarCliente.VtelefonoC;
            VnumeroClienteCCV = frmCargarCliente.VnumeroClienteC;
            //Cargamos datos en el vector Empleado cuando abre el frm
            VnombreECV = frmCargarEmpleado.VnombreE;
            VnumeroECV = frmCargarEmpleado.VnumeroEmpleadoE;
            //inabilito acceso a venta hasta verificar empleado
            txtDniCliente.Enabled = false;
            btnBuscarDniCliente.Enabled = false;
            cmbProducto.Enabled = false;
            nudCantidad.Enabled = false;
            btnCargarProductos.Enabled = false;
            btnFinalizarVenta.Enabled = false;
        }
        private void btnBuscarDniEmpleado_Click(object sender, EventArgs e)
        {
            var verificacion = false;
            for (int i = 0; i < VnombreECV.Length; i++)
            {
                Int32 numeroEmpleado = Convert.ToInt32(txtDniEmpleado.Text);
                if (VnumeroECV[i] == numeroEmpleado)
                {
                    //si encuentra el dni, se cargan todos los datos en los .Text
                    indiceVenta = VnumeroECV[i];
                    lblNombreEmpleadoRespuesta.Text = VnombreECV[i];
                    txtDniEmpleado.Text = "";
                    txtDniCliente.Enabled = true;
                    btnBuscarDniCliente.Enabled = true;
                    cmbProducto.Enabled = true;
                    nudCantidad.Enabled = true;
                    btnCargarProductos.Enabled = true;
                    btnFinalizarVenta.Enabled = true;
                    verificacion = true; break;
                }
            }
            if (verificacion == false)
            {
                //mostrar mesaje de que no existe el cliente
                MessageBox.Show("El Numero de el Empleado no existe en la base de datos, porfavor llame a un supervisor", "El Numero de el Empleado no existe ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDniEmpleado.Text = "";
            }

        }
        private void btnBuscarDniCliente_Click_1(object sender, EventArgs e)
        {
            var verificacion = false;
            for (int i = 0; i < VdniCCV.Length; i++)
            {
                if (Convert.ToString(VdniCCV[i]) == txtDniCliente.Text)
                {
                    //si encuentra el dni, se cargan todos los datos en los .Text
                    indiceCompra = VnumeroClienteCCV[i];
                    lblNombreClienteRespuesta.Text = VnombreCV[i];
                    lblApellidoClienteRespuesta.Text = VapellidoCCV[i];
                    lblTelCliente.Text = VtelefonoCCV[i];
                    lblDireccionCliente.Text = VdireccionCCV[i];
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
                    frmCargarCliente cargarCliCV = new frmCargarCliente();
                    cargarCliCV.Show();
                    Close();
                }
                else
                {
                    //borrar el texto escrito incorrectamente y datos anteriores tambien
                    txtDniCliente.Text = "";
                }
            }
        }

        private void btnCargarProductos_Click(object sender, EventArgs e)
        {
            int indice = cmbProducto.SelectedIndex;
            string producto = "";
            int cantidad = Convert.ToInt32(nudCantidad.Value);
            double precio = 0;
            switch (indice)
            {
                case 0:
                    producto = "Celular Samsung Galaxy M13";
                    precio = 101.519;
                    dataGridView1.Rows.Add(producto, cantidad, "$" + precio);
                    ValorTotalTotal = ValorTotalTotal + (precio * cantidad);
                    lblTotalCliente.Text = "$" + Convert.ToString(ValorTotalTotal);
                    break;
                case 1:
                    producto = "Smart TV 40 Pulgadas Hitachi";
                    precio = 101.519;
                    dataGridView1.Rows.Add(producto, cantidad, "$" + precio);
                    ValorTotalTotal = ValorTotalTotal + (precio * cantidad);
                    lblTotalCliente.Text = "$" + Convert.ToString(ValorTotalTotal);
                    break;
                case 2:
                    producto = "Auriculares Vincha Plegable";
                    precio = 8.129;
                    dataGridView1.Rows.Add(producto, cantidad, "$" + precio);
                    ValorTotalTotal = ValorTotalTotal + (precio * cantidad);
                    lblTotalCliente.Text = "$" + Convert.ToString(ValorTotalTotal);
                    break;
                case 3:
                    producto = "Auriculares Bluetooth Tws Philips";
                    precio = 33.609;
                    dataGridView1.Rows.Add(producto, cantidad, "$" + precio);
                    ValorTotalTotal = ValorTotalTotal + (precio * cantidad);
                    lblTotalCliente.Text = "$" + Convert.ToString(ValorTotalTotal);
                    break;
                case 4:
                    producto = "Soporte Tv 19 A 43 Pulgadas One For";
                    precio = 13.129;
                    dataGridView1.Rows.Add(producto, cantidad, "$" + precio);
                    ValorTotalTotal = ValorTotalTotal + (precio * cantidad);
                    lblTotalCliente.Text = "$" + Convert.ToString(ValorTotalTotal);
                    break;

            }
            cmbProducto.Text = "Seleccione el Producto";
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            Double valorAnteriorDelCliente = VIndiceCargaCompra[indiceCompra];
            VIndiceCargaCompra[indiceCompra] = ValorTotalTotal + valorAnteriorDelCliente;
            Double valorAnteriorDelEmpleado = VIndiceCargaVenta[indiceVenta];
            VIndiceCargaVenta[indiceVenta] = ValorTotalTotal + valorAnteriorDelEmpleado;
            //volvemos al menu principal
            frmMenuPrincipal frmMenuPrincipal12CV = new frmMenuPrincipal();
            frmMenuPrincipal12CV.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //volvemos al menu principal
            frmMenuPrincipal frmMenuPrincipal11CV = new frmMenuPrincipal();
            frmMenuPrincipal11CV.Show();
            Close();
        }
    }
}
