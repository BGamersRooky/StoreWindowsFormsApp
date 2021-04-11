namespace TVP_Projekat1
{
    partial class UpravljajProizvodima
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
            this.lblIzmena = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblImeP = new System.Windows.Forms.Label();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtCenaP = new System.Windows.Forms.TextBox();
            this.txtImeP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProizvodi = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblIzmena
            // 
            this.lblIzmena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzmena.ForeColor = System.Drawing.Color.DarkRed;
            this.lblIzmena.Location = new System.Drawing.Point(12, 9);
            this.lblIzmena.Name = "lblIzmena";
            this.lblIzmena.Size = new System.Drawing.Size(293, 23);
            this.lblIzmena.TabIndex = 21;
            this.lblIzmena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(230, 93);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeni.TabIndex = 20;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.IzmeniProizvod);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(230, 64);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 19;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.ObrisiProizvod);
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(17, 100);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(39, 13);
            this.lblCena.TabIndex = 17;
            this.lblCena.Text = "Cena*:";
            // 
            // lblImeP
            // 
            this.lblImeP.AutoSize = true;
            this.lblImeP.Location = new System.Drawing.Point(17, 58);
            this.lblImeP.Name = "lblImeP";
            this.lblImeP.Size = new System.Drawing.Size(27, 13);
            this.lblImeP.TabIndex = 16;
            this.lblImeP.Text = "Ime:";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(230, 122);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 14;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.UgasiProizvod);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(230, 35);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.DodajProizvod);
            // 
            // txtCenaP
            // 
            this.txtCenaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCenaP.Location = new System.Drawing.Point(70, 93);
            this.txtCenaP.Name = "txtCenaP";
            this.txtCenaP.Size = new System.Drawing.Size(100, 32);
            this.txtCenaP.TabIndex = 12;
            // 
            // txtImeP
            // 
            this.txtImeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImeP.Location = new System.Drawing.Point(70, 46);
            this.txtImeP.Name = "txtImeP";
            this.txtImeP.Size = new System.Drawing.Size(100, 32);
            this.txtImeP.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "*decimale obeleziti sa zarezom";
            // 
            // txtProizvodi
            // 
            this.txtProizvodi.Location = new System.Drawing.Point(15, 166);
            this.txtProizvodi.Name = "txtProizvodi";
            this.txtProizvodi.Size = new System.Drawing.Size(290, 285);
            this.txtProizvodi.TabIndex = 23;
            this.txtProizvodi.Text = "";
            this.txtProizvodi.TextChanged += new System.EventHandler(this.UcitavanjeStrane);
            // 
            // UpravljajProizvodima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 463);
            this.Controls.Add(this.txtProizvodi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIzmena);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblImeP);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtCenaP);
            this.Controls.Add(this.txtImeP);
            this.Name = "UpravljajProizvodima";
            this.Text = "UpravljajProizvodima";
            this.Load += new System.EventHandler(this.UcitavanjeStrane);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIzmena;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblImeP;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtCenaP;
        private System.Windows.Forms.TextBox txtImeP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtProizvodi;
    }
}