using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_de_Datos.Objetos;
using Capa_Modelo_de_Datos;

namespace Capa_Controladora
{
    public class AdministracionEmpresaController
    {
        private int id_empresa;
        private String ruc_cedula;
        private String razon_social_nombre;
        private String nombre_comercial_apellido;
        private String direccion;
        private String provincia;
        private String ciudad;
        private String fecha_inicio_actividades_fecha_nacimiento;
        private String telefono;
        private String correo;
        private String nacionalidad;
        private String sexo;

        public AdministracionEmpresaController(int id_empresa, string ruc_cedula, string razon_social_nombre, string nombre_comercial_apellido, string direccion, string provincia, string ciudad, string fecha_inicio_actividades_fecha_nacimiento, string telefono, string correo)
        {
            this.id_empresa = id_empresa;
            this.ruc_cedula = ruc_cedula;
            this.razon_social_nombre = razon_social_nombre;
            this.nombre_comercial_apellido = nombre_comercial_apellido;
            this.direccion = direccion;
            this.provincia = provincia;
            this.ciudad = ciudad;
            this.fecha_inicio_actividades_fecha_nacimiento = fecha_inicio_actividades_fecha_nacimiento;
            this.telefono = telefono;
            this.correo = correo;
        }

        public AdministracionEmpresaController(string ruc_cedula, string razon_social_nombre, string direccion, string provincia, string ciudad, string fecha_inicio_actividades_fecha_nacimiento, string telefono, string correo, string nacionalidad, string sexo)
        {
            this.ruc_cedula = ruc_cedula;
            this.razon_social_nombre = razon_social_nombre;
            this.direccion = direccion;
            this.provincia = provincia;
            this.ciudad = ciudad;
            this.fecha_inicio_actividades_fecha_nacimiento = fecha_inicio_actividades_fecha_nacimiento;
            this.telefono = telefono;
            this.correo = correo;
            this.nacionalidad = nacionalidad;
            this.sexo = sexo;
        }

        public AdministracionEmpresaController(){}

        public int Id_empresa
        {
            get { return id_empresa; }
            set { id_empresa = value; }
        }

        public String Ruc_cedula
        {
            get { return ruc_cedula; }
            set { ruc_cedula = value; }
        }
        public String Razon_social_nombre
        {
            get { return razon_social_nombre; }
            set { razon_social_nombre = value; }
        }
        public String Nombre_comercial_apellido
        {
            get { return nombre_comercial_apellido; }
            set { nombre_comercial_apellido = value; }
        }
        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public String Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }
        public String Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public String Fecha_inicio_actividades_fecha_nacimiento
        {
            get { return fecha_inicio_actividades_fecha_nacimiento; }
            set { fecha_inicio_actividades_fecha_nacimiento = value; }
        }
        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public String Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
        public String Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }



        IngresosDatos ingresoDatos = new IngresosDatos();
        ConsultaDatosAdministracion consultaDatosAdministracion = new ConsultaDatosAdministracion();

        public String registrarEmpresa()
        {
            String mensaje = "";
            try
            {
                Empresa empresa = new Empresa(Id_empresa, Ruc_cedula, Razon_social_nombre, Nombre_comercial_apellido, Direccion, Provincia, Ciudad,
                                            Fecha_inicio_actividades_fecha_nacimiento, Telefono, Correo);
                mensaje = ingresoDatos.insertarDatosEmpresa(empresa);
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                return mensaje;
                throw ex;
            }
            return mensaje;
        }
        public String registrarPropietario(String rutaFoto)
        {
            String mensaje = "";
            try
            {
                Propietario propietario = new Propietario(Ruc_cedula, Razon_social_nombre, Direccion, Fecha_inicio_actividades_fecha_nacimiento, Nacionalidad, Sexo, Telefono, Correo, Provincia, Ciudad);
                mensaje = ingresoDatos.insertarDatosPropietario(propietario,rutaFoto);
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                return mensaje;
                throw ex;
            }
            return mensaje;
        }

        public String datosEmpresa()
        {
            //Crear un arreglo o una lista de String para generar las consultas PILAS
            return consultaDatosAdministracion.datosEmpresa().Ruc.ToString();
        }

    }
}
