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
  public partial class frmTestDelegados : Form
  {
    public frmTestDelegados()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string nombre="";
      nombre=this.textBox1.Text;
      ((Form1)this.Owner).miDel(nombre);//instancia del form dueño del form actual
      
    }
  }
}
