namespace P06ZadaniePogoda
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
            this.cbMiasta = new System.Windows.Forms.ComboBox();
            this.btnPodajTemeperature = new System.Windows.Forms.Button();
            this.rbCelsjusz = new System.Windows.Forms.RadioButton();
            this.rbKelvin = new System.Windows.Forms.RadioButton();
            this.rbFarenheit = new System.Windows.Forms.RadioButton();
            this.lblRaport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMiasta
            // 
            this.cbMiasta.FormattingEnabled = true;
            this.cbMiasta.Location = new System.Drawing.Point(25, 27);
            this.cbMiasta.Name = "cbMiasta";
            this.cbMiasta.Size = new System.Drawing.Size(173, 21);
            this.cbMiasta.TabIndex = 0;
            // 
            // btnPodajTemeperature
            // 
            this.btnPodajTemeperature.Location = new System.Drawing.Point(204, 25);
            this.btnPodajTemeperature.Name = "btnPodajTemeperature";
            this.btnPodajTemeperature.Size = new System.Drawing.Size(137, 23);
            this.btnPodajTemeperature.TabIndex = 1;
            this.btnPodajTemeperature.Text = "Podaj Temperature";
            this.btnPodajTemeperature.UseVisualStyleBackColor = true;
            this.btnPodajTemeperature.Click += new System.EventHandler(this.btnPodajTemeperature_Click);
            // 
            // rbCelsjusz
            // 
            this.rbCelsjusz.AutoSize = true;
            this.rbCelsjusz.Checked = true;
            this.rbCelsjusz.Location = new System.Drawing.Point(25, 64);
            this.rbCelsjusz.Name = "rbCelsjusz";
            this.rbCelsjusz.Size = new System.Drawing.Size(63, 17);
            this.rbCelsjusz.TabIndex = 2;
            this.rbCelsjusz.TabStop = true;
            this.rbCelsjusz.Text = "Celsjusz";
            this.rbCelsjusz.UseVisualStyleBackColor = true;
            // 
            // rbKelvin
            // 
            this.rbKelvin.AutoSize = true;
            this.rbKelvin.Location = new System.Drawing.Point(25, 87);
            this.rbKelvin.Name = "rbKelvin";
            this.rbKelvin.Size = new System.Drawing.Size(54, 17);
            this.rbKelvin.TabIndex = 3;
            this.rbKelvin.Text = "Klevin";
            this.rbKelvin.UseVisualStyleBackColor = true;
            // 
            // rbFarenheit
            // 
            this.rbFarenheit.AutoSize = true;
            this.rbFarenheit.Location = new System.Drawing.Point(25, 110);
            this.rbFarenheit.Name = "rbFarenheit";
            this.rbFarenheit.Size = new System.Drawing.Size(69, 17);
            this.rbFarenheit.TabIndex = 4;
            this.rbFarenheit.Text = "Farenheit";
            this.rbFarenheit.UseVisualStyleBackColor = true;
            // 
            // lblRaport
            // 
            this.lblRaport.AutoSize = true;
            this.lblRaport.Location = new System.Drawing.Point(128, 64);
            this.lblRaport.Name = "lblRaport";
            this.lblRaport.Size = new System.Drawing.Size(35, 13);
            this.lblRaport.TabIndex = 5;
            this.lblRaport.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 155);
            this.Controls.Add(this.lblRaport);
            this.Controls.Add(this.rbFarenheit);
            this.Controls.Add(this.rbKelvin);
            this.Controls.Add(this.rbCelsjusz);
            this.Controls.Add(this.btnPodajTemeperature);
            this.Controls.Add(this.cbMiasta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMiasta;
        private System.Windows.Forms.Button btnPodajTemeperature;
        private System.Windows.Forms.RadioButton rbCelsjusz;
        private System.Windows.Forms.RadioButton rbKelvin;
        private System.Windows.Forms.RadioButton rbFarenheit;
        private System.Windows.Forms.Label lblRaport;
    }
}

