namespace Proiect_Fis
{
    partial class ClientOptionsForm
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
            this.btnCreareCont = new System.Windows.Forms.Button();
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.btnVizualizareProduse = new System.Windows.Forms.Button();
            this.btnDepunereComanda = new System.Windows.Forms.Button();
            this.btnDepunereCerereService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreareCont
            // 
            this.btnCreareCont.Location = new System.Drawing.Point(37, 36);
            this.btnCreareCont.Name = "btnCreareCont";
            this.btnCreareCont.Size = new System.Drawing.Size(132, 23);
            this.btnCreareCont.TabIndex = 0;
            this.btnCreareCont.Text = "Creare Cont";
            this.btnCreareCont.UseVisualStyleBackColor = true;
            this.btnCreareCont.Click += new System.EventHandler(this.btnCreareCont_Click);
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.Location = new System.Drawing.Point(37, 86);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(132, 23);
            this.btnAutentificare.TabIndex = 1;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.UseVisualStyleBackColor = true;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // btnVizualizareProduse
            // 
            this.btnVizualizareProduse.Location = new System.Drawing.Point(37, 140);
            this.btnVizualizareProduse.Name = "btnVizualizareProduse";
            this.btnVizualizareProduse.Size = new System.Drawing.Size(132, 23);
            this.btnVizualizareProduse.TabIndex = 2;
            this.btnVizualizareProduse.Text = "Vizualizare Produse";
            this.btnVizualizareProduse.UseVisualStyleBackColor = true;
            this.btnVizualizareProduse.Click += new System.EventHandler(this.btnVizualizareProduse_Click);
            // 
            // btnDepunereComanda
            // 
            this.btnDepunereComanda.Location = new System.Drawing.Point(37, 184);
            this.btnDepunereComanda.Name = "btnDepunereComanda";
            this.btnDepunereComanda.Size = new System.Drawing.Size(132, 23);
            this.btnDepunereComanda.TabIndex = 3;
            this.btnDepunereComanda.Text = "Depunere Comandă";
            this.btnDepunereComanda.UseVisualStyleBackColor = true;
            this.btnDepunereComanda.Click += new System.EventHandler(this.btnDepunereComanda_Click);
            // 
            // btnDepunereCerereService
            // 
            this.btnDepunereCerereService.Location = new System.Drawing.Point(37, 234);
            this.btnDepunereCerereService.Name = "btnDepunereCerereService";
            this.btnDepunereCerereService.Size = new System.Drawing.Size(132, 23);
            this.btnDepunereCerereService.TabIndex = 4;
            this.btnDepunereCerereService.Text = "Depunere Cerere Service";
            this.btnDepunereCerereService.UseVisualStyleBackColor = true;
            this.btnDepunereCerereService.Click += new System.EventHandler(this.btnDepunereCerereService_Click);
            // 
            // ClientOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDepunereCerereService);
            this.Controls.Add(this.btnDepunereComanda);
            this.Controls.Add(this.btnVizualizareProduse);
            this.Controls.Add(this.btnAutentificare);
            this.Controls.Add(this.btnCreareCont);
            this.Name = "ClientOptionsForm";
            this.Text = "ClientOptionsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreareCont;
        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.Button btnVizualizareProduse;
        private System.Windows.Forms.Button btnDepunereComanda;
        private System.Windows.Forms.Button btnDepunereCerereService;
    }
}