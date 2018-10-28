using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diccionario dic = new Diccionario();
            MessageBox.Show(dic.GuardarEnLista(dic, dic.contarPalabras(this.richTextBox1.Text)));
            
            
            
        }
    }
}
