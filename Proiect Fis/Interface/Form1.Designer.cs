namespace Proiect_Fis
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCatalogSist = new System.Windows.Forms.Button();
            this.btnCatalogPC = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnClientSignIn = new System.Windows.Forms.Button();
            this.btnManagerSignIn = new System.Windows.Forms.Button();
            this.btnContAngajat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Page";
            // 
            // btnCatalogSist
            // 
            this.btnCatalogSist.Location = new System.Drawing.Point(47, 309);
            this.btnCatalogSist.Name = "btnCatalogSist";
            this.btnCatalogSist.Size = new System.Drawing.Size(211, 65);
            this.btnCatalogSist.TabIndex = 1;
            this.btnCatalogSist.Text = "Catalog Sisteme Electronice";
            this.btnCatalogSist.UseVisualStyleBackColor = true;
            this.btnCatalogSist.Click += new System.EventHandler(this.btnCatalogSist_Click);
            // 
            // btnCatalogPC
            // 
            this.btnCatalogPC.Location = new System.Drawing.Point(302, 309);
            this.btnCatalogPC.Name = "btnCatalogPC";
            this.btnCatalogPC.Size = new System.Drawing.Size(211, 65);
            this.btnCatalogPC.TabIndex = 2;
            this.btnCatalogPC.Text = "Catalog Piese PC";
            this.btnCatalogPC.UseVisualStyleBackColor = true;
            this.btnCatalogPC.Click += new System.EventHandler(this.btnCatalogPC_Click);
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(550, 309);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(211, 65);
            this.btnService.TabIndex = 3;
            this.btnService.Text = "Service";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnClientSignIn
            // 
            this.btnClientSignIn.Location = new System.Drawing.Point(654, 12);
            this.btnClientSignIn.Name = "btnClientSignIn";
            this.btnClientSignIn.Size = new System.Drawing.Size(134, 40);
            this.btnClientSignIn.TabIndex = 4;
            this.btnClientSignIn.Text = "Intra In Cont - Client";
            this.btnClientSignIn.UseVisualStyleBackColor = true;
            this.btnClientSignIn.Click += new System.EventHandler(this.btnClientSignIn_Click);
            // 
            // btnManagerSignIn
            // 
            this.btnManagerSignIn.Location = new System.Drawing.Point(13, 13);
            this.btnManagerSignIn.Name = "btnManagerSignIn";
            this.btnManagerSignIn.Size = new System.Drawing.Size(101, 23);
            this.btnManagerSignIn.TabIndex = 5;
            this.btnManagerSignIn.Text = "Cont Manager";
            this.btnManagerSignIn.UseVisualStyleBackColor = true;
            this.btnManagerSignIn.Click += new System.EventHandler(this.btnManagerSignIn_Click);
            // 
            // btnContAngajat
            // 
            this.btnContAngajat.Location = new System.Drawing.Point(12, 42);
            this.btnContAngajat.Name = "btnContAngajat";
            this.btnContAngajat.Size = new System.Drawing.Size(101, 23);
            this.btnContAngajat.TabIndex = 6;
            this.btnContAngajat.Text = "Cont Angajat";
            this.btnContAngajat.UseVisualStyleBackColor = true;
            this.btnContAngajat.Click += new System.EventHandler(this.btnContAngajat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContAngajat);
            this.Controls.Add(this.btnManagerSignIn);
            this.Controls.Add(this.btnClientSignIn);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnCatalogPC);
            this.Controls.Add(this.btnCatalogSist);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCatalogSist;
        private System.Windows.Forms.Button btnCatalogPC;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnClientSignIn;
        private System.Windows.Forms.Button btnManagerSignIn;
        private System.Windows.Forms.Button btnContAngajat;
    }
}

