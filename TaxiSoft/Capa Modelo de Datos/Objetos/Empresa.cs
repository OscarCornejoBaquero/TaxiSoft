using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_de_Datos.Objetos
{
    public class Empresa
    {
        private int id_empresa;
        private String ruc;
        private String razon_social;
        private String nombre_comercial;
        private String direccion;
        private String provincia;
        private String ciudad;
        private String fecha_inicio_actividades;
        private String telefono;
        private String correo;

        public Empresa(int id_empresa, string ruc, string razon_social, string nombre_comercial, string direccion, string provincia, string ciudad, String fecha_inicio_actividades, string telefono, string correo)
        {
            this.id_empresa = id_empresa;
            this.ruc = ruc;
            this.razon_social = razon_social;
            this.nombre_comercial = nombre_comercial;
            this.direccion = direccion;
            this.provincia = provincia;
            this.ciudad = ciudad;
            this.fecha_inicio_actividades = fecha_inicio_actividades;
            this.telefono = telefono;
            this.correo = correo;
        }

        public Empresa(){}

        public int Id_empresa
        {
            get { return id_empresa; }
            set { id_empresa = value; }
        }

        public String Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }
        public String Razon_social
        {
            get { return razon_social; }
            set { razon_social = value; }
        }
        public String Nombre_comercial
        {
            get { return nombre_comercial; }
            set { nombre_comercial = value; }
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
        public String Fecha_inicio_actividades
        {
            get { return fecha_inicio_actividades; }
            set { fecha_inicio_actividades = value; }
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
    }
}
