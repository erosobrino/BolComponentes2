using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//- Ajuste de línea(El menú dispondrá de un check).
//- Cuadro de Acerca de… modal.Usa una función lambda para lanzar este cuadro. Ver
//apéndice del tema de multihilo de Servicios.
//- Selección de escritura todo en mayúsculas, minúsculas o normal (Se verán Checks).

namespace Ejer4
{
    public partial class Form1 : Form
    {
        enum tipo
        {
            mayusculas = 1,
            minuscula = 2,
            normal = 3
        }
        string directorio = Environment.GetEnvironmentVariable("homedrive") + "\\" + Environment.GetEnvironmentVariable("homepath") + "\\configNotas2.bin";
        bool modificado = false;

        int R, G, B;
        bool ajusteLinea = false;
        tipo tipoSeleccionado = (tipo)3;
        string[] rutasArchivos = new string[5];

        string ruta;
        public Form1()
        {
            InitializeComponent();
        }
        private void Nuevo(object sender, EventArgs e)
        {
            DialogResult res = opciones(sender, e);
            if (res.Equals(DialogResult.OK))
            {
                tbNote.Text = "";
            }
        }

        private DialogResult opciones(object sender, EventArgs e)
        {
            if (tbNote.Text.Length > 0 && modificado)
            {
                DialogResult dialog = MessageBox.Show("Quieres guardar el documento?", "Opciones", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (dialog)
                {
                    case DialogResult.Yes:
                        return Guardar(sender, e);
                    case DialogResult.No:
                        return DialogResult.OK;
                    case DialogResult.Cancel:
                        return DialogResult.Cancel;
                    default: return DialogResult.Cancel;
                }
            }
            else
            {
                return DialogResult.OK;
            }
        }

        private void Abrir(object sender, EventArgs e)
        {
            DialogResult oldText = opciones(sender, e);
            if (oldText.Equals(DialogResult.OK))
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Selecciona el archivo";
                openFile.InitialDirectory = Environment.GetEnvironmentVariable("homedrive");
                openFile.Filter = "Texto (*.txt)|*.txt|INI(*.ini)|*.ini|Java(*.java)|*.java|CS(*.cs)|*.cs|Python(*.py)|*.py|HTML(*.html)|*.html|CSS(*.css)|*.css|XML(*.xml)|*.xml|Todos los archivos|";
                openFile.ValidateNames = true;
                DialogResult res = openFile.ShowDialog();
                if (res == DialogResult.OK)
                {
                    tbNote.Text = "";
                    using (StreamReader reader = new StreamReader(openFile.FileName))
                    {
                        String line = reader.ReadLine();
                        while (line != null)
                        {
                            tbNote.AppendText(line);
                            line = reader.ReadLine();
                        }
                        //tbNota.Text = reader.ReadToEnd();
                    }
                    ruta = openFile.FileName;

                    for (int i = rutasArchivos.Length - 1; i > 0; i--)
                    {
                        rutasArchivos[i] = rutasArchivos[i - 1];
                    }
                    rutasArchivos[0] = ruta;
                }
                modificado = false;
            }
        }



