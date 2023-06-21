/* Proyecto 2 C#
 * Integrantes:
 * Juan Matias Cagna 
 * Julian Ruiz
 * Federico Villacorta
*/

/* El codigo esta dividido en dos clases: Tesla y SpaceX. Las cuales a la vez tienen subclases con los modelos correspondientes 
 * de cada una (ModeloX, Starship, etc) con todas sus caracteristicas. Las clases tienen un metodo Escaneo que en base al kilometraje del vehiculo,
 * la frecuencia de los controles y la frecuencia de service de cada modelo especifico, devuelve una string con todos los services y controles
 * que se le realizo al vehiculo escaneado. 
 * Tambien tienen un metodo para calcular el nivel de bateria/combustible restante en base a la autonomia de ese vehiculo y el kilometraje/horas de vuelo que tiene.
 * Este metodo asume que el vehiculo se carga al 100% de vuelta al llegar a 0%, es decir, al haber recorrido toda su autonomia. 
 * 
 * La interfaz se basa en TabControls, cada vez que se presiona un boton del menu principal (que en si mismo es una tab de la TabControl principal tambien)
 * se cambia a la tab correspondiente, (por ej: alta vehiculos, eliminar vehiculos, etc), y estas tabs a la vez se dividen en otras tabs internas. 
 * En la tab de alta de vehiculos por ejemplo, al cambiar el tipo de vehiculo de Tesla a SpaceX, se cambia de una tab a otra
 * en la que los labels son distintos, y en base a esto tambien el programa sabe si crear un vehiculo de la clase Tesla o de la clase SpaceX.
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto2
{
    public partial class FormPrincipal : Form
    {
        //--------------------- Listas de vehiculos ---------------------
        List<Tesla> ListaTeslas = new List<Tesla>();
        List<SpaceX> ListaSpaceX = new List<SpaceX>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        //--------------------- Opciones del menu principal ---------------------
        private void btnMenuAltaVehiculos_Click(object sender, EventArgs e)
        {
            listaTabsMenu.SelectedTab = tabAltaVehiculos;
        }

        private void btnMenuEliminarVehiculos_Click(object sender, EventArgs e)
        {
            listaTabsMenu.SelectedTab = tabEliminarVehiculos;
        }

        private void btnMenuEscanearVehiculo_Click(object sender, EventArgs e)
        {
            listaTabsMenu.SelectedTab = tabEscanearVehiculos;
        }

        private void btnMenuMostrarCarga_Click(object sender, EventArgs e)
        {
            listaTabsMenu.SelectedTab = tabCargaVehiculos;
        }

        //--------------------- Boton ver Tesla mas nuevo ---------------------
        private void btnMenuTeslaMasNuevo_Click(object sender, EventArgs e)
        {
            // Si la lista de Teslas no esta vacia, recorre la lista buscando el mas nuevo
            if (ListaTeslas.Count > 0)
            {
                int indexTeslaMasNuevo = 0;

                for (int index = 0; index < ListaTeslas.Count; index++)
                {
                    if (ListaTeslas[index].Anio > ListaTeslas[indexTeslaMasNuevo].Anio)
                    {
                        indexTeslaMasNuevo = index;
                    }
                }

                // Agarra los datos del Tesla mas nuevo y los muestra en una MessageBox
                string modelo = ListaTeslas[indexTeslaMasNuevo].GetType().Name;
                string anio = ListaTeslas[indexTeslaMasNuevo].Anio.ToString();
                string duenio = ListaTeslas[indexTeslaMasNuevo].Duenio;

                MessageBox.Show($"El Tesla mas nuevo es el {modelo} de {duenio} del anio {anio}");
            }
            else
            {
                MessageBox.Show("Error: No hay Teslas dados de alta");
            }
        }

        //--------------------- Tab alta vehiculos ---------------------
        private void radiobtnAltaOpcionTesla_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnAltaOpcionTesla.Checked)
            {
                listaTabsAlta.Visible = true;
                listaTabsAlta.SelectedTab = tabAltaTesla;
            }
        }

        private void radiobtnAltaOpcionSpaceX_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnAltaOpcionSpaceX.Checked)
            {
                listaTabsAlta.Visible = true;
                listaTabsAlta.SelectedTab = tabAltaSpaceX;
            }
        }

        // Si se guarda un Tesla
        private void btnAltaTeslaGuardar_Click(object sender, EventArgs e)
        {
            string modelo = dropDownModeloTesla.Text;
            Int32.TryParse(textBoxAnioTesla.Text, out int anio);
            Int32.TryParse(textBoxKmActualTesla.Text, out int kmActual);
            string color = textBoxColorTesla.Text;
            string duenio = textBoxDuenioTesla.Text;

            // Checkea el tipo de dato de los campos, y si son validos, sino muestra un error
            if (anio < 2012 || anio > 2023 || kmActual <= 0 || String.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(color) || string.IsNullOrEmpty(duenio))
            {
                string error = "Error: ";

                if (String.IsNullOrEmpty(modelo))
                {
                    error += "\n-Seleccione un modelo";
                }
                if (anio < 2012 || anio > 2023)
                {
                    error += "\n-Anio no valido";
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
                    error += "\n-Duenio no valido";
                }

                MessageBox.Show(error);
            }

            // Si no hay ningun error, crea el Tesla del modelo correspondiente
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

        // Si se guarda un SpaceX 
        private void btnAltaSpaceXGuardar_Click(object sender, EventArgs e)
        {
            string modelo = dropDownModeloSpaceX.Text;
            Int32.TryParse(textBoxAnioSpaceX.Text, out int anio);
            Int32.TryParse(textBoxHsVueloActualSpaceX.Text, out int hsVueloActual);
            string color = textBoxColorSpaceX.Text;
            string duenio = textBoxEmpresaSpaceX.Text;

            // Checkea el tipo de dato de los campos, y si son validos, sino muestra un error
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
                    error += "\n-Horas de vuelo no validas";
                }
                if (string.IsNullOrEmpty(color))
                {
                    error += "\n-Color no valido";
                }
                if (string.IsNullOrEmpty(duenio))
                {
                    error += "\n-Empresa duenia no valido";
                }

                MessageBox.Show(error);
            }

            // Si no hay ningun error, crea el SpaceX del modelo correspondiente
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

        // Boton para volver al menu principal, borra todo
        private void btnAltaVolverMenu_Click(object sender, EventArgs e)
        {
            listaTabsAlta.Visible = false;
            radiobtnAltaOpcionTesla.Checked = false;
            radiobtnAltaOpcionSpaceX.Checked = false;
            listaTabsMenu.SelectedTab = tabMenuPrincipal;
        }


        //--------------------- Tab eliminar vehiculos ---------------------

        // Al apretar el boton eliminar vehiculo
        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            // Nombre duenio ingresado
            string duenioABuscar = textBoxEliminarDueño.Text;

            if (!String.IsNullOrEmpty(duenioABuscar))
            {
                // Si esta seleccionada la opcion Tesla, busca en la lista de Teslas
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

                        // Si encuentra al duenio, elimina el Tesla de la lista
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

                // Si esta seleccionada la opcion SpaceX, busca en la lista de SpaceX
                else if (radiobtnEliminarOpcionSpaceX.Checked)
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

                        // Si encuentra al duenio, elimina el SpaceX de la lista
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
            else
            {
                MessageBox.Show("Error: duenio invalido");
            }
        }
        private void btnEliminarVolverMenu_Click(object sender, EventArgs e)
        {
            textBoxEliminarDueño.Text = string.Empty;
            listaTabsMenu.SelectedTab = tabMenuPrincipal;
        }


        //--------------------- Tab escanear vehiculos ---------------------

        // Al apretar el boton buscar
        private void btnEscanearBuscarDuenio_Click(object sender, EventArgs e)
        {
            string duenioABuscar = textBoxEscanearDuenio.Text;

            if (!String.IsNullOrEmpty(duenioABuscar))
            {
                // Si esta seleccionada la opcion Tesla
                if (radiobtnEscanearOpcionTesla.Checked)
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

                        // Si encuentra un Tesla con el duenio que se busco, agarra los datos
                        if (encontrado)
                        {
                            int anio = ListaTeslas[indexTesla].Anio;
                            string modelo = ListaTeslas[indexTesla].GetType().Name;
                            int asientos = ListaTeslas[indexTesla].Asientos;
                            int kmActual = ListaTeslas[indexTesla].KmActual;
                            string duenio = ListaTeslas[indexTesla].Duenio;

                            listaTabsEscanear.Visible = true;
                            listaTabsEscanear.SelectedTab = tabEscanearTesla;
                            panelEscanearServicesSpaceX.Visible = false;
                            panelEscanearServicesTesla.Visible = true;

                            // Llama al metodo Escaneo, que devuelve una string con los datos de service y controles
                            string totalServices = ListaTeslas[indexTesla].Escaneo();

                            if (tablaEscanearDatosTesla.Rows.Count != 0)
                            {
                                tablaEscanearDatosTesla.Rows.Clear();
                            }

                            // Se agregan los datos del Tesla a la tabla
                            tablaEscanearDatosTesla.Rows.Add(anio, modelo, asientos, kmActual + "km", duenio, totalServices);
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

                        // Si encuentra un SpaceX con el duenio que se busco, agarra los datos
                        if (encontrado)
                        {
                            int anio = ListaSpaceX[indexSpaceX].Anio;
                            string modelo = ListaSpaceX[indexSpaceX].GetType().Name;
                            int hsVuelo = ListaSpaceX[indexSpaceX].HsVueloActual;
                            string empresaDuenia = ListaSpaceX[indexSpaceX].EmpresaDuenia;

                            listaTabsEscanear.Visible = true;
                            listaTabsEscanear.SelectedTab = tabEscanearSpaceX;
                            panelEscanearServicesTesla.Visible = false;
                            panelEscanearServicesSpaceX.Location = new Point(8, 24);
                            panelEscanearServicesSpaceX.Visible = true;

                            // Llama al metodo Escaneo, que devuelve una string con los datos de service y controles
                            string totalServices = ListaSpaceX[indexSpaceX].Escaneo();

                            if (tablaEscanearDatosSpaceX.Rows.Count != 0)
                            {
                                tablaEscanearDatosSpaceX.Rows.Clear();
                            }

                            // Se agregan los datos del SpaceX a la tabla
                            tablaEscanearDatosSpaceX.Rows.Add(anio, modelo, hsVuelo + "hs", empresaDuenia, totalServices);

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
            else
            {
                MessageBox.Show("Error: duenio invalido");
            }
        }
        private void btnEscanearVolverMenu_Click(object sender, EventArgs e)
        {
            textBoxEscanearDuenio.Text = string.Empty;
            listaTabsEscanear.Visible = false;
            panelEscanearServicesTesla.Visible = false;
            panelEscanearServicesSpaceX.Visible = false;
            listaTabsMenu.SelectedTab = tabMenuPrincipal;
        }

        //--------------------- Tab nivel de carga vehiculos ---------------------

        // Al apretar el boton mostrar
        private void btnCargaMostrarVehiculos_Click(object sender, EventArgs e)
        {
            // Si esta seleccionada la opcion Tesla
            if (radiobtnCargaOpcionTesla.Checked)
            {
                if (ListaTeslas.Count > 0)
                {
                    listaTabsCarga.SelectedTab = tabCargaTesla;
                    listaTabsCarga.Visible = true;

                    if (tablaCargaDatosTesla.Rows.Count != 0)
                    {
                        tablaCargaDatosTesla.Rows.Clear();
                    }

                    // El loop agrega uno por uno los Teslas de la lista a la tabla
                    foreach (Tesla tesla in ListaTeslas)
                    {
                        tablaCargaDatosTesla.Rows.Add(tesla.Anio, tesla.GetType().Name, tesla.Duenio, tesla.Autonomia + "km", tesla.KmActual + "km", tesla.NivelBateria());
                    }
                }
                else
                {
                    MessageBox.Show("Error: no hay Teslas dados de alta");
                }

            }

            // Si esta seleccionada la opcion SpaceX
            else if (radiobtnCargaOpcionSpaceX.Checked)
            {
                if (ListaSpaceX.Count > 0)
                {
                    listaTabsCarga.SelectedTab = tabCargaSpaceX;
                    listaTabsCarga.Visible = true;

                    if (tablaCargaDatosSpaceX.Rows.Count != 0)
                    {
                        tablaCargaDatosSpaceX.Rows.Clear();
                    }

                    // El loop agrega uno por uno los SpaceX de la lista a la tabla
                    foreach (SpaceX spaceX in ListaSpaceX)
                    {
                        tablaCargaDatosSpaceX.Rows.Add(spaceX.Anio, spaceX.GetType().Name, spaceX.EmpresaDuenia, spaceX.Autonomia + "hs", spaceX.HsVueloActual + "hs", spaceX.NivelCombustible());
                    }

                }
                else
                {
                    MessageBox.Show("Error: no hay SpaceX dados de alta");
                }

            }
            else
                MessageBox.Show("Error: seleccione el tipo de vehiculo");
        }

        private void btnCargaVolverMenu_Click(object sender, EventArgs e)
        {
            listaTabsCarga.Visible = false;
            listaTabsMenu.SelectedTab = tabMenuPrincipal;
        }

    }
}
