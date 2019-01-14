using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer3
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2()
        {
            InitializeComponent();
        }

        private void siguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1.btSiguiente_Click(sender, e);
        }

        private void anteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1.btAnterior_Click(sender, e);
        }

        private void cerrarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                form1.btSiguiente_Click(sender, e);
            }
            if (e.KeyCode == Keys.D)
            {
                form1.btAnterior_Click(sender, e);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            form1 = (Form1)Owner;
        }
    }
}
