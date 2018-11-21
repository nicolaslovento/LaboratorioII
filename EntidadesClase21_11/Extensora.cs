using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace EntidadesClase21_11
{
  public static class Extensora
  {
    //Metodos de Extension / Agregado


    public static string ObtenerDatos(this PersonaExternaSellada persona)
    {

      return persona.Nombre+" "+persona.Apellido+" "+persona.Edad+" "+persona.Sexo;
    }

    public static bool EsNulo(this Object a)
    {

      if (Object.Equals(a,null))
      {
        return true;
      }

      return false;
    }

    public static Int32 CantidadDigitos(this Int32 num)
    {
      string n=num.ToString();

      return n.Length; 
    }
    //el this significa a quien le voy a agregar ese metodo
    public static bool TieneLaMismaCantidad(this Int32 num,Int32 num2)
    {
      if (Extensora.CantidadDigitos(num) == num2.CantidadDigitos())
      {
        return true;
      }
      return false;
    }


    public static bool AgregarDb(this Persona p)
    {
      SqlConnection conexion = new SqlConnection("Data Source = LAB5PC22\\SQLEXPRESS; Initial Catalog = Personas_db; Integrated Security = True");

      SqlCommand comandoSql = new SqlCommand();
      comandoSql.CommandType = CommandType.Text;
      comandoSql.Connection = conexion;
      comandoSql.CommandText = string.Format("INSERT INTO dbo.personas ([nombre],[apellido],[edad],[sexo]) values ('{0}','{1}',{2},{3})",p.Nombre,p.Apellido, p.Edad,(int)p.Sexo);
      bool retorno = false;
      try {
            conexion.Open();
            comandoSql.ExecuteNonQuery();
            conexion.Close();
            retorno = true;
      }
      catch (Exception)
      {
        
      }

      return retorno;


    }

  }
}
