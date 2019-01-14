namespace Ejer3
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
            this.btAbrir = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.lblDirectorio = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(268, 45);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(94, 47);
            this.btAbrir.TabIndex = 1;
            this.btAbrir.Text = "Abrir";
            this.toolTip1.SetToolTip(this.btAbrir, "Abrir imagen");
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            this.btAbrir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Flechas);
            // 
            // btAnterior
            // 
            this.btAnterior.Location = new System.Drawing.Point(62, 45);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(94, 47);
            this.btAnterior.TabIndex = 0;
            this.btAnterior.Text = "Anterior";
            this.toolTip1.SetToolTip(this.btAnterior, "Mostrar anterior imagen");
            this.btAnterior.UseVisualStyleBackColor = true;
            this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
            this.btAnterior.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Flechas);
            // 
            // btSiguiente
            // 
            this.btSiguiente.Location = new System.Drawing.Point(466, 45);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(94, 47);
            this.btSiguiente.TabIndex = 2;
            this.btSiguiente.Text = "Siguiente";
            this.toolTip1.SetToolTip(this.btSiguiente, "Mostrar siguiente imagen");
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            this.btSiguiente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Flechas);
            // 
            // lblDirectorio
            // 
            this.lblDirectorio.AutoSize = true;
            this.lblDirectorio.Location = new System.Drawing.Point(48, 165);
            this.lblDirectorio.Name = "lblDirectorio";
            this.lblDirectorio.Size = new System.Drawing.Size(0, 17);
            this.lblDirectorio.TabIndex = 3;
            this.toolTip1.SetToolTip(this.lblDirectorio, "Informacion del directorio de trabajo");
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(124, 348);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.lblInfo, "Informacion de la imagen");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 258);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblDirectorio);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.btAnterior);
            this.Controls.Add(this.btAbrir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Visor de Imagenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Flechas);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Label lblDirectorio;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

