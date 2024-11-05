namespace P09ZadanieBiblioteka
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSygnatury = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAutorzy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWydanie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTytul = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNrKarty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSygnaturaSzczegoly = new System.Windows.Forms.TextBox();
            this.lbHistoriaWypozyczen = new System.Windows.Forms.ListBox();
            this.dtpDataZakupu = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(424, 188);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpDataZakupu);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lbSygnatury);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtAutorzy);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtWydanie);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtTytul);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNrKarty);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(416, 162);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Głowna";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbHistoriaWypozyczen);
            this.tabPage2.Controls.Add(this.txtSygnaturaSzczegoly);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(416, 162);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sygnatury";
            // 
            // lbSygnatury
            // 
            this.lbSygnatury.FormattingEnabled = true;
            this.lbSygnatury.Location = new System.Drawing.Point(229, 32);
            this.lbSygnatury.Name = "lbSygnatury";
            this.lbSygnatury.Size = new System.Drawing.Size(158, 108);
            this.lbSygnatury.TabIndex = 24;
            this.lbSygnatury.SelectedIndexChanged += new System.EventHandler(this.lbSygnatury_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Data zakupu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAutorzy
            // 
            this.txtAutorzy.Location = new System.Drawing.Point(123, 75);
            this.txtAutorzy.Multiline = true;
            this.txtAutorzy.Name = "txtAutorzy";
            this.txtAutorzy.Size = new System.Drawing.Size(100, 63);
            this.txtAutorzy.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Autorzy";
            // 
            // txtWydanie
            // 
            this.txtWydanie.Location = new System.Drawing.Point(17, 75);
            this.txtWydanie.Name = "txtWydanie";
            this.txtWydanie.Size = new System.Drawing.Size(100, 20);
            this.txtWydanie.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Wydanie";
            // 
            // txtTytul
            // 
            this.txtTytul.Location = new System.Drawing.Point(123, 32);
            this.txtTytul.Name = "txtTytul";
            this.txtTytul.Size = new System.Drawing.Size(100, 20);
            this.txtTytul.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tytuł";
            // 
            // txtNrKarty
            // 
            this.txtNrKarty.Location = new System.Drawing.Point(17, 32);
            this.txtNrKarty.Name = "txtNrKarty";
            this.txtNrKarty.Size = new System.Drawing.Size(100, 20);
            this.txtNrKarty.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Karta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sygnatura";
            // 
            // txtSygnaturaSzczegoly
            // 
            this.txtSygnaturaSzczegoly.Location = new System.Drawing.Point(11, 31);
            this.txtSygnaturaSzczegoly.Name = "txtSygnaturaSzczegoly";
            this.txtSygnaturaSzczegoly.ReadOnly = true;
            this.txtSygnaturaSzczegoly.Size = new System.Drawing.Size(100, 20);
            this.txtSygnaturaSzczegoly.TabIndex = 1;
            // 
            // lbHistoriaWypozyczen
            // 
            this.lbHistoriaWypozyczen.FormattingEnabled = true;
            this.lbHistoriaWypozyczen.Location = new System.Drawing.Point(11, 58);
            this.lbHistoriaWypozyczen.Name = "lbHistoriaWypozyczen";
            this.lbHistoriaWypozyczen.Size = new System.Drawing.Size(397, 95);
            this.lbHistoriaWypozyczen.TabIndex = 2;
            // 
            // dtpDataZakupu
            // 
            this.dtpDataZakupu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataZakupu.Location = new System.Drawing.Point(17, 118);
            this.dtpDataZakupu.Name = "dtpDataZakupu";
            this.dtpDataZakupu.Size = new System.Drawing.Size(100, 20);
            this.dtpDataZakupu.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 188);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbSygnatury;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAutorzy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWydanie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTytul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNrKarty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbHistoriaWypozyczen;
        private System.Windows.Forms.TextBox txtSygnaturaSzczegoly;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDataZakupu;
    }
}

