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
    }
}
