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
        public Form2 form2 = new Form2();
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
                lblDirectorio.Text = openFile.FileName.Substring(0, openFile.FileName.Length - openFile.FileName.LastIndexOf('\\') - 1);
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

        public void btSiguiente_Click(object sender, EventArgs e)
        {

            if (index < rutas.Count - 1)
            {
                index++;
                img = new Bitmap(rutas[index]);
                muestraImg();
            }
        }

        public void btAnterior_Click(object sender, EventArgs e)
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
            form2.Visible = false;
            form2.BackgroundImage = img;
            form2.Size = img.Size;
            form2.Top = (Screen.PrimaryScreen.WorkingArea.Height - form2.Height) / 2;
            form2.Left = (Screen.PrimaryScreen.WorkingArea.Width - form2.Width) / 2;
            form2.Show(this);
            Text = "Visor de Imagenes -<" + rutas[index].Substring(rutas[index].LastIndexOf('\\')+1) + ">";
            lblInfo.Text = rutas[index].Substring(rutas[index].LastIndexOf('\\') + 1);
            long tamaño = new FileInfo(rutas[index]).Length;
            string cadenaLong = "";
            if (tamaño > 1024 && tamaño < 1048576)
            {
                cadenaLong = tamaño / 1024 + "KB";
            }
            if (tamaño >= 1048576)
            {
                cadenaLong = tamaño / 1048576 + "MB";
            }
            lblInfo.Text += "\n" + cadenaLong + "\n Alto: " + img.Size.Height + "\nAncho: " + img.Size.Width;
        }

        private void KeyDown_Flechas(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                btSiguiente_Click(sender, e);
            }
            if (e.KeyCode == Keys.D)
            {
                btAnterior_Click(sender, e);
            }
        }
    }
}
