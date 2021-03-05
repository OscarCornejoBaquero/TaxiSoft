using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_de_Datos;

namespace Capa_Controladora
{
    public class RellenoCombos
    {
        public List<String> provincias(String provi)
        {
            ClsProvincias provincias = new ClsProvincias();
            List<String> pro = new List<string>();
            pro = provincias.provincias(provi);
            return pro;
        }

        public List<String> cantones(String canton)
        {
            ClsCantones cantones = new ClsCantones();
            List<String> can = new List<string>();
            can = cantones.cantones(canton);
            return can;
        }
    }
}
