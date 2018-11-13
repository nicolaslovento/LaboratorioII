using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaForm13_11
{
  public partial class Form1 : Form
  {
    public ActualizarNombrePorDelegado miDel;

    public Form1()
    {
      InitializeComponent();
      IsMdiContainer = true;

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      
    }

    private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
    {

      FormDatos datos = new FormDatos();
      datos.Show(this);
      this.miDel += new ActualizarNombrePorDelegado(datos.ActualizarNombre);


      frmTestDelegados frmTestDelegados = new frmTestDelegados();
      frmTestDelegados.Show(this);
      this.miDel.Invoke("Probando");//explicita
      //this.miDel("Probando");implicita



    }
  }
}
