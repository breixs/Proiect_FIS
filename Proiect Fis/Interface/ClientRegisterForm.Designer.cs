namespace Proiect_Fis.Interface
{
    partial class ClientRegisterForm
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
            this.Nume = new System.Windows.Forms.Label();
            this.Parola = new System.Windows.Forms.Label();
            this.RegisterNume = new System.Windows.Forms.TextBox();
            this.RegisterParola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Location = new System.Drawing.Point(113, 111);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(29, 13);
            this.Nume.TabIndex = 0;
            this.Nume.Text = "User";
            // 
            // Parola
            // 
            this.Parola.AutoSize = true;
            this.Parola.Location = new System.Drawing.Point(113, 182);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(37, 13);
            this.Parola.TabIndex = 1;
            this.Parola.Text = "Parola";
            // 
            // RegisterNume
            // 
            this.RegisterNume.Location = new System.Drawing.Point(253, 108);
            this.RegisterNume.Name = "RegisterNume";
            this.RegisterNume.Size = new System.Drawing.Size(296, 20);
            this.RegisterNume.TabIndex = 2;
            // 
            // RegisterParola
            // 
            this.RegisterParola.Location = new System.Drawing.Point(253, 179);
            this.RegisterParola.Name = "RegisterParola";
            this.RegisterParola.Size = new System.Drawing.Size(296, 20);
            this.RegisterParola.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 73);
            this.label3.TabIndex = 4;
            this.label3.Text = "Creare Cont";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RegisterParola);
            this.Controls.Add(this.RegisterNume);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.Nume);
            this.Name = "ClientRegisterForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Label Parola;
        private System.Windows.Forms.TextBox RegisterNume;
        private System.Windows.Forms.TextBox RegisterParola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}