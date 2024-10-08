using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.FormCliente
{
    public partial class Formuser : Form
    {
        public Formuser()
        {
            InitializeComponent();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbSalir_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbSalir, "Cerrar ventana");
        }

        private void pcMinimizar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pcMinimizar, "Minimizar ventana");
        }
    }
}
