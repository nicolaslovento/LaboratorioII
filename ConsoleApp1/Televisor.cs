using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml;
using System.Xml.Serialization;


namespace ConsoleApp1
{
    public class Televisor
    {
        public List<Televisor> listaTelevisores;
        public int id;
        public string marca;
        public double precio;
        public int pulgadas;
        public string pais;

        public Televisor()
        {
            this.listaTelevisores = new List<Televisor>();
        }

        public Televisor(int id,string marca,double precio,int pulgadas,string pais):this()
        {
            this.id = id;
            this.marca = marca;
            this.precio = precio;
            this.pulgadas = pulgadas;
            this.pais = pais;
        }


        public bool Insertar()
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);

            SqlCommand comando = new SqlCommand();

            comando.CommandText = string.Format("INSERT INTO Televisores values({0},'{1}',{2},{3},'{4}')",this.id,this.marca,this.precio,this.pulgadas,this.pais);//omito los campos (entre televisores y values)
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();

            return false;

        }

        

        public static bool Modificar(Televisor tele)
        {

          SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);

          SqlCommand comando = new SqlCommand();

          comando.CommandText = string.Format("UPDATE Televisores SET marca='"+tele.marca+"',precio="+ tele.precio+",pulgadas="+ tele.pulgadas+",pais='"+tele.pais+"' WHERE codigo="+tele.id);//omito los campos (entre televisores y values)
          comando.CommandType = System.Data.CommandType.Text;
          comando.Connection = conexion;

          conexion.Open();
          comando.ExecuteNonQuery();
          conexion.Close();

          return false;

        }

    public static bool Delete(Televisor tele)
    {

      SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);

      SqlCommand comando = new SqlCommand();
      try
      {
        comando.CommandText = string.Format("DELETE Televisores WHERE codigo=" + tele.id);//omito los campos (entre televisores y values)
        comando.CommandType = System.Data.CommandType.Text;
        comando.Connection = conexion;

        conexion.Open();
        comando.ExecuteNonQuery();
        conexion.Close();
      }
      catch (Exception)
      {
        return false;
      }


      return true;

    }

    public static Televisor TraerUno(int idTele)
    {

      SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);

      SqlCommand comando = new SqlCommand();
      
        comando.CommandText = string.Format("SELECT Televisores WHERE codigo=" + idTele);//omito los campos (entre televisores y values)
        comando.CommandType = System.Data.CommandType.Text;
        comando.Connection = conexion;

        conexion.Open();
        comando.ExecuteNonQuery();
        conexion.Close();
      
     


      return true;

    }




  }
}
