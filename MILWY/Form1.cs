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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register Cambio = new Register();
            this.Hide(); //oculta la forma actual
            Cambio.Show(); // muestra la forma2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interfaz Cambio = new Interfaz();
            this.Hide(); //oculta la forma actual
            Cambio.Show(); // muestra la forma2
        }
    }
}