        private DialogResult Guardar(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            DialogResult res = new DialogResult();
            if (tbNote.Text.Length > 0)
            {
                saveFile.Title = "Selecciona la ruta y el nombre";
                saveFile.InitialDirectory = Environment.GetEnvironmentVariable("homedrive");
                saveFile.Filter = "Texto (*.txt)|*.txt|INI(*.ini)|*.ini|Java(*.java)|*.java|CS(*.cs)|*.cs|Python(*.py)|*.py|HTML(*.html)|*.html|CSS(*.css)|*.css|XML(*.xml)|*.xml|Todos los archivos|";
                saveFile.ValidateNames = true;
                res = saveFile.ShowDialog();
                if (res == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFile.FileName))
                    {
                        writer.Write(tbNote.Text);
                    }
                    modificado = false;
                    ruta = saveFile.FileName;
                }
                for (int i = rutasArchivos.Length - 1; i > 0; i--)
                {
                    rutasArchivos[i] = rutasArchivos[i - 1];
                }
                rutasArchivos[0] = ruta;
            }
            return res;
        }

        private void tbNota_TextChanged(object sender, EventArgs e)
        {
            modificado = true;
            int cantidadFrases = tbNote.Text.Split('\n').Length;
            int cantidadPalabras = Regex.Matches(tbNote.Text, @"[\S]+").Count;
            toolTip1.SetToolTip(tbNote, cantidadFrases + " Frases\n" + cantidadPalabras + " Palabras\n" + tbNote.TextLength + " Caracteres");
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar(sender, e);
        }

        private void colorFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult res = colorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                tbNote.ForeColor = colorDialog.Color;
            }
        }

        private void colorFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult res = colorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                tbNote.BackColor = colorDialog.Color;
            }
        }

        private void tipoFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            DialogResult res = fontDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                tbNote.Font = fontDialog.Font;
            }
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbNote.SelectAll();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbNote.Copy();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbNote.Cut();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbNote.Paste();
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbNote.Undo();
        }

        private void recientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rutasArchivos.Length; i++)
            {
                if (rutasArchivos[i] != null)
                {
                    recientesToolStripMenuItem.DropDownItems[i].Text = rutasArchivos[i];
                    bool boolTexto = recientesToolStripMenuItem.DropDownItems[i].Text.Length > 1;
                    recientesToolStripMenuItem.DropDownItems[i].Visible = boolTexto;
                }
            }
        }

        private void ajusteDeLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void seleccionMayusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void seleccionMinusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void seleccionNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AcercaForm().ShowDialog();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = opciones(sender, e);
            if (res.Equals(DialogResult.Cancel))
            {
                e.Cancel = true;
            }
            else
            {
                using (BinaryWriter writer = new BinaryWriter(new FileStream(directorio, FileMode.Create)))
                {
                    writer.Write(ajusteLinea);
                    writer.Write((int)tipoSeleccionado);
                    writer.Write(tbNote.ForeColor.R);
                    writer.Write(tbNote.ForeColor.G);
                    writer.Write(tbNote.ForeColor.B);
                    writer.Write(tbNote.BackColor.R);
                    writer.Write(tbNote.BackColor.G);
                    writer.Write(tbNote.BackColor.B);
                    writer.Write(tbNote.Font.FontFamily.Name);
                    writer.Write((int)tbNote.Font.Size);
                    if (ruta != null)
                    {
                        writer.Write(ruta);
                    }
                    else
                    {
                        writer.Write("");
                    }
                    foreach (string s in rutasArchivos)
                    {
                        if (s == null)
                        {
                            writer.Write("");
                        }
                        else
                            writer.Write(s);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(directorio))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(directorio, FileMode.Open)))
                {
                    try
                    {
                        ajusteLinea = reader.ReadBoolean();
                        tipoSeleccionado = (tipo)reader.ReadInt32();
                        R = reader.ReadByte();
                        G = reader.ReadByte();
                        B = reader.ReadByte();
                        tbNote.ForeColor = Color.FromArgb(R, G, B);
                        R = reader.ReadByte();
                        G = reader.ReadByte();
                        B = reader.ReadByte();
                        tbNote.BackColor = Color.FromArgb(R, G, B);
                        tbNote.Font = new Font(reader.ReadString(), reader.ReadInt32());
                        ruta = reader.ReadString();
                        for (int i = 0; i < rutasArchivos.Length; i++)
                        {
                            rutasArchivos[i] = reader.ReadString();
                        }
                    }
                    catch//No genérico
                    {

                    }
                }
                if (ruta != null)
                {
                    FileInfo file = new FileInfo(ruta);
                    if (file.Exists)
                    {
                        using (StreamReader reader = new StreamReader(ruta))
                        {
                            String linea = reader.ReadLine();
                            while (linea != null)
                            {
                                tbNote.AppendText(linea);
                                linea = reader.ReadLine();
                            }
                        }
                        modificado = false;
                    }
                }
            }
        }
    }
}