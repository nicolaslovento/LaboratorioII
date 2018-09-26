using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NuevasEntidades;


namespace practicaFormClase8
{
    public partial class Form1 : Form
    {
        private PaletaC _miPaleta;
        public Form1()
        {
            InitializeComponent();
            this._miPaleta = (PaletaC)5;
            this.agregarTemperaToolStripMenuItem.Enabled = true;
            this.groupBox1.Enabled = false;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            string texto=this.textBox1.SelectedText;
            int index = 0;
            foreach(string item in this.textBox1.Lines)
            {
                if (texto == item)
                {
                    break;
                }
                index++;
            }
            index = index - 1;
            texto += " Posicion" + index.ToString();

            MessageBox.Show(texto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            DialogResult rta = form2.ShowDialog();

            if (rta == DialogResult.OK)
            {
                this._miPaleta += form2.MiTempera;
                this.textBox1.Text = (string)this._miPaleta;

            }
        }

        private void agregarTemperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = true;
        }
    }
}
