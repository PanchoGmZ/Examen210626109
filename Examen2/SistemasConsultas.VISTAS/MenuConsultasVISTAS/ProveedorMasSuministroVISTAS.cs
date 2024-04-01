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
    public partial class ProveedorMasSuministroVISTAS : Form
    {
        public ProveedorMasSuministroVISTAS()
        {
            InitializeComponent();
        }
        ProveedorMasSuministroBss bss = new ProveedorMasSuministroBss();
        private void ProveedorMasSuministroVISTAS_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveedorMasSuministroBss();
        }
    }
}
