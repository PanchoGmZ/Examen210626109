using SistemasConsultas.BSS;
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
    public partial class ProductosPorExpirarpVISTAS : Form
    {
        public ProductosPorExpirarpVISTAS()
        {
            InitializeComponent();
        }
        ProductosPorExpirarBss bss = new ProductosPorExpirarBss();
        private void ProductosPorExpirarpVISTAS_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProducotsPorExpirarBss();
        }
    }
}
