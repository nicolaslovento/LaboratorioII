using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;


namespace EntidadesClase21_11
{
  public class PersonaExternaHeredada : PersonaExterna
  {

    public PersonaExternaHeredada(string nombre, string apellido, int edad, Entidades.Externa.ESexo sexo) : base(nombre, apellido, edad, sexo)
    {
    }

    public string Nombre { get { return this._nombre; } }
    public string Apellido { get { return this._apellido; } }
    public int Edad { get { return this._edad; } }
    public Entidades.Externa.ESexo Sexo { get { return this._sexo; } }

    public string ObtenerDatos()
    {
      return string.Format("{0},{1},{2},{3}", this.Nombre, this.Apellido, this.Edad, this.Sexo);
    }



  }
}
