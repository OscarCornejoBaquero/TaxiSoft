using Capa_Modelo_de_Datos.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_de_Datos
{
   
    public class IngresosDatos
    {
        Conexion conn = new Conexion();
        SqlConnection conexion;

        public string insertarDatosEmpresa(Empresa empresa)
        {
            String mensaje = "";
            try
            {
                conexion=conn.abrir_conexion();
                if (empresa != null)
                {
                    string cadena = "INSERT INTO [dbo].[Empresa] ([ruc],[razon_social],[nombre_comercial],[direccion],[provincia],[ciudad],[fecha_inicio_actividad],[telefono],[correo]) " +
                                    "VALUES (@ruc,@razon,@nombre,@direccion,@provincia,@ciudad,@fecha,@telefono,@correo)";
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.Parameters.AddWithValue("@ruc", empresa.Ruc);
                    comando.Parameters.AddWithValue("@razon", empresa.Razon_social);
                    comando.Parameters.AddWithValue("@nombre", empresa.Nombre_comercial);
                    comando.Parameters.AddWithValue("@direccion", empresa.Direccion);
                    comando.Parameters.AddWithValue("@provincia", empresa.Provincia);
                    comando.Parameters.AddWithValue("@ciudad", empresa.Ciudad);
                    comando.Parameters.AddWithValue("@fecha", empresa.Fecha_inicio_actividades);
                    comando.Parameters.AddWithValue("@telefono", empresa.Telefono);
                    comando.Parameters.AddWithValue("@correo", empresa.Correo);
                    comando.ExecuteNonQuery();
                    conn.cerrar_conexion();
                    mensaje = "Datos de Empresa Agregados Correctamente";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensaje;
        }

        public string insertarDatosPropietario(Propietario propietario, String rutaFoto)
        {
            String mensaje = "";
            SqlCommand comando=null;
            byte[] binData=null;
            try{
                conexion = conn.abrir_conexion();
                if (propietario != null){
                    if (rutaFoto.Equals("null")){
                        string cadena = "INSERT INTO [dbo].[Propietario] ([cedula],[nombres_completos],[direccion],[fecha_nacimiento],[nacionalidad],[sexo],[telefono],[correo],[provincia],[ciudad])" +
                                        "VALUES (@ruc,@nombre,@direccion,@fecha,@nacionalidad,@sexo,@telefono,@correo,@provincia,@ciudad)";
                        comando = new SqlCommand(cadena, conexion);
                    }
                    else{
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        FileStream stream = new FileStream(rutaFoto, FileMode.Open, FileAccess.Read);
                        binData = new byte[stream.Length];
                        stream.Read(binData, 0, Convert.ToInt32(stream.Length));
                        string cadena = "INSERT INTO [dbo].[Propietario] ([cedula],[nombres_completos],[direccion],[fecha_nacimiento],[nacionalidad],[sexo],[telefono],[correo],[provincia],[ciudad],[foto])" +
                                       "VALUES (@ruc,@nombre,@direccion,@fecha,@nacionalidad,@sexo,@telefono,@correo,@provincia,@ciudad,@foto)";
                        comando = new SqlCommand(cadena, conexion);
                        comando.Parameters.AddWithValue("@foto", binData);
                    }
                    comando.Parameters.AddWithValue("@ruc", propietario.Cedula);
                    comando.Parameters.AddWithValue("@nombre", propietario.Nombres_completos);
                    comando.Parameters.AddWithValue("@direccion", propietario.Direccion);
                    comando.Parameters.AddWithValue("@fecha", propietario.Fecha_nacimiento);
                    comando.Parameters.AddWithValue("@nacionalidad", propietario.Nacionalidad);
                    comando.Parameters.AddWithValue("@sexo", propietario.Sexo);
                    comando.Parameters.AddWithValue("@telefono", propietario.Telefono);
                    comando.Parameters.AddWithValue("@correo", propietario.Correo);
                    comando.Parameters.AddWithValue("@provincia", propietario.Provincia);
                    comando.Parameters.AddWithValue("@ciudad", propietario.Ciudad);
                    comando.ExecuteNonQuery();
                    conn.cerrar_conexion();
                    mensaje = "Datos de Propietario Agregados Correctamente";
                }         
            }
            catch (Exception ex){
                throw ex;
            }
            return mensaje;
        }

    }

}
