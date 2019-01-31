using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer4
{
    //Validado
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
            acercaDeToolStripMenuItem.Click += (Sender, Ev) => new AcercaForm().ShowDialog();
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
                            tbNote.AppendText(Environment.NewLine);
                        }
                        //tbNota.Text = reader.ReadToEnd();
                    }
                    ruta = openFile.FileName;

                    bool esta = false;
                    for (int i = 0; i < rutasArchivos.Length; i++)
                    {
                        if (!esta)
                        {
                            if (rutasArchivos[i] != null)
                            {
                                if (rutasArchivos[i].ToUpper().Equals(ruta.ToUpper()))
                                {
                                    esta = true;
                                }
                            }
                        }
                    }
                    if (!esta)
                    {
                        for (int i = rutasArchivos.Length - 1; i > 0; i--)
                        {
                            rutasArchivos[i] = rutasArchivos[i - 1];
                            bool boolTexto = recientesToolStripMenuItem1.DropDownItems[i].Text.Length > 1;
                            recientesToolStripMenuItem1.DropDownItems[i].Visible = boolTexto;
                        }
                        rutasArchivos[0] = ruta;
                        recientesToolStripMenuItem1.DropDownItems[0].Visible = true;
                    }
                    modificado = false;
                }
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
                bool esta = false;
                for (int i = 0; i < rutasArchivos.Length; i++)
                {
                    if (!esta)
                    {
                        if (rutasArchivos[i] != null)
                        {
                            if (rutasArchivos[i].ToUpper().Equals(ruta.ToUpper()))
                            {
                                esta = true;
                            }
                        }
                    }
                }
                if (!esta)
                {
                    for (int i = rutasArchivos.Length - 1; i > 0; i--)
                    {
                        rutasArchivos[i] = rutasArchivos[i - 1];
                        bool boolTexto = recientesToolStripMenuItem1.DropDownItems[i].Text.Length > 1;
                        recientesToolStripMenuItem1.DropDownItems[i].Visible = boolTexto;
                    }
                    rutasArchivos[0] = ruta;
                    recientesToolStripMenuItem1.DropDownItems[0].Visible = true;
                }
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

        private void Reciente_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            DialogResult oldText = opciones(sender, e);
            if (oldText.Equals(DialogResult.OK))
            {
                tbNote.Text = "";
                try
                {
                    using (StreamReader reader = new StreamReader(menuItem.Text))
                    {
                        String line = reader.ReadLine();
                        while (line != null)
                        {
                            tbNote.AppendText(line);
                            line = reader.ReadLine();
                        }
                        //tbNota.Text = reader.ReadToEnd();
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("This file doesnt exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    for (int i = 0; i < rutasArchivos.Length; i++)
                    {
                        if (rutasArchivos[i] == menuItem.Text)
                        {
                            rutasArchivos[i] = "";
                            recientesToolStripMenuItem1.DropDownItems[i].Text = "";
                            recientesToolStripMenuItem1.DropDownItems[i].Visible = false;
                        }
                    }
                    ruta = menuItem.Text;

                    bool esta = false;
                    for (int i = 0; i < rutasArchivos.Length; i++)
                    {
                        if (!esta)
                        {
                            if (rutasArchivos[i] != null)
                            {
                                if (rutasArchivos[i].ToUpper().Equals(ruta.ToUpper()))
                                {
                                    esta = true;
                                }
                            }
                        }
                    }
                    if (!esta)
                    {
                        for (int i = rutasArchivos.Length - 1; i > 0; i--)
                        {
                            rutasArchivos[i] = rutasArchivos[i - 1];
                            bool boolTexto = recientesToolStripMenuItem1.DropDownItems[i].Text.Length > 1;
                            recientesToolStripMenuItem1.DropDownItems[i].Visible = boolTexto;
                        }
                        rutasArchivos[0] = ruta;
                        recientesToolStripMenuItem1.DropDownItems[0].Visible = true;
                    }
                }
                modificado = false;
            }
        }

        private void ajusteDeLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajusteDeLineaToolStripMenuItem.Checked = !ajusteDeLineaToolStripMenuItem.Checked;
            tbNote.WordWrap = ajusteDeLineaToolStripMenuItem.Checked;
        }

        private void seleccionMayusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seleccionMayusculasToolStripMenuItem.Checked = true;
            seleccionMinusculasToolStripMenuItem.Checked = false;
            seleccionNormalToolStripMenuItem.Checked = false;
            tipoSeleccionado = tipo.mayusculas;
            tbNote.CharacterCasing = CharacterCasing.Upper;
            modificado = false;
        }

        private void seleccionMinusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seleccionMayusculasToolStripMenuItem.Checked = false;
            seleccionMinusculasToolStripMenuItem.Checked = true;
            seleccionNormalToolStripMenuItem.Checked = false;
            tipoSeleccionado = (tipo)2;
            tbNote.CharacterCasing = CharacterCasing.Lower;
            modificado = false;
        }

        private void seleccionNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seleccionMayusculasToolStripMenuItem.Checked = false;
            seleccionMinusculasToolStripMenuItem.Checked = false;
            seleccionNormalToolStripMenuItem.Checked = true;
            tipoSeleccionado = (tipo)3;
            tbNote.CharacterCasing = CharacterCasing.Normal;
            modificado = false;
        }

        private void recientesToolStripMenuItem1_DropDownOpened(object sender, EventArgs e)
        {
            for (int i = 0; i < rutasArchivos.Length; i++)
            {
                if (rutasArchivos[i] != null)
                {
                    recientesToolStripMenuItem1.DropDownItems[i].Text = rutasArchivos[i];
                    bool boolTexto = recientesToolStripMenuItem1.DropDownItems[i].Text.Length > 1;
                    recientesToolStripMenuItem1.DropDownItems[i].Visible = boolTexto;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
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
                        writer.Write(tbNote.WordWrap);
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
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(directorio))
            {
                try
                {
                    using (BinaryReader reader = new BinaryReader(File.Open(directorio, FileMode.Open)))
                    {
                        ajusteLinea = reader.ReadBoolean();
                        tbNote.WordWrap = ajusteLinea;
                        ajusteDeLineaToolStripMenuItem.Checked = ajusteLinea;
                        tipoSeleccionado = (tipo)reader.ReadInt32();
                        switch (tipoSeleccionado)
                        {
                            case (tipo)1:
                                seleccionMayusculasToolStripMenuItem.Checked = true;
                                seleccionMayusculasToolStripMenuItem_Click(sender, e);
                                break;
                            case (tipo)2:
                                seleccionMinusculasToolStripMenuItem.Checked = true;
                                seleccionMinusculasToolStripMenuItem_Click(sender, e);
                                break;
                            case (tipo)3:
                                seleccionNormalToolStripMenuItem.Checked = true;
                                seleccionNormalToolStripMenuItem_Click(sender, e);
                                break;
                        }
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
                }
                catch { }
            }
            if (ruta != null)
            {
                try
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
                                tbNote.AppendText(Environment.NewLine);
                            }
                        }
                        modificado = false;
                    }
                }
                catch (ArgumentException) { }
            }
            for (int i = 0; i < rutasArchivos.Length; i++)
            {
                if (rutasArchivos[i] != null)
                {
                    recientesToolStripMenuItem1.DropDownItems[i].Text = rutasArchivos[i];
                    bool boolTexto = recientesToolStripMenuItem1.DropDownItems[i].Text.Length > 1;
                    recientesToolStripMenuItem1.DropDownItems[i].Visible = boolTexto;
                }
            }
        }
    }
}