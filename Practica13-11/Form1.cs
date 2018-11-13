using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Practica13_11
{
  public delegate void MiDelegado(Object a, EventArgs b);

  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }


    public void MiManejadorClick(object o,EventArgs e)
    {
       MessageBox.Show(((Control)o).Name);
    }

    public void MiOtroManejador(object o, EventArgs e)
    {
      //saca el manejador de eventos del button 2
      /*this.button2.Click -= new EventHandler(MiManejadorClick);
      this.button1.Click += new EventHandler(MiManejadorClick);
      this.button1.Click += new EventHandler(CambiarFondo);*/


    }

    public void MiManejadorCentral(object o, EventArgs e)
    {
      if (Object.Equals(o,button1))
      {
        
        this.button1.Click -= new EventHandler(MiManejadorClick);
        this.button2.Click += new EventHandler(MiManejadorClick);
      }
      if (Object.Equals(button2, o))
      {
        
        this.button2.Click -= new EventHandler(MiManejadorClick);
        this.textBox1.Click += new EventHandler(MiManejadorClick);
      }
      if (Object.Equals(textBox1,o))
      {
        this.textBox1.Click -= new EventHandler(MiManejadorClick);
        this.button1.Click += new EventHandler(MiManejadorClick);
      }

    }



    public void CambiarFondo(object o, EventArgs e)
    {
      ((Control)o).BackColor = Color.Azure;
    }


    private void Form1_Load(object sender, EventArgs e)
    {
      //1 evento, varios manejadores.
      /*this.button1.Click += new EventHandler(MiManejadorClick);
      this.button2.Click += new EventHandler(MiManejadorClick);
      this.textBox1.Click+= new EventHandler(MiManejadorClick);
      this.button2.Click += new EventHandler(MiOtroManejador);//Saca el evento al objeto button2 y asigno al button 1 otro mas.
      //y cambio de color.*/

      this.button1.Click += new EventHandler(MiManejadorClick);
      this.button1.Click += new EventHandler(MiManejadorCentral);
      this.button2.Click += new EventHandler(MiManejadorCentral);
      this.textBox1.Click += new EventHandler(MiManejadorCentral);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      //Saco todos los eventos de los controles.
      /*this.button1.Click -= new EventHandler(MiManejadorClick);
      this.button2.Click -= new EventHandler(MiManejadorClick);
      this.textBox1.Click -= new EventHandler(MiManejadorClick);
      this.button2.Click -= new EventHandler(MiOtroManejador);
    }

    private void button2_Click(object sender, EventArgs e)
    {
     
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    
  }
}
