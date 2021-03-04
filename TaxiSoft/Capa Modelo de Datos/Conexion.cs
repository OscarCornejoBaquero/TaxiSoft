using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_de_Datos
{
    public class Conexion
    {
        string ConnectionString = "server=localhost; database=TaxiSoft ; integrated security = true";
        SqlConnection conexion;

        public String  abrir_conexion()
        {
            String resp;
            try
            {
                conexion = new SqlConnection(ConnectionString);
                conexion.Open();
                resp = "Conectado";
            }
            catch (Exception e)
            {
                resp = "No Conectado";
            }
            
            

            return resp;
        }

    }
}
