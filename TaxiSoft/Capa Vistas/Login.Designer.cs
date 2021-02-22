
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
            this.SeccionDatos = new System.Windows.Forms.Panel();
            this.ckPass = new System.Windows.Forms.CheckBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SeccionFondo = new System.Windows.Forms.Panel();
            this.salir = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SeccionDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SeccionFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeccionDatos
            // 
            this.SeccionDatos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SeccionDatos.Controls.Add(this.button1);
            this.SeccionDatos.Controls.Add(this.ckPass);
            this.SeccionDatos.Controls.Add(this.label6);
            this.SeccionDatos.Controls.Add(this.txtPass);
            this.SeccionDatos.Controls.Add(this.label5);
            this.SeccionDatos.Controls.Add(this.txtUsuario);
            this.SeccionDatos.Controls.Add(this.label4);
            this.SeccionDatos.Controls.Add(this.label3);
            this.SeccionDatos.Controls.Add(this.label2);
            this.SeccionDatos.Location = new System.Drawing.Point(-1, 0);
            this.SeccionDatos.Name = "SeccionDatos";
            this.SeccionDatos.Size = new System.Drawing.Size(339, 331);
            this.SeccionDatos.TabIndex = 0;
            // 
            // ckPass
            // 
            this.ckPass.Font = new System.Drawing.Font("Calibri", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckPass.Location = new System.Drawing.Point(58, 190);
            this.ckPass.Name = "ckPass";
            this.ckPass.Size = new System.Drawing.Size(110, 19);
            this.ckPass.TabIndex = 7;
            this.ckPass.Text = "Mostrar Contraseña";
            this.ckPass.UseVisualStyleBackColor = true;
            this.ckPass.CheckedChanged += new System.EventHandler(this.ckPass_CheckedChanged);
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(58, 166);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(230, 19);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "Ingrese su Contraseña";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(55, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "_____________________________________";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUsuario.Location = new System.Drawing.Point(58, 103);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(230, 19);
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
            this.label4.Location = new System.Drawing.Point(55, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "_____________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Usuario";
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
            this.SeccionFondo.BackgroundImage = global::Capa_Vistas.Properties.Resources.FondoLogin;
            this.SeccionFondo.Controls.Add(this.salir);
            this.SeccionFondo.Location = new System.Drawing.Point(337, 0);
            this.SeccionFondo.Name = "SeccionFondo";
            this.SeccionFondo.Size = new System.Drawing.Size(277, 331);
            this.SeccionFondo.TabIndex = 1;
            // 
            // salir
            // 
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.Image = global::Capa_Vistas.Properties.Resources.icons8_close_window_26px_1;
            this.salir.Location = new System.Drawing.Point(251, 0);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(25, 30);
            this.salir.TabIndex = 10;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::Capa_Vistas.Properties.Resources.icons8_workspace_48px_1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(81, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Iniciar Sesión";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Image = global::Capa_Vistas.Properties.Resources.icons8_forgot_password_30px;
            this.label6.Location = new System.Drawing.Point(17, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 28);
            this.label6.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Image = global::Capa_Vistas.Properties.Resources.icons8_user_30px_7;
            this.label2.Location = new System.Drawing.Point(17, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 28);
            this.label2.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(614, 331);
            this.Controls.Add(this.SeccionFondo);
            this.Controls.Add(this.SeccionDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.SeccionDatos.ResumeLayout(false);
            this.SeccionDatos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SeccionFondo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SeccionDatos;
        private System.Windows.Forms.Panel SeccionFondo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label salir;
    }
}