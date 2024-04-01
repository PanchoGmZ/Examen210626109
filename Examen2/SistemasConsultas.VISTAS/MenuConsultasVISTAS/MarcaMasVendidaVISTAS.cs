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
    public partial class MarcaMasVendidaVISTAS : Form
    {
        public MarcaMasVendidaVISTAS()
        {
            InitializeComponent();
        }
        MarcaMasVendidaBss bss = new MarcaMasVendidaBss();
        private void MarcaMasVendidaVISTAS_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.MarcaMasVendidasBss();
        }
    }
}
