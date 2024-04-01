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
    public partial class NombreClientesVISTAS : Form
    {
        ClienteBss bss = new ClienteBss();
        public NombreClientesVISTAS()
        {
            InitializeComponent();
        }

        private void NombreClientesVISTAS_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ClienteDatosBss();
        }
    }
}
