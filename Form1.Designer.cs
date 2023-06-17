namespace Proyecto2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAltaVehiculo = new System.Windows.Forms.Button();
            this.btnEliminarVehiculo = new System.Windows.Forms.Button();
            this.btnTeslaMasNuevo = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listaTabsMenu = new System.Windows.Forms.TabControl();
            this.tabMenuPrincipal = new System.Windows.Forms.TabPage();
            this.tabAltaVehiculos = new System.Windows.Forms.TabPage();
            this.listaTabsAlta = new System.Windows.Forms.TabControl();
            this.tabAltaTesla = new System.Windows.Forms.TabPage();
            this.textBoxDueñoTesla = new System.Windows.Forms.TextBox();
            this.textBoxColorTesla = new System.Windows.Forms.TextBox();
            this.textBoxKilometrajeTesla = new System.Windows.Forms.TextBox();
            this.textBoxAñoTesla = new System.Windows.Forms.TextBox();
            this.dropDownModeloTesla = new System.Windows.Forms.ComboBox();
            this.labelModeloTesla = new System.Windows.Forms.Label();
            this.labelDueñoTesla = new System.Windows.Forms.Label();
            this.labelColorTesla = new System.Windows.Forms.Label();
            this.labelKilometrajeTesla = new System.Windows.Forms.Label();
            this.labelAñoTesla = new System.Windows.Forms.Label();
            this.tabAltaSpaceX = new System.Windows.Forms.TabPage();
            this.textBoxEmpresaSpaceX = new System.Windows.Forms.TextBox();
            this.textBoxColorSpaceX = new System.Windows.Forms.TextBox();
            this.textBoxHorasSpaceX = new System.Windows.Forms.TextBox();
            this.textBoxAñoSpaceX = new System.Windows.Forms.TextBox();
            this.dropDownModeloSpaceX = new System.Windows.Forms.ComboBox();
            this.labelModeloSpaceX = new System.Windows.Forms.Label();
            this.labelEmpresaSpaceX = new System.Windows.Forms.Label();
            this.labelColorSpaceX = new System.Windows.Forms.Label();
            this.labelHorasSpaceX = new System.Windows.Forms.Label();
            this.labelAñoSpaceX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.labelAltaTipoVehiculo = new System.Windows.Forms.Label();
            this.radiobtnAltaOpcionSpaceX = new System.Windows.Forms.RadioButton();
            this.radiobtnAltaOpcionTesla = new System.Windows.Forms.RadioButton();
            this.btnAltaMenuPrincipal = new System.Windows.Forms.Button();
            this.tabEliminarVehiculos = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.logoTesla = new System.Windows.Forms.PictureBox();
            this.logoSpaceX = new System.Windows.Forms.PictureBox();
            this.btnAltaTeslaGuardar = new System.Windows.Forms.Button();
            this.btnAltaTeslaLimpiar = new System.Windows.Forms.Button();
            this.btnAltaSpaceXGuardar = new System.Windows.Forms.Button();
            this.btnAltaSpaceXLimpiar = new System.Windows.Forms.Button();
            this.listaTabsMenu.SuspendLayout();
            this.tabMenuPrincipal.SuspendLayout();
            this.tabAltaVehiculos.SuspendLayout();
            this.listaTabsAlta.SuspendLayout();
            this.tabAltaTesla.SuspendLayout();
            this.tabAltaSpaceX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoTesla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoSpaceX)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAltaVehiculo
            // 
            this.btnAltaVehiculo.Location = new System.Drawing.Point(245, 110);
            this.btnAltaVehiculo.Name = "btnAltaVehiculo";
            this.btnAltaVehiculo.Size = new System.Drawing.Size(220, 55);
            this.btnAltaVehiculo.TabIndex = 0;
            this.btnAltaVehiculo.Text = "Dar de alta un vehiculo";
            this.btnAltaVehiculo.UseVisualStyleBackColor = true;
            this.btnAltaVehiculo.Click += new System.EventHandler(this.btnAltaVehiculo_Click);
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(580, 110);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(220, 55);
            this.btnEliminarVehiculo.TabIndex = 2;
            this.btnEliminarVehiculo.Text = "Eliminar un vehiculo";
            this.btnEliminarVehiculo.UseVisualStyleBackColor = true;
            this.btnEliminarVehiculo.Click += new System.EventHandler(this.btnEliminarVehiculo_Click);
            // 
            // btnTeslaMasNuevo
            // 
            this.btnTeslaMasNuevo.Location = new System.Drawing.Point(418, 266);
            this.btnTeslaMasNuevo.Name = "btnTeslaMasNuevo";
            this.btnTeslaMasNuevo.Size = new System.Drawing.Size(220, 55);
            this.btnTeslaMasNuevo.TabIndex = 3;
            this.btnTeslaMasNuevo.Text = "Mostrar el Tesla mas nuevo";
            this.btnTeslaMasNuevo.UseVisualStyleBackColor = true;
            this.btnTeslaMasNuevo.Click += new System.EventHandler(this.btnTeslaMasNuevo_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(154, 266);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(220, 55);
            this.button6.TabIndex = 4;
            this.button6.Text = "Escanear un vehiculo";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(682, 266);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(220, 55);
            this.button7.TabIndex = 8;
            this.button7.Text = "Mostrar carga de todos los vehiculos";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // listaTabsMenu
            // 
            this.listaTabsMenu.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.listaTabsMenu.Controls.Add(this.tabMenuPrincipal);
            this.listaTabsMenu.Controls.Add(this.tabAltaVehiculos);
            this.listaTabsMenu.Controls.Add(this.tabEliminarVehiculos);
            this.listaTabsMenu.ItemSize = new System.Drawing.Size(0, 1);
            this.listaTabsMenu.Location = new System.Drawing.Point(112, 193);
            this.listaTabsMenu.Multiline = true;
            this.listaTabsMenu.Name = "listaTabsMenu";
            this.listaTabsMenu.SelectedIndex = 0;
            this.listaTabsMenu.Size = new System.Drawing.Size(1050, 500);
            this.listaTabsMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.listaTabsMenu.TabIndex = 10;
            this.listaTabsMenu.TabStop = false;
            // 
            // tabMenuPrincipal
            // 
            this.tabMenuPrincipal.BackColor = System.Drawing.Color.SteelBlue;
            this.tabMenuPrincipal.Controls.Add(this.btnEliminarVehiculo);
            this.tabMenuPrincipal.Controls.Add(this.btnTeslaMasNuevo);
            this.tabMenuPrincipal.Controls.Add(this.btnAltaVehiculo);
            this.tabMenuPrincipal.Controls.Add(this.button6);
            this.tabMenuPrincipal.Controls.Add(this.button7);
            this.tabMenuPrincipal.Location = new System.Drawing.Point(4, 5);
            this.tabMenuPrincipal.Name = "tabMenuPrincipal";
            this.tabMenuPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenuPrincipal.Size = new System.Drawing.Size(1042, 491);
            this.tabMenuPrincipal.TabIndex = 0;
            this.tabMenuPrincipal.Text = "tabPage1";
            // 
            // tabAltaVehiculos
            // 
            this.tabAltaVehiculos.BackColor = System.Drawing.Color.SteelBlue;
            this.tabAltaVehiculos.Controls.Add(this.listaTabsAlta);
            this.tabAltaVehiculos.Controls.Add(this.labelAltaTipoVehiculo);
            this.tabAltaVehiculos.Controls.Add(this.radiobtnAltaOpcionSpaceX);
            this.tabAltaVehiculos.Controls.Add(this.radiobtnAltaOpcionTesla);
            this.tabAltaVehiculos.Controls.Add(this.btnAltaMenuPrincipal);
            this.tabAltaVehiculos.Location = new System.Drawing.Point(4, 5);
            this.tabAltaVehiculos.Name = "tabAltaVehiculos";
            this.tabAltaVehiculos.Padding = new System.Windows.Forms.Padding(3);
            this.tabAltaVehiculos.Size = new System.Drawing.Size(1042, 491);
            this.tabAltaVehiculos.TabIndex = 1;
            this.tabAltaVehiculos.Text = "tabPage2";
            // 
            // listaTabsAlta
            // 
            this.listaTabsAlta.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.listaTabsAlta.Controls.Add(this.tabAltaTesla);
            this.listaTabsAlta.Controls.Add(this.tabAltaSpaceX);
            this.listaTabsAlta.ItemSize = new System.Drawing.Size(0, 1);
            this.listaTabsAlta.Location = new System.Drawing.Point(281, 110);
            this.listaTabsAlta.Multiline = true;
            this.listaTabsAlta.Name = "listaTabsAlta";
            this.listaTabsAlta.SelectedIndex = 0;
            this.listaTabsAlta.Size = new System.Drawing.Size(516, 348);
            this.listaTabsAlta.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.listaTabsAlta.TabIndex = 11;
            this.listaTabsAlta.TabStop = false;
            this.listaTabsAlta.Visible = false;
            // 
            // tabAltaTesla
            // 
            this.tabAltaTesla.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabAltaTesla.Controls.Add(this.btnAltaTeslaLimpiar);
            this.tabAltaTesla.Controls.Add(this.btnAltaTeslaGuardar);
            this.tabAltaTesla.Controls.Add(this.textBoxDueñoTesla);
            this.tabAltaTesla.Controls.Add(this.textBoxColorTesla);
            this.tabAltaTesla.Controls.Add(this.textBoxKilometrajeTesla);
            this.tabAltaTesla.Controls.Add(this.textBoxAñoTesla);
            this.tabAltaTesla.Controls.Add(this.dropDownModeloTesla);
            this.tabAltaTesla.Controls.Add(this.labelModeloTesla);
            this.tabAltaTesla.Controls.Add(this.labelDueñoTesla);
            this.tabAltaTesla.Controls.Add(this.labelColorTesla);
            this.tabAltaTesla.Controls.Add(this.labelKilometrajeTesla);
            this.tabAltaTesla.Controls.Add(this.labelAñoTesla);
            this.tabAltaTesla.Location = new System.Drawing.Point(4, 5);
            this.tabAltaTesla.Name = "tabAltaTesla";
            this.tabAltaTesla.Padding = new System.Windows.Forms.Padding(3);
            this.tabAltaTesla.Size = new System.Drawing.Size(508, 339);
            this.tabAltaTesla.TabIndex = 0;
            this.tabAltaTesla.Text = "tabPage1";
            // 
            // textBoxDueñoTesla
            // 
            this.textBoxDueñoTesla.Location = new System.Drawing.Point(270, 250);
            this.textBoxDueñoTesla.Name = "textBoxDueñoTesla";
            this.textBoxDueñoTesla.Size = new System.Drawing.Size(190, 22);
            this.textBoxDueñoTesla.TabIndex = 21;
            // 
            // textBoxColorTesla
            // 
            this.textBoxColorTesla.Location = new System.Drawing.Point(270, 205);
            this.textBoxColorTesla.Name = "textBoxColorTesla";
            this.textBoxColorTesla.Size = new System.Drawing.Size(190, 22);
            this.textBoxColorTesla.TabIndex = 20;
            // 
            // textBoxKilometrajeTesla
            // 
            this.textBoxKilometrajeTesla.Location = new System.Drawing.Point(270, 160);
            this.textBoxKilometrajeTesla.Name = "textBoxKilometrajeTesla";
            this.textBoxKilometrajeTesla.Size = new System.Drawing.Size(190, 22);
            this.textBoxKilometrajeTesla.TabIndex = 19;
            // 
            // textBoxAñoTesla
            // 
            this.textBoxAñoTesla.Location = new System.Drawing.Point(270, 115);
            this.textBoxAñoTesla.Name = "textBoxAñoTesla";
            this.textBoxAñoTesla.Size = new System.Drawing.Size(190, 22);
            this.textBoxAñoTesla.TabIndex = 18;
            // 
            // dropDownModeloTesla
            // 
            this.dropDownModeloTesla.FormattingEnabled = true;
            this.dropDownModeloTesla.Items.AddRange(new object[] {
            "Modelo X",
            "Modelo S",
            "CyberTruck"});
            this.dropDownModeloTesla.Location = new System.Drawing.Point(270, 65);
            this.dropDownModeloTesla.Name = "dropDownModeloTesla";
            this.dropDownModeloTesla.Size = new System.Drawing.Size(190, 24);
            this.dropDownModeloTesla.TabIndex = 17;
            // 
            // labelModeloTesla
            // 
            this.labelModeloTesla.AutoSize = true;
            this.labelModeloTesla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModeloTesla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelModeloTesla.Location = new System.Drawing.Point(45, 70);
            this.labelModeloTesla.Name = "labelModeloTesla";
            this.labelModeloTesla.Size = new System.Drawing.Size(68, 20);
            this.labelModeloTesla.TabIndex = 16;
            this.labelModeloTesla.Text = "Modelo:";
            // 
            // labelDueñoTesla
            // 
            this.labelDueñoTesla.AutoSize = true;
            this.labelDueñoTesla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDueñoTesla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDueñoTesla.Location = new System.Drawing.Point(45, 250);
            this.labelDueñoTesla.Name = "labelDueñoTesla";
            this.labelDueñoTesla.Size = new System.Drawing.Size(63, 20);
            this.labelDueñoTesla.TabIndex = 15;
            this.labelDueñoTesla.Text = "Dueño:";
            // 
            // labelColorTesla
            // 
            this.labelColorTesla.AutoSize = true;
            this.labelColorTesla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColorTesla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelColorTesla.Location = new System.Drawing.Point(45, 205);
            this.labelColorTesla.Name = "labelColorTesla";
            this.labelColorTesla.Size = new System.Drawing.Size(54, 20);
            this.labelColorTesla.TabIndex = 14;
            this.labelColorTesla.Text = "Color:";
            // 
            // labelKilometrajeTesla
            // 
            this.labelKilometrajeTesla.AutoSize = true;
            this.labelKilometrajeTesla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKilometrajeTesla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelKilometrajeTesla.Location = new System.Drawing.Point(45, 160);
            this.labelKilometrajeTesla.Name = "labelKilometrajeTesla";
            this.labelKilometrajeTesla.Size = new System.Drawing.Size(148, 20);
            this.labelKilometrajeTesla.TabIndex = 13;
            this.labelKilometrajeTesla.Text = "Kilometraje actual:";
            // 
            // labelAñoTesla
            // 
            this.labelAñoTesla.AutoSize = true;
            this.labelAñoTesla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAñoTesla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAñoTesla.Location = new System.Drawing.Point(45, 115);
            this.labelAñoTesla.Name = "labelAñoTesla";
            this.labelAñoTesla.Size = new System.Drawing.Size(43, 20);
            this.labelAñoTesla.TabIndex = 12;
            this.labelAñoTesla.Text = "Año:";
            this.labelAñoTesla.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabAltaSpaceX
            // 
            this.tabAltaSpaceX.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabAltaSpaceX.Controls.Add(this.btnAltaSpaceXLimpiar);
            this.tabAltaSpaceX.Controls.Add(this.btnAltaSpaceXGuardar);
            this.tabAltaSpaceX.Controls.Add(this.textBoxEmpresaSpaceX);
            this.tabAltaSpaceX.Controls.Add(this.textBoxColorSpaceX);
            this.tabAltaSpaceX.Controls.Add(this.textBoxHorasSpaceX);
            this.tabAltaSpaceX.Controls.Add(this.textBoxAñoSpaceX);
            this.tabAltaSpaceX.Controls.Add(this.dropDownModeloSpaceX);
            this.tabAltaSpaceX.Controls.Add(this.labelModeloSpaceX);
            this.tabAltaSpaceX.Controls.Add(this.labelEmpresaSpaceX);
            this.tabAltaSpaceX.Controls.Add(this.labelColorSpaceX);
            this.tabAltaSpaceX.Controls.Add(this.labelHorasSpaceX);
            this.tabAltaSpaceX.Controls.Add(this.labelAñoSpaceX);
            this.tabAltaSpaceX.Controls.Add(this.label2);
            this.tabAltaSpaceX.Controls.Add(this.button8);
            this.tabAltaSpaceX.Location = new System.Drawing.Point(4, 5);
            this.tabAltaSpaceX.Name = "tabAltaSpaceX";
            this.tabAltaSpaceX.Padding = new System.Windows.Forms.Padding(3);
            this.tabAltaSpaceX.Size = new System.Drawing.Size(508, 339);
            this.tabAltaSpaceX.TabIndex = 1;
            this.tabAltaSpaceX.Text = "tabPage2";
            // 
            // textBoxEmpresaSpaceX
            // 
            this.textBoxEmpresaSpaceX.Location = new System.Drawing.Point(270, 250);
            this.textBoxEmpresaSpaceX.Name = "textBoxEmpresaSpaceX";
            this.textBoxEmpresaSpaceX.Size = new System.Drawing.Size(190, 22);
            this.textBoxEmpresaSpaceX.TabIndex = 31;
            // 
            // textBoxColorSpaceX
            // 
            this.textBoxColorSpaceX.Location = new System.Drawing.Point(270, 205);
            this.textBoxColorSpaceX.Name = "textBoxColorSpaceX";
            this.textBoxColorSpaceX.Size = new System.Drawing.Size(190, 22);
            this.textBoxColorSpaceX.TabIndex = 30;
            // 
            // textBoxHorasSpaceX
            // 
            this.textBoxHorasSpaceX.Location = new System.Drawing.Point(270, 160);
            this.textBoxHorasSpaceX.Name = "textBoxHorasSpaceX";
            this.textBoxHorasSpaceX.Size = new System.Drawing.Size(190, 22);
            this.textBoxHorasSpaceX.TabIndex = 29;
            // 
            // textBoxAñoSpaceX
            // 
            this.textBoxAñoSpaceX.Location = new System.Drawing.Point(270, 115);
            this.textBoxAñoSpaceX.Name = "textBoxAñoSpaceX";
            this.textBoxAñoSpaceX.Size = new System.Drawing.Size(190, 22);
            this.textBoxAñoSpaceX.TabIndex = 28;
            // 
            // dropDownModeloSpaceX
            // 
            this.dropDownModeloSpaceX.FormattingEnabled = true;
            this.dropDownModeloSpaceX.Items.AddRange(new object[] {
            "Starship",
            "Falcon 9"});
            this.dropDownModeloSpaceX.Location = new System.Drawing.Point(270, 65);
            this.dropDownModeloSpaceX.Name = "dropDownModeloSpaceX";
            this.dropDownModeloSpaceX.Size = new System.Drawing.Size(190, 24);
            this.dropDownModeloSpaceX.TabIndex = 27;
            // 
            // labelModeloSpaceX
            // 
            this.labelModeloSpaceX.AutoSize = true;
            this.labelModeloSpaceX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModeloSpaceX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelModeloSpaceX.Location = new System.Drawing.Point(45, 70);
            this.labelModeloSpaceX.Name = "labelModeloSpaceX";
            this.labelModeloSpaceX.Size = new System.Drawing.Size(68, 20);
            this.labelModeloSpaceX.TabIndex = 26;
            this.labelModeloSpaceX.Text = "Modelo:";
            // 
            // labelEmpresaSpaceX
            // 
            this.labelEmpresaSpaceX.AutoSize = true;
            this.labelEmpresaSpaceX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpresaSpaceX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpresaSpaceX.Location = new System.Drawing.Point(45, 250);
            this.labelEmpresaSpaceX.Name = "labelEmpresaSpaceX";
            this.labelEmpresaSpaceX.Size = new System.Drawing.Size(131, 20);
            this.labelEmpresaSpaceX.TabIndex = 25;
            this.labelEmpresaSpaceX.Text = "Empresa dueña:";
            // 
            // labelColorSpaceX
            // 
            this.labelColorSpaceX.AutoSize = true;
            this.labelColorSpaceX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColorSpaceX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelColorSpaceX.Location = new System.Drawing.Point(45, 205);
            this.labelColorSpaceX.Name = "labelColorSpaceX";
            this.labelColorSpaceX.Size = new System.Drawing.Size(54, 20);
            this.labelColorSpaceX.TabIndex = 24;
            this.labelColorSpaceX.Text = "Color:";
            // 
            // labelHorasSpaceX
            // 
            this.labelHorasSpaceX.AutoSize = true;
            this.labelHorasSpaceX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorasSpaceX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHorasSpaceX.Location = new System.Drawing.Point(45, 160);
            this.labelHorasSpaceX.Name = "labelHorasSpaceX";
            this.labelHorasSpaceX.Size = new System.Drawing.Size(195, 20);
            this.labelHorasSpaceX.TabIndex = 23;
            this.labelHorasSpaceX.Text = "Horas de vuelo actuales:";
            // 
            // labelAñoSpaceX
            // 
            this.labelAñoSpaceX.AutoSize = true;
            this.labelAñoSpaceX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAñoSpaceX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAñoSpaceX.Location = new System.Drawing.Point(45, 115);
            this.labelAñoSpaceX.Name = "labelAñoSpaceX";
            this.labelAñoSpaceX.Size = new System.Drawing.Size(43, 20);
            this.labelAñoSpaceX.TabIndex = 22;
            this.labelAñoSpaceX.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(277, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de vehiculo:";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(31, 403);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(220, 55);
            this.button8.TabIndex = 1;
            this.button8.Text = "Volver al menu principal";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // labelAltaTipoVehiculo
            // 
            this.labelAltaTipoVehiculo.AutoSize = true;
            this.labelAltaTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltaTipoVehiculo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAltaTipoVehiculo.Location = new System.Drawing.Point(281, 65);
            this.labelAltaTipoVehiculo.Name = "labelAltaTipoVehiculo";
            this.labelAltaTipoVehiculo.Size = new System.Drawing.Size(135, 20);
            this.labelAltaTipoVehiculo.TabIndex = 4;
            this.labelAltaTipoVehiculo.Text = "Tipo de vehiculo:";
            // 
            // radiobtnAltaOpcionSpaceX
            // 
            this.radiobtnAltaOpcionSpaceX.AutoSize = true;
            this.radiobtnAltaOpcionSpaceX.Location = new System.Drawing.Point(601, 65);
            this.radiobtnAltaOpcionSpaceX.Name = "radiobtnAltaOpcionSpaceX";
            this.radiobtnAltaOpcionSpaceX.Size = new System.Drawing.Size(76, 20);
            this.radiobtnAltaOpcionSpaceX.TabIndex = 3;
            this.radiobtnAltaOpcionSpaceX.TabStop = true;
            this.radiobtnAltaOpcionSpaceX.Text = "SpaceX";
            this.radiobtnAltaOpcionSpaceX.UseVisualStyleBackColor = true;
            this.radiobtnAltaOpcionSpaceX.CheckedChanged += new System.EventHandler(this.radiobtnOpcionSpaceX_CheckedChanged);
            // 
            // radiobtnAltaOpcionTesla
            // 
            this.radiobtnAltaOpcionTesla.AutoSize = true;
            this.radiobtnAltaOpcionTesla.Location = new System.Drawing.Point(490, 66);
            this.radiobtnAltaOpcionTesla.Name = "radiobtnAltaOpcionTesla";
            this.radiobtnAltaOpcionTesla.Size = new System.Drawing.Size(63, 20);
            this.radiobtnAltaOpcionTesla.TabIndex = 2;
            this.radiobtnAltaOpcionTesla.TabStop = true;
            this.radiobtnAltaOpcionTesla.Text = "Tesla";
            this.radiobtnAltaOpcionTesla.UseVisualStyleBackColor = true;
            this.radiobtnAltaOpcionTesla.CheckedChanged += new System.EventHandler(this.radiobtnOpcionTesla_CheckedChanged);
            // 
            // btnAltaMenuPrincipal
            // 
            this.btnAltaMenuPrincipal.Location = new System.Drawing.Point(31, 403);
            this.btnAltaMenuPrincipal.Name = "btnAltaMenuPrincipal";
            this.btnAltaMenuPrincipal.Size = new System.Drawing.Size(220, 55);
            this.btnAltaMenuPrincipal.TabIndex = 1;
            this.btnAltaMenuPrincipal.Text = "Volver al menu principal";
            this.btnAltaMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnAltaMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // tabEliminarVehiculos
            // 
            this.tabEliminarVehiculos.Location = new System.Drawing.Point(4, 5);
            this.tabEliminarVehiculos.Name = "tabEliminarVehiculos";
            this.tabEliminarVehiculos.Size = new System.Drawing.Size(1042, 491);
            this.tabEliminarVehiculos.TabIndex = 2;
            this.tabEliminarVehiculos.Text = "tabPage3";
            this.tabEliminarVehiculos.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // logoTesla
            // 
            this.logoTesla.Image = ((System.Drawing.Image)(resources.GetObject("logoTesla.Image")));
            this.logoTesla.Location = new System.Drawing.Point(270, 27);
            this.logoTesla.Name = "logoTesla";
            this.logoTesla.Size = new System.Drawing.Size(364, 160);
            this.logoTesla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoTesla.TabIndex = 12;
            this.logoTesla.TabStop = false;
            // 
            // logoSpaceX
            // 
            this.logoSpaceX.Image = ((System.Drawing.Image)(resources.GetObject("logoSpaceX.Image")));
            this.logoSpaceX.Location = new System.Drawing.Point(697, 78);
            this.logoSpaceX.Name = "logoSpaceX";
            this.logoSpaceX.Size = new System.Drawing.Size(321, 54);
            this.logoSpaceX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoSpaceX.TabIndex = 13;
            this.logoSpaceX.TabStop = false;
            // 
            // btnAltaTeslaGuardar
            // 
            this.btnAltaTeslaGuardar.Location = new System.Drawing.Point(49, 304);
            this.btnAltaTeslaGuardar.Name = "btnAltaTeslaGuardar";
            this.btnAltaTeslaGuardar.Size = new System.Drawing.Size(138, 23);
            this.btnAltaTeslaGuardar.TabIndex = 22;
            this.btnAltaTeslaGuardar.Text = "Guardar";
            this.btnAltaTeslaGuardar.UseVisualStyleBackColor = true;
            // 
            // btnAltaTeslaLimpiar
            // 
            this.btnAltaTeslaLimpiar.Location = new System.Drawing.Point(205, 304);
            this.btnAltaTeslaLimpiar.Name = "btnAltaTeslaLimpiar";
            this.btnAltaTeslaLimpiar.Size = new System.Drawing.Size(138, 23);
            this.btnAltaTeslaLimpiar.TabIndex = 23;
            this.btnAltaTeslaLimpiar.Text = "Limpiar";
            this.btnAltaTeslaLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnAltaSpaceXGuardar
            // 
            this.btnAltaSpaceXGuardar.Location = new System.Drawing.Point(49, 304);
            this.btnAltaSpaceXGuardar.Name = "btnAltaSpaceXGuardar";
            this.btnAltaSpaceXGuardar.Size = new System.Drawing.Size(138, 23);
            this.btnAltaSpaceXGuardar.TabIndex = 32;
            this.btnAltaSpaceXGuardar.Text = "Guardar";
            this.btnAltaSpaceXGuardar.UseVisualStyleBackColor = true;
            // 
            // btnAltaSpaceXLimpiar
            // 
            this.btnAltaSpaceXLimpiar.Location = new System.Drawing.Point(205, 304);
            this.btnAltaSpaceXLimpiar.Name = "btnAltaSpaceXLimpiar";
            this.btnAltaSpaceXLimpiar.Size = new System.Drawing.Size(138, 23);
            this.btnAltaSpaceXLimpiar.TabIndex = 33;
            this.btnAltaSpaceXLimpiar.Text = "Limpiar";
            this.btnAltaSpaceXLimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.logoSpaceX);
            this.Controls.Add(this.logoTesla);
            this.Controls.Add(this.listaTabsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto 2 C# | Cagna - Ruiz - Villacorta";
            this.listaTabsMenu.ResumeLayout(false);
            this.tabMenuPrincipal.ResumeLayout(false);
            this.tabAltaVehiculos.ResumeLayout(false);
            this.tabAltaVehiculos.PerformLayout();
            this.listaTabsAlta.ResumeLayout(false);
            this.tabAltaTesla.ResumeLayout(false);
            this.tabAltaTesla.PerformLayout();
            this.tabAltaSpaceX.ResumeLayout(false);
            this.tabAltaSpaceX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoTesla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoSpaceX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaVehiculo;
        private System.Windows.Forms.Button btnEliminarVehiculo;
        private System.Windows.Forms.Button btnTeslaMasNuevo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TabControl listaTabsMenu;
        private System.Windows.Forms.TabPage tabMenuPrincipal;
        private System.Windows.Forms.TabPage tabAltaVehiculos;
        private System.Windows.Forms.TabPage tabEliminarVehiculos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox logoTesla;
        private System.Windows.Forms.PictureBox logoSpaceX;
        private System.Windows.Forms.Button btnAltaMenuPrincipal;
        private System.Windows.Forms.RadioButton radiobtnAltaOpcionSpaceX;
        private System.Windows.Forms.RadioButton radiobtnAltaOpcionTesla;
        private System.Windows.Forms.Label labelAltaTipoVehiculo;
        private System.Windows.Forms.TabControl listaTabsAlta;
        private System.Windows.Forms.TabPage tabAltaTesla;
        private System.Windows.Forms.TabPage tabAltaSpaceX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox dropDownModeloTesla;
        private System.Windows.Forms.Label labelModeloTesla;
        private System.Windows.Forms.Label labelDueñoTesla;
        private System.Windows.Forms.Label labelColorTesla;
        private System.Windows.Forms.Label labelKilometrajeTesla;
        private System.Windows.Forms.Label labelAñoTesla;
        private System.Windows.Forms.TextBox textBoxDueñoTesla;
        private System.Windows.Forms.TextBox textBoxColorTesla;
        private System.Windows.Forms.TextBox textBoxKilometrajeTesla;
        private System.Windows.Forms.TextBox textBoxAñoTesla;
        private System.Windows.Forms.TextBox textBoxEmpresaSpaceX;
        private System.Windows.Forms.TextBox textBoxColorSpaceX;
        private System.Windows.Forms.TextBox textBoxHorasSpaceX;
        private System.Windows.Forms.TextBox textBoxAñoSpaceX;
        private System.Windows.Forms.ComboBox dropDownModeloSpaceX;
        private System.Windows.Forms.Label labelModeloSpaceX;
        private System.Windows.Forms.Label labelEmpresaSpaceX;
        private System.Windows.Forms.Label labelColorSpaceX;
        private System.Windows.Forms.Label labelHorasSpaceX;
        private System.Windows.Forms.Label labelAñoSpaceX;
        private System.Windows.Forms.Button btnAltaTeslaLimpiar;
        private System.Windows.Forms.Button btnAltaTeslaGuardar;
        private System.Windows.Forms.Button btnAltaSpaceXLimpiar;
        private System.Windows.Forms.Button btnAltaSpaceXGuardar;
    }
}

