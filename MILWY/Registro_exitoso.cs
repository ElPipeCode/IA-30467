using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MILWY
{
    public partial class Registro_exitoso : Form
    {
        public Registro_exitoso()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Cambio = new Form1();
            this.Hide(); //oculta la forma actual
            Cambio.Show(); // muestra la forma2
        }
    }
}
