using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCRUD
{
    public class PersonaDal

    {
        public static int AgregarPersona(Persona persona)
        {
            int retorna = 0;
            using(SqlConnection conn = BDGeneral.BDConectar())
            {
                SqlCommand sqlCommand = conn.CreateCommand();
                string query = "insert into Persona (nombre,edad,numero) values('"+persona.nombre+"', "+persona.edad+",'"+persona.numero+"')";
                SqlCommand comando = new SqlCommand(query, conn);
                retorna = comando.ExecuteNonQuery();

            }
            return retorna;
        }
        public static List<Persona> PresentarGrid()
        {
            List<Persona> Lista = new List<Persona>();
            using (SqlConnection conec = BDGeneral.BDConectar())
            {
                string query = "select *from Persona";
                SqlCommand sqlCommand = new SqlCommand(query, conec);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Persona persona = new Persona();
                    persona.id = reader.GetInt32(0);
                    persona.nombre = reader.GetString(1);
                    persona.edad = reader.GetInt32(2);
                    persona.numero = reader.GetString(3);

                    Lista.Add(persona);

                }
                conec.Close();
                return Lista;
            }
        }
        public static int Modificar(Persona persona)
        {
            int result = 0;
            using(SqlConnection connection = BDGeneral.BDConectar())
            {
                string query = "update Persona set nombre ='" + persona.nombre + "',edad = '" + persona.edad + "',numero = '" + persona.numero + "' where id="+persona.id+" ";
                SqlCommand sqlCommand1 = new SqlCommand(query, connection);
            result = sqlCommand1.ExecuteNonQuery();
                connection.Close();


            }
            return result;
        }
        public static int EliminarPersona(int id)
        {
            int retorna = 0;
            using (SqlConnection conn = BDGeneral.BDConectar())
            {
                SqlCommand sqlCommand = conn.CreateCommand();
                string query = "delete from Persona where id="+id+"";
                SqlCommand comando = new SqlCommand(query, conn);
                retorna = comando.ExecuteNonQuery();

            }
            return retorna;
        }
    }
}
