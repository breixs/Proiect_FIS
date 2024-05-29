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
            this.Logout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btnAutentificare.Location = new System.Drawing.Point(37, 77);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(132, 23);
            this.btnAutentificare.TabIndex = 1;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.UseVisualStyleBackColor = true;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // btnVizualizareProduse
            // 
            this.btnVizualizareProduse.Location = new System.Drawing.Point(37, 151);
            this.btnVizualizareProduse.Name = "btnVizualizareProduse";
            this.btnVizualizareProduse.Size = new System.Drawing.Size(132, 23);
            this.btnVizualizareProduse.TabIndex = 2;
            this.btnVizualizareProduse.Text = "Vizualizare Produse";
            this.btnVizualizareProduse.UseVisualStyleBackColor = true;
            this.btnVizualizareProduse.Click += new System.EventHandler(this.btnVizualizareProduse_Click);
            // 
            // btnDepunereComanda
            // 
            this.btnDepunereComanda.Location = new System.Drawing.Point(37, 233);
            this.btnDepunereComanda.Name = "btnDepunereComanda";
            this.btnDepunereComanda.Size = new System.Drawing.Size(132, 23);
            this.btnDepunereComanda.TabIndex = 3;
            this.btnDepunereComanda.Text = "Depunere Comandă";
            this.btnDepunereComanda.UseVisualStyleBackColor = true;
            this.btnDepunereComanda.Click += new System.EventHandler(this.btnDepunereComanda_Click);
            // 
            // btnDepunereCerereService
            // 
            this.btnDepunereCerereService.Location = new System.Drawing.Point(37, 271);
            this.btnDepunereCerereService.Name = "btnDepunereCerereService";
            this.btnDepunereCerereService.Size = new System.Drawing.Size(132, 23);
            this.btnDepunereCerereService.TabIndex = 4;
            this.btnDepunereCerereService.Text = "Depunere Cerere Service";
            this.btnDepunereCerereService.UseVisualStyleBackColor = true;
            this.btnDepunereCerereService.Click += new System.EventHandler(this.btnDepunereCerereService_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(37, 115);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(132, 23);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "Delogare";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Vizualizare Piese";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Logout);
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
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button button1;
    }
}