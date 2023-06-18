﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto2
{
    public partial class FormPrincipal : Form
    {
        List<Tesla> ListaTeslas = new List<Tesla>();
        List<SpaceX> ListaSpaceX = new List<SpaceX>();
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
            string duenioABuscar = textBoxEliminarDueño.Text;

            // Si esta seleccionada la opcion Tesla
            if (radiobtnEliminarOpcionTesla.Checked)
            {
                if (ListaTeslas.Count > 0)
                {
                    int indexTesla = 0;
                    bool encontrado = false;

                    for (int index = 0; index < ListaTeslas.Count; index++)
                    {
                        if (ListaTeslas[index].Duenio == duenioABuscar)
                        {
                            encontrado = true;
                            indexTesla = index;
                            break;
                        }
                    }

                    if (encontrado)
                    {
                        ListaTeslas.RemoveAt(indexTesla);
                        MessageBox.Show("El Tesla fue eliminado con exito");
                    }
                    else
                    {
                        MessageBox.Show("El Tesla no fue encontrado");
                    }

                }
                else
                {
                    MessageBox.Show("Error: No hay Teslas dados de alta");
                }
            }

            // Si esta seleccionada la opcion SpaceX
            else
            {
                if (ListaSpaceX.Count > 0)
                {
                    int indexSpaceX = 0;
                    bool encontrado = false;

                    for (int index = 0; index < ListaSpaceX.Count; index++)
                    {
                        if (ListaSpaceX[index].EmpresaDuenia == duenioABuscar)
                        {
                            encontrado = true;
                            indexSpaceX = index;
                            break;
                        }
                    }

                    if (encontrado)
                    {
                        ListaSpaceX.RemoveAt(indexSpaceX);
                        MessageBox.Show("El SpaceX fue eliminado con exito");
                    }
                    else
                    {
                        MessageBox.Show("El SpaceX no fue encontrado");
                    }

                }
                else
                {
                    MessageBox.Show("Error: No hay SpaceX dados de alta");
                }
            }

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

        private void btnAltaTeslaGuardar_Click(object sender, EventArgs e)
        {
            string modelo = dropDownModeloTesla.Text;
            Int32.TryParse(textBoxAnioTesla.Text, out int anio);
            Int32.TryParse(textBoxKmActualTesla.Text, out int kmActual);
            string color = textBoxColorTesla.Text;
            string duenio = textBoxDuenioTesla.Text;

            if (anio < 2012 || anio > 2023 || kmActual <= 0 || String.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(color) || string.IsNullOrEmpty(duenio))
            {
                string error = "Error: ";

                if (String.IsNullOrEmpty(modelo))
                {
                    error += "\n-Seleccione un modelo";
                }
                if (anio < 2012 || anio > 2023)
                {
                    error += "\n-Año no valido";
                }
                if (kmActual <= 0)
                {
                    error += "\n-Kilometraje no valido";
                }
                if (string.IsNullOrEmpty(color))
                {
                    error += "\n-Color no valido";
                }
                if (string.IsNullOrEmpty(duenio))
                {
                    error += "\n-Dueño no valido";
                }

                MessageBox.Show(error);
            }

            else
            {
                if (modelo == "Modelo X")
                {
                    ModeloX NuevoTesla = new ModeloX(anio, kmActual, color, duenio);
                    ListaTeslas.Add(NuevoTesla);
                }
                else if (modelo == "Modelo S")
                {
                    ModeloS NuevoTesla = new ModeloS(anio, kmActual, color, duenio);
                    ListaTeslas.Add(NuevoTesla);
                }
                else if (modelo == "Cybertruck")
                {
                    Cybertruck NuevoTesla = new Cybertruck(anio, kmActual, color, duenio);
                    ListaTeslas.Add(NuevoTesla);
                }

                MessageBox.Show($"El vehiculo fue guardado con exito");
                dropDownModeloTesla.SelectedIndex = -1;
                textBoxAnioTesla.Clear();
                textBoxKmActualTesla.Clear();
                textBoxColorTesla.Clear();
                textBoxDuenioTesla.Clear();
            }
        }
        private void btnAltaTeslaLimpiar_Click(object sender, EventArgs e)
        {
            dropDownModeloTesla.SelectedIndex = -1;
            textBoxAnioTesla.Clear();
            textBoxKmActualTesla.Clear();
            textBoxColorTesla.Clear();
            textBoxDuenioTesla.Clear();
        }

        private void btnAltaSpaceXGuardar_Click(object sender, EventArgs e)
        {
            string modelo = dropDownModeloSpaceX.Text;
            Int32.TryParse(textBoxAnioSpaceX.Text, out int anio);
            Int32.TryParse(textBoxHsVueloActualSpaceX.Text, out int hsVueloActual);
            string color = textBoxColorSpaceX.Text;
            string duenio = textBoxEmpresaSpaceX.Text;

            if (anio < 2012 || anio > 2023 || hsVueloActual <= 0 || String.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(color) || string.IsNullOrEmpty(duenio))
            {
                string error = "Error: ";

                if (String.IsNullOrEmpty(modelo))
                {
                    error += "\n-Seleccione un modelo";
                }
                if (anio < 2012 || anio > 2023)
                {
                    error += "\n-Año no valido";
                }
                if (hsVueloActual <= 0)
                {
                    error += "\n-Kilometraje no valido";
                }
                if (string.IsNullOrEmpty(color))
                {
                    error += "\n-Color no valido";
                }
                if (string.IsNullOrEmpty(duenio))
                {
                    error += "\n-Dueño no valido";
                }

                MessageBox.Show(error);
            }

            else
            {
                if (modelo == "Starship")
                {
                    Starship NuevoSpaceX = new Starship(anio, hsVueloActual, color, duenio);
                    ListaSpaceX.Add(NuevoSpaceX);
                }
                else if (modelo == "Falcon 9")
                {
                    Falcon9 NuevoSpaceX = new Falcon9(anio, hsVueloActual, color, duenio);
                    ListaSpaceX.Add(NuevoSpaceX);
                }

                MessageBox.Show($"El vehiculo fue guardado con exito");
                dropDownModeloSpaceX.SelectedIndex = -1;
                textBoxAnioSpaceX.Clear();
                textBoxHsVueloActualSpaceX.Clear();
                textBoxColorSpaceX.Clear();
                textBoxEmpresaSpaceX.Clear();
            }
        }
        private void btnAltaSpaceXLimpiar_Click(object sender, EventArgs e)
        {
            dropDownModeloSpaceX.SelectedIndex = -1;
            textBoxAnioSpaceX.Clear();
            textBoxHsVueloActualSpaceX.Clear();
            textBoxColorSpaceX.Clear();
            textBoxEmpresaSpaceX.Clear();
        }
    }
}
