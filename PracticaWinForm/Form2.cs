using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaWinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


            foreach (ConsoleColor color in ConsoleColor.GetValues(typeof(ConsoleColor)))
            {
                this.cboBox1.Items.Add(color);
            }

            this.cboBox1.SelectedItem = ConsoleColor.Red;
            this.cboBox1.DropDownStyle = ComboBoxStyle.DropDownList;


            foreach (EtipoTinta tinta in Enum.GetValues(typeof(EtipoTinta)))
            {
                this.cboBox2.Items.Add(tinta);
            }

            this.cboBox2.SelectedItem = EtipoTinta.Comon;
            this.cboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        
    }
}
