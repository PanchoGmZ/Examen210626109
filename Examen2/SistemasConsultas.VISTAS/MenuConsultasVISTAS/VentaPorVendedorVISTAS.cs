using SistemasConsultas.BSS;
using SistemasConsultas.DAL;
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
    public partial class VentaPorVendedorVISTAS : Form
    {
        public VentaPorVendedorVISTAS()
        {
            InitializeComponent();
        }
        VentaPorVendedorBss bss = new VentaPorVendedorBss();
        private void VentaPorVendedorVISTAS_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.VentaPorVendedoresBss();
        }
    }
}
