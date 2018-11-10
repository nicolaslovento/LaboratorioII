using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml;
using System.Xml.Serialization;

namespace PruebaSqlCompleto
{
    public class Persona
    {
        
        public string _nombre;
        public int _edad;
        public static List<Persona> lista;
        public int _id;

        public Persona(int id, string nombre, int edad)
        {
            this._nombre = nombre;
            this._edad = edad;
            
            this._id = id;
        }
        public Persona()
        {

        }

        public static bool Subir(Persona p)
        {
           
                 SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);

                 SqlCommand comandoSql = new SqlCommand();
                 comandoSql.CommandType = CommandType.Text;
                 comandoSql.Connection = conexion;
                 comandoSql.CommandText = string.Format("INSERT INTO Table_1 values ({0},'{1}',{2})", p._id,p._nombre, p._edad);

                 conexion.Open();
                 comandoSql.ExecuteNonQuery();
                 conexion.Close();
                 Console.WriteLine("Se agregó con éxito..");

            
            
               
            

            return true;

        }

        public static bool Borrar(Persona p)
        {
            
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);

                SqlCommand comandoSql = new SqlCommand();
                comandoSql.CommandType = CommandType.Text;
                comandoSql.Connection = conexion;
                comandoSql.CommandText = string.Format("DELETE FROM Table_1 WHERE id={0}",p._id);

                conexion.Open();
                comandoSql.ExecuteNonQuery();
                conexion.Close();
                Console.WriteLine("Se Borró con éxito..");

            
            
            return true;

        }

        public static bool Borrar(int idPersona)
        {

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);

            SqlCommand comandoSql = new SqlCommand();
            comandoSql.CommandType = CommandType.Text;
            comandoSql.Connection = conexion;
            comandoSql.CommandText = string.Format("DELETE FROM Table_1 WHERE id={0}", idPersona);

            conexion.Open();
            comandoSql.ExecuteNonQuery();
            conexion.Close();
            Console.WriteLine("Se Borró con éxito..");



            return true;

        }

        public static bool Modificar(Persona p)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);

            SqlCommand comando = new SqlCommand();
            comando.CommandText = "UPDATE Table_1 SET Nombre='"+p._nombre+"',Edad="+p._edad+" WHERE Id="+p._id;
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            Console.WriteLine("Se ha modificado con exito..");

            return true;

        }


        public static List<Persona> TraerTodos()
        {
            List<Persona> nuevaLista = new List<Persona>();
            int indice = 1;
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);

            SqlCommand comandoSql = new SqlCommand();
            comandoSql.CommandType = CommandType.Text;
            comandoSql.Connection = conexion;
            comandoSql.CommandText = string.Format("SELECT * FROM Table_1 WHERE 1=1");

            conexion.Open();
            SqlDataReader lector;
            lector = comandoSql.ExecuteReader();
            while (lector.Read())
            {
                nuevaLista.Add(new Persona((int)lector[0], (string)lector[1], (int)lector[2]));
                Console.WriteLine("{0} persona agregada..",indice);
                indice++;
            }
            
            conexion.Close();
            



            return nuevaLista;

        }

        public static Persona TraerUno(int idPersona)
        {
            
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);

            SqlCommand comandoSql = new SqlCommand();
            comandoSql.CommandType = CommandType.Text;
            comandoSql.Connection = conexion;
            comandoSql.CommandText = string.Format("SELECT * FROM Table_1 WHERE Id={0}",idPersona);

            conexion.Open();
            SqlDataReader lector;
            lector = comandoSql.ExecuteReader();
            lector.Read();

            Persona p= new Persona((int)lector[0], (string)lector[1], (int)lector[2]);

            Console.WriteLine("Se trajo una persona..");
                
            conexion.Close();

            return p;

        }

        public static bool GuardarXml(List<Persona> lista)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Persona>));
            XmlTextWriter xmlWriter = new XmlTextWriter("P.xml",Encoding.UTF8);
            XmlTextReader xmlReader = new XmlTextReader("P.xml");

            xmlSerializer.Serialize(xmlWriter, lista);

            xmlWriter.Close();
            return true;

        }

        public static bool leerXml()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Persona>));
            XmlTextReader xmlReader = new XmlTextReader("P.xml");
            List<Persona> nuevaLista;
            nuevaLista=(List<Persona>)xmlSerializer.Deserialize(xmlReader);

            foreach(Persona p in nuevaLista)
            {
                Console.WriteLine(p.ToString());
            }
            xmlReader.Close();

            return true;

        }

        public override string ToString()
        {
            return "Nombre: " + this._nombre + "\nID" + this._id + "\nEdad" + this._edad;
        }



    }
}
