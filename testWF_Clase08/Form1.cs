using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesClase7;//agrego la biblioteca de clases que agregamos.(sirve para no escribir más codigo al utilizar las clases.)

namespace testWF_Clase08
{
  public partial class Form1 : Form
  {
    Paleta _miPaleta;

    public Form1()
    {
      InitializeComponent();
      this._miPaleta = 5;
    }



  }
}
