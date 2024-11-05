namespace P01AplikacjaOkienkowa
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
            this.btnPolicz = new System.Windows.Forms.Button();
            this.txtLiczba1 = new System.Windows.Forms.TextBox();
            this.txtLiczba2 = new System.Windows.Forms.TextBox();
            this.lblWynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPolicz
            // 
            this.btnPolicz.Location = new System.Drawing.Point(138, 25);
            this.btnPolicz.Name = "btnPolicz";
            this.btnPolicz.Size = new System.Drawing.Size(75, 49);
            this.btnPolicz.TabIndex = 0;
            this.btnPolicz.Text = "Policz";
            this.btnPolicz.UseVisualStyleBackColor = true;
            this.btnPolicz.Click += new System.EventHandler(this.btnPolicz_Click);
            // 
            // txtLiczba1
            // 
            this.txtLiczba1.Location = new System.Drawing.Point(32, 27);
            this.txtLiczba1.Name = "txtLiczba1";
            this.txtLiczba1.Size = new System.Drawing.Size(100, 20);
            this.txtLiczba1.TabIndex = 1;
            // 
            // txtLiczba2
            // 
            this.txtLiczba2.Location = new System.Drawing.Point(32, 54);
            this.txtLiczba2.Name = "txtLiczba2";
            this.txtLiczba2.Size = new System.Drawing.Size(100, 20);
            this.txtLiczba2.TabIndex = 2;
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Location = new System.Drawing.Point(32, 90);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(35, 13);
            this.lblWynik.TabIndex = 3;
            this.lblWynik.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 132);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.txtLiczba2);
            this.Controls.Add(this.txtLiczba1);
            this.Controls.Add(this.btnPolicz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPolicz;
        private System.Windows.Forms.TextBox txtLiczba1;
        private System.Windows.Forms.TextBox txtLiczba2;
        private System.Windows.Forms.Label lblWynik;
    }
}

