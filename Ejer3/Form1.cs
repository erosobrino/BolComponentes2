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
        public Form2 form2;
        Bitmap img;
        string[] imagenes = new string[] { ".BMP", ".GIF", ".JPG", ".JPEG", ".PNG", ".TIFF", ".ico" };
        List<string> rutas = new List<string>();
        int index;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Selecciona una imagen";
            openFile.InitialDirectory = Environment.GetEnvironmentVariable("homedrive") + "\\" + Environment.GetEnvironmentVariable("homepath");
            openFile.Filter = "Todos (*.*)|*.*";
            openFile.ValidateNames = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                rutas.Clear();
                bool valido = false;
                FileInfo f = new FileInfo(openFile.FileName);
                for (int i = 0; i < imagenes.Length; i++)
                {
                    if (!valido)
                    {
                        if (String.Equals(f.Extension, imagenes[i], StringComparison.OrdinalIgnoreCase))
                        {
                            valido = true;
                        }
                    }
                }
                if (valido)
                {
                    lblError.Text = "";
                    lblDirectorio.Text = f.DirectoryName;
                    DirectoryInfo d = new DirectoryInfo(f.DirectoryName);
                    foreach (FileInfo fileInfo in d.GetFiles())
                        for (int i = 0; i < imagenes.Length; i++)
                        {
                            if (String.Equals(fileInfo.Extension, imagenes[i], StringComparison.OrdinalIgnoreCase))
                            {
                                rutas.Add(fileInfo.FullName);
                                if (fileInfo.FullName == openFile.FileName)
                                {
                                    index = rutas.Count - 1;
                                }
                            }
                        }
                    muestraImg();
                }
                else
                {
                    lblError.Text = "Error en el archivo";
                }
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
                muestraImg();
            }
        }

        public void btAnterior_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                muestraImg();
            }
        }

        private void muestraImg()
        {
            try
            {
                lblError.Text = "";
                lblInfo.Text = "";
                img = new Bitmap(rutas[index]);
                form2.Visible = true;
                form2.Size = img.Size;
                form2.pictureBox1.Image = img;
                form2.Top = (Screen.PrimaryScreen.WorkingArea.Height - form2.Height) / 2;
                form2.Left = (Screen.PrimaryScreen.WorkingArea.Width - form2.Width) / 2;
                Text = "Visor de Imagenes -<" + rutas[index].Substring(rutas[index].LastIndexOf('\\') + 1) + ">";
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
            catch (ArgumentException)
            {
                lblError.Text = "Error en el archivo";
                form2.Visible = false;
            }
        }

        private void KeyDown_Flechas(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                btAnterior_Click(sender, e);
            }
            if (e.KeyCode == Keys.D)
            {
                btSiguiente_Click(sender, e);
            }
        }
    }
}
