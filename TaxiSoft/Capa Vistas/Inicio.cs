using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Capa_Vistas
{

    public partial class Inicio : Form
    {
       
        public Inicio()
        {
            InitializeComponent();
            costomizeDesing();
            openChildForm(new ModuloAdministracion.AdministracionInicio());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void costomizeDesing()
        {
            panelSubMenuAdmin.Visible = false;
            panelSubMenuSocios.Visible = false;
            panelSubMenuServicios.Visible = false;
            panelSubClientes.Visible = false;
            panelSubmenuReportes.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubMenuAdmin.Visible == true)
                panelSubMenuAdmin.Visible = false;

            if (panelSubMenuServicios.Visible == true)
                panelSubMenuServicios.Visible = false;

            if (panelSubMenuSocios.Visible == true)
                panelSubMenuSocios.Visible = false;

            if(panelSubClientes.Visible == true)
                panelSubClientes.Visible = false;

            if (panelSubmenuReportes.Visible == true)
                panelSubmenuReportes.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuAdmin);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            textoBarra.Text = textoBarra.Text+" Empresa";
            openChildForm(new ModuloAdministracion.AdministracionEmpresa());

            //esto va al final 
            //hideSubMenu();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            textoBarra.Text = textoBarra.Text + " Usuarios";
            openChildForm(new ModuloAdministracion.AdministracionUsuarios());

            //esto va al final 
            // hideSubMenu();
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            textoBarra.Text = textoBarra.Text + " Rutas y Precios";
            openChildForm(new ModuloTaxis.AdministracionRutas());

            //esto va al final 
            // hideSubMenu();
        }

        private void btnEstadoTaxi_Click(object sender, EventArgs e)
        {
            textoBarra.Text = textoBarra.Text + " Estado Taxis";
            openChildForm(new ModuloTaxis.AdministraconEstadoTaxi());
            //esto va al final 
            // hideSubMenu();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            textoBarra.Text = "Sistema de Control de Taxi Ruta Software";
            openChildForm(new ModuloAdministracion.AdministracionInicio());
            //esto va al final 
            hideSubMenu();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuSocios);
        }

        private void btnAdminSocios_Click(object sender, EventArgs e)
        {
            textoBarra.Text = textoBarra.Text + " Gestión de Socios";
            openChildForm(new ModuloSocios.SociosGestionSocios());
            //esto va al final 
            //hideSubMenu();
        }

        private void btnAdminTaxis_Click(object sender, EventArgs e)
        {
            textoBarra.Text = textoBarra.Text + " Gestion de Taxsis";
            //esto va al final 
            //hideSubMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //esto va al final 
            showSubMenu(panelSubClientes);
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuServicios);
        }

        private void btnCarreras_Click(object sender, EventArgs e)
        {
            textoBarra.Text = textoBarra.Text + " Gestión de Carreras";
            openChildForm(new ModuloTaxis.ServiciosCarreras());

            //esto va al final 
            //hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuReportes);
        }

        private void btnReporteGeneral_Click(object sender, EventArgs e)
        {
            textoBarra.Text = textoBarra.Text + " Reporte Generales";
            openChildForm(new ModuloReportes.ReportesGenerales());

            //esto va al final 
            // hideSubMenu();
        }

        private void btnReporteTaxis_Click(object sender, EventArgs e)
        {
            textoBarra.Text = textoBarra.Text + " Reporte de Taxis ";
            openChildForm(new ModuloReportes.ReporteTaxis());

            //esto va al final 
            //hideSubMenu();
        }

        private void btnReporteCliente_Click(object sender, EventArgs e)
        {
            textoBarra.Text = textoBarra.Text + " Reporte Clientes";
            openChildForm(new ModuloReportes.ReportesClientes());

            //esto va al final 
            // hideSubMenu();
        }

        private void btnReporteSocio_Click(object sender, EventArgs e)
        {
            textoBarra.Text = textoBarra.Text + " Reporte Socios";
            openChildForm(new ModuloReportes.ReportesSocios());

            //esto va al final 
            //hideSubMenu();
        }

        private void btnClienteAcciones_Click(object sender, EventArgs e)
        {
            textoBarra.Text = textoBarra.Text + " Gestión de Clientes";
            openChildForm(new ModuloClientes.ClientesGestionClientes());

            //esto va al final 
            //hideSubMenu();
        }

        private void btnClienteConsulta_Click(object sender, EventArgs e)
        {
            textoBarra.Text = textoBarra.Text + " Consultas de Clientes";
            openChildForm(new ModuloClientes.ClientesGestionClientes());

            //esto va al final 
            //hideSubMenu();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pBarraHerramienta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
