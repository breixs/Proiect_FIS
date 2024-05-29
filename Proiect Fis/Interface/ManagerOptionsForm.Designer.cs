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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numeTB = new System.Windows.Forms.TextBox();
            this.scorTB = new System.Windows.Forms.TextBox();
            this.pretTB = new System.Windows.Forms.TextBox();
            this.descriereTB = new System.Windows.Forms.TextBox();
            this.produsIdTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categorieTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.btnAdaugaProdus.Location = new System.Drawing.Point(618, 92);
            this.btnAdaugaProdus.Name = "btnAdaugaProdus";
            this.btnAdaugaProdus.Size = new System.Drawing.Size(123, 23);
            this.btnAdaugaProdus.TabIndex = 4;
            this.btnAdaugaProdus.Text = "Adaugă Produs";
            this.btnAdaugaProdus.UseVisualStyleBackColor = true;
            this.btnAdaugaProdus.Click += new System.EventHandler(this.BtnAdaugaProdus_Click);
            // 
            // btnAdaugaPiesa
            // 
            this.btnAdaugaPiesa.Location = new System.Drawing.Point(618, 131);
            this.btnAdaugaPiesa.Name = "btnAdaugaPiesa";
            this.btnAdaugaPiesa.Size = new System.Drawing.Size(123, 23);
            this.btnAdaugaPiesa.TabIndex = 5;
            this.btnAdaugaPiesa.Text = "Adaugă Piesă";
            this.btnAdaugaPiesa.UseVisualStyleBackColor = true;
            this.btnAdaugaPiesa.Click += new System.EventHandler(this.BtnAdaugaPiesa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.categorieTB);
            this.groupBox1.Controls.Add(this.numeTB);
            this.groupBox1.Controls.Add(this.btnAdaugaPiesa);
            this.groupBox1.Controls.Add(this.scorTB);
            this.groupBox1.Controls.Add(this.pretTB);
            this.groupBox1.Controls.Add(this.descriereTB);
            this.groupBox1.Controls.Add(this.produsIdTb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdaugaProdus);
            this.groupBox1.Location = new System.Drawing.Point(13, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 201);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adaugare Produse";
            // 
            // numeTB
            // 
            this.numeTB.Location = new System.Drawing.Point(65, 50);
            this.numeTB.Name = "numeTB";
            this.numeTB.Size = new System.Drawing.Size(331, 20);
            this.numeTB.TabIndex = 14;
            // 
            // scorTB
            // 
            this.scorTB.Location = new System.Drawing.Point(65, 128);
            this.scorTB.Name = "scorTB";
            this.scorTB.Size = new System.Drawing.Size(331, 20);
            this.scorTB.TabIndex = 13;
            // 
            // pretTB
            // 
            this.pretTB.Location = new System.Drawing.Point(65, 102);
            this.pretTB.Name = "pretTB";
            this.pretTB.Size = new System.Drawing.Size(331, 20);
            this.pretTB.TabIndex = 12;
            // 
            // descriereTB
            // 
            this.descriereTB.Location = new System.Drawing.Point(65, 76);
            this.descriereTB.Name = "descriereTB";
            this.descriereTB.Size = new System.Drawing.Size(331, 20);
            this.descriereTB.TabIndex = 11;
            // 
            // produsIdTb
            // 
            this.produsIdTb.Location = new System.Drawing.Point(65, 24);
            this.produsIdTb.Name = "produsIdTb";
            this.produsIdTb.Size = new System.Drawing.Size(331, 20);
            this.produsIdTb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Scor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descriere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ProdusID";
            // 
            // categorieTB
            // 
            this.categorieTB.Location = new System.Drawing.Point(65, 154);
            this.categorieTB.Name = "categorieTB";
            this.categorieTB.Size = new System.Drawing.Size(331, 20);
            this.categorieTB.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Categorie";
            // 
            // ManagerOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStergePromotie);
            this.Controls.Add(this.btnPropunePromotie);
            this.Controls.Add(this.btnVizualizareAngajati);
            this.Controls.Add(this.btnAdaugaAngajat);
            this.Name = "ManagerOptionsForm";
            this.Text = "Manager Options";
            this.Load += new System.EventHandler(this.ManagerOptionsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugaAngajat;
        private System.Windows.Forms.Button btnVizualizareAngajati;
        private System.Windows.Forms.Button btnPropunePromotie;
        private System.Windows.Forms.Button btnStergePromotie;
        private System.Windows.Forms.Button btnAdaugaProdus;
        private System.Windows.Forms.Button btnAdaugaPiesa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numeTB;
        private System.Windows.Forms.TextBox scorTB;
        private System.Windows.Forms.TextBox pretTB;
        private System.Windows.Forms.TextBox descriereTB;
        private System.Windows.Forms.TextBox produsIdTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox categorieTB;
    }
}
