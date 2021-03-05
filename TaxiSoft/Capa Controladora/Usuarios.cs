using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_de_Datos;


namespace Capa_Controladora
{
    public class Usuarios : Persona
    {
        private String usuario;
        private String password;
        private String rol;
        private String estado;
        Conexion con = new Conexion();

        public Usuarios(){}

        public Usuarios(string cedula, string nombres_completos, string direccion, DateTime fecha_nacimiento,
                        string nacionalidad, string sexo, string telefono, string correo, string usuario, string password, string rol, string estado) 
                        : base (cedula,nombres_completos,direccion,fecha_nacimiento,nacionalidad,sexo,telefono,correo){
            this.usuario = usuario;
            this.password = password;
            this.rol = rol;
            this.estado = estado;
        }

        //Getter y Setter 
        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        //Metodos 
        public override string registrar()
        {
            return "";
        }


    }
}
