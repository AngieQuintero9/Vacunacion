namespace Vacunacion
{
    partial class DatosPaciente
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosPaciente));
            btnCancelar = new Button();
            btnGuardar = new Button();
            erpMensaje = new ErrorProvider(components);
            ttMensaje = new ToolTip(components);
            tbDatosNacimiento = new TabPage();
            gbDatosNacimiento = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            lblLactanciaExclusiva = new Label();
            txtEdadGestacional = new TextBox();
            lblEdadGestacional = new Label();
            cboMunicipioNacimiento = new ComboBox();
            lblMunicipioNacimiento = new Label();
            lblLugarAtencionParto = new Label();
            cboLugarAtencionParto = new ComboBox();
            lblDepartamentoNacimiento = new Label();
            cboDepartamentoNacimiento = new ComboBox();
            lblPesoNacer = new Label();
            txtPesoNacer = new TextBox();
            lblTallaNacer = new Label();
            txtTallaNacer = new TextBox();
            tbDatosContacto = new TabPage();
            gbDatosContacto = new GroupBox();
            cboMunicipio = new ComboBox();
            lblMunicipio = new Label();
            label2 = new Label();
            cboCiudad = new ComboBox();
            lblDepartamento = new Label();
            cboDepartamento = new ComboBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblCelular = new Label();
            txtCelular = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            tbDatosBasicos = new TabPage();
            rdbMasculino = new RadioButton();
            rdbFemenino = new RadioButton();
            rdbNoBinario = new RadioButton();
            cboEPS = new ComboBox();
            lblEPS = new Label();
            lblSexo = new Label();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            cboTiposDocumento = new ComboBox();
            lblTiposDocumento = new Label();
            txtNumeroDocumento = new TextBox();
            label1 = new Label();
            gbDatosBasicos = new GroupBox();
            txtSegundoApellido = new TextBox();
            lblSegundoApellido = new Label();
            txtPrimerApellido = new TextBox();
            lblPrimerApellido = new Label();
            txtSegundoNombre = new TextBox();
            lblSegundoNombre = new Label();
            txtPrimerNombre = new TextBox();
            lblPrimerNombre = new Label();
            tbDatosPaciente = new TabControl();
            lblRegimenAfiliacion = new Label();
            cboRegimenAfiliacion = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)erpMensaje).BeginInit();
            tbDatosNacimiento.SuspendLayout();
            gbDatosNacimiento.SuspendLayout();
            tbDatosContacto.SuspendLayout();
            gbDatosContacto.SuspendLayout();
            tbDatosBasicos.SuspendLayout();
            gbDatosBasicos.SuspendLayout();
            tbDatosPaciente.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 255);
            btnCancelar.Dock = DockStyle.Bottom;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCancelar.Location = new Point(0, 489);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(740, 37);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 255, 255);
            btnGuardar.Dock = DockStyle.Bottom;
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGuardar.Location = new Point(0, 526);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(740, 33);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // erpMensaje
            // 
            erpMensaje.ContainerControl = this;
            // 
            // tbDatosNacimiento
            // 
            tbDatosNacimiento.BackColor = Color.FromArgb(255, 192, 255);
            tbDatosNacimiento.Controls.Add(gbDatosNacimiento);
            tbDatosNacimiento.Location = new Point(4, 26);
            tbDatosNacimiento.Name = "tbDatosNacimiento";
            tbDatosNacimiento.Padding = new Padding(3);
            tbDatosNacimiento.Size = new Size(706, 396);
            tbDatosNacimiento.TabIndex = 2;
            tbDatosNacimiento.Text = "Datos de Nacimiento";
            // 
            // gbDatosNacimiento
            // 
            gbDatosNacimiento.BackColor = Color.FromArgb(255, 192, 255);
            gbDatosNacimiento.Controls.Add(checkBox2);
            gbDatosNacimiento.Controls.Add(checkBox1);
            gbDatosNacimiento.Controls.Add(lblLactanciaExclusiva);
            gbDatosNacimiento.Controls.Add(txtEdadGestacional);
            gbDatosNacimiento.Controls.Add(lblEdadGestacional);
            gbDatosNacimiento.Controls.Add(cboMunicipioNacimiento);
            gbDatosNacimiento.Controls.Add(lblMunicipioNacimiento);
            gbDatosNacimiento.Controls.Add(lblLugarAtencionParto);
            gbDatosNacimiento.Controls.Add(cboLugarAtencionParto);
            gbDatosNacimiento.Controls.Add(lblDepartamentoNacimiento);
            gbDatosNacimiento.Controls.Add(cboDepartamentoNacimiento);
            gbDatosNacimiento.Controls.Add(lblPesoNacer);
            gbDatosNacimiento.Controls.Add(txtPesoNacer);
            gbDatosNacimiento.Controls.Add(lblTallaNacer);
            gbDatosNacimiento.Controls.Add(txtTallaNacer);
            gbDatosNacimiento.Location = new Point(40, 41);
            gbDatosNacimiento.Name = "gbDatosNacimiento";
            gbDatosNacimiento.Size = new Size(692, 379);
            gbDatosNacimiento.TabIndex = 1;
            gbDatosNacimiento.TabStop = false;
            gbDatosNacimiento.Text = "Datos de Nacimiento";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(334, 329);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(44, 21);
            checkBox2.TabIndex = 16;
            checkBox2.Text = "No";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(282, 329);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(36, 21);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Si";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblLactanciaExclusiva
            // 
            lblLactanciaExclusiva.AutoSize = true;
            lblLactanciaExclusiva.Location = new Point(12, 330);
            lblLactanciaExclusiva.Name = "lblLactanciaExclusiva";
            lblLactanciaExclusiva.Size = new Size(255, 17);
            lblLactanciaExclusiva.TabIndex = 14;
            lblLactanciaExclusiva.Text = "Lactancia Materna Exclusiva (hasta 6 meses)";
            // 
            // txtEdadGestacional
            // 
            txtEdadGestacional.Location = new Point(187, 278);
            txtEdadGestacional.Name = "txtEdadGestacional";
            txtEdadGestacional.Size = new Size(446, 25);
            txtEdadGestacional.TabIndex = 13;
            // 
            // lblEdadGestacional
            // 
            lblEdadGestacional.AutoSize = true;
            lblEdadGestacional.Location = new Point(15, 287);
            lblEdadGestacional.Name = "lblEdadGestacional";
            lblEdadGestacional.Size = new Size(160, 17);
            lblEdadGestacional.TabIndex = 12;
            lblEdadGestacional.Text = "Edad Gestacional(Semanas)";
            // 
            // cboMunicipioNacimiento
            // 
            cboMunicipioNacimiento.FormattingEnabled = true;
            cboMunicipioNacimiento.Items.AddRange(new object[] { "Leticia", "Medellín", "Arauca", "Barranquilla", "Bogotá", "Cartagena de Indias", "Tunja", "Manizales", "Florencia", "Yopal", "Popayán", "Valledupar", "Quibdó", "Montería", "Bogotá", "Inírida", "San José del Guaviare", "Neiva", "Riohacha", "Santa Marta", "Villavicencio", "Pasto", "San José de Cúcuta", "Mocoa", "Armenia", "Pereira", "San Andrés", "Bucaramanga", "Sincelejo", "Ibagué", "Cali", "Mitú", "Puerto Carreño" });
            cboMunicipioNacimiento.Location = new Point(187, 91);
            cboMunicipioNacimiento.Name = "cboMunicipioNacimiento";
            cboMunicipioNacimiento.Size = new Size(441, 25);
            cboMunicipioNacimiento.TabIndex = 11;
            // 
            // lblMunicipioNacimiento
            // 
            lblMunicipioNacimiento.AutoSize = true;
            lblMunicipioNacimiento.Location = new Point(13, 94);
            lblMunicipioNacimiento.Name = "lblMunicipioNacimiento";
            lblMunicipioNacimiento.Size = new Size(147, 17);
            lblMunicipioNacimiento.TabIndex = 10;
            lblMunicipioNacimiento.Text = "Municipio de Nacimiento";
            // 
            // lblLugarAtencionParto
            // 
            lblLugarAtencionParto.AutoSize = true;
            lblLugarAtencionParto.Location = new Point(13, 145);
            lblLugarAtencionParto.Name = "lblLugarAtencionParto";
            lblLugarAtencionParto.Size = new Size(146, 17);
            lblLugarAtencionParto.TabIndex = 6;
            lblLugarAtencionParto.Text = "Lugar Atención del Parto";
            // 
            // cboLugarAtencionParto
            // 
            cboLugarAtencionParto.FormattingEnabled = true;
            cboLugarAtencionParto.Items.AddRange(new object[] { "Hospital", "Clínica", "En casa" });
            cboLugarAtencionParto.Location = new Point(187, 142);
            cboLugarAtencionParto.Name = "cboLugarAtencionParto";
            cboLugarAtencionParto.Size = new Size(441, 25);
            cboLugarAtencionParto.TabIndex = 7;
            // 
            // lblDepartamentoNacimiento
            // 
            lblDepartamentoNacimiento.AutoSize = true;
            lblDepartamentoNacimiento.Location = new Point(12, 48);
            lblDepartamentoNacimiento.Name = "lblDepartamentoNacimiento";
            lblDepartamentoNacimiento.Size = new Size(173, 17);
            lblDepartamentoNacimiento.TabIndex = 4;
            lblDepartamentoNacimiento.Text = "Departamento de Nacimiento";
            // 
            // cboDepartamentoNacimiento
            // 
            cboDepartamentoNacimiento.FormattingEnabled = true;
            cboDepartamentoNacimiento.Items.AddRange(new object[] { "Amazonas", "Antioquia", "Arauca", "Atlántico", "Bogotá", "Bolívar", "Boyacá", "Caldas", "Caquetá", "Casanare", "Cauca", "Cesar", "Chocó", "Córdoba", "Cundinamarca", "Guainía", "Guaviare", "Huila", "La Guajira", "Magdalena", "Meta", "Nariño", "Norte de Santander", "Putumayo", "Quindío", "Risaralda", "San Andrés y Providencia", "Santander", "Sucre", "Tolima", "Valle del Cauca", "Vaupés", "Vichada" });
            cboDepartamentoNacimiento.Location = new Point(187, 39);
            cboDepartamentoNacimiento.Name = "cboDepartamentoNacimiento";
            cboDepartamentoNacimiento.Size = new Size(441, 25);
            cboDepartamentoNacimiento.TabIndex = 5;
            // 
            // lblPesoNacer
            // 
            lblPesoNacer.AutoSize = true;
            lblPesoNacer.Location = new Point(13, 190);
            lblPesoNacer.Name = "lblPesoNacer";
            lblPesoNacer.Size = new Size(109, 17);
            lblPesoNacer.TabIndex = 8;
            lblPesoNacer.Text = "Peso al Nacer (gr)";
            // 
            // txtPesoNacer
            // 
            txtPesoNacer.Location = new Point(187, 187);
            txtPesoNacer.Name = "txtPesoNacer";
            txtPesoNacer.Size = new Size(446, 25);
            txtPesoNacer.TabIndex = 9;
            // 
            // lblTallaNacer
            // 
            lblTallaNacer.AutoSize = true;
            lblTallaNacer.Location = new Point(12, 240);
            lblTallaNacer.Name = "lblTallaNacer";
            lblTallaNacer.Size = new Size(116, 17);
            lblTallaNacer.TabIndex = 0;
            lblTallaNacer.Text = "Talla al Nacer (cm)";
            // 
            // txtTallaNacer
            // 
            txtTallaNacer.Location = new Point(187, 231);
            txtTallaNacer.Name = "txtTallaNacer";
            txtTallaNacer.Size = new Size(446, 25);
            txtTallaNacer.TabIndex = 1;
            // 
            // tbDatosContacto
            // 
            tbDatosContacto.BackColor = Color.FromArgb(255, 192, 255);
            tbDatosContacto.Controls.Add(gbDatosContacto);
            tbDatosContacto.Location = new Point(4, 26);
            tbDatosContacto.Name = "tbDatosContacto";
            tbDatosContacto.Padding = new Padding(3);
            tbDatosContacto.Size = new Size(706, 396);
            tbDatosContacto.TabIndex = 1;
            tbDatosContacto.Text = "Datos de Contacto";
            // 
            // gbDatosContacto
            // 
            gbDatosContacto.Controls.Add(cboMunicipio);
            gbDatosContacto.Controls.Add(lblMunicipio);
            gbDatosContacto.Controls.Add(label2);
            gbDatosContacto.Controls.Add(cboCiudad);
            gbDatosContacto.Controls.Add(lblDepartamento);
            gbDatosContacto.Controls.Add(cboDepartamento);
            gbDatosContacto.Controls.Add(lblDireccion);
            gbDatosContacto.Controls.Add(txtDireccion);
            gbDatosContacto.Controls.Add(lblCelular);
            gbDatosContacto.Controls.Add(txtCelular);
            gbDatosContacto.Controls.Add(lblTelefono);
            gbDatosContacto.Controls.Add(txtTelefono);
            gbDatosContacto.Location = new Point(21, 20);
            gbDatosContacto.Name = "gbDatosContacto";
            gbDatosContacto.Size = new Size(692, 343);
            gbDatosContacto.TabIndex = 0;
            gbDatosContacto.TabStop = false;
            gbDatosContacto.Text = "Datos de Contacto";
            // 
            // cboMunicipio
            // 
            cboMunicipio.FormattingEnabled = true;
            cboMunicipio.Items.AddRange(new object[] { "Leticia", "Medellín", "Arauca", "Barranquilla", "Bogotá", "Cartagena de Indias", "Tunja", "Manizales", "Florencia", "Yopal", "Popayán", "Valledupar", "Quibdó", "Montería", "Bogotá", "Inírida", "San José del Guaviare", "Neiva", "Riohacha", "Santa Marta", "Villavicencio", "Pasto", "San José de Cúcuta", "Mocoa", "Armenia", "Pereira", "San Andrés", "Bucaramanga", "Sincelejo", "Ibagué", "Cali", "Mitú", "Puerto Carreño" });
            cboMunicipio.Location = new Point(187, 190);
            cboMunicipio.Name = "cboMunicipio";
            cboMunicipio.Size = new Size(362, 25);
            cboMunicipio.TabIndex = 11;
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Location = new Point(13, 199);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(62, 17);
            lblMunicipio.TabIndex = 10;
            lblMunicipio.Text = "Municipio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 244);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 6;
            label2.Text = "Ciudad";
            // 
            // cboCiudad
            // 
            cboCiudad.FormattingEnabled = true;
            cboCiudad.Items.AddRange(new object[] { "Bogotá", "Medellín", "Cartagena", "Cali", "Santa Marta", "Barranquilla ", "Villavicencio", "San Gil ", "Bucaramanga" });
            cboCiudad.Location = new Point(187, 235);
            cboCiudad.Name = "cboCiudad";
            cboCiudad.Size = new Size(362, 25);
            cboCiudad.TabIndex = 7;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(13, 156);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(88, 17);
            lblDepartamento.TabIndex = 4;
            lblDepartamento.Text = "Departamento";
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Items.AddRange(new object[] { "Amazonas", "Antioquia", "Arauca", "Atlántico", "Bogotá", "Bolívar", "Boyacá", "Caldas", "Caquetá", "Casanare", "Cauca", "Cesar", "Chocó", "Córdoba", "Cundinamarca", "Guainía", "Guaviare", "Huila", "La Guajira", "Magdalena", "Meta", "Nariño", "Norte de Santander", "Putumayo", "Quindío", "Risaralda", "San Andrés y Providencia", "Santander", "Sucre", "Tolima", "Valle del Cauca", "Vaupés", "Vichada" });
            cboDepartamento.Location = new Point(187, 147);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(362, 25);
            cboDepartamento.TabIndex = 5;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(13, 286);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 17);
            lblDireccion.TabIndex = 8;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(187, 277);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(362, 25);
            txtDireccion.TabIndex = 9;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(13, 107);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(47, 17);
            lblCelular.TabIndex = 2;
            lblCelular.Text = "Celular";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(187, 97);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(362, 25);
            txtCelular.TabIndex = 3;
            txtCelular.Validating += txtCelular_Validating;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(13, 53);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 17);
            lblTelefono.TabIndex = 0;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(187, 53);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(362, 25);
            txtTelefono.TabIndex = 1;
            txtTelefono.Validating += txtTelefono_Validating;
            // 
            // tbDatosBasicos
            // 
            tbDatosBasicos.BackColor = Color.FromArgb(255, 192, 255);
            tbDatosBasicos.Controls.Add(gbDatosBasicos);
            tbDatosBasicos.Location = new Point(4, 26);
            tbDatosBasicos.Name = "tbDatosBasicos";
            tbDatosBasicos.Padding = new Padding(3);
            tbDatosBasicos.Size = new Size(706, 412);
            tbDatosBasicos.TabIndex = 0;
            tbDatosBasicos.Text = "Datos Básicos";
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(187, 263);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(82, 21);
            rdbMasculino.TabIndex = 7;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.Location = new Point(275, 263);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(79, 21);
            rdbFemenino.TabIndex = 8;
            rdbFemenino.TabStop = true;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbNoBinario
            // 
            rdbNoBinario.AutoSize = true;
            rdbNoBinario.Location = new Point(360, 265);
            rdbNoBinario.Name = "rdbNoBinario";
            rdbNoBinario.Size = new Size(86, 21);
            rdbNoBinario.TabIndex = 9;
            rdbNoBinario.TabStop = true;
            rdbNoBinario.Text = "No Binario";
            rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // cboEPS
            // 
            cboEPS.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEPS.FormattingEnabled = true;
            cboEPS.Items.AddRange(new object[] { "EPS SURA", "MEDICINA PREPAGADA", "NUEVA EPS", "PARTICULAR", "POLIZA", "SALUD TOTAL", "SAVIA SALUD" });
            cboEPS.Location = new Point(187, 296);
            cboEPS.Name = "cboEPS";
            cboEPS.Size = new Size(349, 25);
            cboEPS.Sorted = true;
            cboEPS.TabIndex = 18;
            // 
            // lblEPS
            // 
            lblEPS.AutoSize = true;
            lblEPS.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblEPS.Location = new Point(32, 304);
            lblEPS.Name = "lblEPS";
            lblEPS.Size = new Size(27, 17);
            lblEPS.TabIndex = 10;
            lblEPS.Text = "EPS";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblSexo.Location = new Point(32, 265);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(33, 17);
            lblSexo.TabIndex = 6;
            lblSexo.Text = "Sexo";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblFechaNacimiento.Location = new Point(32, 230);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(125, 17);
            lblFechaNacimiento.TabIndex = 4;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CustomFormat = "dd/mm/yyyy";
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.Location = new Point(188, 222);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(348, 25);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // cboTiposDocumento
            // 
            cboTiposDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTiposDocumento.FormattingEnabled = true;
            cboTiposDocumento.Items.AddRange(new object[] { "Cédula de Ciudadanía", "Cédula de Extranjería", "Certificado de Nacido Vivo", "Pasaporte", "Permiso Especial de Permanencia", "Registro Civil de Nacimiento", "Tarjeta de Identidad" });
            cboTiposDocumento.Location = new Point(187, 160);
            cboTiposDocumento.Name = "cboTiposDocumento";
            cboTiposDocumento.Size = new Size(349, 25);
            cboTiposDocumento.Sorted = true;
            cboTiposDocumento.TabIndex = 1;
            // 
            // lblTiposDocumento
            // 
            lblTiposDocumento.AutoSize = true;
            lblTiposDocumento.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblTiposDocumento.Location = new Point(30, 168);
            lblTiposDocumento.Name = "lblTiposDocumento";
            lblTiposDocumento.Size = new Size(122, 17);
            lblTiposDocumento.TabIndex = 0;
            lblTiposDocumento.Text = "Tipos de Documento";
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(188, 191);
            txtNumeroDocumento.MaxLength = 20;
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(348, 25);
            txtNumeroDocumento.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(30, 199);
            label1.Name = "label1";
            label1.Size = new Size(142, 17);
            label1.TabIndex = 2;
            label1.Text = "Número del Documento";
            // 
            // gbDatosBasicos
            // 
            gbDatosBasicos.BackColor = Color.FromArgb(255, 192, 255);
            gbDatosBasicos.Controls.Add(cboRegimenAfiliacion);
            gbDatosBasicos.Controls.Add(lblRegimenAfiliacion);
            gbDatosBasicos.Controls.Add(txtSegundoApellido);
            gbDatosBasicos.Controls.Add(cboEPS);
            gbDatosBasicos.Controls.Add(rdbNoBinario);
            gbDatosBasicos.Controls.Add(rdbFemenino);
            gbDatosBasicos.Controls.Add(lblEPS);
            gbDatosBasicos.Controls.Add(rdbMasculino);
            gbDatosBasicos.Controls.Add(lblSegundoApellido);
            gbDatosBasicos.Controls.Add(txtPrimerApellido);
            gbDatosBasicos.Controls.Add(lblPrimerApellido);
            gbDatosBasicos.Controls.Add(txtSegundoNombre);
            gbDatosBasicos.Controls.Add(lblSegundoNombre);
            gbDatosBasicos.Controls.Add(txtPrimerNombre);
            gbDatosBasicos.Controls.Add(lblSexo);
            gbDatosBasicos.Controls.Add(lblPrimerNombre);
            gbDatosBasicos.Controls.Add(dtpFechaNacimiento);
            gbDatosBasicos.Controls.Add(lblFechaNacimiento);
            gbDatosBasicos.Controls.Add(lblTiposDocumento);
            gbDatosBasicos.Controls.Add(cboTiposDocumento);
            gbDatosBasicos.Controls.Add(txtNumeroDocumento);
            gbDatosBasicos.Controls.Add(label1);
            gbDatosBasicos.Location = new Point(31, 25);
            gbDatosBasicos.Name = "gbDatosBasicos";
            gbDatosBasicos.Size = new Size(642, 358);
            gbDatosBasicos.TabIndex = 0;
            gbDatosBasicos.TabStop = false;
            gbDatosBasicos.Text = "Datos básicos";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(187, 129);
            txtSegundoApellido.MaxLength = 100;
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(349, 25);
            txtSegundoApellido.TabIndex = 7;
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblSegundoApellido.Location = new Point(30, 137);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(103, 17);
            lblSegundoApellido.TabIndex = 6;
            lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(187, 98);
            txtPrimerApellido.MaxLength = 100;
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(349, 25);
            txtPrimerApellido.TabIndex = 5;
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblPrimerApellido.Location = new Point(32, 106);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(93, 17);
            lblPrimerApellido.TabIndex = 4;
            lblPrimerApellido.Text = "Primer Apellido";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(187, 67);
            txtSegundoNombre.MaxLength = 100;
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(349, 25);
            txtSegundoNombre.TabIndex = 3;
            // 
            // lblSegundoNombre
            // 
            lblSegundoNombre.AutoSize = true;
            lblSegundoNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblSegundoNombre.Location = new Point(32, 75);
            lblSegundoNombre.Name = "lblSegundoNombre";
            lblSegundoNombre.Size = new Size(105, 17);
            lblSegundoNombre.TabIndex = 2;
            lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(187, 36);
            txtPrimerNombre.MaxLength = 100;
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(349, 25);
            txtPrimerNombre.TabIndex = 1;
            txtPrimerNombre.KeyPress += txtPrimerNombre_KeyPress_1;
            // 
            // lblPrimerNombre
            // 
            lblPrimerNombre.AutoSize = true;
            lblPrimerNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblPrimerNombre.Location = new Point(32, 44);
            lblPrimerNombre.Name = "lblPrimerNombre";
            lblPrimerNombre.Size = new Size(95, 17);
            lblPrimerNombre.TabIndex = 0;
            lblPrimerNombre.Text = "Primer Nombre";
            // 
            // tbDatosPaciente
            // 
            tbDatosPaciente.Controls.Add(tbDatosBasicos);
            tbDatosPaciente.Controls.Add(tbDatosContacto);
            tbDatosPaciente.Controls.Add(tbDatosNacimiento);
            tbDatosPaciente.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            tbDatosPaciente.Location = new Point(12, 12);
            tbDatosPaciente.Name = "tbDatosPaciente";
            tbDatosPaciente.SelectedIndex = 0;
            tbDatosPaciente.Size = new Size(714, 442);
            tbDatosPaciente.TabIndex = 0;
            // 
            // lblRegimenAfiliacion
            // 
            lblRegimenAfiliacion.AutoSize = true;
            lblRegimenAfiliacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblRegimenAfiliacion.Location = new Point(32, 338);
            lblRegimenAfiliacion.Name = "lblRegimenAfiliacion";
            lblRegimenAfiliacion.Size = new Size(111, 17);
            lblRegimenAfiliacion.TabIndex = 19;
            lblRegimenAfiliacion.Text = "Régimen Afiliación";
            // 
            // cboRegimenAfiliacion
            // 
            cboRegimenAfiliacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRegimenAfiliacion.FormattingEnabled = true;
            cboRegimenAfiliacion.Items.AddRange(new object[] { "EPS SURA", "MEDICINA PREPAGADA", "NUEVA EPS", "PARTICULAR", "POLIZA", "SALUD TOTAL", "SAVIA SALUD" });
            cboRegimenAfiliacion.Location = new Point(187, 330);
            cboRegimenAfiliacion.Name = "cboRegimenAfiliacion";
            cboRegimenAfiliacion.Size = new Size(349, 25);
            cboRegimenAfiliacion.Sorted = true;
            cboRegimenAfiliacion.TabIndex = 19;
            // 
            // DatosPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(740, 559);
            Controls.Add(tbDatosPaciente);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DatosPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos Paciente";
            ((System.ComponentModel.ISupportInitialize)erpMensaje).EndInit();
            tbDatosNacimiento.ResumeLayout(false);
            gbDatosNacimiento.ResumeLayout(false);
            gbDatosNacimiento.PerformLayout();
            tbDatosContacto.ResumeLayout(false);
            gbDatosContacto.ResumeLayout(false);
            gbDatosContacto.PerformLayout();
            tbDatosBasicos.ResumeLayout(false);
            gbDatosBasicos.ResumeLayout(false);
            gbDatosBasicos.PerformLayout();
            tbDatosPaciente.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnCancelar;
        private Button btnGuardar;
        private ErrorProvider erpMensaje;
        private ToolTip ttMensaje;
        private TabControl tbDatosPaciente;
        private TabPage tbDatosBasicos;
        private RadioButton rdbMasculino;
        private RadioButton rdbFemenino;
        private RadioButton rdbNoBinario;
        private ComboBox cboEPS;
        private Label lblEPS;
        private Label lblSexo;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cboTiposDocumento;
        private Label lblTiposDocumento;
        private TextBox txtNumeroDocumento;
        private Label label1;
        private GroupBox gbDatosBasicos;
        private TextBox txtSegundoApellido;
        private Label lblSegundoApellido;
        private TextBox txtPrimerApellido;
        private Label lblPrimerApellido;
        private TextBox txtSegundoNombre;
        private Label lblSegundoNombre;
        private TextBox txtPrimerNombre;
        private Label lblPrimerNombre;
        private TabPage tbDatosContacto;
        private GroupBox gbDatosContacto;
        private ComboBox cboMunicipio;
        private Label lblMunicipio;
        private Label label2;
        private ComboBox cboCiudad;
        private Label lblDepartamento;
        private ComboBox cboDepartamento;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblCelular;
        private TextBox txtCelular;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private TabPage tbDatosNacimiento;
        private GroupBox gbDatosNacimiento;
        private TextBox txtEdadGestacional;
        private Label lblEdadGestacional;
        private ComboBox cboMunicipioNacimiento;
        private Label lblMunicipioNacimiento;
        private Label lblLugarAtencionParto;
        private ComboBox cboLugarAtencionParto;
        private Label lblDepartamentoNacimiento;
        private ComboBox cboDepartamentoNacimiento;
        private Label lblPesoNacer;
        private TextBox txtPesoNacer;
        private Label lblTallaNacer;
        private TextBox txtTallaNacer;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label lblLactanciaExclusiva;
        private ComboBox cboRegimenAfiliacion;
        private Label lblRegimenAfiliacion;
    }
}