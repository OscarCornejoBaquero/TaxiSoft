using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controladora;

namespace Capa_Vistas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ckPass_CheckedChanged(object sender, EventArgs e)
        {
            string text = txtPass.Text;
            if (ckPass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.Text = text;

            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                txtPass.Text = text;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text != "")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingrese el Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text != "")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
                txtPass.ForeColor = Color.Gray;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Ingrese Su Contraseña";
                txtPass.UseSystemPasswordChar = false;
                txtPass.ForeColor = Color.Gray;
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Usuarios per = new Usuarios();
            //MessageBox.Show(per.pruebaConexion());

            Inicio inicio = new Inicio();
            inicio.Show();
        }
    }
}
