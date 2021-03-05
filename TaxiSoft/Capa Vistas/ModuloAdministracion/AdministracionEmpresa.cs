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
using System.Text.RegularExpressions;

namespace Capa_Vistas.ModuloAdministracion
{
    public partial class AdministracionEmpresa : Form
    {
        AdministracionEmpresaController admin = new AdministracionEmpresaController();
        String mensaje = "";
        String ruta = "";
        public AdministracionEmpresa()
        {
            InitializeComponent();
            rellenarProEmpresa();
            datosEmpresa();
        }
        public void rellenarProEmpresa()
        {
            RellenoCombos Al = new RellenoCombos();
            List<String> provincias = Al.provincias("Ecuatoriana");
            cmbProvinciaEMpresa.Items.Clear();
            foreach (var can in provincias)
            {
                cmbProvinciaEMpresa.Items.Add(can);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarPro_Click(object sender, EventArgs e)
        {
            String email;
            if (email_bien_escrito(txtCorreo.Text) == true && txtCedulaPro.Text !="" && txtNombresPro.Text !="" && txtDireccionPro.Text !="" && txtTelefonoPro.Text !="")
            {
                email = txtCorreoPro.Text;
                try
                {

                    admin.Ruc_cedula = txtCedulaPro.Text;
                    admin.Razon_social_nombre = txtNombresPro.Text;
                    admin.Direccion = txtDireccionPro.Text;
                    admin.Provincia = cmbProvinciasPro.SelectedItem.ToString();
                    admin.Ciudad = cmbCiudadesPro.SelectedItem.ToString();
                    admin.Fecha_inicio_actividades_fecha_nacimiento = dtpFechaNaciPro.Value.ToString("yyyyMMdd");
                    admin.Telefono = txtTelefonoPro.Text;
                    admin.Correo = email;
                    admin.Sexo = cmbSexoPro.SelectedItem.ToString();
                    admin.Nacionalidad = cmbNacionalidadPro.SelectedItem.ToString();
                    String prueba = "Ruta";

                    if (ckbFotoPro.Checked == true)
                    {
                        ruta = "null";
                        prueba = "Foto Nula";

                    }
                    MessageBox.Show(prueba);
                    MessageBox.Show(ruta);
                    mensaje = admin.registrarPropietario(ruta);

                    MessageBox.Show(mensaje);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Correo no tiene un Formato Correcto");
            }
            
        }

        private void btnGuardarEmpresa_Click(object sender, EventArgs e)
        {
            String email;
            if (email_bien_escrito(txtCorreo.Text) == true && txtRuc.Text != "" && txtRazonSocial.Text!="" && txtNombre.Text !="" && txtTelefono.Text !="")
            {
                email = txtCorreo.Text;
                try
                {
                    admin.Ruc_cedula = txtRuc.Text;
                    admin.Razon_social_nombre = txtRazonSocial.Text;
                    admin.Nombre_comercial_apellido = txtNombre.Text;
                    admin.Direccion = txtDireccion.Text;
                    admin.Provincia = cmbProvinciaEMpresa.SelectedItem.ToString();
                    admin.Ciudad = cmbCiudadEmpresa.SelectedItem.ToString();
                    admin.Fecha_inicio_actividades_fecha_nacimiento = dtFechaInicio.Value.ToString("yyyyMMdd");
                    admin.Telefono = txtTelefono.Text;
                    admin.Correo = email;
                    mensaje = admin.registrarEmpresa();
                    MessageBox.Show(mensaje);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Correo no tiene un Formato Correcto");
            }

            
        }

        private void btnFotoPro_Click(object sender, EventArgs e)
        {
            DialogoFoto.InitialDirectory = "C:\\";
            DialogoFoto.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)(*.JPEG)|*.jpe;*.jpeg;*.JPEG|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            DialogoFoto.FilterIndex = 1;
            DialogoFoto.RestoreDirectory = true;

            if (DialogoFoto.ShowDialog() == DialogResult.OK)
            {
                pbFotoPro.ImageLocation = DialogoFoto.FileName;
                ruta = DialogoFoto.FileName;
            }
            else
            {
                MessageBox.Show("No selecciono Imagen ", "Sin Seleccion ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbProvinciasPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            RellenoCombos Al = new RellenoCombos();
            List<String> ciudades = Al.cantones(cmbProvinciasPro.SelectedItem.ToString());
            cmbCiudadesPro.Items.Clear();
            foreach (var can in ciudades)
            {
                cmbCiudadesPro.Items.Add(can);
            }
        }

        private void cmbCiudadesPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbNacionalidadPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            RellenoCombos Al = new RellenoCombos();
            List<String> provincias = Al.provincias(cmbNacionalidadPro.SelectedItem.ToString());
            cmbProvinciasPro.Items.Clear();
            foreach (var can in provincias)
            {
                cmbProvinciasPro.Items.Add(can);
            }
        }

        private void cmbProvinciaEMpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            RellenoCombos Al = new RellenoCombos();
            List<String> ciudades = Al.cantones(cmbProvinciaEMpresa.SelectedItem.ToString());
            cmbCiudadEmpresa.Items.Clear();
            foreach (var can in ciudades)
            {
                cmbCiudadEmpresa.Items.Add(can);
            }
        }

        private void txtCedulaPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTelefonoPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void datosEmpresa()
        {
            
            txtRuc.Text = admin.datosEmpresa(); 
        }
    }
}
