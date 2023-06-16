using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoUDI
{
    public partial class PanelMenu : Form
    {
        public PanelMenu()
        {
            InitializeComponent();
        }

        private void labelProd_Click(object sender, EventArgs e)
        {
            PanelProductos npanelP = new PanelProductos();
            npanelP.Show();
            this.Hide();

        }

        private void labelProv_Click(object sender, EventArgs e)
        {
            PanelProveedores npanelProv = new PanelProveedores();
            npanelProv.Show();
            this.Hide();
        }

        private void labelCliente_Click(object sender, EventArgs e)
        {
            PanelClientes npanelC = new PanelClientes();
            npanelC.Show();
            this.Hide();
        }
    }
}
