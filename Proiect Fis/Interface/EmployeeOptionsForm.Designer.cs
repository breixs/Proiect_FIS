namespace Proiect_Fis
{
    partial class EmployeeOptionsForm
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
            this.btnCreeazaComanda = new System.Windows.Forms.Button();
            this.btnSchimbaStatusComanda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreeazaComanda
            // 
            this.btnCreeazaComanda.Location = new System.Drawing.Point(40, 36);
            this.btnCreeazaComanda.Name = "btnCreeazaComanda";
            this.btnCreeazaComanda.Size = new System.Drawing.Size(137, 23);
            this.btnCreeazaComanda.TabIndex = 0;
            this.btnCreeazaComanda.Text = "Creează Comandă";
            this.btnCreeazaComanda.UseVisualStyleBackColor = true;
            this.btnCreeazaComanda.Click += new System.EventHandler(this.btnCreeazaComanda_Click);
            // 
            // btnSchimbaStatusComanda
            // 
            this.btnSchimbaStatusComanda.Location = new System.Drawing.Point(40, 88);
            this.btnSchimbaStatusComanda.Name = "btnSchimbaStatusComanda";
            this.btnSchimbaStatusComanda.Size = new System.Drawing.Size(137, 23);
            this.btnSchimbaStatusComanda.TabIndex = 1;
            this.btnSchimbaStatusComanda.Text = "Schimbă Status Comandă";
            this.btnSchimbaStatusComanda.UseVisualStyleBackColor = true;
            this.btnSchimbaStatusComanda.Click += new System.EventHandler(this.btnSchimbaStatusComanda_Click);
            // 
            // EmployeeOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSchimbaStatusComanda);
            this.Controls.Add(this.btnCreeazaComanda);
            this.Name = "EmployeeOptionsForm";
            this.Text = "EmployeeOptionsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreeazaComanda;
        private System.Windows.Forms.Button btnSchimbaStatusComanda;
    }
}