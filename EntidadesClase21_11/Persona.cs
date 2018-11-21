using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace EntidadesClase21_11
{
  public enum ESexo{ Masculino,Femenino,Indeterminado}

  public class Persona
  {
        protected string _nombre;
        protected string _apellido;
        protected int _edad;
        protected ESexo _sexo;

        public Persona(string nombre, string apellido, int edad, ESexo sexo)
        {
          this._nombre = nombre;
          this._apellido = apellido;
          this._edad = edad;
          this._sexo = sexo;
        }

        public string Nombre { get {return this._nombre; } }
        public string Apellido { get { return this._apellido; } }
        public int Edad { get { return this._edad; } }
        public ESexo Sexo { get { return this._sexo; } }

        public string ObtenerDatos()
        {
          return string.Format("{0},{1},{2},{3}", this.Nombre, this.Apellido, this.Edad, this.Sexo);
        }

    public static List<Persona> TraerTodos()
    {
      List<Persona> nuevaLista = new List<Persona>();
      int indice = 1;
      SqlConnection conexion = new SqlConnection("Data Source = LAB5PC22\\SQLEXPRESS; Initial Catalog = Personas_db; Integrated Security = True");

      SqlCommand comandoSql = new SqlCommand();
      comandoSql.CommandType = CommandType.Text;
      comandoSql.Connection = conexion;
      comandoSql.CommandText = string.Format("SELECT * FROM dbo.personas WHERE 1=1");

      conexion.Open();
      SqlDataReader lector;
      lector = comandoSql.ExecuteReader();
      while (lector.Read())
      {
        nuevaLista.Add(new Persona((string)lector[1], (string)lector[2], (int)lector[3], (ESexo)lector[4]));
        
        indice++;
      }

     conexion.Close();




      return nuevaLista;

    }

  }
}
