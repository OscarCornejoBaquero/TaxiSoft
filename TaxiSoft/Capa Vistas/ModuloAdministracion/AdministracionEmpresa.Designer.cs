
namespace Capa_Vistas.ModuloAdministracion
{
    partial class AdministracionEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionEmpresa));
            this.label1 = new System.Windows.Forms.Label();
            this.tblEmpresa = new System.Windows.Forms.TabControl();
            this.tpEmpresa = new System.Windows.Forms.TabPage();
            this.chActivarDatos = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbCiudadEmpresa = new System.Windows.Forms.ComboBox();
            this.cmbProvinciaEMpresa = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnActualizarEmpresa = new System.Windows.Forms.Button();
            this.btnGuardarEmpresa = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpPropietario = new System.Windows.Forms.TabPage();
            this.ckbFotoPro = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.btnFotoPro = new System.Windows.Forms.Button();
            this.chActivarEdicionPro = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbNacionalidadPro = new System.Windows.Forms.ComboBox();
            this.cmbSexoPro = new System.Windows.Forms.ComboBox();
            this.cmbCiudadesPro = new System.Windows.Forms.ComboBox();
            this.cmbProvinciasPro = new System.Windows.Forms.ComboBox();
            this.dtpFechaNaciPro = new System.Windows.Forms.DateTimePicker();
            this.txtCorreoPro = new System.Windows.Forms.TextBox();
            this.txtTelefonoPro = new System.Windows.Forms.TextBox();
            this.txtDireccionPro = new System.Windows.Forms.TextBox();
            this.txtNombresPro = new System.Windows.Forms.TextBox();
            this.txtCedulaPro = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.pbFotoPro = new System.Windows.Forms.PictureBox();
            this.btnModificarPro = new System.Windows.Forms.Button();
            this.btnGuardarPro = new System.Windows.Forms.Button();
            this.Iconos = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.DialogoFoto = new System.Windows.Forms.OpenFileDialog();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.tblEmpresa.SuspendLayout();
            this.tpEmpresa.SuspendLayout();
            this.tpPropietario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPro)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Administración de la Empresa";
            // 
            // tblEmpresa
            // 
            this.tblEmpresa.Controls.Add(this.tpEmpresa);
            this.tblEmpresa.Controls.Add(this.tpPropietario);
            this.tblEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEmpresa.ImageList = this.Iconos;
            this.tblEmpresa.ItemSize = new System.Drawing.Size(90, 50);
            this.tblEmpresa.Location = new System.Drawing.Point(0, 0);
            this.tblEmpresa.Name = "tblEmpresa";
            this.tblEmpresa.SelectedIndex = 0;
            this.tblEmpresa.Size = new System.Drawing.Size(1030, 522);
            this.tblEmpresa.TabIndex = 5;
            // 
            // tpEmpresa
            // 
            this.tpEmpresa.Controls.Add(this.chActivarDatos);
            this.tpEmpresa.Controls.Add(this.label12);
            this.tpEmpresa.Controls.Add(this.cmbCiudadEmpresa);
            this.tpEmpresa.Controls.Add(this.cmbProvinciaEMpresa);
            this.tpEmpresa.Controls.Add(this.label10);
            this.tpEmpresa.Controls.Add(this.label9);
            this.tpEmpresa.Controls.Add(this.dtFechaInicio);
            this.tpEmpresa.Controls.Add(this.btnActualizarEmpresa);
            this.tpEmpresa.Controls.Add(this.btnGuardarEmpresa);
            this.tpEmpresa.Controls.Add(this.txtCorreo);
            this.tpEmpresa.Controls.Add(this.txtTelefono);
            this.tpEmpresa.Controls.Add(this.txtDireccion);
            this.tpEmpresa.Controls.Add(this.txtNombre);
            this.tpEmpresa.Controls.Add(this.txtRazonSocial);
            this.tpEmpresa.Controls.Add(this.txtRuc);
            this.tpEmpresa.Controls.Add(this.label8);
            this.tpEmpresa.Controls.Add(this.label7);
            this.tpEmpresa.Controls.Add(this.label6);
            this.tpEmpresa.Controls.Add(this.label11);
            this.tpEmpresa.Controls.Add(this.label5);
            this.tpEmpresa.Controls.Add(this.label4);
            this.tpEmpresa.Controls.Add(this.label3);
            this.tpEmpresa.Controls.Add(this.label2);
            this.tpEmpresa.ImageIndex = 0;
            this.tpEmpresa.Location = new System.Drawing.Point(4, 54);
            this.tpEmpresa.Name = "tpEmpresa";
            this.tpEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmpresa.Size = new System.Drawing.Size(1022, 464);
            this.tpEmpresa.TabIndex = 0;
            this.tpEmpresa.Text = "Datos de la Empresa";
            this.tpEmpresa.UseVisualStyleBackColor = true;
            // 
            // chActivarDatos
            // 
            this.chActivarDatos.AutoSize = true;
            this.chActivarDatos.Location = new System.Drawing.Point(389, 412);
            this.chActivarDatos.Name = "chActivarDatos";
            this.chActivarDatos.Size = new System.Drawing.Size(15, 14);
            this.chActivarDatos.TabIndex = 34;
            this.chActivarDatos.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(224, 412);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "ACTIVAR EDICIÓN DE DATOS";
            // 
            // cmbCiudadEmpresa
            // 
            this.cmbCiudadEmpresa.FormattingEnabled = true;
            this.cmbCiudadEmpresa.Items.AddRange(new object[] {
            "Prueba2",
            "Prueba3"});
            this.cmbCiudadEmpresa.Location = new System.Drawing.Point(494, 232);
            this.cmbCiudadEmpresa.Name = "cmbCiudadEmpresa";
            this.cmbCiudadEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudadEmpresa.TabIndex = 30;
            // 
            // cmbProvinciaEMpresa
            // 
            this.cmbProvinciaEMpresa.FormattingEnabled = true;
            this.cmbProvinciaEMpresa.Items.AddRange(new object[] {
            "Prueba",
            "Prueba2"});
            this.cmbProvinciaEMpresa.Location = new System.Drawing.Point(286, 232);
            this.cmbProvinciaEMpresa.Name = "cmbProvinciaEMpresa";
            this.cmbProvinciaEMpresa.Size = new System.Drawing.Size(106, 21);
            this.cmbProvinciaEMpresa.TabIndex = 29;
            this.cmbProvinciaEMpresa.SelectedIndexChanged += new System.EventHandler(this.cmbProvinciaEMpresa_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = global::Capa_Vistas.Properties.Resources.map_16px;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(398, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 35;
            this.label10.Text = "CIUDAD:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::Capa_Vistas.Properties.Resources.map_16px;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(68, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "PROVINCIA:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(374, 264);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(241, 20);
            this.dtFechaInicio.TabIndex = 31;
            // 
            // btnActualizarEmpresa
            // 
            this.btnActualizarEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnActualizarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEmpresa.Image = global::Capa_Vistas.Properties.Resources.edit_property_30px;
            this.btnActualizarEmpresa.Location = new System.Drawing.Point(806, 235);
            this.btnActualizarEmpresa.Name = "btnActualizarEmpresa";
            this.btnActualizarEmpresa.Size = new System.Drawing.Size(146, 54);
            this.btnActualizarEmpresa.TabIndex = 36;
            this.btnActualizarEmpresa.Text = "Modificar Datos Empresa";
            this.btnActualizarEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarEmpresa.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEmpresa
            // 
            this.btnGuardarEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnGuardarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEmpresa.Image = global::Capa_Vistas.Properties.Resources.save_40px;
            this.btnGuardarEmpresa.Location = new System.Drawing.Point(806, 161);
            this.btnGuardarEmpresa.Name = "btnGuardarEmpresa";
            this.btnGuardarEmpresa.Size = new System.Drawing.Size(146, 54);
            this.btnGuardarEmpresa.TabIndex = 35;
            this.btnGuardarEmpresa.Text = "Guardar Datos Empresa";
            this.btnGuardarEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarEmpresa.UseVisualStyleBackColor = true;
            this.btnGuardarEmpresa.Click += new System.EventHandler(this.btnGuardarEmpresa_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(286, 344);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(330, 20);
            this.txtCorreo.TabIndex = 33;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(286, 301);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(330, 20);
            this.txtTelefono.TabIndex = 32;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(286, 195);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(329, 20);
            this.txtDireccion.TabIndex = 28;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(286, 161);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(329, 20);
            this.txtNombre.TabIndex = 27;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(286, 122);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(330, 20);
            this.txtRazonSocial.TabIndex = 26;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(286, 87);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(118, 20);
            this.txtRuc.TabIndex = 25;
            this.txtRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRuc_KeyPress);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::Capa_Vistas.Properties.Resources.calendar_16px;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(69, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(295, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "FECHA DE INICIO DE ACTIVIDADES:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::Capa_Vistas.Properties.Resources.email_16px;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(69, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "CORREO:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::Capa_Vistas.Properties.Resources.phone_16px;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(69, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "TELÉFONO:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = global::Capa_Vistas.Properties.Resources.name_16px;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(67, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "NOMBRE COMERCIAL:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::Capa_Vistas.Properties.Resources.address_16px;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(67, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "DIRECCIÓN:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::Capa_Vistas.Properties.Resources.name_16px;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(67, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "RAZÓN SOCIAL:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::Capa_Vistas.Properties.Resources.identity_theft_16px;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(67, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "RUC:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 39);
            this.label2.TabIndex = 17;
            this.label2.Text = "Datos Empresa";
            // 
            // tpPropietario
            // 
            this.tpPropietario.Controls.Add(this.ckbFotoPro);
            this.tpPropietario.Controls.Add(this.label16);
            this.tpPropietario.Controls.Add(this.label14);
            this.tpPropietario.Controls.Add(this.label15);
            this.tpPropietario.Controls.Add(this.label24);
            this.tpPropietario.Controls.Add(this.label25);
            this.tpPropietario.Controls.Add(this.label26);
            this.tpPropietario.Controls.Add(this.label27);
            this.tpPropietario.Controls.Add(this.label29);
            this.tpPropietario.Controls.Add(this.label30);
            this.tpPropietario.Controls.Add(this.label31);
            this.tpPropietario.Controls.Add(this.btnFotoPro);
            this.tpPropietario.Controls.Add(this.chActivarEdicionPro);
            this.tpPropietario.Controls.Add(this.label13);
            this.tpPropietario.Controls.Add(this.cmbNacionalidadPro);
            this.tpPropietario.Controls.Add(this.cmbSexoPro);
            this.tpPropietario.Controls.Add(this.cmbCiudadesPro);
            this.tpPropietario.Controls.Add(this.cmbProvinciasPro);
            this.tpPropietario.Controls.Add(this.dtpFechaNaciPro);
            this.tpPropietario.Controls.Add(this.txtCorreoPro);
            this.tpPropietario.Controls.Add(this.txtTelefonoPro);
            this.tpPropietario.Controls.Add(this.txtDireccionPro);
            this.tpPropietario.Controls.Add(this.txtNombresPro);
            this.tpPropietario.Controls.Add(this.txtCedulaPro);
            this.tpPropietario.Controls.Add(this.label23);
            this.tpPropietario.Controls.Add(this.pbFotoPro);
            this.tpPropietario.Controls.Add(this.btnModificarPro);
            this.tpPropietario.Controls.Add(this.btnGuardarPro);
            this.tpPropietario.ImageIndex = 1;
            this.tpPropietario.Location = new System.Drawing.Point(4, 54);
            this.tpPropietario.Name = "tpPropietario";
            this.tpPropietario.Padding = new System.Windows.Forms.Padding(3);
            this.tpPropietario.Size = new System.Drawing.Size(1022, 464);
            this.tpPropietario.TabIndex = 1;
            this.tpPropietario.Text = "Datos del Propietario ";
            this.tpPropietario.UseVisualStyleBackColor = true;
            // 
            // ckbFotoPro
            // 
            this.ckbFotoPro.AutoSize = true;
            this.ckbFotoPro.Location = new System.Drawing.Point(684, 280);
            this.ckbFotoPro.Name = "ckbFotoPro";
            this.ckbFotoPro.Size = new System.Drawing.Size(74, 17);
            this.ckbFotoPro.TabIndex = 73;
            this.ckbFotoPro.Text = "NO FOTO";
            this.ckbFotoPro.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Image = global::Capa_Vistas.Properties.Resources.map_16px;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(407, 295);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 19);
            this.label16.TabIndex = 72;
            this.label16.Text = "SEXO:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Image = global::Capa_Vistas.Properties.Resources.map_16px;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(407, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 19);
            this.label14.TabIndex = 72;
            this.label14.Text = "CIUDAD:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Image = global::Capa_Vistas.Properties.Resources.map_16px;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(52, 257);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 19);
            this.label15.TabIndex = 71;
            this.label15.Text = "NACIONALIDAD:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Image = global::Capa_Vistas.Properties.Resources.map_16px;
            this.label24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label24.Location = new System.Drawing.Point(51, 293);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(144, 19);
            this.label24.TabIndex = 71;
            this.label24.Text = "PROVINCIA:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Image = global::Capa_Vistas.Properties.Resources.calendar_16px;
            this.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label25.Location = new System.Drawing.Point(51, 217);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(228, 19);
            this.label25.TabIndex = 70;
            this.label25.Text = "FECHA DE NACIMIENTO:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Image = global::Capa_Vistas.Properties.Resources.email_16px;
            this.label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label26.Location = new System.Drawing.Point(57, 368);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(125, 19);
            this.label26.TabIndex = 69;
            this.label26.Text = "CORREO:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Image = global::Capa_Vistas.Properties.Resources.phone_16px;
            this.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label27.Location = new System.Drawing.Point(53, 331);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(140, 19);
            this.label27.TabIndex = 67;
            this.label27.Text = "TELÉFONO:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Image = global::Capa_Vistas.Properties.Resources.address_16px;
            this.label29.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label29.Location = new System.Drawing.Point(52, 182);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(147, 19);
            this.label29.TabIndex = 65;
            this.label29.Text = "DIRECCIÓN:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Image = global::Capa_Vistas.Properties.Resources.name_16px;
            this.label30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label30.Location = new System.Drawing.Point(54, 144);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(227, 19);
            this.label30.TabIndex = 64;
            this.label30.Text = "NOMBRES COMPLETOS:";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Image = global::Capa_Vistas.Properties.Resources.identity_theft_16px;
            this.label31.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label31.Location = new System.Drawing.Point(54, 110);
            this.label31.Name = "label31";
            this.label31.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label31.Size = new System.Drawing.Size(122, 19);
            this.label31.TabIndex = 68;
            this.label31.Text = "CEDULA:";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFotoPro
            // 
            this.btnFotoPro.Location = new System.Drawing.Point(684, 241);
            this.btnFotoPro.Name = "btnFotoPro";
            this.btnFotoPro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFotoPro.Size = new System.Drawing.Size(128, 23);
            this.btnFotoPro.TabIndex = 58;
            this.btnFotoPro.Text = "Cargar Foto";
            this.btnFotoPro.UseVisualStyleBackColor = true;
            this.btnFotoPro.Click += new System.EventHandler(this.btnFotoPro_Click);
            // 
            // chActivarEdicionPro
            // 
            this.chActivarEdicionPro.AutoSize = true;
            this.chActivarEdicionPro.Location = new System.Drawing.Point(831, 356);
            this.chActivarEdicionPro.Name = "chActivarEdicionPro";
            this.chActivarEdicionPro.Size = new System.Drawing.Size(15, 14);
            this.chActivarEdicionPro.TabIndex = 57;
            this.chActivarEdicionPro.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(666, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "ACTIVAR EDICIÓN DE DATOS";
            // 
            // cmbNacionalidadPro
            // 
            this.cmbNacionalidadPro.FormattingEnabled = true;
            this.cmbNacionalidadPro.Items.AddRange(new object[] {
            "Seleccione",
            "Ecuatoriana",
            "Otro"});
            this.cmbNacionalidadPro.Location = new System.Drawing.Point(291, 256);
            this.cmbNacionalidadPro.Name = "cmbNacionalidadPro";
            this.cmbNacionalidadPro.Size = new System.Drawing.Size(106, 21);
            this.cmbNacionalidadPro.TabIndex = 52;
            this.cmbNacionalidadPro.SelectedIndexChanged += new System.EventHandler(this.cmbNacionalidadPro_SelectedIndexChanged);
            // 
            // cmbSexoPro
            // 
            this.cmbSexoPro.FormattingEnabled = true;
            this.cmbSexoPro.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Sin datos"});
            this.cmbSexoPro.Location = new System.Drawing.Point(502, 294);
            this.cmbSexoPro.Name = "cmbSexoPro";
            this.cmbSexoPro.Size = new System.Drawing.Size(121, 21);
            this.cmbSexoPro.TabIndex = 53;
            // 
            // cmbCiudadesPro
            // 
            this.cmbCiudadesPro.FormattingEnabled = true;
            this.cmbCiudadesPro.Items.AddRange(new object[] {
            "sdsdsd",
            "rgrgrgrg"});
            this.cmbCiudadesPro.Location = new System.Drawing.Point(502, 258);
            this.cmbCiudadesPro.Name = "cmbCiudadesPro";
            this.cmbCiudadesPro.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudadesPro.TabIndex = 53;
            this.cmbCiudadesPro.SelectedIndexChanged += new System.EventHandler(this.cmbCiudadesPro_SelectedIndexChanged);
            // 
            // cmbProvinciasPro
            // 
            this.cmbProvinciasPro.FormattingEnabled = true;
            this.cmbProvinciasPro.Items.AddRange(new object[] {
            "Prue",
            "oeoe"});
            this.cmbProvinciasPro.Location = new System.Drawing.Point(290, 292);
            this.cmbProvinciasPro.Name = "cmbProvinciasPro";
            this.cmbProvinciasPro.Size = new System.Drawing.Size(106, 21);
            this.cmbProvinciasPro.TabIndex = 52;
            this.cmbProvinciasPro.SelectedIndexChanged += new System.EventHandler(this.cmbProvinciasPro_SelectedIndexChanged);
            // 
            // dtpFechaNaciPro
            // 
            this.dtpFechaNaciPro.Location = new System.Drawing.Point(294, 217);
            this.dtpFechaNaciPro.Name = "dtpFechaNaciPro";
            this.dtpFechaNaciPro.Size = new System.Drawing.Size(241, 20);
            this.dtpFechaNaciPro.TabIndex = 54;
            this.dtpFechaNaciPro.Value = new System.DateTime(1990, 1, 31, 0, 0, 0, 0);
            // 
            // txtCorreoPro
            // 
            this.txtCorreoPro.Location = new System.Drawing.Point(294, 367);
            this.txtCorreoPro.Name = "txtCorreoPro";
            this.txtCorreoPro.Size = new System.Drawing.Size(330, 20);
            this.txtCorreoPro.TabIndex = 56;
            // 
            // txtTelefonoPro
            // 
            this.txtTelefonoPro.Location = new System.Drawing.Point(294, 330);
            this.txtTelefonoPro.Name = "txtTelefonoPro";
            this.txtTelefonoPro.Size = new System.Drawing.Size(330, 20);
            this.txtTelefonoPro.TabIndex = 55;
            this.txtTelefonoPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoPro_KeyPress);
            // 
            // txtDireccionPro
            // 
            this.txtDireccionPro.Location = new System.Drawing.Point(294, 183);
            this.txtDireccionPro.Name = "txtDireccionPro";
            this.txtDireccionPro.Size = new System.Drawing.Size(329, 20);
            this.txtDireccionPro.TabIndex = 51;
            // 
            // txtNombresPro
            // 
            this.txtNombresPro.Location = new System.Drawing.Point(296, 144);
            this.txtNombresPro.Name = "txtNombresPro";
            this.txtNombresPro.Size = new System.Drawing.Size(330, 20);
            this.txtNombresPro.TabIndex = 49;
            // 
            // txtCedulaPro
            // 
            this.txtCedulaPro.Location = new System.Drawing.Point(296, 109);
            this.txtCedulaPro.Name = "txtCedulaPro";
            this.txtCedulaPro.Size = new System.Drawing.Size(175, 20);
            this.txtCedulaPro.TabIndex = 48;
            this.txtCedulaPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaPro_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(372, 33);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(372, 39);
            this.label23.TabIndex = 40;
            this.label23.Text = "Datos Propietario Empresa";
            // 
            // pbFotoPro
            // 
            this.pbFotoPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFotoPro.Location = new System.Drawing.Point(684, 96);
            this.pbFotoPro.Name = "pbFotoPro";
            this.pbFotoPro.Size = new System.Drawing.Size(128, 128);
            this.pbFotoPro.TabIndex = 63;
            this.pbFotoPro.TabStop = false;
            // 
            // btnModificarPro
            // 
            this.btnModificarPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnModificarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPro.Image = global::Capa_Vistas.Properties.Resources.edit_property_30px;
            this.btnModificarPro.Location = new System.Drawing.Point(859, 257);
            this.btnModificarPro.Name = "btnModificarPro";
            this.btnModificarPro.Size = new System.Drawing.Size(146, 54);
            this.btnModificarPro.TabIndex = 60;
            this.btnModificarPro.Text = "Modificar Datos Propietario";
            this.btnModificarPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarPro.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPro
            // 
            this.btnGuardarPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnGuardarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPro.Image = global::Capa_Vistas.Properties.Resources.save_40px;
            this.btnGuardarPro.Location = new System.Drawing.Point(859, 183);
            this.btnGuardarPro.Name = "btnGuardarPro";
            this.btnGuardarPro.Size = new System.Drawing.Size(146, 54);
            this.btnGuardarPro.TabIndex = 59;
            this.btnGuardarPro.Text = "Guardar Datos Propietario";
            this.btnGuardarPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarPro.UseVisualStyleBackColor = true;
            this.btnGuardarPro.Click += new System.EventHandler(this.btnGuardarPro_Click);
            // 
            // Iconos
            // 
            this.Iconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Iconos.ImageStream")));
            this.Iconos.TransparentColor = System.Drawing.Color.Transparent;
            this.Iconos.Images.SetKeyName(0, "business_building_100px.png");
            this.Iconos.Images.SetKeyName(1, "male_user_100px.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblEmpresa);
            this.panel1.Location = new System.Drawing.Point(2, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 522);
            this.panel1.TabIndex = 6;
            // 
            // DialogoFoto
            // 
            this.DialogoFoto.FileName = "DialogoFoto";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Capa_Vistas.Properties.Resources.icons8_close_window_26px;
            this.btnSalir.Location = new System.Drawing.Point(12, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 28);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // AdministracionEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1034, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministracionEmpresa";
            this.Text = "AdministracionEmpresa";
            this.tblEmpresa.ResumeLayout(false);
            this.tpEmpresa.ResumeLayout(false);
            this.tpEmpresa.PerformLayout();
            this.tpPropietario.ResumeLayout(false);
            this.tpPropietario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPro)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tblEmpresa;
        private System.Windows.Forms.TabPage tpEmpresa;
        private System.Windows.Forms.CheckBox chActivarDatos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbCiudadEmpresa;
        private System.Windows.Forms.ComboBox cmbProvinciaEMpresa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Button btnActualizarEmpresa;
        private System.Windows.Forms.Button btnGuardarEmpresa;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpPropietario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList Iconos;
        private System.Windows.Forms.Button btnFotoPro;
        private System.Windows.Forms.PictureBox pbFotoPro;
        private System.Windows.Forms.CheckBox chActivarEdicionPro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCiudadesPro;
        private System.Windows.Forms.ComboBox cmbProvinciasPro;
        private System.Windows.Forms.DateTimePicker dtpFechaNaciPro;
        private System.Windows.Forms.Button btnModificarPro;
        private System.Windows.Forms.Button btnGuardarPro;
        private System.Windows.Forms.TextBox txtCorreoPro;
        private System.Windows.Forms.TextBox txtTelefonoPro;
        private System.Windows.Forms.TextBox txtDireccionPro;
        private System.Windows.Forms.TextBox txtNombresPro;
        private System.Windows.Forms.TextBox txtCedulaPro;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.OpenFileDialog DialogoFoto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.CheckBox ckbFotoPro;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbNacionalidadPro;
        private System.Windows.Forms.ComboBox cmbSexoPro;
    }
}