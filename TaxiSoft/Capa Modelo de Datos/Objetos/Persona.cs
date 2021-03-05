using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_de_Datos
{
    public class Persona
    {
        private String cedula;
        private String nombres_completos;
        private String direccion;
        private String fecha_nacimiento;
        private String nacionalidad;
        private String sexo;
        private String telefono;
        private String correo;
        private List<Object> lst_obj;

        public Persona(){}

        public Persona(string cedula, string nombres_completos, string direccion, String fecha_nacimiento, string nacionalidad, string sexo, string telefono, string correo)
        {
            this.cedula = cedula;
            this.nombres_completos = nombres_completos;
            this.direccion = direccion;
            this.fecha_nacimiento = fecha_nacimiento;
            this.nacionalidad = nacionalidad;
            this.sexo = sexo;
            this.telefono = telefono;
            this.correo = correo;
        }

        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public String Nombres_completos
        {
            get { return nombres_completos; }
            set { nombres_completos = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public String Fecha_nacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
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
