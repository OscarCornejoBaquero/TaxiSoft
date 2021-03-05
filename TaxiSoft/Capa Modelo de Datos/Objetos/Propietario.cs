using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_de_Datos.Objetos
{
    public class Propietario : Persona
    {
        
        private String provincia;
        private String ciudad;

        public Propietario(string cedula, string nombres_completos, string direccion, String fecha_nacimiento,
                        string nacionalidad, string sexo, string telefono, string correo, string provincia, string ciudad)
            : base(cedula, nombres_completos, direccion, fecha_nacimiento, nacionalidad, sexo, telefono, correo)
        {
            this.provincia = provincia;
            this.ciudad = ciudad;
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



    }
}
