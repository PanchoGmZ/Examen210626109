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

namespace SistemasConsultas.VISTAS
{
    public partial class ProdTipoProdVISTAS : Form
    {
        public ProdTipoProdVISTAS()
        {
            InitializeComponent();
        }
        ProductoVendidoTipoProdBSS bss = new ProductoVendidoTipoProdBSS();
        private void ProdTipoProdVISTAS_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProductosTipoProdBss();
        }
    }
}
