
namespace Ps3_Zad2_Klient
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Dos_RAM = new System.Windows.Forms.CheckBox();
            this.Dos_CPU = new System.Windows.Forms.CheckBox();
            this.Dos_PROC = new System.Windows.Forms.CheckBox();
            this.pasekpost1 = new System.Windows.Forms.ProgressBar();
            this.pasekpost2 = new System.Windows.Forms.ProgressBar();
            this.pasekpost3 = new System.Windows.Forms.ProgressBar();
            this.Polocz = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Start2 = new System.Windows.Forms.Button();
            this.Start3 = new System.Windows.Forms.Button();
            this.l2_2 = new System.Windows.Forms.Label();
            this.l2_3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(439, 30);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(82, 19);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start RAM";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(436, 110);
            this.Stop.Margin = new System.Windows.Forms.Padding(2);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(85, 24);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Dos_RAM
            // 
            this.Dos_RAM.AutoSize = true;
            this.Dos_RAM.Location = new System.Drawing.Point(540, 15);
            this.Dos_RAM.Margin = new System.Windows.Forms.Padding(2);
            this.Dos_RAM.Name = "Dos_RAM";
            this.Dos_RAM.Size = new System.Drawing.Size(50, 17);
            this.Dos_RAM.TabIndex = 3;
            this.Dos_RAM.Text = "RAM";
            this.Dos_RAM.UseVisualStyleBackColor = true;
            // 
            // Dos_CPU
            // 
            this.Dos_CPU.AutoSize = true;
            this.Dos_CPU.Location = new System.Drawing.Point(540, 37);
            this.Dos_CPU.Margin = new System.Windows.Forms.Padding(2);
            this.Dos_CPU.Name = "Dos_CPU";
            this.Dos_CPU.Size = new System.Drawing.Size(48, 17);
            this.Dos_CPU.TabIndex = 4;
            this.Dos_CPU.Text = "CPU";
            this.Dos_CPU.UseVisualStyleBackColor = true;
            // 
            // Dos_PROC
            // 
            this.Dos_PROC.AutoSize = true;
            this.Dos_PROC.Location = new System.Drawing.Point(540, 60);
            this.Dos_PROC.Margin = new System.Windows.Forms.Padding(2);
            this.Dos_PROC.Name = "Dos_PROC";
            this.Dos_PROC.Size = new System.Drawing.Size(50, 17);
            this.Dos_PROC.TabIndex = 5;
            this.Dos_PROC.Text = "Dysk";
            this.Dos_PROC.UseVisualStyleBackColor = true;
            // 
            // pasekpost1
            // 
            this.pasekpost1.Location = new System.Drawing.Point(23, 182);
            this.pasekpost1.Margin = new System.Windows.Forms.Padding(2);
            this.pasekpost1.Maximum = 16384;
            this.pasekpost1.Name = "pasekpost1";
            this.pasekpost1.Size = new System.Drawing.Size(221, 35);
            this.pasekpost1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pasekpost1.TabIndex = 6;
            this.pasekpost1.Click += new System.EventHandler(this.pasekpost1_Click);
            // 
            // pasekpost2
            // 
            this.pasekpost2.Location = new System.Drawing.Point(23, 242);
            this.pasekpost2.Margin = new System.Windows.Forms.Padding(2);
            this.pasekpost2.Maximum = 1000;
            this.pasekpost2.Name = "pasekpost2";
            this.pasekpost2.Size = new System.Drawing.Size(221, 37);
            this.pasekpost2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pasekpost2.TabIndex = 7;
            // 
            // pasekpost3
            // 
            this.pasekpost3.Location = new System.Drawing.Point(23, 312);
            this.pasekpost3.Margin = new System.Windows.Forms.Padding(2);
            this.pasekpost3.Maximum = 1000;
            this.pasekpost3.Name = "pasekpost3";
            this.pasekpost3.Size = new System.Drawing.Size(221, 43);
            this.pasekpost3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pasekpost3.TabIndex = 8;
            this.pasekpost3.Click += new System.EventHandler(this.pasekpost3_Click);
            // 
            // Polocz
            // 
            this.Polocz.Location = new System.Drawing.Point(436, 7);
            this.Polocz.Margin = new System.Windows.Forms.Padding(2);
            this.Polocz.Name = "Polocz";
            this.Polocz.Size = new System.Drawing.Size(85, 19);
            this.Polocz.TabIndex = 10;
            this.Polocz.Text = "Polocz";
            this.Polocz.UseVisualStyleBackColor = true;
            this.Polocz.Click += new System.EventHandler(this.Polocz_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(20, 167);
            this.l.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(35, 13);
            this.l.TabIndex = 11;
            this.l.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Start2
            // 
            this.Start2.Location = new System.Drawing.Point(439, 54);
            this.Start2.Name = "Start2";
            this.Start2.Size = new System.Drawing.Size(82, 23);
            this.Start2.TabIndex = 24;
            this.Start2.Text = "Start CPU";
            this.Start2.UseVisualStyleBackColor = true;
            this.Start2.Click += new System.EventHandler(this.Start2_Click);
            // 
            // Start3
            // 
            this.Start3.Location = new System.Drawing.Point(439, 83);
            this.Start3.Name = "Start3";
            this.Start3.Size = new System.Drawing.Size(82, 22);
            this.Start3.TabIndex = 25;
            this.Start3.Text = "Start Dysk";
            this.Start3.UseVisualStyleBackColor = true;
            this.Start3.Click += new System.EventHandler(this.Start3_Click);
            // 
            // l2_2
            // 
            this.l2_2.AutoSize = true;
            this.l2_2.Location = new System.Drawing.Point(23, 224);
            this.l2_2.Name = "l2_2";
            this.l2_2.Size = new System.Drawing.Size(35, 13);
            this.l2_2.TabIndex = 26;
            this.l2_2.Text = "label1";
            // 
            // l2_3
            // 
            this.l2_3.AutoSize = true;
            this.l2_3.Location = new System.Drawing.Point(23, 294);
            this.l2_3.Name = "l2_3";
            this.l2_3.Size = new System.Drawing.Size(35, 13);
            this.l2_3.TabIndex = 27;
            this.l2_3.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.l2_3);
            this.Controls.Add(this.l2_2);
            this.Controls.Add(this.Start3);
            this.Controls.Add(this.Start2);
            this.Controls.Add(this.l);
            this.Controls.Add(this.Polocz);
            this.Controls.Add(this.pasekpost3);
            this.Controls.Add(this.pasekpost2);
            this.Controls.Add(this.pasekpost1);
            this.Controls.Add(this.Dos_PROC);
            this.Controls.Add(this.Dos_CPU);
            this.Controls.Add(this.Dos_RAM);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.CheckBox Dos_RAM;
        private System.Windows.Forms.CheckBox Dos_CPU;
        private System.Windows.Forms.CheckBox Dos_PROC;
        private System.Windows.Forms.ProgressBar pasekpost1;
        private System.Windows.Forms.ProgressBar pasekpost2;
        private System.Windows.Forms.ProgressBar pasekpost3;
        private System.Windows.Forms.Button Polocz;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Start2;
        private System.Windows.Forms.Button Start3;
        private System.Windows.Forms.Label l2_2;
        private System.Windows.Forms.Label l2_3;
    }
}

