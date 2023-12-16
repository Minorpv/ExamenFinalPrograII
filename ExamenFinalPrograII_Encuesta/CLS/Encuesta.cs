using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ExamenFinalPrograII_Encuesta.CLS
{
    public class Encuesta
    {
        private int ID;
        private string Nombre;
        private int Edad;
        private string Correo;
        private int partido;

        public Encuesta(string nombre, int edad, string correo, int partido)
        {
            Nombre = nombre;
            Edad = edad;
            Correo = correo;
            this.partido = partido;
        }

        public Encuesta()
        {
        }

        //Metodos
        public static int Agregar(string nombre, int edad, string correo, int Partido)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBConn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("agregarEncuesta", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@NOMBRE", nombre));
                    cmd.Parameters.Add(new SqlParameter("@EDAD", edad));
                    cmd.Parameters.Add(new SqlParameter("@CORREO", correo));
                    cmd.Parameters.Add(new SqlParameter("@PARTIDO", Partido));


                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;

        }
    }
}