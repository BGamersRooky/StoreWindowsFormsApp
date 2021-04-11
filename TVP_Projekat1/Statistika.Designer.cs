namespace TVP_Projekat1
{
    partial class Statistika
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.charStatistika = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radVelicina = new System.Windows.Forms.RadioButton();
            this.radProcent = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.charStatistika)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // charStatistika
            // 
            chartArea3.Name = "ChartArea1";
            this.charStatistika.ChartAreas.Add(chartArea3);
            this.charStatistika.Location = new System.Drawing.Point(15, 100);
            this.charStatistika.Name = "charStatistika";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsXValueIndexed = true;
            series3.Name = "Series1";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.charStatistika.Series.Add(series3);
            this.charStatistika.Size = new System.Drawing.Size(571, 436);
            this.charStatistika.TabIndex = 0;
            this.charStatistika.Text = "chart1";
            // 
            // radVelicina
            // 
            this.radVelicina.AutoSize = true;
            this.radVelicina.Checked = true;
            this.radVelicina.Location = new System.Drawing.Point(6, 10);
            this.radVelicina.Name = "radVelicina";
            this.radVelicina.Size = new System.Drawing.Size(69, 17);
            this.radVelicina.TabIndex = 1;
            this.radVelicina.TabStop = true;
            this.radVelicina.Text = "Kolicinski";
            this.radVelicina.UseVisualStyleBackColor = true;
            this.radVelicina.CheckedChanged += new System.EventHandler(this.Statistika_Load);
            // 
            // radProcent
            // 
            this.radProcent.AutoSize = true;
            this.radProcent.Location = new System.Drawing.Point(106, 10);
            this.radProcent.Name = "radProcent";
            this.radProcent.Size = new System.Drawing.Size(88, 17);
            this.radProcent.TabIndex = 2;
            this.radProcent.Text = "Procentualno";
            this.radProcent.UseVisualStyleBackColor = true;
            this.radProcent.CheckedChanged += new System.EventHandler(this.Velicina);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radVelicina);
            this.groupBox1.Controls.Add(this.radProcent);
            this.groupBox1.Location = new System.Drawing.Point(15, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 34);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.charStatistika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistika";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.Statistika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charStatistika)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart charStatistika;
        private System.Windows.Forms.RadioButton radVelicina;
        private System.Windows.Forms.RadioButton radProcent;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}