using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MILWY
{
    public partial class Interfaz : Form
    {
       
        public Interfaz()
        {
            InitializeComponent();
            
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 Cambio = new Form1();
            this.Hide(); //oculta la forma actual
            Cambio.Show(); // muestra la forma2
        }
    }
}
