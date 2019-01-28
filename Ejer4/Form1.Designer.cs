namespace Ejer4
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
            this.tbNote = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoTextoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.recientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionMayusculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionMinusculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.colorFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.ajusteDeLineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSNuevo = new System.Windows.Forms.ToolStripButton();
            this.tSGuardar = new System.Windows.Forms.ToolStripButton();
            this.tSAbrir = new System.Windows.Forms.ToolStripButton();
            this.tSAjusteLinea = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNote
            // 
            this.tbNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNote.Location = new System.Drawing.Point(0, 55);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNote.Size = new System.Drawing.Size(800, 510);
            this.tbNote.TabIndex = 0;
            this.tbNote.WordWrap = false;
            this.tbNote.TextChanged += new System.EventHandler(this.tbNota_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoTextoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoTextoToolStripMenuItem
            // 
            this.nuevoTextoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoTextoToolStripMenuItem1,
            this.guardarToolStripMenuItem,
            this.abrirArchivoToolStripMenuItem,
            this.toolStripMenuItem8,
            this.recientesToolStripMenuItem1});
            this.nuevoTextoToolStripMenuItem.Name = "nuevoTextoToolStripMenuItem";
            this.nuevoTextoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.nuevoTextoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoTextoToolStripMenuItem1
            // 
            this.nuevoTextoToolStripMenuItem1.Name = "nuevoTextoToolStripMenuItem1";
            this.nuevoTextoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoTextoToolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
            this.nuevoTextoToolStripMenuItem1.Text = "&Nuevo Texto";
            this.nuevoTextoToolStripMenuItem1.ToolTipText = "Inicia en blanco";
            this.nuevoTextoToolStripMenuItem1.Click += new System.EventHandler(this.Nuevo);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            this.guardarToolStripMenuItem.ToolTipText = "Guardar el archivo";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.abrirArchivoToolStripMenuItem.Text = "&Abrir Archivo";
            this.abrirArchivoToolStripMenuItem.ToolTipText = "Abrir un archivo";
            this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.Abrir);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(217, 6);
            // 
            // recientesToolStripMenuItem1
            // 
            this.recientesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.recientesToolStripMenuItem1.Name = "recientesToolStripMenuItem1";
            this.recientesToolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
            this.recientesToolStripMenuItem1.Text = "&Recientes";
            this.recientesToolStripMenuItem1.DropDownOpened += new System.EventHandler(this.recientesToolStripMenuItem1_DropDownOpened);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(75, 26);
            this.toolStripMenuItem1.Visible = false;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.Reciente_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(75, 26);
            this.toolStripMenuItem2.Visible = false;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Reciente_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(75, 26);
            this.toolStripMenuItem3.Visible = false;
            this.toolStripMenuItem3.Click += new System.EventHandler(this.Reciente_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(75, 26);
            this.toolStripMenuItem4.Visible = false;
            this.toolStripMenuItem4.Click += new System.EventHandler(this.Reciente_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(75, 26);
            this.toolStripMenuItem5.Visible = false;
            this.toolStripMenuItem5.Click += new System.EventHandler(this.Reciente_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshacerToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.cortarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.toolStripMenuItem9,
            this.seleccionarTodoToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.deshacerToolStripMenuItem.Text = "&Deshacer";
            this.deshacerToolStripMenuItem.ToolTipText = "Vuelve al estado anterior";
            this.deshacerToolStripMenuItem.Click += new System.EventHandler(this.deshacerToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.copiarToolStripMenuItem.Text = "&Copiar";
            this.copiarToolStripMenuItem.ToolTipText = "Copia el texto seleccionado";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.cortarToolStripMenuItem.Text = "&Cortar";
            this.cortarToolStripMenuItem.ToolTipText = "Corta el texto seleccionado";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.pegarToolStripMenuItem.Text = "&Pegar";
            this.pegarToolStripMenuItem.ToolTipText = "Pega el texto copiado o cortado anteriormente";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            this.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            this.seleccionarTodoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.seleccionarTodoToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.seleccionarTodoToolStripMenuItem.Text = "&Seleccionar Todo";
            this.seleccionarTodoToolStripMenuItem.ToolTipText = "Selecciona todo el texto";
            this.seleccionarTodoToolStripMenuItem.Click += new System.EventHandler(this.seleccionarTodoToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionMayusculasToolStripMenuItem,
            this.seleccionMinusculasToolStripMenuItem,
            this.seleccionNormalToolStripMenuItem,
            this.toolStripMenuItem6,
            this.colorFuenteToolStripMenuItem,
            this.colorFondoToolStripMenuItem,
            this.tipoFuenteToolStripMenuItem,
            this.toolStripMenuItem7,
            this.ajusteDeLineaToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // seleccionMayusculasToolStripMenuItem
            // 
            this.seleccionMayusculasToolStripMenuItem.Name = "seleccionMayusculasToolStripMenuItem";
            this.seleccionMayusculasToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.seleccionMayusculasToolStripMenuItem.Text = "&Seleccion Mayusculas";
            this.seleccionMayusculasToolStripMenuItem.ToolTipText = "Cambia el modo del texto a mayusculas";
            this.seleccionMayusculasToolStripMenuItem.Click += new System.EventHandler(this.seleccionMayusculasToolStripMenuItem_Click);
            // 
            // seleccionMinusculasToolStripMenuItem
            // 
            this.seleccionMinusculasToolStripMenuItem.Name = "seleccionMinusculasToolStripMenuItem";
            this.seleccionMinusculasToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.seleccionMinusculasToolStripMenuItem.Text = "&Seleccion Minusculas";
            this.seleccionMinusculasToolStripMenuItem.ToolTipText = "Cambia el modo del texto a minusculas";
            this.seleccionMinusculasToolStripMenuItem.Click += new System.EventHandler(this.seleccionMinusculasToolStripMenuItem_Click);
            // 
            // seleccionNormalToolStripMenuItem
            // 
            this.seleccionNormalToolStripMenuItem.Name = "seleccionNormalToolStripMenuItem";
            this.seleccionNormalToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.seleccionNormalToolStripMenuItem.Text = "&Seleccion Normal";
            this.seleccionNormalToolStripMenuItem.ToolTipText = "Cambia el modo del texto a normal";
            this.seleccionNormalToolStripMenuItem.Click += new System.EventHandler(this.seleccionNormalToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(223, 6);
            // 
            // colorFuenteToolStripMenuItem
            // 
            this.colorFuenteToolStripMenuItem.Name = "colorFuenteToolStripMenuItem";
            this.colorFuenteToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.colorFuenteToolStripMenuItem.Text = "Color &Fuente";
            this.colorFuenteToolStripMenuItem.ToolTipText = "Formulario para cambiar la fuente";
            this.colorFuenteToolStripMenuItem.Click += new System.EventHandler(this.colorFuenteToolStripMenuItem_Click);
            // 
            // colorFondoToolStripMenuItem
            // 
            this.colorFondoToolStripMenuItem.Name = "colorFondoToolStripMenuItem";
            this.colorFondoToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.colorFondoToolStripMenuItem.Text = "&Color Fondo";
            this.colorFondoToolStripMenuItem.ToolTipText = "Formulario para cambiar el color de fondo";
            this.colorFondoToolStripMenuItem.Click += new System.EventHandler(this.colorFondoToolStripMenuItem_Click);
            // 
            // tipoFuenteToolStripMenuItem
            // 
            this.tipoFuenteToolStripMenuItem.Name = "tipoFuenteToolStripMenuItem";
            this.tipoFuenteToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.tipoFuenteToolStripMenuItem.Text = "&Tipo Fuente";
            this.tipoFuenteToolStripMenuItem.ToolTipText = "Formulario para cambiar el color del texto";
            this.tipoFuenteToolStripMenuItem.Click += new System.EventHandler(this.tipoFuenteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(223, 6);
            // 
            // ajusteDeLineaToolStripMenuItem
            // 
            this.ajusteDeLineaToolStripMenuItem.Name = "ajusteDeLineaToolStripMenuItem";
            this.ajusteDeLineaToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.ajusteDeLineaToolStripMenuItem.Text = "Ajuste de linea";
            this.ajusteDeLineaToolStripMenuItem.ToolTipText = "Ajusta la linea al tamaño del formulario";
            this.ajusteDeLineaToolStripMenuItem.Click += new System.EventHandler(this.ajusteDeLineaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca &de";
            this.acercaDeToolStripMenuItem.ToolTipText = "Muestra informacion del creador";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSNuevo,
            this.tSGuardar,
            this.tSAbrir,
            this.tSAjusteLinea});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSNuevo
            // 
            this.tSNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tSNuevo.Image")));
            this.tSNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSNuevo.Name = "tSNuevo";
            this.tSNuevo.Size = new System.Drawing.Size(56, 24);
            this.tSNuevo.Text = "Nuevo";
            this.tSNuevo.Click += new System.EventHandler(this.tSNuevo_Click);
            // 
            // tSGuardar
            // 
            this.tSGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tSGuardar.Image")));
            this.tSGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSGuardar.Name = "tSGuardar";
            this.tSGuardar.Size = new System.Drawing.Size(66, 24);
            this.tSGuardar.Text = "Guardar";
            this.tSGuardar.Click += new System.EventHandler(this.tSGuardar_Click);
            // 
            // tSAbrir
            // 
            this.tSAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSAbrir.Image = ((System.Drawing.Image)(resources.GetObject("tSAbrir.Image")));
            this.tSAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSAbrir.Name = "tSAbrir";
            this.tSAbrir.Size = new System.Drawing.Size(46, 24);
            this.tSAbrir.Text = "Abrir";
            this.tSAbrir.Click += new System.EventHandler(this.tSAbrir_Click);
            // 
            // tSAjusteLinea
            // 
            this.tSAjusteLinea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSAjusteLinea.Image = ((System.Drawing.Image)(resources.GetObject("tSAjusteLinea.Image")));
            this.tSAjusteLinea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSAjusteLinea.Name = "tSAjusteLinea";
            this.tSAjusteLinea.Size = new System.Drawing.Size(111, 24);
            this.tSAjusteLinea.Text = "Ajuste de linea";
            this.tSAjusteLinea.Click += new System.EventHandler(this.tSAjusteLinea_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(300, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Editor de texto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoTextoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionMayusculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionMinusculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoFuenteToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.ToolStripMenuItem ajusteDeLineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSNuevo;
        private System.Windows.Forms.ToolStripButton tSGuardar;
        private System.Windows.Forms.ToolStripButton tSAbrir;
        private System.Windows.Forms.ToolStripButton tSAjusteLinea;
        public System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
    }
}
