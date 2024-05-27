namespace Proiect_Fis
{
    partial class ManagerOptionsForm
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
            this.btnAdaugaAngajat = new System.Windows.Forms.Button();
            this.btnVizualizareAngajati = new System.Windows.Forms.Button();
            this.btnPropunePromotie = new System.Windows.Forms.Button();
            this.btnStergePromotie = new System.Windows.Forms.Button();
            this.btnAdaugaProdus = new System.Windows.Forms.Button();
            this.btnAdaugaPiesa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdaugaAngajat
            // 
            this.btnAdaugaAngajat.Location = new System.Drawing.Point(12, 12);
            this.btnAdaugaAngajat.Name = "btnAdaugaAngajat";
            this.btnAdaugaAngajat.Size = new System.Drawing.Size(123, 23);
            this.btnAdaugaAngajat.TabIndex = 0;
            this.btnAdaugaAngajat.Text = "Adaugă Angajat";
            this.btnAdaugaAngajat.UseVisualStyleBackColor = true;
            this.btnAdaugaAngajat.Click += new System.EventHandler(this.BtnAdaugaAngajat_Click);
            // 
            // btnVizualizareAngajati
            // 
            this.btnVizualizareAngajati.Location = new System.Drawing.Point(12, 41);
            this.btnVizualizareAngajati.Name = "btnVizualizareAngajati";
            this.btnVizualizareAngajati.Size = new System.Drawing.Size(123, 23);
            this.btnVizualizareAngajati.TabIndex = 1;
            this.btnVizualizareAngajati.Text = "Vizualizează Angajați";
            this.btnVizualizareAngajati.UseVisualStyleBackColor = true;
            this.btnVizualizareAngajati.Click += new System.EventHandler(this.BtnVizualizareAngajati_Click);
            // 
            // btnPropunePromotie
            // 
            this.btnPropunePromotie.Location = new System.Drawing.Point(12, 70);
            this.btnPropunePromotie.Name = "btnPropunePromotie";
            this.btnPropunePromotie.Size = new System.Drawing.Size(123, 23);
            this.btnPropunePromotie.TabIndex = 2;
            this.btnPropunePromotie.Text = "Propune Promotie";
            this.btnPropunePromotie.UseVisualStyleBackColor = true;
            this.btnPropunePromotie.Click += new System.EventHandler(this.BtnPropunePromotie_Click);
            // 
            // btnStergePromotie
            // 
            this.btnStergePromotie.Location = new System.Drawing.Point(12, 99);
            this.btnStergePromotie.Name = "btnStergePromotie";
            this.btnStergePromotie.Size = new System.Drawing.Size(123, 23);
            this.btnStergePromotie.TabIndex = 3;
            this.btnStergePromotie.Text = "Șterge Promotie";
            this.btnStergePromotie.UseVisualStyleBackColor = true;
            this.btnStergePromotie.Click += new System.EventHandler(this.BtnStergePromotie_Click);
            // 
            // btnAdaugaProdus
            // 
            this.btnAdaugaProdus.Location = new System.Drawing.Point(12, 128);
            this.btnAdaugaProdus.Name = "btnAdaugaProdus";
            this.btnAdaugaProdus.Size = new System.Drawing.Size(123, 23);
            this.btnAdaugaProdus.TabIndex = 4;
            this.btnAdaugaProdus.Text = "Adaugă Produs";
            this.btnAdaugaProdus.UseVisualStyleBackColor = true;
            this.btnAdaugaProdus.Click += new System.EventHandler(this.BtnAdaugaProdus_Click);
            // 
            // btnAdaugaPiesa
            // 
            this.btnAdaugaPiesa.Location = new System.Drawing.Point(12, 157);
            this.btnAdaugaPiesa.Name = "btnAdaugaPiesa";
            this.btnAdaugaPiesa.Size = new System.Drawing.Size(123, 23);
            this.btnAdaugaPiesa.TabIndex = 5;
            this.btnAdaugaPiesa.Text = "Adaugă Piesă";
            this.btnAdaugaPiesa.UseVisualStyleBackColor = true;
            this.btnAdaugaPiesa.Click += new System.EventHandler(this.BtnAdaugaPiesa_Click);
            // 
            // ManagerOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdaugaPiesa);
            this.Controls.Add(this.btnAdaugaProdus);
            this.Controls.Add(this.btnStergePromotie);
            this.Controls.Add(this.btnPropunePromotie);
            this.Controls.Add(this.btnVizualizareAngajati);
            this.Controls.Add(this.btnAdaugaAngajat);
            this.Name = "ManagerOptionsForm";
            this.Text = "Manager Options";
            this.Load += new System.EventHandler(this.ManagerOptionsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugaAngajat;
        private System.Windows.Forms.Button btnVizualizareAngajati;
        private System.Windows.Forms.Button btnPropunePromotie;
        private System.Windows.Forms.Button btnStergePromotie;
        private System.Windows.Forms.Button btnAdaugaProdus;
        private System.Windows.Forms.Button btnAdaugaPiesa;
    }
}
