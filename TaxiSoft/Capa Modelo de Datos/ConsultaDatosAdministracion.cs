using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_de_Datos.Objetos;

namespace Capa_Modelo_de_Datos
{
    public class ConsultaDatosAdministracion
    {
        Conexion conn = new Conexion();
        SqlConnection conexion;

        public Empresa datosEmpresa()
        {
            Empresa empresa = null;
            try
            {
                conexion = conn.abrir_conexion();
                string qry = "select * from [dbo].[Empresa]";
                SqlCommand SqlCom = new SqlCommand(qry, conexion);

                SqlDataReader drE = SqlCom.ExecuteReader();

                //SqlDataAdapter dp = new SqlDataAdapter(SqlCom);
                //DataSet ds = new DataSet("Empresa");
                if (drE.Read())
                {
                    empresa = new Empresa((int)drE["id_empresa"], (String)drE["ruc"], (String)drE["razon_social"],
                        (String)drE["nombre_comercial"], (String)drE["direccion"], (String)drE["provincia"], (String)drE["ciudad"],
                        (String)drE["fecha_inicio_actividad"].ToString(), (String)drE["telefono"], (String)drE["correo"]);
                }


                
                return empresa;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

    }
}
