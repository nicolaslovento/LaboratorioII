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
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);

            SqlCommand comandoSql = new SqlCommand();

            comandoSql.CommandText = "SELECT * FROM Table_1 WHERE 1=1 ";
            comandoSql.CommandType = CommandType.Text;
            comandoSql.Connection = conexion;

            Console.WriteLine("ABRO Y LEO TODAS LAS FILAS DE LA TABLA");

            conexion.Open();
            SqlDataReader lectorSql;
            lectorSql = comandoSql.ExecuteReader();

            while (lectorSql.Read())
            {
                Console.WriteLine(lectorSql[0]+" "+ lectorSql[1]+" "+lectorSql[2]);
            }

            conexion.Close();

            //AGREGO 10 PERSONAS
            /*Persona p1 = new Persona(1,"Nicolas",24);
            Persona p2 = new Persona(2, "Adrian", 51);
            Persona p3 = new Persona(3, "Roberto", 55);
            Persona p4 = new Persona(4, "Milagros", 32);
            Persona p5 = new Persona(5, "Sofia", 22);
            Persona p6 = new Persona(6, "Augusto", 39);
            Persona p7 = new Persona(7, "Maria", 18);
            Persona p8 = new Persona(8, "Auu", 21);
            Persona p9 = new Persona(9, "Joaquin", 65);
            Persona p10 = new Persona(10, "Anastacio", 90);

            Persona.Subir(p1);
            Persona.Subir(p2);
            Persona.Subir(p3);
            Persona.Subir(p4);
            Persona.Subir(p5);
            Persona.Subir(p6);
            Persona.Subir(p7);
            Persona.Subir(p8);
            Persona.Subir(p9);
            Persona.Subir(p10);*/


            Console.WriteLine("*********MODIFICO UNO***********");
            Persona p2 = new Persona(2, "Juan Carlos", 20);
            Persona.Modificar(p2);


            Console.WriteLine("*********TRAIGO LA LISTA Y LA MUESTRO  ***********");
            

            Persona.lista=Persona.TraerTodos();

            foreach(Persona p in Persona.lista)
            {
                Console.WriteLine(p.ToString());
            }


            Console.WriteLine("**********TRAIGO UNO Y LO MUESTRO***********");

            Persona pTraida=Persona.TraerUno(1);

            Console.WriteLine(pTraida.ToString());

            //GUARDO EN XML LA LIST<Persona>

            if (Persona.GuardarXml(Persona.lista))
            {
                Console.WriteLine("Se guardo la lista xml con exito..");
            }

            Persona.leerXml();




            //GUARDO DATOS SQL EN DATATABLE y PASARLO A XML
            DataTable dataTable = new DataTable("Personas");

            conexion.Open();
            lectorSql = comandoSql.ExecuteReader();//es el comando SELECT *
            dataTable.Load(lectorSql);
            dataTable.WriteXmlSchema("EsquemaPersonas.xml");
            dataTable.WriteXml("Personas.xml");
            conexion.Close();

            //GUARDO DATOS XML EN DATATABLE
            DataTable lectorTable = new DataTable("Personas");
            lectorTable.ReadXmlSchema("EsquemaPersonas.xml");
            lectorTable.ReadXml("Personas.xml");



            Console.ReadKey();

        }
    }
}
