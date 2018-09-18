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
    public partial class Form2 : Form
    {
        private tempera _miTempera;

        public Form2()
        {
            InitializeComponent();

            foreach(ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.comboBox1.Items.Add(color);
            }

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.SelectedItem = ConsoleColor.Red;
        }

        public tempera MiTempera {

            get { return this._miTempera; }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marca = this.textBox1.Text;
            sbyte cantidad = sbyte.Parse(this.textBox2.Text);
            System.ConsoleColor color = (System.ConsoleColor)this.comboBox1.SelectedItem;

            this._miTempera = new tempera(cantidad,color,marca);
            this.DialogResult= DialogResult.OK;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
