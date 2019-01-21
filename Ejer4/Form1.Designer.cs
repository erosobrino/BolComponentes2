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
            this.recientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajusteDeLineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionMayusculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionMinusculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNote
            // 
            this.tbNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNote.Location = new System.Drawing.Point(0, 28);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNote.Size = new System.Drawing.Size(800, 537);
            this.tbNote.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tbNote, "p");
            this.tbNote.TextChanged += new System.EventHandler(this.tbNota_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoTextoToolStripMenuItem,
            this.recientesToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ajusteDeLineaToolStripMenuItem,
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
            this.abrirArchivoToolStripMenuItem});
            this.nuevoTextoToolStripMenuItem.Name = "nuevoTextoToolStripMenuItem";
            this.nuevoTextoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.nuevoTextoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoTextoToolStripMenuItem1
            // 
            this.nuevoTextoToolStripMenuItem1.Name = "nuevoTextoToolStripMenuItem1";
            this.nuevoTextoToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.nuevoTextoToolStripMenuItem1.Text = "&Nuevo Texto";
            this.nuevoTextoToolStripMenuItem1.Click += new System.EventHandler(this.Nuevo);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.abrirArchivoToolStripMenuItem.Text = "&Abrir Archivo";
            this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.Abrir);
            // 
            // recientesToolStripMenuItem
            // 
            this.recientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.recientesToolStripMenuItem.Name = "recientesToolStripMenuItem";
            this.recientesToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.recientesToolStripMenuItem.Text = "&Recientes";
            this.recientesToolStripMenuItem.Click += new System.EventHandler(this.recientesToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshacerToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.cortarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.seleccionarTodoToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.deshacerToolStripMenuItem.Text = "&Deshacer";
            this.deshacerToolStripMenuItem.Click += new System.EventHandler(this.deshacerToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.copiarToolStripMenuItem.Text = "&Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.cortarToolStripMenuItem.Text = "&Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.pegarToolStripMenuItem.Text = "&Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            this.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            this.seleccionarTodoToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.seleccionarTodoToolStripMenuItem.Text = "&Seleccionar Todo";
            this.seleccionarTodoToolStripMenuItem.Click += new System.EventHandler(this.seleccionarTodoToolStripMenuItem_Click);
            // 
            // ajusteDeLineaToolStripMenuItem
            // 
            this.ajusteDeLineaToolStripMenuItem.Name = "ajusteDeLineaToolStripMenuItem";
            this.ajusteDeLineaToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.ajusteDeLineaToolStripMenuItem.Text = "&Ajuste de linea";
            this.ajusteDeLineaToolStripMenuItem.Click += new System.EventHandler(this.ajusteDeLineaToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionMayusculasToolStripMenuItem,
            this.seleccionMinusculasToolStripMenuItem,
            this.seleccionNormalToolStripMenuItem,
            this.colorFuenteToolStripMenuItem,
            this.colorFondoToolStripMenuItem,
            this.tipoFuenteToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // seleccionMayusculasToolStripMenuItem
            // 
            this.seleccionMayusculasToolStripMenuItem.Name = "seleccionMayusculasToolStripMenuItem";
            this.seleccionMayusculasToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.seleccionMayusculasToolStripMenuItem.Text = "&Seleccion Mayusculas";
            this.seleccionMayusculasToolStripMenuItem.Click += new System.EventHandler(this.seleccionMayusculasToolStripMenuItem_Click);
            // 
            // seleccionMinusculasToolStripMenuItem
            // 
            this.seleccionMinusculasToolStripMenuItem.Name = "seleccionMinusculasToolStripMenuItem";
            this.seleccionMinusculasToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.seleccionMinusculasToolStripMenuItem.Text = "&Seleccion Minusculas";
            this.seleccionMinusculasToolStripMenuItem.Click += new System.EventHandler(this.seleccionMinusculasToolStripMenuItem_Click);
            // 
            // seleccionNormalToolStripMenuItem
            // 
            this.seleccionNormalToolStripMenuItem.Name = "seleccionNormalToolStripMenuItem";
            this.seleccionNormalToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.seleccionNormalToolStripMenuItem.Text = "&Seleccion Normal";
            this.seleccionNormalToolStripMenuItem.Click += new System.EventHandler(this.seleccionNormalToolStripMenuItem_Click);
            // 
            // colorFuenteToolStripMenuItem
            // 
            this.colorFuenteToolStripMenuItem.Name = "colorFuenteToolStripMenuItem";
            this.colorFuenteToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.colorFuenteToolStripMenuItem.Text = "Color &Fuente";
            this.colorFuenteToolStripMenuItem.Click += new System.EventHandler(this.colorFuenteToolStripMenuItem_Click);
            // 
            // colorFondoToolStripMenuItem
            // 
            this.colorFondoToolStripMenuItem.Name = "colorFondoToolStripMenuItem";
            this.colorFondoToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.colorFondoToolStripMenuItem.Text = "&Color Fondo";
            this.colorFondoToolStripMenuItem.Click += new System.EventHandler(this.colorFondoToolStripMenuItem_Click);
            // 
            // tipoFuenteToolStripMenuItem
            // 
            this.tipoFuenteToolStripMenuItem.Name = "tipoFuenteToolStripMenuItem";
            this.tipoFuenteToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.tipoFuenteToolStripMenuItem.Text = "&Tipo Fuente";
            this.tipoFuenteToolStripMenuItem.Click += new System.EventHandler(this.tipoFuenteToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(216, 26);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(216, 26);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(216, 26);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Editor de texto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNote;
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
        private System.Windows.Forms.ToolStripMenuItem ajusteDeLineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionMayusculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionMinusculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoFuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ToolStripMenuItem recientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}
