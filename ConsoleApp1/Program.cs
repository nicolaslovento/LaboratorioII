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
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);//dependen del motor de base de datos

            SqlCommand comando = new SqlCommand();//Instancio.Ejecuta instrucciones en la base de datos.

            comando.CommandText = "SELECT * FROM Televisores WHERE 1=1";//propiedad de tipo string
            comando.CommandType = System.Data.CommandType.Text;//Recibe un enumerado
            comando.Connection=conexion;




            conexion.Open();//Conecta a la base de datos.

            SqlDataReader lector ;//no se puede instanciar.Solo lectura y solo avance.
            lector = comando.ExecuteReader();//contiene todas las filas de la consulta

            Televisor tele = new Televisor();
            while (lector.Read())
            {
                //Retorna object ya que puede retornar cualquier dato. Casteo o utilizo metodos del data reader
                
                tele.listaTelevisores.Add(new Televisor((int)lector[0],(string)lector[1],lector.GetDouble(2),(int)lector[3],(string)lector[4]));

                //lector[0] nombre de la columna o posicion.
                Console.WriteLine(lector[0]+" "+lector[1]+" "+lector["precio"]+" "+lector[3]+" "+lector["pais"]);
            }

            Televisor newT2 = new Televisor(123, "asdasd", 23, 53, "Brasil");
            Televisor.Modificar(newT2);
            if (Televisor.Delete(newT2))
            {
             Console.WriteLine("Se borro el producto");
             }
            //Televisor newT = new Televisor(144, "asd", 213223, 23, "Argentina");
            //newT.Insertar();
            conexion.Close();//Desconecta.




            /*Vamos a serializar televisores*/
            /*Cualquier objeto de memoria("Sacarle una foto") y guardala en un archivo.Para luego volver a traerla.*/
            //Para serializar es necesario que los atributos sean publicos o que tengan propiedades
            XmlSerializer xmlSer=new XmlSerializer(typeof(List<Televisor>));//se encarga de serializar(pasar de memoria a archivo o archivo a memoria cualquier tipo de obj)
            //En el constructor se le pasa el typeof de lo que va a serializar
            XmlTextWriter xmlWri = new XmlTextWriter("televisores.xml",Encoding.UTF8);
            //Se utiliza para escribir en el archivo, primer param "Nombre del path", seg param
            XmlTextReader xmlRea = new XmlTextReader("televisores.xml");
            //Solo necesita el path

            xmlSer.Serialize(xmlWri,tele.listaTelevisores);//La clase a ser serializada debe tener un constructor x defecto y la clase public
            //recibe 2 param:1 escritor de xml,2 obj a ser serializado)verifica si coincide con el tipo de dato especificado
            xmlWri.Close();

            List<Televisor> nueva = new List<Televisor>();
            nueva=(List<Televisor>)xmlSer.Deserialize(xmlRea);//devuelve un object el cual hay que castear

            xmlRea.Close();
            Console.WriteLine("NUEVA LISTA, CANT: "+nueva.Count);

            conexion.Open();

            lector = comando.ExecuteReader();
            //voy a generar una replica de la base de datos en memoria
            //representacion en memoria de la base de datos
            DataTable teleTable = new DataTable("televisores");

            teleTable.Load(lector);

            //ahora serializamos el dataTable

            teleTable.WriteXmlSchema("televisores_Esquema.xml");
            teleTable.WriteXml("televisores_DT.xml");

            conexion.Close();

            DataTable lecturaTable = new DataTable();

            lecturaTable.ReadXmlSchema("televisores_Esquema.xml");
            lecturaTable.ReadXml("televisores_DT.xml");


            Console.ReadKey();


            conexion.Close();//Desconecta.




        }
    }
}
