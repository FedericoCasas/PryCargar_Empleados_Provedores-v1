using System;
using System.Windows.Forms;

namespace PryPerezFederico
{
    public partial class frmMostrarTotales : Form
    {
        public frmMostrarTotales()
        {
            InitializeComponent();
        }
        Double[] VcomprasMT = new Double[3];
        Double[] VventasMT = new Double[3];

        private void MOSTRAR_VENTAS_Y_COMPRAS_TOTALES_Load(object sender, EventArgs e)
        {

            VcomprasMT = frmCargarVenta.VIndiceCargaCompra;
            VventasMT = frmCargarVenta.VIndiceCargaVenta;
        }

        private void btnMostrarTo_Click(object sender, EventArgs e)
        {
            Double ventas = 0;
            Double compras = 0;
            for (int i = 0; i < VcomprasMT.Length; i++)
            {
                compras = compras + VcomprasMT[i];
                lblVentas.Text = Convert.ToString(compras);
                ventas = ventas + VventasMT[i];
                lblVentas.Text = Convert.ToString(ventas);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //volvemos al menu principal
            frmMenuPrincipal frmMenuPrincipal14MT = new frmMenuPrincipal();
            frmMenuPrincipal14MT.Show();
            Close();
        }
    }
}
