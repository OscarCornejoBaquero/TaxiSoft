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

        public Conexion(){}

        public SqlConnection abrir_conexion()
        {
            conexion = new SqlConnection(ConnectionString);
            conexion.Open();
            return conexion;
            
        }
        public SqlConnection cerrar_conexion()
        {
            conexion = new SqlConnection(ConnectionString);
            conexion.Close();
            return conexion;
            
        }


    }
}
