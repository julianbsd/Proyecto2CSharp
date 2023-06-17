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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
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

        private void btnEliminarMenuPrincipal_Click(object sender, EventArgs e)
        {
            listaTabsMenu.SelectedTab = tabMenuPrincipal;
        }

        private void btnEliminarVehiculo_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"El vehiculo fue eliminado con exito ");
        }

        private void btnMenuEscanear_Click(object sender, EventArgs e)
        {
            listaTabsMenu.SelectedTab = tabEscanearVehiculos;
        }

        private void btnMenuMostrarCarga_Click(object sender, EventArgs e)
        {
            listaTabsMenu.SelectedTab = tabCargaVehiculos;
        }

        private void btnEscanearVolverMenu_Click(object sender, EventArgs e)
        {
            listaTabsMenu.SelectedTab = tabMenuPrincipal;
        }

        private void btnCargaVolverMenu_Click(object sender, EventArgs e)
        {
            listaTabsMenu.SelectedTab = tabMenuPrincipal;
        }

        private void radiobtnCargaOpcionTesla_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnCargaOpcionTesla.Checked)
            {
                listaTabsCarga.Visible = true;
                listaTabsCarga.SelectedTab = tabCargaTesla;
            }
            else
            {
                listaTabsCarga.Visible = false;
            }
        }

        private void radiobtnEliminarOpcionSpaceX_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radiobtnCargaOpcionSpaceX_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnCargaOpcionSpaceX.Checked)
            {
                listaTabsCarga.Visible = true;
                listaTabsCarga.SelectedTab = tabCargaSpaceX;
            }
            else
            {
                listaTabsCarga.Visible = false;
            }
        }
    }
}
