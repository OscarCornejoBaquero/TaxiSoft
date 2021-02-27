
namespace Capa_Vistas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SeccionFondo = new System.Windows.Forms.Panel();
            this.salir = new System.Windows.Forms.Label();
            this.SeccionDatos = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ckPass = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SeccionFondo.SuspendLayout();
            this.SeccionDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 331);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(337, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 331);
            this.panel2.TabIndex = 1;
            // 
            // SeccionFondo
            // 
            this.SeccionFondo.BackColor = System.Drawing.Color.Transparent;
            this.SeccionFondo.BackgroundImage = global::Capa_Vistas.Properties.Resources.imagenLogin;
            this.SeccionFondo.Controls.Add(this.salir);
            this.SeccionFondo.Location = new System.Drawing.Point(282, 0);
            this.SeccionFondo.Name = "SeccionFondo";
            this.SeccionFondo.Size = new System.Drawing.Size(371, 405);
            this.SeccionFondo.TabIndex = 1;
            // 
            // salir
            // 
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.Image = global::Capa_Vistas.Properties.Resources.icons8_delete_50px_21;
            this.salir.Location = new System.Drawing.Point(343, 0);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(25, 30);
            this.salir.TabIndex = 10;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // SeccionDatos
            // 
            this.SeccionDatos.BackColor = System.Drawing.Color.White;
            this.SeccionDatos.BackgroundImage = global::Capa_Vistas.Properties.Resources.silver;
            this.SeccionDatos.Controls.Add(this.pictureBox1);
            this.SeccionDatos.Controls.Add(this.button1);
            this.SeccionDatos.Controls.Add(this.ckPass);
            this.SeccionDatos.Controls.Add(this.label6);
            this.SeccionDatos.Controls.Add(this.txtPass);
            this.SeccionDatos.Controls.Add(this.label5);
            this.SeccionDatos.Controls.Add(this.txtUsuario);
            this.SeccionDatos.Controls.Add(this.label4);
            this.SeccionDatos.Controls.Add(this.label2);
            this.SeccionDatos.Location = new System.Drawing.Point(-1, 0);
            this.SeccionDatos.Name = "SeccionDatos";
            this.SeccionDatos.Size = new System.Drawing.Size(286, 405);
            this.SeccionDatos.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Capa_Vistas.Properties.Resources.male_user_100px;
            this.pictureBox1.Location = new System.Drawing.Point(76, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(58, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckPass
            // 
            this.ckPass.BackColor = System.Drawing.Color.Transparent;
            this.ckPass.Font = new System.Drawing.Font("Calibri", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckPass.Location = new System.Drawing.Point(47, 269);
            this.ckPass.Name = "ckPass";
            this.ckPass.Size = new System.Drawing.Size(110, 19);
            this.ckPass.TabIndex = 7;
            this.ckPass.Text = "Mostrar Contraseña";
            this.ckPass.UseVisualStyleBackColor = false;
            this.ckPass.CheckedChanged += new System.EventHandler(this.ckPass_CheckedChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Image = global::Capa_Vistas.Properties.Resources.icons8_forgot_password_30px;
            this.label6.Location = new System.Drawing.Point(13, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 28);
            this.label6.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Gray;
            this.txtPass.Location = new System.Drawing.Point(51, 243);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(211, 19);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "Ingrese su Contraseña";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(44, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "_____________________________________";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.Location = new System.Drawing.Point(51, 182);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(211, 19);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Tag = "Usuario";
            this.txtUsuario.Text = "Ingrese su Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(44, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "_____________________________________";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = global::Capa_Vistas.Properties.Resources.icons8_user_30px_7;
            this.label2.Location = new System.Drawing.Point(13, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 28);
            this.label2.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(654, 407);
            this.Controls.Add(this.SeccionFondo);
            this.Controls.Add(this.SeccionDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SeccionFondo.ResumeLayout(false);
            this.SeccionDatos.ResumeLayout(false);
            this.SeccionDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SeccionDatos;
        private System.Windows.Forms.Panel SeccionFondo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label salir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}