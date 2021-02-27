
namespace Capa_Vistas.ModuloTaxis
{
    partial class AdministracionRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionRutas));
            this.label1 = new System.Windows.Forms.Label();
            this.tabRutasPrecios = new System.Windows.Forms.TabControl();
            this.tabRutas = new System.Windows.Forms.TabPage();
            this.panelGeneralRutas = new System.Windows.Forms.Panel();
            this.panelBotonesInferior = new System.Windows.Forms.Panel();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.dgvListaRutas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.tabAdminRutas = new System.Windows.Forms.TabPage();
            this.tabAdminDirecciones = new System.Windows.Forms.TabPage();
            this.IconosRutasPrecios = new System.Windows.Forms.ImageList(this.components);
            this.txtEditarRuta = new System.Windows.Forms.TextBox();
            this.panelControles = new System.Windows.Forms.Panel();
            this.panelAdministracion = new System.Windows.Forms.Panel();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.cmbInicioRuta = new System.Windows.Forms.ComboBox();
            this.cmbFinRuta = new System.Windows.Forms.ComboBox();
            this.txtParadasSectores = new System.Windows.Forms.TextBox();
            this.cmbParadaSector = new System.Windows.Forms.ComboBox();
            this.btnAgregarParada = new System.Windows.Forms.Button();
            this.panelBotonesPrecios = new System.Windows.Forms.Panel();
            this.panelContenedorPrecios = new System.Windows.Forms.Panel();
            this.panelInferiorPrecios = new System.Windows.Forms.Panel();
            this.txtDireccionRuta = new System.Windows.Forms.TextBox();
            this.cmbSectorRuta = new System.Windows.Forms.ComboBox();
            this.dgvListaPrecioRutas = new System.Windows.Forms.DataGridView();
            this.btnEditarRuta = new System.Windows.Forms.Button();
            this.btnListarRutas = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnGuardarRuta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargarRuta = new System.Windows.Forms.Button();
            this.btnModificarRuta = new System.Windows.Forms.Button();
            this.btnEliminarRuta = new System.Windows.Forms.Button();
            this.btnAgregarRuta = new System.Windows.Forms.Button();
            this.btnModificarDireccion = new System.Windows.Forms.Button();
            this.btnNuevaDireccion = new System.Windows.Forms.Button();
            this.btnAgregarDireccion = new System.Windows.Forms.Button();
            this.btnEliminarDireccion = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecioRuta = new System.Windows.Forms.TextBox();
            this.tabRutasPrecios.SuspendLayout();
            this.tabRutas.SuspendLayout();
            this.panelGeneralRutas.SuspendLayout();
            this.panelBotonesInferior.SuspendLayout();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRutas)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.tabAdminRutas.SuspendLayout();
            this.tabAdminDirecciones.SuspendLayout();
            this.panelControles.SuspendLayout();
            this.panelAdministracion.SuspendLayout();
            this.panelBotonesPrecios.SuspendLayout();
            this.panelContenedorPrecios.SuspendLayout();
            this.panelInferiorPrecios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPrecioRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1034, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rutas y Precios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabRutasPrecios
            // 
            this.tabRutasPrecios.Controls.Add(this.tabRutas);
            this.tabRutasPrecios.Controls.Add(this.tabAdminRutas);
            this.tabRutasPrecios.Controls.Add(this.tabAdminDirecciones);
            this.tabRutasPrecios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRutasPrecios.ImageList = this.IconosRutasPrecios;
            this.tabRutasPrecios.ItemSize = new System.Drawing.Size(90, 50);
            this.tabRutasPrecios.Location = new System.Drawing.Point(0, 33);
            this.tabRutasPrecios.Name = "tabRutasPrecios";
            this.tabRutasPrecios.SelectedIndex = 0;
            this.tabRutasPrecios.Size = new System.Drawing.Size(1034, 540);
            this.tabRutasPrecios.TabIndex = 6;
            // 
            // tabRutas
            // 
            this.tabRutas.Controls.Add(this.panelGeneralRutas);
            this.tabRutas.ImageIndex = 0;
            this.tabRutas.Location = new System.Drawing.Point(4, 54);
            this.tabRutas.Name = "tabRutas";
            this.tabRutas.Padding = new System.Windows.Forms.Padding(3);
            this.tabRutas.Size = new System.Drawing.Size(1026, 482);
            this.tabRutas.TabIndex = 0;
            this.tabRutas.Text = "Rutas";
            this.tabRutas.UseVisualStyleBackColor = true;
            // 
            // panelGeneralRutas
            // 
            this.panelGeneralRutas.Controls.Add(this.panelBotonesInferior);
            this.panelGeneralRutas.Controls.Add(this.panelTabla);
            this.panelGeneralRutas.Controls.Add(this.panelBotones);
            this.panelGeneralRutas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneralRutas.Location = new System.Drawing.Point(3, 3);
            this.panelGeneralRutas.Name = "panelGeneralRutas";
            this.panelGeneralRutas.Size = new System.Drawing.Size(1020, 476);
            this.panelGeneralRutas.TabIndex = 2;
            // 
            // panelBotonesInferior
            // 
            this.panelBotonesInferior.Controls.Add(this.txtEditarRuta);
            this.panelBotonesInferior.Controls.Add(this.btnEditarRuta);
            this.panelBotonesInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotonesInferior.Location = new System.Drawing.Point(0, 376);
            this.panelBotonesInferior.Name = "panelBotonesInferior";
            this.panelBotonesInferior.Size = new System.Drawing.Size(1020, 100);
            this.panelBotonesInferior.TabIndex = 7;
            // 
            // panelTabla
            // 
            this.panelTabla.Controls.Add(this.dgvListaRutas);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabla.Location = new System.Drawing.Point(0, 100);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(1020, 376);
            this.panelTabla.TabIndex = 6;
            // 
            // dgvListaRutas
            // 
            this.dgvListaRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaRutas.ColumnHeadersHeight = 33;
            this.dgvListaRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvListaRutas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaRutas.Location = new System.Drawing.Point(0, 0);
            this.dgvListaRutas.Name = "dgvListaRutas";
            this.dgvListaRutas.RowHeadersWidth = 55;
            this.dgvListaRutas.Size = new System.Drawing.Size(1020, 376);
            this.dgvListaRutas.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Ruta ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre de la Ruta ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Punto de Partida ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Punto de Llegada ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Recorrido de la Ruta ";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tarifa Base";
            this.Column6.Name = "Column6";
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelBotones.Controls.Add(this.btnListarRutas);
            this.panelBotones.Controls.Add(this.label2);
            this.panelBotones.Controls.Add(this.txtFiltrar);
            this.panelBotones.Controls.Add(this.btnFiltrar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(1020, 100);
            this.panelBotones.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Listas de Rutas ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(91, 59);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(174, 20);
            this.txtFiltrar.TabIndex = 0;
            // 
            // tabAdminRutas
            // 
            this.tabAdminRutas.Controls.Add(this.panelAdministracion);
            this.tabAdminRutas.Controls.Add(this.panelControles);
            this.tabAdminRutas.ImageIndex = 1;
            this.tabAdminRutas.Location = new System.Drawing.Point(4, 54);
            this.tabAdminRutas.Name = "tabAdminRutas";
            this.tabAdminRutas.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminRutas.Size = new System.Drawing.Size(1026, 482);
            this.tabAdminRutas.TabIndex = 1;
            this.tabAdminRutas.Text = "Administración de Rutas";
            this.tabAdminRutas.UseVisualStyleBackColor = true;
            // 
            // tabAdminDirecciones
            // 
            this.tabAdminDirecciones.Controls.Add(this.panelInferiorPrecios);
            this.tabAdminDirecciones.Controls.Add(this.panelContenedorPrecios);
            this.tabAdminDirecciones.Controls.Add(this.panelBotonesPrecios);
            this.tabAdminDirecciones.ImageIndex = 4;
            this.tabAdminDirecciones.Location = new System.Drawing.Point(4, 54);
            this.tabAdminDirecciones.Name = "tabAdminDirecciones";
            this.tabAdminDirecciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminDirecciones.Size = new System.Drawing.Size(1026, 482);
            this.tabAdminDirecciones.TabIndex = 3;
            this.tabAdminDirecciones.Text = "Administración de Direcciones de Ruta";
            this.tabAdminDirecciones.UseVisualStyleBackColor = true;
            // 
            // IconosRutasPrecios
            // 
            this.IconosRutasPrecios.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconosRutasPrecios.ImageStream")));
            this.IconosRutasPrecios.TransparentColor = System.Drawing.Color.Transparent;
            this.IconosRutasPrecios.Images.SetKeyName(0, "route_50px.png");
            this.IconosRutasPrecios.Images.SetKeyName(1, "route_64px.png");
            this.IconosRutasPrecios.Images.SetKeyName(2, "price_80px.png");
            this.IconosRutasPrecios.Images.SetKeyName(3, "expensive_price_32px.png");
            this.IconosRutasPrecios.Images.SetKeyName(4, "home_address_80px.png");
            // 
            // txtEditarRuta
            // 
            this.txtEditarRuta.Location = new System.Drawing.Point(29, 46);
            this.txtEditarRuta.Name = "txtEditarRuta";
            this.txtEditarRuta.Size = new System.Drawing.Size(174, 20);
            this.txtEditarRuta.TabIndex = 2;
            // 
            // panelControles
            // 
            this.panelControles.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelControles.Controls.Add(this.txtRuta);
            this.panelControles.Controls.Add(this.btnCargarRuta);
            this.panelControles.Controls.Add(this.btnModificarRuta);
            this.panelControles.Controls.Add(this.btnEliminarRuta);
            this.panelControles.Controls.Add(this.btnAgregarRuta);
            this.panelControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControles.Location = new System.Drawing.Point(3, 3);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(1020, 100);
            this.panelControles.TabIndex = 0;
            // 
            // panelAdministracion
            // 
            this.panelAdministracion.Controls.Add(this.txtPrecioRuta);
            this.panelAdministracion.Controls.Add(this.label10);
            this.panelAdministracion.Controls.Add(this.btnGuardarRuta);
            this.panelAdministracion.Controls.Add(this.btnAgregarParada);
            this.panelAdministracion.Controls.Add(this.txtParadasSectores);
            this.panelAdministracion.Controls.Add(this.label6);
            this.panelAdministracion.Controls.Add(this.cmbFinRuta);
            this.panelAdministracion.Controls.Add(this.label5);
            this.panelAdministracion.Controls.Add(this.cmbParadaSector);
            this.panelAdministracion.Controls.Add(this.cmbInicioRuta);
            this.panelAdministracion.Controls.Add(this.label7);
            this.panelAdministracion.Controls.Add(this.label4);
            this.panelAdministracion.Controls.Add(this.txtRuc);
            this.panelAdministracion.Controls.Add(this.label3);
            this.panelAdministracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdministracion.Location = new System.Drawing.Point(3, 103);
            this.panelAdministracion.Name = "panelAdministracion";
            this.panelAdministracion.Size = new System.Drawing.Size(1020, 376);
            this.panelAdministracion.TabIndex = 1;
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(685, 40);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(140, 20);
            this.txtRuta.TabIndex = 3;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(236, 49);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(598, 20);
            this.txtRuc.TabIndex = 48;
            // 
            // cmbInicioRuta
            // 
            this.cmbInicioRuta.FormattingEnabled = true;
            this.cmbInicioRuta.Location = new System.Drawing.Point(236, 94);
            this.cmbInicioRuta.Name = "cmbInicioRuta";
            this.cmbInicioRuta.Size = new System.Drawing.Size(184, 21);
            this.cmbInicioRuta.TabIndex = 50;
            // 
            // cmbFinRuta
            // 
            this.cmbFinRuta.FormattingEnabled = true;
            this.cmbFinRuta.Location = new System.Drawing.Point(598, 94);
            this.cmbFinRuta.Name = "cmbFinRuta";
            this.cmbFinRuta.Size = new System.Drawing.Size(184, 21);
            this.cmbFinRuta.TabIndex = 52;
            // 
            // txtParadasSectores
            // 
            this.txtParadasSectores.Location = new System.Drawing.Point(322, 250);
            this.txtParadasSectores.Name = "txtParadasSectores";
            this.txtParadasSectores.Size = new System.Drawing.Size(512, 20);
            this.txtParadasSectores.TabIndex = 54;
            // 
            // cmbParadaSector
            // 
            this.cmbParadaSector.FormattingEnabled = true;
            this.cmbParadaSector.Location = new System.Drawing.Point(390, 182);
            this.cmbParadaSector.Name = "cmbParadaSector";
            this.cmbParadaSector.Size = new System.Drawing.Size(184, 21);
            this.cmbParadaSector.TabIndex = 50;
            // 
            // btnAgregarParada
            // 
            this.btnAgregarParada.Location = new System.Drawing.Point(590, 182);
            this.btnAgregarParada.Name = "btnAgregarParada";
            this.btnAgregarParada.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarParada.TabIndex = 55;
            this.btnAgregarParada.Text = "Agregar";
            this.btnAgregarParada.UseVisualStyleBackColor = true;
            // 
            // panelBotonesPrecios
            // 
            this.panelBotonesPrecios.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelBotonesPrecios.Controls.Add(this.dgvListaPrecioRutas);
            this.panelBotonesPrecios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotonesPrecios.Location = new System.Drawing.Point(3, 3);
            this.panelBotonesPrecios.Name = "panelBotonesPrecios";
            this.panelBotonesPrecios.Size = new System.Drawing.Size(1020, 282);
            this.panelBotonesPrecios.TabIndex = 0;
            // 
            // panelContenedorPrecios
            // 
            this.panelContenedorPrecios.AutoSize = true;
            this.panelContenedorPrecios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelContenedorPrecios.Controls.Add(this.cmbSectorRuta);
            this.panelContenedorPrecios.Controls.Add(this.label9);
            this.panelContenedorPrecios.Controls.Add(this.txtDireccionRuta);
            this.panelContenedorPrecios.Controls.Add(this.label8);
            this.panelContenedorPrecios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorPrecios.Location = new System.Drawing.Point(3, 285);
            this.panelContenedorPrecios.Name = "panelContenedorPrecios";
            this.panelContenedorPrecios.Size = new System.Drawing.Size(1020, 194);
            this.panelContenedorPrecios.TabIndex = 1;
            // 
            // panelInferiorPrecios
            // 
            this.panelInferiorPrecios.Controls.Add(this.btnModificarDireccion);
            this.panelInferiorPrecios.Controls.Add(this.btnNuevaDireccion);
            this.panelInferiorPrecios.Controls.Add(this.btnAgregarDireccion);
            this.panelInferiorPrecios.Controls.Add(this.btnEliminarDireccion);
            this.panelInferiorPrecios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferiorPrecios.Location = new System.Drawing.Point(3, 367);
            this.panelInferiorPrecios.Name = "panelInferiorPrecios";
            this.panelInferiorPrecios.Size = new System.Drawing.Size(1020, 112);
            this.panelInferiorPrecios.TabIndex = 2;
            // 
            // txtDireccionRuta
            // 
            this.txtDireccionRuta.Location = new System.Drawing.Point(284, 37);
            this.txtDireccionRuta.Name = "txtDireccionRuta";
            this.txtDireccionRuta.Size = new System.Drawing.Size(219, 20);
            this.txtDireccionRuta.TabIndex = 54;
            // 
            // cmbSectorRuta
            // 
            this.cmbSectorRuta.FormattingEnabled = true;
            this.cmbSectorRuta.Items.AddRange(new object[] {
            "Centro ",
            "Norte",
            "Sur ",
            "Este ",
            "Oeste ",
            "Samborondon ",
            "Chongon ",
            "Duran ",
            "Daule"});
            this.cmbSectorRuta.Location = new System.Drawing.Point(799, 35);
            this.cmbSectorRuta.Name = "cmbSectorRuta";
            this.cmbSectorRuta.Size = new System.Drawing.Size(169, 21);
            this.cmbSectorRuta.TabIndex = 56;
            // 
            // dgvListaPrecioRutas
            // 
            this.dgvListaPrecioRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPrecioRutas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaPrecioRutas.Location = new System.Drawing.Point(0, 0);
            this.dgvListaPrecioRutas.Name = "dgvListaPrecioRutas";
            this.dgvListaPrecioRutas.Size = new System.Drawing.Size(1020, 282);
            this.dgvListaPrecioRutas.TabIndex = 3;
            // 
            // btnEditarRuta
            // 
            this.btnEditarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRuta.Image = global::Capa_Vistas.Properties.Resources.edit_property_30px;
            this.btnEditarRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarRuta.Location = new System.Drawing.Point(230, 30);
            this.btnEditarRuta.Name = "btnEditarRuta";
            this.btnEditarRuta.Size = new System.Drawing.Size(181, 48);
            this.btnEditarRuta.TabIndex = 3;
            this.btnEditarRuta.Text = "Editar Ruta";
            this.btnEditarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarRuta.UseVisualStyleBackColor = true;
            // 
            // btnListarRutas
            // 
            this.btnListarRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarRutas.Image = global::Capa_Vistas.Properties.Resources.waypoint_map_40px;
            this.btnListarRutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarRutas.Location = new System.Drawing.Point(764, 43);
            this.btnListarRutas.Name = "btnListarRutas";
            this.btnListarRutas.Size = new System.Drawing.Size(239, 48);
            this.btnListarRutas.TabIndex = 5;
            this.btnListarRutas.Text = "Listar Todas las Rutas";
            this.btnListarRutas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListarRutas.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Image = global::Capa_Vistas.Properties.Resources.search_property_40px;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(292, 43);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(181, 48);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar Rutas";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarRuta
            // 
            this.btnGuardarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRuta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRuta.Image = global::Capa_Vistas.Properties.Resources.save2_40px;
            this.btnGuardarRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarRuta.Location = new System.Drawing.Point(465, 311);
            this.btnGuardarRuta.Name = "btnGuardarRuta";
            this.btnGuardarRuta.Size = new System.Drawing.Size(173, 48);
            this.btnGuardarRuta.TabIndex = 4;
            this.btnGuardarRuta.Text = "Guardar Ruta";
            this.btnGuardarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarRuta.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::Capa_Vistas.Properties.Resources.name_16px;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(51, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 19);
            this.label6.TabIndex = 53;
            this.label6.Text = "PARADAS O SECTORES DE LA RUTA:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::Capa_Vistas.Properties.Resources.map_16px;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(446, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 19);
            this.label5.TabIndex = 51;
            this.label5.Text = "FIN DE LA RUTA:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::Capa_Vistas.Properties.Resources.map_16px;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(221, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 19);
            this.label7.TabIndex = 49;
            this.label7.Text = "PARADA O SECTOR:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::Capa_Vistas.Properties.Resources.map_16px;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(51, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "INICIO DE LA RUTA:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::Capa_Vistas.Properties.Resources.name_16px;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(51, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "NOMBRE DE LA RUTA:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCargarRuta
            // 
            this.btnCargarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarRuta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarRuta.Image = global::Capa_Vistas.Properties.Resources.search_40px;
            this.btnCargarRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarRuta.Location = new System.Drawing.Point(831, 24);
            this.btnCargarRuta.Name = "btnCargarRuta";
            this.btnCargarRuta.Size = new System.Drawing.Size(153, 48);
            this.btnCargarRuta.TabIndex = 2;
            this.btnCargarRuta.Text = "Cargar Ruta";
            this.btnCargarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarRuta.UseVisualStyleBackColor = true;
            // 
            // btnModificarRuta
            // 
            this.btnModificarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarRuta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarRuta.Image = global::Capa_Vistas.Properties.Resources.edit_40px;
            this.btnModificarRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarRuta.Location = new System.Drawing.Point(462, 24);
            this.btnModificarRuta.Name = "btnModificarRuta";
            this.btnModificarRuta.Size = new System.Drawing.Size(173, 48);
            this.btnModificarRuta.TabIndex = 2;
            this.btnModificarRuta.Text = "Modificar Ruta";
            this.btnModificarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarRuta.UseVisualStyleBackColor = true;
            // 
            // btnEliminarRuta
            // 
            this.btnEliminarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarRuta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRuta.Image = global::Capa_Vistas.Properties.Resources.unavailable_40px;
            this.btnEliminarRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRuta.Location = new System.Drawing.Point(262, 24);
            this.btnEliminarRuta.Name = "btnEliminarRuta";
            this.btnEliminarRuta.Size = new System.Drawing.Size(173, 48);
            this.btnEliminarRuta.TabIndex = 2;
            this.btnEliminarRuta.Text = "Eliminar Ruta";
            this.btnEliminarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarRuta.UseVisualStyleBackColor = true;
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRuta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRuta.Image = global::Capa_Vistas.Properties.Resources.plus_40px;
            this.btnAgregarRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRuta.Location = new System.Drawing.Point(24, 24);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Size = new System.Drawing.Size(206, 48);
            this.btnAgregarRuta.TabIndex = 2;
            this.btnAgregarRuta.Text = "Agregar Nueva Ruta";
            this.btnAgregarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarRuta.UseVisualStyleBackColor = true;
            // 
            // btnModificarDireccion
            // 
            this.btnModificarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDireccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDireccion.Image = global::Capa_Vistas.Properties.Resources.edit_40px;
            this.btnModificarDireccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarDireccion.Location = new System.Drawing.Point(483, 24);
            this.btnModificarDireccion.Name = "btnModificarDireccion";
            this.btnModificarDireccion.Size = new System.Drawing.Size(197, 48);
            this.btnModificarDireccion.TabIndex = 3;
            this.btnModificarDireccion.Text = "Modificar Dirección";
            this.btnModificarDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarDireccion.UseVisualStyleBackColor = true;
            // 
            // btnNuevaDireccion
            // 
            this.btnNuevaDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaDireccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaDireccion.Image = global::Capa_Vistas.Properties.Resources.new_copy_40px;
            this.btnNuevaDireccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaDireccion.Location = new System.Drawing.Point(53, 24);
            this.btnNuevaDireccion.Name = "btnNuevaDireccion";
            this.btnNuevaDireccion.Size = new System.Drawing.Size(189, 48);
            this.btnNuevaDireccion.TabIndex = 5;
            this.btnNuevaDireccion.Text = "Nueva Dirección";
            this.btnNuevaDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaDireccion.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDireccion
            // 
            this.btnAgregarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDireccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDireccion.Image = global::Capa_Vistas.Properties.Resources.plus_40px;
            this.btnAgregarDireccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDireccion.Location = new System.Drawing.Point(275, 24);
            this.btnAgregarDireccion.Name = "btnAgregarDireccion";
            this.btnAgregarDireccion.Size = new System.Drawing.Size(189, 48);
            this.btnAgregarDireccion.TabIndex = 5;
            this.btnAgregarDireccion.Text = "Agregar Dirección";
            this.btnAgregarDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarDireccion.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDireccion
            // 
            this.btnEliminarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDireccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDireccion.Image = global::Capa_Vistas.Properties.Resources.unavailable_40px;
            this.btnEliminarDireccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarDireccion.Location = new System.Drawing.Point(705, 24);
            this.btnEliminarDireccion.Name = "btnEliminarDireccion";
            this.btnEliminarDireccion.Size = new System.Drawing.Size(200, 48);
            this.btnEliminarDireccion.TabIndex = 4;
            this.btnEliminarDireccion.Text = "Eliminar Dirección";
            this.btnEliminarDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarDireccion.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::Capa_Vistas.Properties.Resources.map_16px;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(593, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 19);
            this.label9.TabIndex = 55;
            this.label9.Text = "SECTOR DE LA RUTA:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::Capa_Vistas.Properties.Resources.map_16px;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(73, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 19);
            this.label8.TabIndex = 51;
            this.label8.Text = "DIRECCIÓN DE LA RUTA: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Capa_Vistas.Properties.Resources.icons8_close_window_26px;
            this.btnSalir.Location = new System.Drawing.Point(6, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 28);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.TabStop = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = global::Capa_Vistas.Properties.Resources.map_16px;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(788, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 19);
            this.label10.TabIndex = 56;
            this.label10.Text = "PRECIO RUTA:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrecioRuta
            // 
            this.txtPrecioRuta.Location = new System.Drawing.Point(915, 95);
            this.txtPrecioRuta.Name = "txtPrecioRuta";
            this.txtPrecioRuta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioRuta.TabIndex = 57;
            // 
            // AdministracionRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1034, 573);
            this.Controls.Add(this.tabRutasPrecios);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministracionRutas";
            this.Text = "TaxisRutas";
            this.tabRutasPrecios.ResumeLayout(false);
            this.tabRutas.ResumeLayout(false);
            this.panelGeneralRutas.ResumeLayout(false);
            this.panelBotonesInferior.ResumeLayout(false);
            this.panelBotonesInferior.PerformLayout();
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRutas)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            this.tabAdminRutas.ResumeLayout(false);
            this.tabAdminDirecciones.ResumeLayout(false);
            this.tabAdminDirecciones.PerformLayout();
            this.panelControles.ResumeLayout(false);
            this.panelControles.PerformLayout();
            this.panelAdministracion.ResumeLayout(false);
            this.panelAdministracion.PerformLayout();
            this.panelBotonesPrecios.ResumeLayout(false);
            this.panelContenedorPrecios.ResumeLayout(false);
            this.panelContenedorPrecios.PerformLayout();
            this.panelInferiorPrecios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPrecioRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabRutasPrecios;
        private System.Windows.Forms.TabPage tabRutas;
        private System.Windows.Forms.TabPage tabAdminRutas;
        private System.Windows.Forms.TabPage tabAdminDirecciones;
        private System.Windows.Forms.ImageList IconosRutasPrecios;
        private System.Windows.Forms.Panel panelGeneralRutas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Panel panelBotonesInferior;
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView dgvListaRutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.TextBox txtEditarRuta;
        private System.Windows.Forms.Button btnEditarRuta;
        private System.Windows.Forms.Button btnListarRutas;
        private System.Windows.Forms.Panel panelAdministracion;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Button btnAgregarRuta;
        private System.Windows.Forms.Button btnEliminarRuta;
        private System.Windows.Forms.Button btnModificarRuta;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnCargarRuta;
        private System.Windows.Forms.Button btnGuardarRuta;
        private System.Windows.Forms.Button btnAgregarParada;
        private System.Windows.Forms.TextBox txtParadasSectores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFinRuta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbParadaSector;
        private System.Windows.Forms.ComboBox cmbInicioRuta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelInferiorPrecios;
        private System.Windows.Forms.Panel panelContenedorPrecios;
        private System.Windows.Forms.Panel panelBotonesPrecios;
        private System.Windows.Forms.TextBox txtDireccionRuta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModificarDireccion;
        private System.Windows.Forms.Button btnEliminarDireccion;
        private System.Windows.Forms.Button btnAgregarDireccion;
        private System.Windows.Forms.Button btnNuevaDireccion;
        private System.Windows.Forms.ComboBox cmbSectorRuta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvListaPrecioRutas;
        private System.Windows.Forms.TextBox txtPrecioRuta;
        private System.Windows.Forms.Label label10;
    }
}