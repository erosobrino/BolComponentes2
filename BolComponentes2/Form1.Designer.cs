namespace BolComponentes2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lboxLista1 = new System.Windows.Forms.ListBox();
            this.lboxLista2 = new System.Windows.Forms.ListBox();
            this.btAñadir = new System.Windows.Forms.Button();
            this.btQuitar = new System.Windows.Forms.Button();
            this.btTraspasar = new System.Windows.Forms.Button();
            this.btTraspasar2 = new System.Windows.Forms.Button();
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lboxLista1
            // 
            this.lboxLista1.FormattingEnabled = true;
            this.lboxLista1.ItemHeight = 16;
            this.lboxLista1.Location = new System.Drawing.Point(12, 8);
            this.lboxLista1.Name = "lboxLista1";
            this.lboxLista1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lboxLista1.Size = new System.Drawing.Size(195, 132);
            this.lboxLista1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lboxLista1, "Lista de elementos");
            this.lboxLista1.SelectedIndexChanged += new System.EventHandler(this.lboxLista1_SelectedIndexChanged);
            // 
            // lboxLista2
            // 
            this.lboxLista2.FormattingEnabled = true;
            this.lboxLista2.ItemHeight = 16;
            this.lboxLista2.Location = new System.Drawing.Point(247, 8);
            this.lboxLista2.Name = "lboxLista2";
            this.lboxLista2.Size = new System.Drawing.Size(195, 132);
            this.lboxLista2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.lboxLista2, "Hay 0 elementos");
            // 
            // btAñadir
            // 
            this.btAñadir.Location = new System.Drawing.Point(12, 207);
            this.btAñadir.Name = "btAñadir";
            this.btAñadir.Size = new System.Drawing.Size(195, 54);
            this.btAñadir.TabIndex = 4;
            this.btAñadir.Text = "Añadir";
            this.toolTip1.SetToolTip(this.btAñadir, "Añade el texto del textbox a la primera lista");
            this.btAñadir.UseVisualStyleBackColor = true;
            this.btAñadir.Click += new System.EventHandler(this.btAñadir_Click);
            // 
            // btQuitar
            // 
            this.btQuitar.Location = new System.Drawing.Point(247, 207);
            this.btQuitar.Name = "btQuitar";
            this.btQuitar.Size = new System.Drawing.Size(195, 54);
            this.btQuitar.TabIndex = 5;
            this.btQuitar.Text = "Quitar";
            this.toolTip1.SetToolTip(this.btQuitar, "Elimina el indice seleciconado de la primera lista");
            this.btQuitar.UseVisualStyleBackColor = true;
            this.btQuitar.Click += new System.EventHandler(this.btQuitar_Click);
            // 
            // btTraspasar
            // 
            this.btTraspasar.Location = new System.Drawing.Point(12, 147);
            this.btTraspasar.Name = "btTraspasar";
            this.btTraspasar.Size = new System.Drawing.Size(195, 54);
            this.btTraspasar.TabIndex = 2;
            this.btTraspasar.Text = "Traspasar";
            this.toolTip1.SetToolTip(this.btTraspasar, "Traspasa los elementos seleccionados a la otra lista en el mismo orden");
            this.btTraspasar.UseVisualStyleBackColor = true;
            this.btTraspasar.Click += new System.EventHandler(this.btTraspasar_Click);
            // 
            // btTraspasar2
            // 
            this.btTraspasar2.Location = new System.Drawing.Point(247, 146);
            this.btTraspasar2.Name = "btTraspasar2";
            this.btTraspasar2.Size = new System.Drawing.Size(195, 54);
            this.btTraspasar2.TabIndex = 3;
            this.btTraspasar2.Text = "Traspasar";
            this.toolTip1.SetToolTip(this.btTraspasar2, "Traspasa los elementos seleccionados a la otra lista en el mismo orden");
            this.btTraspasar2.UseVisualStyleBackColor = true;
            this.btTraspasar2.Click += new System.EventHandler(this.btTraspasar2_Click);
            // 
            // tbTexto
            // 
            this.tbTexto.Location = new System.Drawing.Point(12, 324);
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.Size = new System.Drawing.Size(430, 22);
            this.tbTexto.TabIndex = 8;
            this.toolTip1.SetToolTip(this.tbTexto, "Escribe el texto que quieras añadir");
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(21, 284);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(30, 17);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "lbl1";
            this.toolTip1.SetToolTip(this.lbl1, "Cantidad de elementos en la primera lista");
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(244, 284);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(46, 17);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "label2";
            this.toolTip1.SetToolTip(this.lbl2, "Muestra los indices seleccionados");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 367);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.tbTexto);
            this.Controls.Add(this.btTraspasar2);
            this.Controls.Add(this.btTraspasar);
            this.Controls.Add(this.btQuitar);
            this.Controls.Add(this.btAñadir);
            this.Controls.Add(this.lboxLista2);
            this.Controls.Add(this.lboxLista1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxLista1;
        private System.Windows.Forms.ListBox lboxLista2;
        private System.Windows.Forms.Button btAñadir;
        private System.Windows.Forms.Button btQuitar;
        private System.Windows.Forms.Button btTraspasar;
        private System.Windows.Forms.Button btTraspasar2;
        private System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

