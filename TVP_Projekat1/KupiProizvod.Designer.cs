namespace TVP_Projekat1
{
    partial class KupiProizvod
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
            this.lblListaP = new System.Windows.Forms.Label();
            this.lstProizvodi = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lstKorpa = new System.Windows.Forms.ListBox();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnKupi = new System.Windows.Forms.Button();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            this.lblRacun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaP
            // 
            this.lblListaP.AutoSize = true;
            this.lblListaP.Location = new System.Drawing.Point(12, 84);
            this.lblListaP.Name = "lblListaP";
            this.lblListaP.Size = new System.Drawing.Size(79, 13);
            this.lblListaP.TabIndex = 1;
            this.lblListaP.Text = "Lista Proizvoda";
            // 
            // lstProizvodi
            // 
            this.lstProizvodi.FormattingEnabled = true;
            this.lstProizvodi.Location = new System.Drawing.Point(15, 100);
            this.lstProizvodi.Name = "lstProizvodi";
            this.lstProizvodi.Size = new System.Drawing.Size(201, 342);
            this.lstProizvodi.TabIndex = 2;
            this.lstProizvodi.Click += new System.EventHandler(this.Promena);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(233, 126);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj >>";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.DodajKorpa);
            // 
            // lstKorpa
            // 
            this.lstKorpa.FormattingEnabled = true;
            this.lstKorpa.Location = new System.Drawing.Point(325, 100);
            this.lstKorpa.Name = "lstKorpa";
            this.lstKorpa.Size = new System.Drawing.Size(201, 108);
            this.lstKorpa.TabIndex = 4;
            this.lstKorpa.Click += new System.EventHandler(this.Promena);
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(233, 155);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(75, 23);
            this.btnUkloni.TabIndex = 5;
            this.btnUkloni.Text = "<< Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.UkloniKorpa);
            // 
            // btnKupi
            // 
            this.btnKupi.Location = new System.Drawing.Point(233, 184);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(75, 23);
            this.btnKupi.TabIndex = 6;
            this.btnKupi.Text = "Potvrdi";
            this.btnKupi.UseVisualStyleBackColor = true;
            this.btnKupi.Click += new System.EventHandler(this.Kupi);
            // 
            // nudKolicina
            // 
            this.nudKolicina.Location = new System.Drawing.Point(233, 100);
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(75, 20);
            this.nudKolicina.TabIndex = 7;
            this.nudKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKolicina.ValueChanged += new System.EventHandler(this.PromeniKolicinu);
            // 
            // lblRacun
            // 
            this.lblRacun.AutoSize = true;
            this.lblRacun.Location = new System.Drawing.Point(322, 222);
            this.lblRacun.Name = "lblRacun";
            this.lblRacun.Size = new System.Drawing.Size(42, 13);
            this.lblRacun.TabIndex = 8;
            this.lblRacun.Text = "Racun:";
            // 
            // KupiProizvod
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.ControlBox = false;
            this.Controls.Add(this.lblRacun);
            this.Controls.Add(this.nudKolicina);
            this.Controls.Add(this.btnKupi);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.lstKorpa);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lstProizvodi);
            this.Controls.Add(this.lblListaP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KupiProizvod";
            this.Text = "KupiProizvod";
            this.Load += new System.EventHandler(this.KupiProizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblListaP;
        private System.Windows.Forms.ListBox lstProizvodi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox lstKorpa;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.NumericUpDown nudKolicina;
        private System.Windows.Forms.Label lblRacun;
    }
}