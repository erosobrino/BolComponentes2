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

namespace Ejer2
{
    //Validado
    public partial class Form1 : Form
    {
        bool acertada = false;
        int contraseña = 1111;
        string[] teclas = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "*", "0", "#" };
        string a = "123456789*0#";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 formPin = new Form2();
            DialogResult res = DialogResult.Cancel;
            int cont = 0;
            while (cont <= 3 && !acertada)
            {
                if (cont == 3)
                {
                    this.Close();
                }
                try
                {
                    res = formPin.ShowDialog();
                }
                catch (ObjectDisposedException) { }
                switch (res)
                {
                    case DialogResult.OK:
                        formPin.lblError.Text = "";
                        int pin = -1;
                        try
                        {
                            pin = Convert.ToInt32(formPin.txtPin.Text);
                        }
                        catch (FormatException)
                        {
                            formPin.lblError.Text = "Error al introducir el Pin";
                            formPin.lblError.Text = pin + "";
                        }
                        catch (OverflowException)
                        {
                            formPin.lblError.Text = "El pin es demasiado grande";
                        }
                        if (!acertada)
                        {
                            if (contraseña == pin)
                            {
                                //formPin.lblError.Text = contraseñas[i] + "";
                                acertada = true;
                            }
                        }
                        if (acertada)
                        {
                            formPin.lblError.Text = "Correcta";
                        }
                        else
                        {
                            formPin.lblError.Text = "El PIN no es correcto";
                        }
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                }
                cont++;
            }
            int contNum = 0;
            int x = 2;
            int y = 60;
            Button bt;
            for (int i = 0; i < teclas.Length; i++)
            {
                contNum++;
                bt = new Button();
                bt.Text = teclas[i];
                bt.Location = new Point(x, y);
                x += 85;
                bt.Size = new Size(75, 75);
                if (contNum % 3 == 0)
                {
                    x = 2;
                    y += 85;
                }
                bt.Enabled = true;
                bt.MouseEnter += MouseEnterBt;
                bt.MouseLeave += MouseExitBt;
                bt.MouseClick += MouseClickBt;
                this.Controls.Add(bt);

            }
        }
        private void MouseEnterBt(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.BackColor != Color.Red)
                bt.BackColor = Color.Blue;
        }

        private void MouseExitBt(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.BackColor != Color.Red)
            {
                bt.BackColor = DefaultBackColor;
                bt.UseVisualStyleBackColor = true;
            }
        }
        private void MouseClickBt(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.Red;
            txtNumero.Text += bt.Text;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    Button bt = (Button)control;
                    bt.BackColor = DefaultBackColor;
                }
            }
            txtNumero.Text = "";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btReset_Click(sender, e);
        }

        private void grabarNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text.Length > 0)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "Select path and name";
                //saveFile.InitialDirectory = "C:\\";
                saveFile.InitialDirectory = "D:\\";
                saveFile.Filter = "Text (*.txt)|*.txt|All files|*.*";
                saveFile.ValidateNames = true;
                saveFile.OverwritePrompt = false;
                DialogResult res = saveFile.ShowDialog();
                if (res == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFile.FileName, true))
                    {
                        writer.WriteLine(txtNumero.Text);
                    }
                }
                btReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Debes introducir un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ero Sobrino Dorado", "Informacion");
        }
    }
}
