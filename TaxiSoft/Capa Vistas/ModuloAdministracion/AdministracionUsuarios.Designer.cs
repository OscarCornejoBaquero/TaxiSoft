
namespace Capa_Vistas.ModuloAdministracion
{
    partial class AdministracionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.tbcUsuarios = new System.Windows.Forms.TabControl();
            this.tabRegistroUsuarios = new System.Windows.Forms.TabPage();
            this.tabConsultarUsuario = new System.Windows.Forms.TabPage();
            this.tabModificarUsuario = new System.Windows.Forms.TabPage();
            this.tabEliminarUsuario = new System.Windows.Forms.TabPage();
            this.IconosPes = new System.Windows.Forms.ImageList(this.components);
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.chActivarDatos = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnGuardarEmpresa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnActualizarEmpresa = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.tbcUsuarios.SuspendLayout();
            this.tabRegistroUsuarios.SuspendLayout();
            this.tabConsultarUsuario.SuspendLayout();
            this.tabModificarUsuario.SuspendLayout();
            this.tabEliminarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.label1.Text = "Administración de Usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbcUsuarios
            // 
            this.tbcUsuarios.Controls.Add(this.tabRegistroUsuarios);
            this.tbcUsuarios.Controls.Add(this.tabConsultarUsuario);
            this.tbcUsuarios.Controls.Add(this.tabModificarUsuario);
            this.tbcUsuarios.Controls.Add(this.tabEliminarUsuario);
            this.tbcUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcUsuarios.ImageList = this.IconosPes;
            this.tbcUsuarios.ItemSize = new System.Drawing.Size(90, 50);
            this.tbcUsuarios.Location = new System.Drawing.Point(0, 33);
            this.tbcUsuarios.Name = "tbcUsuarios";
            this.tbcUsuarios.SelectedIndex = 0;
            this.tbcUsuarios.Size = new System.Drawing.Size(1034, 540);
            this.tbcUsuarios.TabIndex = 6;
            // 
            // tabRegistroUsuarios
            // 
            this.tabRegistroUsuarios.Controls.Add(this.label18);
            this.tabRegistroUsuarios.Controls.Add(this.textBox10);
            this.tabRegistroUsuarios.Controls.Add(this.textBox8);
            this.tabRegistroUsuarios.Controls.Add(this.label22);
            this.tabRegistroUsuarios.Controls.Add(this.btnGuardarEmpresa);
            this.tabRegistroUsuarios.Controls.Add(this.label2);
            this.tabRegistroUsuarios.Controls.Add(this.pictureBox1);
            this.tabRegistroUsuarios.Controls.Add(this.button1);
            this.tabRegistroUsuarios.Controls.Add(this.cmbProvincia);
            this.tabRegistroUsuarios.Controls.Add(this.label9);
            this.tabRegistroUsuarios.Controls.Add(this.dtFechaInicio);
            this.tabRegistroUsuarios.Controls.Add(this.txtCorreo);
            this.tabRegistroUsuarios.Controls.Add(this.txtTelefono);
            this.tabRegistroUsuarios.Controls.Add(this.txtDireccion);
            this.tabRegistroUsuarios.Controls.Add(this.txtNombre);
            this.tabRegistroUsuarios.Controls.Add(this.txtRazonSocial);
            this.tabRegistroUsuarios.Controls.Add(this.txtRuc);
            this.tabRegistroUsuarios.Controls.Add(this.label8);
            this.tabRegistroUsuarios.Controls.Add(this.label7);
            this.tabRegistroUsuarios.Controls.Add(this.label6);
            this.tabRegistroUsuarios.Controls.Add(this.label11);
            this.tabRegistroUsuarios.Controls.Add(this.label5);
            this.tabRegistroUsuarios.Controls.Add(this.label4);
            this.tabRegistroUsuarios.Controls.Add(this.label3);
            this.tabRegistroUsuarios.ImageIndex = 0;
            this.tabRegistroUsuarios.Location = new System.Drawing.Point(4, 54);
            this.tabRegistroUsuarios.Name = "tabRegistroUsuarios";
            this.tabRegistroUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistroUsuarios.Size = new System.Drawing.Size(1026, 482);
            this.tabRegistroUsuarios.TabIndex = 0;
            this.tabRegistroUsuarios.Text = "Registro de Usuarios";
            this.tabRegistroUsuarios.UseVisualStyleBackColor = true;
            // 
            // tabConsultarUsuario
            // 
            this.tabConsultarUsuario.Controls.Add(this.button5);
            this.tabConsultarUsuario.Controls.Add(this.dataGridView1);
            this.tabConsultarUsuario.Controls.Add(this.label20);
            this.tabConsultarUsuario.Controls.Add(this.textBox7);
            this.tabConsultarUsuario.Controls.Add(this.label21);
            this.tabConsultarUsuario.Controls.Add(this.button4);
            this.tabConsultarUsuario.ImageIndex = 1;
            this.tabConsultarUsuario.Location = new System.Drawing.Point(4, 54);
            this.tabConsultarUsuario.Name = "tabConsultarUsuario";
            this.tabConsultarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultarUsuario.Size = new System.Drawing.Size(1026, 482);
            this.tabConsultarUsuario.TabIndex = 1;
            this.tabConsultarUsuario.Text = "Consulta de Usuarios";
            this.tabConsultarUsuario.UseVisualStyleBackColor = true;
            // 
            // tabModificarUsuario
            // 
            this.tabModificarUsuario.Controls.Add(this.label25);
            this.tabModificarUsuario.Controls.Add(this.textBox11);
            this.tabModificarUsuario.Controls.Add(this.textBox9);
            this.tabModificarUsuario.Controls.Add(this.chActivarDatos);
            this.tabModificarUsuario.Controls.Add(this.label19);
            this.tabModificarUsuario.Controls.Add(this.comboBox1);
            this.tabModificarUsuario.Controls.Add(this.dateTimePicker1);
            this.tabModificarUsuario.Controls.Add(this.textBox1);
            this.tabModificarUsuario.Controls.Add(this.textBox2);
            this.tabModificarUsuario.Controls.Add(this.textBox3);
            this.tabModificarUsuario.Controls.Add(this.textBox4);
            this.tabModificarUsuario.Controls.Add(this.textBox5);
            this.tabModificarUsuario.Controls.Add(this.textBox6);
            this.tabModificarUsuario.Controls.Add(this.label10);
            this.tabModificarUsuario.Controls.Add(this.label12);
            this.tabModificarUsuario.Controls.Add(this.label13);
            this.tabModificarUsuario.Controls.Add(this.label14);
            this.tabModificarUsuario.Controls.Add(this.label15);
            this.tabModificarUsuario.Controls.Add(this.label16);
            this.tabModificarUsuario.Controls.Add(this.label17);
            this.tabModificarUsuario.Controls.Add(this.label23);
            this.tabModificarUsuario.Controls.Add(this.label24);
            this.tabModificarUsuario.Controls.Add(this.button3);
            this.tabModificarUsuario.Controls.Add(this.button2);
            this.tabModificarUsuario.Controls.Add(this.btnActualizarEmpresa);
            this.tabModificarUsuario.Controls.Add(this.pictureBox2);
            this.tabModificarUsuario.ImageIndex = 2;
            this.tabModificarUsuario.Location = new System.Drawing.Point(4, 54);
            this.tabModificarUsuario.Name = "tabModificarUsuario";
            this.tabModificarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificarUsuario.Size = new System.Drawing.Size(1026, 482);
            this.tabModificarUsuario.TabIndex = 2;
            this.tabModificarUsuario.Text = "Modificar Usuario";
            this.tabModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // tabEliminarUsuario
            // 
            this.tabEliminarUsuario.Controls.Add(this.button7);
            this.tabEliminarUsuario.Controls.Add(this.dataGridView2);
            this.tabEliminarUsuario.Controls.Add(this.label26);
            this.tabEliminarUsuario.Controls.Add(this.textBox12);
            this.tabEliminarUsuario.Controls.Add(this.label27);
            this.tabEliminarUsuario.Controls.Add(this.button6);
            this.tabEliminarUsuario.ImageIndex = 3;
            this.tabEliminarUsuario.Location = new System.Drawing.Point(4, 54);
            this.tabEliminarUsuario.Name = "tabEliminarUsuario";
            this.tabEliminarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminarUsuario.Size = new System.Drawing.Size(1026, 482);
            this.tabEliminarUsuario.TabIndex = 3;
            this.tabEliminarUsuario.Text = "Eliminar Usuario";
            this.tabEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // IconosPes
            // 
            this.IconosPes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconosPes.ImageStream")));
            this.IconosPes.TransparentColor = System.Drawing.Color.Transparent;
            this.IconosPes.Images.SetKeyName(0, "add_user_male_100px.png");
            this.IconosPes.Images.SetKeyName(1, "list_64px.png");
            this.IconosPes.Images.SetKeyName(2, "registration_40px.png");
            this.IconosPes.Images.SetKeyName(3, "delete_64px.png");
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(505, 435);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(257, 21);
            this.cmbProvincia.TabIndex = 50;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(505, 193);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(259, 20);
            this.dtFechaInicio.TabIndex = 52;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(503, 353);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(259, 20);
            this.txtCorreo.TabIndex = 54;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(504, 313);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(259, 20);
            this.txtTelefono.TabIndex = 53;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(505, 274);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(258, 20);
            this.txtDireccion.TabIndex = 49;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(505, 159);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(258, 20);
            this.txtNombre.TabIndex = 48;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(505, 120);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(259, 20);
            this.txtRazonSocial.TabIndex = 47;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(505, 85);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(118, 20);
            this.txtRuc.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 39);
            this.label2.TabIndex = 62;
            this.label2.Text = "Registro de Datos Usuario";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(492, 438);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 21);
            this.comboBox1.TabIndex = 73;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(492, 207);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 20);
            this.dateTimePicker1.TabIndex = 74;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(492, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 76;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(491, 313);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 20);
            this.textBox2.TabIndex = 75;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(491, 277);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(258, 20);
            this.textBox3.TabIndex = 72;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(492, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(258, 20);
            this.textBox4.TabIndex = 71;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(492, 134);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(259, 20);
            this.textBox5.TabIndex = 70;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(185, 98);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(118, 20);
            this.textBox6.TabIndex = 69;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(376, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(423, 39);
            this.label19.TabIndex = 80;
            this.label19.Text = "Modificación de Datos Usuario";
            // 
            // chActivarDatos
            // 
            this.chActivarDatos.AutoSize = true;
            this.chActivarDatos.Location = new System.Drawing.Point(494, 99);
            this.chActivarDatos.Name = "chActivarDatos";
            this.chActivarDatos.Size = new System.Drawing.Size(97, 17);
            this.chActivarDatos.TabIndex = 85;
            this.chActivarDatos.Text = "Activar Edición";
            this.chActivarDatos.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(463, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(327, 39);
            this.label20.TabIndex = 88;
            this.label20.Text = "Consulta Datos Usuario";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(202, 104);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(118, 20);
            this.textBox7.TabIndex = 87;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(67, 103);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(116, 19);
            this.label21.TabIndex = 86;
            this.label21.Text = "CEDULA O RUC: ";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(504, 392);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(259, 20);
            this.textBox8.TabIndex = 65;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(491, 399);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(259, 20);
            this.textBox9.TabIndex = 87;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(965, 283);
            this.dataGridView1.TabIndex = 91;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(505, 232);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(258, 20);
            this.textBox10.TabIndex = 66;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(491, 239);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(258, 20);
            this.textBox11.TabIndex = 97;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 172);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(965, 141);
            this.dataGridView2.TabIndex = 96;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(492, 27);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(237, 39);
            this.label26.TabIndex = 94;
            this.label26.Text = "Eliminar Usuario";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(204, 101);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(118, 20);
            this.textBox12.TabIndex = 93;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(69, 100);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(116, 19);
            this.label27.TabIndex = 92;
            this.label27.Text = "CEDULA O RUC: ";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Image = global::Capa_Vistas.Properties.Resources.phone_16px;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label18.Location = new System.Drawing.Point(217, 231);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 19);
            this.label18.TabIndex = 67;
            this.label18.Text = "TELÉFONO: ";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Image = global::Capa_Vistas.Properties.Resources.password_16px;
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.Location = new System.Drawing.Point(217, 393);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(235, 19);
            this.label22.TabIndex = 64;
            this.label22.Text = "CONFIRMAR CONTRASEÑA:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuardarEmpresa
            // 
            this.btnGuardarEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnGuardarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEmpresa.Image = global::Capa_Vistas.Properties.Resources.save_40px;
            this.btnGuardarEmpresa.Location = new System.Drawing.Point(850, 251);
            this.btnGuardarEmpresa.Name = "btnGuardarEmpresa";
            this.btnGuardarEmpresa.Size = new System.Drawing.Size(146, 54);
            this.btnGuardarEmpresa.TabIndex = 63;
            this.btnGuardarEmpresa.Text = "Guardar Datos de Usuario";
            this.btnGuardarEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarEmpresa.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(33, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 127);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Capa_Vistas.Properties.Resources.camera_16px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(33, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 27);
            this.button1.TabIndex = 60;
            this.button1.Text = "CARGAR FOTO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::Capa_Vistas.Properties.Resources.email_16px;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(217, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 19);
            this.label9.TabIndex = 55;
            this.label9.Text = "CORREO: ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::Capa_Vistas.Properties.Resources.user_16px;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(215, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 45;
            this.label8.Text = "USUARIO:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::Capa_Vistas.Properties.Resources.view_more_16px;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(217, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "ROL: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::Capa_Vistas.Properties.Resources.password_16px;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(216, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "CONTRASEÑA:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = global::Capa_Vistas.Properties.Resources.address_16px;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(217, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 19);
            this.label11.TabIndex = 41;
            this.label11.Text = "DIRECCIÓN:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::Capa_Vistas.Properties.Resources.calendar_16px;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(217, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "FECHA DE NACIMIENTO:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::Capa_Vistas.Properties.Resources.name_16px;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(217, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "NOMBRES COMPLETOS:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::Capa_Vistas.Properties.Resources.identity_theft_16px;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(217, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "CEDULA O RUC: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button5
            // 
            this.button5.Image = global::Capa_Vistas.Properties.Resources.search_property_40px;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(791, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(203, 58);
            this.button5.TabIndex = 92;
            this.button5.Text = "Listar Todos los Usuarios";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::Capa_Vistas.Properties.Resources.find_user_male_40px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(343, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 58);
            this.button4.TabIndex = 89;
            this.button4.Text = "Consultar Usuario Individual";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Image = global::Capa_Vistas.Properties.Resources.phone_16px;
            this.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label25.Location = new System.Drawing.Point(231, 238);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(115, 19);
            this.label25.TabIndex = 98;
            this.label25.Text = "TELÉFONO: ";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = global::Capa_Vistas.Properties.Resources.password_16px;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(231, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 19);
            this.label10.TabIndex = 96;
            this.label10.Text = "CONFIRMAR CONTRASEÑA:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = global::Capa_Vistas.Properties.Resources.email_16px;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(231, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 19);
            this.label12.TabIndex = 95;
            this.label12.Text = "CORREO: ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = global::Capa_Vistas.Properties.Resources.user_16px;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(229, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 19);
            this.label13.TabIndex = 94;
            this.label13.Text = "USUARIO:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Image = global::Capa_Vistas.Properties.Resources.view_more_16px;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(231, 442);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 19);
            this.label14.TabIndex = 93;
            this.label14.Text = "ROL: ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Image = global::Capa_Vistas.Properties.Resources.password_16px;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(230, 359);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 19);
            this.label15.TabIndex = 91;
            this.label15.Text = "CONTRASEÑA:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Image = global::Capa_Vistas.Properties.Resources.address_16px;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(229, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 19);
            this.label16.TabIndex = 90;
            this.label16.Text = "DIRECCIÓN:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Image = global::Capa_Vistas.Properties.Resources.calendar_16px;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Location = new System.Drawing.Point(229, 209);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(213, 19);
            this.label17.TabIndex = 89;
            this.label17.Text = "FECHA DE NACIMIENTO:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Image = global::Capa_Vistas.Properties.Resources.name_16px;
            this.label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label23.Location = new System.Drawing.Point(229, 137);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(208, 19);
            this.label23.TabIndex = 88;
            this.label23.Text = "NOMBRES COMPLETOS:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Image = global::Capa_Vistas.Properties.Resources.identity_theft_16px;
            this.label24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label24.Location = new System.Drawing.Point(29, 97);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(150, 19);
            this.label24.TabIndex = 92;
            this.label24.Text = "CEDULA O RUC: ";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.Image = global::Capa_Vistas.Properties.Resources.user_16px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(309, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 33);
            this.button3.TabIndex = 84;
            this.button3.Text = "Consultar Usuario";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Capa_Vistas.Properties.Resources.camera_16px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(43, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 27);
            this.button2.TabIndex = 78;
            this.button2.Text = "CARGAR FOTO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnActualizarEmpresa
            // 
            this.btnActualizarEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnActualizarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEmpresa.Image = global::Capa_Vistas.Properties.Resources.edit_property_30px;
            this.btnActualizarEmpresa.Location = new System.Drawing.Point(840, 238);
            this.btnActualizarEmpresa.Name = "btnActualizarEmpresa";
            this.btnActualizarEmpresa.Size = new System.Drawing.Size(146, 54);
            this.btnActualizarEmpresa.TabIndex = 82;
            this.btnActualizarEmpresa.Text = "Actualizar Datos de Usuario";
            this.btnActualizarEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarEmpresa.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(43, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 127);
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::Capa_Vistas.Properties.Resources.delete_64px;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(412, 366);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(284, 75);
            this.button7.TabIndex = 97;
            this.button7.Text = "ELIMINAR USUARIO";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = global::Capa_Vistas.Properties.Resources.find_user_male_40px;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(345, 81);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(208, 58);
            this.button6.TabIndex = 95;
            this.button6.Text = "Consultar Usuario a Eliminar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Capa_Vistas.Properties.Resources.icons8_close_window_26px;
            this.btnSalir.Location = new System.Drawing.Point(6, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 28);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.TabStop = false;
            // 
            // AdministracionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1034, 573);
            this.Controls.Add(this.tbcUsuarios);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministracionUsuarios";
            this.Text = "AdministracionUsuarios";
            this.tbcUsuarios.ResumeLayout(false);
            this.tabRegistroUsuarios.ResumeLayout(false);
            this.tabRegistroUsuarios.PerformLayout();
            this.tabConsultarUsuario.ResumeLayout(false);
            this.tabConsultarUsuario.PerformLayout();
            this.tabModificarUsuario.ResumeLayout(false);
            this.tabModificarUsuario.PerformLayout();
            this.tabEliminarUsuario.ResumeLayout(false);
            this.tabEliminarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbcUsuarios;
        private System.Windows.Forms.TabPage tabRegistroUsuarios;
        private System.Windows.Forms.TabPage tabConsultarUsuario;
        private System.Windows.Forms.TabPage tabModificarUsuario;
        private System.Windows.Forms.TabPage tabEliminarUsuario;
        private System.Windows.Forms.ImageList IconosPes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
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
        private System.Windows.Forms.Button btnGuardarEmpresa;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnActualizarEmpresa;
        private System.Windows.Forms.CheckBox chActivarDatos;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button6;
    }
}