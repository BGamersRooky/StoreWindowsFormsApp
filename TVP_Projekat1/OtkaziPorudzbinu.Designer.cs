namespace TVP_Projekat1
{
    partial class OtkaziPorudzbinu
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
            this.lstPorudzbine = new System.Windows.Forms.ListBox();
            this.lblListaP = new System.Windows.Forms.Label();
            this.lblDetalji = new System.Windows.Forms.Label();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPorudzbine
            // 
            this.lstPorudzbine.FormattingEnabled = true;
            this.lstPorudzbine.Location = new System.Drawing.Point(15, 100);
            this.lstPorudzbine.Name = "lstPorudzbine";
            this.lstPorudzbine.Size = new System.Drawing.Size(201, 342);
            this.lstPorudzbine.TabIndex = 10;
            this.lstPorudzbine.SelectedIndexChanged += new System.EventHandler(this.IspisiDetalje);
            // 
            // lblListaP
            // 
            this.lblListaP.AutoSize = true;
            this.lblListaP.Location = new System.Drawing.Point(12, 84);
            this.lblListaP.Name = "lblListaP";
            this.lblListaP.Size = new System.Drawing.Size(85, 13);
            this.lblListaP.TabIndex = 9;
            this.lblListaP.Text = "Lista Porudzbina";
            // 
            // lblDetalji
            // 
            this.lblDetalji.Location = new System.Drawing.Point(241, 100);
            this.lblDetalji.Name = "lblDetalji";
            this.lblDetalji.Size = new System.Drawing.Size(393, 274);
            this.lblDetalji.TabIndex = 11;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Enabled = false;
            this.btnOtkazi.Location = new System.Drawing.Point(244, 418);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 12;
            this.btnOtkazi.Text = "Otkazite";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.Otkazi);
            // 
            // OtkaziPorudzbinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.ControlBox = false;
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.lblDetalji);
            this.Controls.Add(this.lstPorudzbine);
            this.Controls.Add(this.lblListaP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OtkaziPorudzbinu";
            this.Text = "OtkaziPorudzbinu";
            this.Load += new System.EventHandler(this.OtkaziPorudzbinu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstPorudzbine;
        private System.Windows.Forms.Label lblListaP;
        private System.Windows.Forms.Label lblDetalji;
        private System.Windows.Forms.Button btnOtkazi;
    }
}