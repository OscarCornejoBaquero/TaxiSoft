using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_de_Datos
{
    public class ClsProvincias
    {
        public List<String> provincias(String provi)
        {
            List<String> pro = new List<string>();
            if (provi == "Ecuatoriana")
            {
                pro.Add("Azuay");
                pro.Add("Bolívar");
                pro.Add("Cañar");
                pro.Add("Carchi");
                pro.Add("Chimborazo");
                pro.Add("Cotopaxi");
                pro.Add("El Oro");
                pro.Add("Esmeraldas");
                pro.Add("Galápagos");
                pro.Add("Guayas");
                pro.Add("Imbabura");
                pro.Add("Loja");
                pro.Add("Los Ríos");
                pro.Add("Manabí");
                pro.Add("Morona Santiago");
                pro.Add("Napo");
                pro.Add("Orellana");
                pro.Add("Pastaza");
                pro.Add("Pichincha");
                pro.Add("Santa Elena");
                pro.Add("Santo Domingo de los Tsáchilas");
                pro.Add("Sucumbíos");
                pro.Add("Tungurahua");
                pro.Add("Zamora Chinchipe");
            }
            if (provi == "Otro")
            {
                pro.Add("Otro");
            }

                if (provi == "Colombiana")
            {
                pro.Add("Amazonas");
                pro.Add("Antioquia");
                pro.Add("Arauca");
                pro.Add("Atlántico");
                pro.Add("Bolívar");
                pro.Add("Boyacá");
                pro.Add("Caldas");
                pro.Add("Caquetá");
                pro.Add("Casanare");
                pro.Add("Cauca");
                pro.Add("Cesar");
                pro.Add("Chocó");
                pro.Add("Córdoba");
                pro.Add("Cundinamarca");
                pro.Add("Güainia");
                pro.Add("Guaviare");
                pro.Add("Huila");
                pro.Add("La Guajira");
                pro.Add("Magdalena");
                pro.Add("Meta");
                pro.Add("Nariño");
                pro.Add("Norte de Santander");
                pro.Add("Putumayo");
                pro.Add("Quindío");
                pro.Add("Risaralda");
                pro.Add("San Andrés y Providencia");
                pro.Add("Santander");
                pro.Add("Sucre");
                pro.Add("Tolima");
                pro.Add("Valle del Cauca");
                pro.Add("Vaupés");
                pro.Add("Vichada");

            }
            if (provi == "Argentina")
            {
                pro.Add("Misiones");
                pro.Add("San Luis");
                pro.Add("San Juan");
                pro.Add("Entre Ríos");
                pro.Add("Santa Cruz");
                pro.Add("Río Negro");
                pro.Add("Chubut");
                pro.Add("Córdoba");
                pro.Add("Mendoza");
                pro.Add("La Rioja");
                pro.Add("Catamarca");
                pro.Add("La Pampa");
                pro.Add("Santiago del Estero");
                pro.Add("Corrientes");
                pro.Add("Santa Fe");
                pro.Add("Tucumán");
                pro.Add("Neuquén");
                pro.Add("Salta");
                pro.Add("Chaco");
                pro.Add("Formosa");
                pro.Add("Jujuy");
                pro.Add("Ciudad Autónoma de Buenos Aires");
                pro.Add("Buenos Aires");
                pro.Add("Tierra del Fuego");

            }
            if (provi == "Peruana")
            {
                pro.Add("Amazonas");
                pro.Add("Áncash");
                pro.Add("Apurímac");
                pro.Add("Arequipa");
                pro.Add("Ayacucho");
                pro.Add("Cajamarca");
                pro.Add("Callao");
                pro.Add("Cusco");
                pro.Add("Huancavelica");
                pro.Add("Huánuco");
                pro.Add("Ica");
                pro.Add("Junín");
                pro.Add("La Libertad");
                pro.Add("Lambayeque");
                pro.Add("Lima");
                pro.Add("Loreto");
                pro.Add("Madre de Dios");
                pro.Add("Moquegua");
                pro.Add("Pasco");
                pro.Add("Piura");
                pro.Add("Puno");
                pro.Add("San Martín");
                pro.Add("Tacna");
                pro.Add("Tumbes");
                pro.Add("Ucayali");

            }
            if (provi == "Venezolana")
            {
                pro.Add("AMAZONAS");
                pro.Add("ANZOATEGUI");
                pro.Add("APURE");
                pro.Add("ARAGUA");
                pro.Add("BARINAS");
                pro.Add("MIRANDA");
                pro.Add("CARABOBO");
                pro.Add("COJEDES");
                pro.Add("DELTA AMACURO");
                pro.Add("FALCON");
                pro.Add("GUARICO");
                pro.Add("LARA");
                pro.Add("MERIDA");
                pro.Add("BOLIVAR");
                pro.Add("MONAGAS");
                pro.Add("NUEVA ESPARTA");
                pro.Add("PORTUGUESA");
                pro.Add("SUCRE");
                pro.Add("TACHIRA");
                pro.Add("TRUJILLO");
                pro.Add("YARACUY");
                pro.Add("ZULIA");
                pro.Add("VARGAS");
                pro.Add("D. FEDERALES");

            }


            return pro;
        }
    }
}
