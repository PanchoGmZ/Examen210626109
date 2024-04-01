using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasConsultas.VISTAS.MenuConsultasVISTAS
{
    public partial class MenuVISTAS : Form
    {
        public MenuVISTAS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NombreClientesVISTAS abrir = new NombreClientesVISTAS();
            abrir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProveedorTotalVISTAS abrir = new ProveedorTotalVISTAS();
            abrir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MarcaMasVendidaVISTAS abrir = new MarcaMasVendidaVISTAS();
            abrir.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CantidadTotalProductosVISTAS abrir = new CantidadTotalProductosVISTAS();
            abrir.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductosPorExpirarpVISTAS abrir = new ProductosPorExpirarpVISTAS();
            abrir.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VentaPorVendedorVISTAS abrir = new VentaPorVendedorVISTAS();
            abrir.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TotalIngresoClientesVISTAS abrir = new TotalIngresoClientesVISTAS();
            abrir.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProveedorMasSuministroVISTAS abrir = new ProveedorMasSuministroVISTAS();
            abrir.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ProdTipoProdVISTAS abrir = new ProdTipoProdVISTAS();
            abrir.Show();
        }
    }
}
