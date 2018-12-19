using BolComponentes2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace BolComponentes2
{
    //Validado
    public partial class Form1 : Form
    {
        Icon icon1 = new Icon("D:\\Descargas\\ubuntu.ico");
        //Icon icon1 = new Icon(Properties.Resources.);
        Icon icon2 = new Icon("D:\\Descargas\\Firefox.ico");
        int cont = 0;
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void btTraspasar_Click(object sender, EventArgs e)
        {
            SelectedIndexCollection seleccionIndices = lboxLista1.SelectedIndices;
            for (int i = 0; i < seleccionIndices.Count; i++)
            {
                int id = seleccionIndices[i];
                if (id > lboxLista2.Items.Count)
                {
                    id = lboxLista2.Items.Count;
                }
                lboxLista2.Items.Insert(id, lboxLista1.Items[seleccionIndices[i]]);
            }
            for (int i = seleccionIndices.Count - 1; i >= 0; i--)
            {
                lboxLista1.Items.RemoveAt(seleccionIndices[i]);
            }
            lbl1.Text = lboxLista1.Items.Count + "";
            toolTip1.SetToolTip(this.lboxLista2, "Hay " + lboxLista2.Items.Count + " elementos");
        }

        private void btTraspasar2_Click(object sender, EventArgs e)
        {
            SelectedIndexCollection seleccionIndices = lboxLista2.SelectedIndices;
            for (int i = 0; i < seleccionIndices.Count; i++)
            {
                int id = seleccionIndices[i];
                if (id > lboxLista1.Items.Count)
                {
                    id = lboxLista1.Items.Count;
                }
                lboxLista1.Items.Insert(id, lboxLista2.Items[seleccionIndices[i]]);
            }
            for (int i = seleccionIndices.Count - 1; i >= 0; i--)
            {
                lboxLista2.Items.RemoveAt(seleccionIndices[i]);
            }
            lbl1.Text = lboxLista1.Items.Count + "";
            toolTip1.SetToolTip(this.lboxLista2, "Hay " + lboxLista2.Items.Count + " elementos");
        }

        private void btAñadir_Click(object sender, EventArgs e)
        {
            String texto = tbTexto.Text;
            if (texto.Length > 0)
            {
                lboxLista1.Items.Add(texto);
            }
            lbl1.Text = lboxLista1.Items.Count + "";
        }

        private void btQuitar_Click(object sender, EventArgs e)
        {
            SelectedIndexCollection seleccionIndices = lboxLista1.SelectedIndices;
            for (int i = seleccionIndices.Count - 1; i > -1; i--)
            {
                lboxLista1.Items.RemoveAt(seleccionIndices[i]);
            }
            lbl1.Text = lboxLista1.Items.Count + "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lboxLista1.Items.Add("ero");
            lboxLista1.Items.Add("miguel");
            lboxLista1.Items.Add("julio");
            lboxLista1.Items.Add("dani");
            lboxLista1.Items.Add("alex");
            lbl1.Text = lboxLista1.Items.Count + "";
            lboxLista1_SelectedIndexChanged(sender, e);
            timer.Interval = 1000;
            timer.Tick += new EventHandler(cambiaTitulo);
            timer.Start();
        }

        private void lboxLista1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadena = "Seleccionados: ";
            SelectedIndexCollection seleccionIndices = lboxLista1.SelectedIndices;
            for (int i = 0; i < seleccionIndices.Count; i++)
            {
                cadena += seleccionIndices[i] + " ";
            }
            if (seleccionIndices.Count == 0)
            {
                cadena = "Sin seleccionar";
            }
            lbl2.Text = cadena;
        }

        private void cambiaTitulo(Object myObject, EventArgs eventArgs)
        {
            string titulo = "Ejercicio 1";
            cont++;
            if ((titulo.Length - cont) <= 0)
            {
                cont = 1;
            }
            this.Text = titulo.Substring((titulo.Length - 1 - cont), cont + 1);
            if (cont % 2 == 0)
            {
                if (this.Icon == icon1)
                {
                    this.Icon = icon2;
                }
                else
                {
                    this.Icon = icon1;
                }
            }
        }
    }
}
