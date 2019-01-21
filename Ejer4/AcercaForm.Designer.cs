namespace Ejer4
{
    partial class AcercaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaForm));
            this.lblAcercaDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAcercaDe
            // 
            this.lblAcercaDe.AutoSize = true;
            this.lblAcercaDe.Location = new System.Drawing.Point(37, 25);
            this.lblAcercaDe.Name = "lblAcercaDe";
            this.lblAcercaDe.Size = new System.Drawing.Size(217, 17);
            this.lblAcercaDe.TabIndex = 0;
            this.lblAcercaDe.Text = "Ero Sobrino Dorado @CopyRight";
            // 
            // AcercaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 77);
            this.Controls.Add(this.lblAcercaDe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AcercaForm";
            this.Text = "Acerca de";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAcercaDe;
    }
}