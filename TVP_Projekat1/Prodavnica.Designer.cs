namespace TVP_Projekat1
{
    partial class Prodavnica
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPoruci = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnProizvod = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(223, 23);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Ulogujte se";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(11, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(117, 25);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ime:";
            // 
            // btnPoruci
            // 
            this.btnPoruci.Enabled = false;
            this.btnPoruci.Location = new System.Drawing.Point(688, 12);
            this.btnPoruci.Name = "btnPoruci";
            this.btnPoruci.Size = new System.Drawing.Size(100, 100);
            this.btnPoruci.TabIndex = 7;
            this.btnPoruci.Text = "Porucite Proizvod";
            this.btnPoruci.UseVisualStyleBackColor = true;
            this.btnPoruci.Click += new System.EventHandler(this.PoruciProizvod);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Enabled = false;
            this.btnOtkazi.Location = new System.Drawing.Point(688, 118);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 100);
            this.btnOtkazi.TabIndex = 8;
            this.btnOtkazi.Text = "Otkazite Porudzbinu";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.OtkazitePorudzbinu);
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.Enabled = false;
            this.btnKorisnici.Location = new System.Drawing.Point(688, 224);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(100, 100);
            this.btnKorisnici.TabIndex = 9;
            this.btnKorisnici.Text = "Upravljanje Korisnicima";
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.OpenDodajK);
            // 
            // btnProizvod
            // 
            this.btnProizvod.Enabled = false;
            this.btnProizvod.Location = new System.Drawing.Point(688, 330);
            this.btnProizvod.Name = "btnProizvod";
            this.btnProizvod.Size = new System.Drawing.Size(100, 100);
            this.btnProizvod.TabIndex = 10;
            this.btnProizvod.Text = "Upravljanje Proizvodima";
            this.btnProizvod.UseVisualStyleBackColor = true;
            this.btnProizvod.Click += new System.EventHandler(this.OtvoriUpravljanjeProizvodima);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Enabled = false;
            this.btnStatistika.Location = new System.Drawing.Point(688, 436);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(100, 100);
            this.btnStatistika.TabIndex = 11;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.Statistika);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(396, 23);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 12;
            // 
            // btnLogout
            // 
            this.btnLogout.Enabled = false;
            this.btnLogout.Location = new System.Drawing.Point(304, 23);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Izlogujte se";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.LogOut);
            // 
            // Prodavnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnProizvod);
            this.Controls.Add(this.btnKorisnici);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnPoruci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Prodavnica";
            this.Text = "Prodavnica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPoruci;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Button btnProizvod;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnLogout;
    }
}

