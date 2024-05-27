namespace Proiect_Fis.Interface
{
    partial class CatalogSistemeForm
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
            this.ProdusNumeLabel1 = new System.Windows.Forms.Label();
            this.ProdusDescriereLabel1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdusNumeLabel1
            // 
            this.ProdusNumeLabel1.AutoSize = true;
            this.ProdusNumeLabel1.Location = new System.Drawing.Point(71, 302);
            this.ProdusNumeLabel1.Name = "ProdusNumeLabel1";
            this.ProdusNumeLabel1.Size = new System.Drawing.Size(35, 13);
            this.ProdusNumeLabel1.TabIndex = 0;
            this.ProdusNumeLabel1.Text = "label1";
            // 
            // ProdusDescriereLabel1
            // 
            this.ProdusDescriereLabel1.AutoSize = true;
            this.ProdusDescriereLabel1.Location = new System.Drawing.Point(71, 338);
            this.ProdusDescriereLabel1.Name = "ProdusDescriereLabel1";
            this.ProdusDescriereLabel1.Size = new System.Drawing.Size(35, 13);
            this.ProdusDescriereLabel1.TabIndex = 1;
            this.ProdusDescriereLabel1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect_Fis.Properties.Resources.ram1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 274);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CatalogSistemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProdusDescriereLabel1);
            this.Controls.Add(this.ProdusNumeLabel1);
            this.Name = "CatalogSistemeForm";
            this.Text = "CatalogSistemeForm";
            this.Load += new System.EventHandler(this.CatalogSistemeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProdusNumeLabel1;
        private System.Windows.Forms.Label ProdusDescriereLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}