using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_de_Datos
{
    public class ClsCantones
    {
        public List<String> cantones(String canton)
        {
            List<String> can = new List<string>();
            if (canton == "Azuay")
            {
                can.Add(" EL PAN");
                can.Add(" GUACHAPALA");
                can.Add(" NABON");
                can.Add(" OÑA");
                can.Add(" PUCARA");
                can.Add(" SAN FERNANDO");
                can.Add(" SANTA ISABEL");
                can.Add(" SEVILLA DE ORO");
                can.Add(" SIGSIG");
                can.Add("CAMILO PONCE ENRIQUEZ");
                can.Add("CHORDELEG");
                can.Add("CUENCA");
                can.Add("GIRON");
                can.Add("GUALACEO");
                can.Add("PAUTE");


            }
            if(canton == "Otro")
            {
                can.Add("Otro");
            }
            if (canton == "Bolívar")
            {
                can.Add(" CALUMA ");
                can.Add(" CHILLANES");
                can.Add(" CHIMBO");
                can.Add(" ECHEANDIA");
                can.Add(" GUARANDA");
                can.Add(" LAS NAVES");
                can.Add("SAN MIGUEL");

            }
            if (canton == "Cañar")
            {
                can.Add(" BIBLIAN");
                can.Add(" DELEG");
                can.Add(" LA TRONCAL");
                can.Add("AZOGUES");
                can.Add("CAÑAR");
                can.Add("EL TAMBO ");
                can.Add("SUSCAL");

            }
            if (canton == "Carchi")
            {
                can.Add(" BOLIVAR");
                can.Add(" ESPEJO");
                can.Add(" MIRA");
                can.Add(" SAN PEDRO DE HUACA");
                can.Add(" TULCAN");
                can.Add("MONTUFAR");

            }
            if (canton == "Chimborazo")
            {
                can.Add(" COLTA");
                can.Add(" PENIPE");
                can.Add("ALAUSI");
                can.Add("CHAMBO");
                can.Add("CHUNCHI");
                can.Add("CUMANDA");
                can.Add("GUAMOTE");
                can.Add("GUANO");
                can.Add("PALLATANGA");
                can.Add("RIOBAMBA");

            }

            if (canton == "Cotopaxi")
            {
                can.Add(" PUJILI");
                can.Add(" SALCEDO");
                can.Add("LA MANA");
                can.Add("LATACUNGA");
                can.Add("PANGUA");
                can.Add("SAQUISILI");
                can.Add("SIGCHOS");

            }
            if (canton == "El Oro")
            {
                can.Add("ARENILLAS");
                can.Add("ATAHUALPA");
                can.Add("BALSAS");
                can.Add("CHILLA");
                can.Add("EL GUABO");
                can.Add("HUAQUILLAS");
                can.Add("LAS LAJAS");
                can.Add("MACHALA");
                can.Add("MARCABELI");
                can.Add("PASAJE");
                can.Add("PIÑAS");
                can.Add("PORTOVELO");
                can.Add("SANTA ROSA");
                can.Add("ZARUMA");

            }
            if (canton == "Esmeraldas")
            {
                can.Add(" ESMERALDAS");
                can.Add("ATACAMES");
                can.Add("ELOY ALFARO");
                can.Add("LA CONCORDIA");
                can.Add("MUISNE");
                can.Add("QUININDE");
                can.Add("RIOVERDE");
                can.Add("SAN LORENZO");

            }
            if (canton == "Galápagos")
            {
                can.Add(" ISABELA");
                can.Add(" SAN CRISTOBAL");
                can.Add(" SANTA CRUZ");

            }
            if (canton == "Guayas")
            {
                can.Add(" EL EMPALME");
                can.Add(" GUAYAQUIL");
                can.Add(" MILAGRO");
                can.Add(" PLAYAS");
                can.Add(" SANTA LUCIA");
                can.Add("ALFREDO BAQUERIZO MORENO (JUJAN)");
                can.Add("BALAO");
                can.Add("BALZAR");
                can.Add("COLIMES");
                can.Add("CORONEL MARCELINO MARIDUEÑA");
                can.Add("DAULE");
                can.Add("DURAN");
                can.Add("EL TRIUNFO");
                can.Add("GENERAL ANTONIO ELIZALDE ");
                can.Add("ISIDRO AYORA ");
                can.Add("LOMAS DE SARGENTILLO");
                can.Add("NARANJAL");
                can.Add("NARANJITO");
                can.Add("NOBOL");
                can.Add("PALESTINA");
                can.Add("PEDRO CARBO");
                can.Add("SALITRE (URBINA JADO)");
                can.Add("SAMBORONDON");
                can.Add("SAN JACINTO DE YAGUACHI");
                can.Add("SIMON BOLIVAR");

            }
            if (canton == "Imbabura")
            {
                can.Add(" IBARRA");
                can.Add("ANTONIO ANTE");
                can.Add("COTACACHI");
                can.Add("OTAVALO");
                can.Add("PIMAMPIRO");
                can.Add("SAN MIGUEL DE URCUQUI");

            }
            if (canton == "Loja")
            {
                can.Add(" ESPINDOLA");
                can.Add(" GONZANAMA");
                can.Add(" LOJA");
                can.Add(" PINDAL");
                can.Add(" PUYANGO");
                can.Add("CALVAS");
                can.Add("CATAMAYO");
                can.Add("CELICA");
                can.Add("CHAGUARPAMBA");
                can.Add("MACARA");
                can.Add("OLMEDO");
                can.Add("PALTAS");
                can.Add("QUILANGA");
                can.Add("SARAGURO");
                can.Add("SOZORANGA");
                can.Add("ZAPOTILLO");

            }
            if (canton == "Los Ríos")
            {
                can.Add(" MOCACHE");
                can.Add(" MONTALVO");
                can.Add("BABA");
                can.Add("BABAHOYO");
                can.Add("BUENA FE");
                can.Add("PALENQUE");
                can.Add("PUEBLOVIEJO");
                can.Add("QUEVEDO");
                can.Add("QUINSALOMA");
                can.Add("URDANETA");
                can.Add("VALENCIA");
                can.Add("VENTANAS");
                can.Add("VINCES");

            }
            if (canton == "Manabí")
            {
                can.Add(" FLAVIO ALFARO");
                can.Add(" JAMA");
                can.Add(" JARAMIJO");
                can.Add(" JIPIJAPA");
                can.Add(" MANTA");
                can.Add(" MONTECRISTI   ");
                can.Add(" PEDERNALES");
                can.Add(" PICHINCHA");
                can.Add(" SUCRE");
                can.Add(" TOSAGUA");
                can.Add("24 DE MAYO");
                can.Add("BOLIVAR");
                can.Add("CHONE");
                can.Add("EL CARMEN");
                can.Add("JUNIN");
                can.Add("OLMEDO");
                can.Add("PAJAN");
                can.Add("PORTOVIEJO");
                can.Add("PUERTO LOPEZ");
                can.Add("ROCAFUERTE");
                can.Add("SAN VICENTE");
                can.Add("SANTA ANA");

            }

            if (canton == "Morona Santiago")
            {
                can.Add(" GUALAQUIZA");
                can.Add(" HUAMBOYA");
                can.Add("CANTON TIWINTZA");
                can.Add("LIMON INDANZA");
                can.Add("LOGROÑO ");
                can.Add("MORONA");
                can.Add("PABLO SEXTO");
                can.Add("PALORA");
                can.Add("SAN JUAN BOSCO ");
                can.Add("SANTIAGO");
                can.Add("SUCUA");
                can.Add("TAISHA ");

            }
            if (canton == "Napo")
            {
                can.Add(" CARLOS JULIO AROSEMENA TOLA");
                can.Add("ARCHIDONA");
                can.Add("EL CHACO");
                can.Add("QUIJOS");
                can.Add("TENA");

            }
            if (canton == "Orellana")
            {
                can.Add(" LA JOYA DE LOS SACHAS");
                can.Add(" LORETO");
                can.Add("AGUARICO");
                can.Add("ORELLANA");

            }
            if (canton == "Pastaza")
            {
                can.Add(" ARAJUNO");
                can.Add(" SANTA CLARA");
                can.Add("MERA");
                can.Add("PASTAZA");

            }
            if (canton == "Pichincha")
            {
                can.Add(" MEJIA");
                can.Add(" PEDRO MONCAYO");
                can.Add(" PEDRO VICENTE MALDONADO");
                can.Add(" SAN MIGUEL DE LOS BANCOS");
                can.Add("CAYAMBE");
                can.Add("PUERTO QUITO");
                can.Add("QUITO");
                can.Add("RUMIÑAHUI");

            }
            if (canton == "Santa Elena")
            {
                can.Add(" LA LIBERTAD");
                can.Add(" SANTA ELENA");
                can.Add("SALINAS");

            }
            if (canton == "Santo Domingo de los Tsáchilas")
            {
                can.Add("SANTO DOMINGO");

            }
            if (canton == "Sucumbíos")
            {
                can.Add(" GONZALO PIZARRO");
                can.Add(" LAGO AGRIO");
                can.Add(" PUTUMAYO");
                can.Add(" SUCUMBIOS");
                can.Add("CASCALES");
                can.Add("CUYABENO");
                can.Add("SHUSHUFINDI");

            }
            if (canton == "Tungurahua")
            {
                can.Add(" CEVALLOS");
                can.Add(" MOCHA");
                can.Add(" PATATE");
                can.Add(" QUERO");
                can.Add("AMBATO");
                can.Add("BAÑOS DE AGUA SANTA");
                can.Add("SAN PEDRO DE PELILEO");
                can.Add("SANTIAGO DE PILLARO");
                can.Add("TISALEO");

            }
            if (canton == "Zamora Chinchipe")
            {
                can.Add(" CENTINELA DEL CONDOR");
                can.Add(" CHINCHIPE");
                can.Add(" EL PANGUI");
                can.Add(" NANGARITZA");
                can.Add(" YACUAMBI");
                can.Add(" YANTZAZA (YANZATZA)");
                can.Add("PALANDA");
                can.Add("PAQUISHA ");
                can.Add("ZAMORA");

            }
            return can;
        }
    }
}

