namespace Proiect_Fis.Interface
{
    partial class CerereForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.numeTB = new System.Windows.Forms.TextBox();
            this.parolaTB = new System.Windows.Forms.TextBox();
            this.descriereTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.trimiteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // numeTB
            // 
            this.numeTB.Location = new System.Drawing.Point(212, 81);
            this.numeTB.Name = "numeTB";
            this.numeTB.Size = new System.Drawing.Size(293, 20);
            this.numeTB.TabIndex = 2;
            // 
            // parolaTB
            // 
            this.parolaTB.Location = new System.Drawing.Point(212, 127);
            this.parolaTB.Name = "parolaTB";
            this.parolaTB.Size = new System.Drawing.Size(293, 20);
            this.parolaTB.TabIndex = 3;
            // 
            // descriereTB
            // 
            this.descriereTB.Location = new System.Drawing.Point(212, 177);
            this.descriereTB.Name = "descriereTB";
            this.descriereTB.Size = new System.Drawing.Size(293, 20);
            this.descriereTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrierea Problemei";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // trimiteBtn
            // 
            this.trimiteBtn.Location = new System.Drawing.Point(344, 317);
            this.trimiteBtn.Name = "trimiteBtn";
            this.trimiteBtn.Size = new System.Drawing.Size(123, 47);
            this.trimiteBtn.TabIndex = 9;
            this.trimiteBtn.Text = "Trimite";
            this.trimiteBtn.UseVisualStyleBackColor = true;
            this.trimiteBtn.Click += new System.EventHandler(this.trimiteBtn_Click);
            // 
            // CerereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trimiteBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriereTB);
            this.Controls.Add(this.parolaTB);
            this.Controls.Add(this.numeTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CerereForm";
            this.Text = "CerereForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numeTB;
        private System.Windows.Forms.TextBox parolaTB;
        private System.Windows.Forms.TextBox descriereTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button trimiteBtn;
    }
}