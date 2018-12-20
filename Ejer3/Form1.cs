using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer3
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        Bitmap img;
        string[] imagenes = new string[] { ".BMP", ".GIF", ".JPEG", ".PNG", ".TIFF", ".ico" };
        List<string> rutas = new List<string>();
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Selecciona una imagen";
            openFile.InitialDirectory = "C:\\";
            openFile.Filter = "Todos (*.*)|*.*";
            openFile.ValidateNames = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                rutas.Clear();
                img = new Bitmap(openFile.FileName);
                lblDirectorio.Text = openFile.FileName.Substring(0, openFile.FileName.Length - openFile.FileName.LastIndexOf('\\'));
                DirectoryInfo d = new DirectoryInfo(lblDirectorio.Text);
                foreach (FileInfo f in d.GetFiles())
                    for (int i = 0; i < imagenes.Length; i++)
                    {
                        if (String.Equals(f.Extension, imagenes[i], StringComparison.OrdinalIgnoreCase))
                        {
                            rutas.Add(f.FullName);
                            if (f.FullName == lblDirectorio.Text)
                            {
                                index = rutas.Count - 1;
                            }
                        }
                    }
                muestraImg();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {

            if (index < rutas.Count - 1)
            {
                index++;
                img = new Bitmap(rutas[index]);
                muestraImg();
            }
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                img = new Bitmap(rutas[index]);
                muestraImg();
            }
        }

        private void muestraImg()
        {
            form2.BackgroundImage = img;
            form2.Size = img.Size;
            form2.Show();
            Text = "Visor de Imagenes -<" + rutas[index].Substring(rutas[index].Length - rutas[index].LastIndexOf('\\') + 1) + ">";
            lblInfo.Text = rutas[index].Substring(rutas[index].Length - rutas[index].LastIndexOf('\\') + 2);
            lblInfo.Text += "\n" + new FileInfo(rutas[index]).Length + "\n" + img.Size;
        }
    }
}
