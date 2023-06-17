using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelResponseInput_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnAltaVehiculo_Click(object sender, EventArgs e)
        {
            listaTabsMenu.SelectedTab = tabAltaVehiculos;
        }

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            listaTabsMenu.SelectedTab = tabEliminarVehiculos;
        }

        private void btnTeslaMasNuevo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El Tesla mas nuevo es ");
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            listaTabsMenu.SelectedTab = tabMenuPrincipal;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radiobtnOpcionTesla_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnAltaOpcionTesla.Checked)
            {
                listaTabsAlta.Visible = true;
                listaTabsAlta.SelectedTab = tabAltaTesla;
            }
            else
            {
                listaTabsAlta.Visible = false;
            }
        }

        private void radiobtnOpcionSpaceX_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnAltaOpcionSpaceX.Checked)
            {
                listaTabsAlta.Visible = true;
                listaTabsAlta.SelectedTab = tabAltaSpaceX;
            }
            else
            {
                listaTabsAlta.Visible = false;
            }
        }
    }
}
