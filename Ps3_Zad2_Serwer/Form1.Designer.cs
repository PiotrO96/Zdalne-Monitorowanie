
namespace Ps3_Zad2_Serwer
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
            this.startButton = new System.Windows.Forms.Button();
            this.uzycieCPU = new System.Windows.Forms.CheckBox();
            this.uzycieRAM = new System.Windows.Forms.CheckBox();
            this.zuzycieProcesora = new System.Windows.Forms.CheckBox();
            this.pasekpostepu = new System.Windows.Forms.ProgressBar();
            this.pasekpostepu2 = new System.Windows.Forms.ProgressBar();
            this.pasekpostepu3 = new System.Windows.Forms.ProgressBar();
            this.l = new System.Windows.Forms.Label();
            this.IpText = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.prog_req_ram = new System.Windows.Forms.ProgressBar();
            this.pro_req_CPU = new System.Windows.Forms.ProgressBar();
            this.prog_req_DISK = new System.Windows.Forms.ProgressBar();
            this.prog_resp_RAM = new System.Windows.Forms.ProgressBar();
            this.Prog_res_CPU = new System.Windows.Forms.ProgressBar();
            this.prog_resp_disk = new System.Windows.Forms.ProgressBar();
            this.Start_req_resp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dos_PROC = new System.Windows.Forms.CheckBox();
            this.Dos_CPU = new System.Windows.Forms.CheckBox();
            this.Dos_RAM = new System.Windows.Forms.CheckBox();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.Koniec = new System.Windows.Forms.Button();
            this.ResponseBox = new System.Windows.Forms.TextBox();
            this.ResponseCPU = new System.Windows.Forms.TextBox();
            this.ResponseDisk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(9, 73);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(56, 19);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // uzycieCPU
            // 
            this.uzycieCPU.AutoSize = true;
            this.uzycieCPU.Location = new System.Drawing.Point(89, 11);
            this.uzycieCPU.Margin = new System.Windows.Forms.Padding(2);
            this.uzycieCPU.Name = "uzycieCPU";
            this.uzycieCPU.Size = new System.Drawing.Size(83, 17);
            this.uzycieCPU.TabIndex = 1;
            this.uzycieCPU.Text = "Uzycie CPU";
            this.uzycieCPU.UseVisualStyleBackColor = true;
            // 
            // uzycieRAM
            // 
            this.uzycieRAM.AutoSize = true;
            this.uzycieRAM.Location = new System.Drawing.Point(89, 33);
            this.uzycieRAM.Margin = new System.Windows.Forms.Padding(2);
            this.uzycieRAM.Name = "uzycieRAM";
            this.uzycieRAM.Size = new System.Drawing.Size(83, 17);
            this.uzycieRAM.TabIndex = 2;
            this.uzycieRAM.Text = "uzycie RAM";
            this.uzycieRAM.UseVisualStyleBackColor = true;
            // 
            // zuzycieProcesora
            // 
            this.zuzycieProcesora.AutoSize = true;
            this.zuzycieProcesora.Location = new System.Drawing.Point(89, 55);
            this.zuzycieProcesora.Margin = new System.Windows.Forms.Padding(2);
            this.zuzycieProcesora.Name = "zuzycieProcesora";
            this.zuzycieProcesora.Size = new System.Drawing.Size(94, 17);
            this.zuzycieProcesora.TabIndex = 3;
            this.zuzycieProcesora.Text = "Zuzycie dysku";
            this.zuzycieProcesora.UseVisualStyleBackColor = true;
            // 
            // pasekpostepu
            // 
            this.pasekpostepu.Location = new System.Drawing.Point(9, 201);
            this.pasekpostepu.Margin = new System.Windows.Forms.Padding(2);
            this.pasekpostepu.Maximum = 16384;
            this.pasekpostepu.Name = "pasekpostepu";
            this.pasekpostepu.Size = new System.Drawing.Size(181, 33);
            this.pasekpostepu.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pasekpostepu.TabIndex = 4;
            this.pasekpostepu.Click += new System.EventHandler(this.pasekpostepu_Click);
            // 
            // pasekpostepu2
            // 
            this.pasekpostepu2.Location = new System.Drawing.Point(11, 262);
            this.pasekpostepu2.Margin = new System.Windows.Forms.Padding(2);
            this.pasekpostepu2.Name = "pasekpostepu2";
            this.pasekpostepu2.Size = new System.Drawing.Size(181, 33);
            this.pasekpostepu2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pasekpostepu2.TabIndex = 5;
            // 
            // pasekpostepu3
            // 
            this.pasekpostepu3.Location = new System.Drawing.Point(9, 316);
            this.pasekpostepu3.Margin = new System.Windows.Forms.Padding(2);
            this.pasekpostepu3.Maximum = 1500;
            this.pasekpostepu3.Name = "pasekpostepu3";
            this.pasekpostepu3.Size = new System.Drawing.Size(181, 33);
            this.pasekpostepu3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pasekpostepu3.TabIndex = 6;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(9, 182);
            this.l.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(35, 13);
            this.l.TabIndex = 7;
            this.l.Text = "label1";
            // 
            // IpText
            // 
            this.IpText.Location = new System.Drawing.Point(9, 11);
            this.IpText.Margin = new System.Windows.Forms.Padding(2);
            this.IpText.Name = "IpText";
            this.IpText.Size = new System.Drawing.Size(76, 20);
            this.IpText.TabIndex = 8;
            this.IpText.TextChanged += new System.EventHandler(this.IpText_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "RequestResponse";
            // 
            // prog_req_ram
            // 
            this.prog_req_ram.Location = new System.Drawing.Point(304, 201);
            this.prog_req_ram.Maximum = 16384;
            this.prog_req_ram.Name = "prog_req_ram";
            this.prog_req_ram.Size = new System.Drawing.Size(116, 33);
            this.prog_req_ram.TabIndex = 10;
            // 
            // pro_req_CPU
            // 
            this.pro_req_CPU.Location = new System.Drawing.Point(304, 239);
            this.pro_req_CPU.Name = "pro_req_CPU";
            this.pro_req_CPU.Size = new System.Drawing.Size(116, 33);
            this.pro_req_CPU.TabIndex = 11;
            this.pro_req_CPU.Click += new System.EventHandler(this.pro_req_CPU_Click);
            // 
            // prog_req_DISK
            // 
            this.prog_req_DISK.Location = new System.Drawing.Point(304, 277);
            this.prog_req_DISK.Maximum = 1500;
            this.prog_req_DISK.Name = "prog_req_DISK";
            this.prog_req_DISK.Size = new System.Drawing.Size(116, 33);
            this.prog_req_DISK.TabIndex = 12;
            this.prog_req_DISK.Click += new System.EventHandler(this.progressBar3_Click);
            // 
            // prog_resp_RAM
            // 
            this.prog_resp_RAM.Location = new System.Drawing.Point(472, 201);
            this.prog_resp_RAM.Maximum = 16384;
            this.prog_resp_RAM.Name = "prog_resp_RAM";
            this.prog_resp_RAM.Size = new System.Drawing.Size(116, 33);
            this.prog_resp_RAM.TabIndex = 13;
            // 
            // Prog_res_CPU
            // 
            this.Prog_res_CPU.Location = new System.Drawing.Point(472, 240);
            this.Prog_res_CPU.Name = "Prog_res_CPU";
            this.Prog_res_CPU.Size = new System.Drawing.Size(116, 33);
            this.Prog_res_CPU.TabIndex = 14;
            // 
            // prog_resp_disk
            // 
            this.prog_resp_disk.Location = new System.Drawing.Point(472, 279);
            this.prog_resp_disk.Maximum = 1500;
            this.prog_resp_disk.Name = "prog_resp_disk";
            this.prog_resp_disk.Size = new System.Drawing.Size(116, 33);
            this.prog_resp_disk.TabIndex = 15;
            // 
            // Start_req_resp
            // 
            this.Start_req_resp.Location = new System.Drawing.Point(304, 109);
            this.Start_req_resp.Name = "Start_req_resp";
            this.Start_req_resp.Size = new System.Drawing.Size(282, 45);
            this.Start_req_resp.TabIndex = 16;
            this.Start_req_resp.Text = "Start  Req Resp";
            this.Start_req_resp.UseVisualStyleBackColor = true;
            this.Start_req_resp.Click += new System.EventHandler(this.Start_req_resp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Request";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Response";
            // 
            // Dos_PROC
            // 
            this.Dos_PROC.AutoSize = true;
            this.Dos_PROC.Location = new System.Drawing.Point(538, 87);
            this.Dos_PROC.Margin = new System.Windows.Forms.Padding(2);
            this.Dos_PROC.Name = "Dos_PROC";
            this.Dos_PROC.Size = new System.Drawing.Size(50, 17);
            this.Dos_PROC.TabIndex = 23;
            this.Dos_PROC.Text = "Dysk";
            this.Dos_PROC.UseVisualStyleBackColor = true;
            // 
            // Dos_CPU
            // 
            this.Dos_CPU.AutoSize = true;
            this.Dos_CPU.Location = new System.Drawing.Point(538, 64);
            this.Dos_CPU.Margin = new System.Windows.Forms.Padding(2);
            this.Dos_CPU.Name = "Dos_CPU";
            this.Dos_CPU.Size = new System.Drawing.Size(48, 17);
            this.Dos_CPU.TabIndex = 22;
            this.Dos_CPU.Text = "CPU";
            this.Dos_CPU.UseVisualStyleBackColor = true;
            // 
            // Dos_RAM
            // 
            this.Dos_RAM.AutoSize = true;
            this.Dos_RAM.Location = new System.Drawing.Point(538, 42);
            this.Dos_RAM.Margin = new System.Windows.Forms.Padding(2);
            this.Dos_RAM.Name = "Dos_RAM";
            this.Dos_RAM.Size = new System.Drawing.Size(50, 17);
            this.Dos_RAM.TabIndex = 21;
            this.Dos_RAM.Text = "RAM";
            this.Dos_RAM.UseVisualStyleBackColor = true;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(9, 297);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(35, 13);
            this.l3.TabIndex = 26;
            this.l3.Text = "label6";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(13, 239);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(35, 13);
            this.l2.TabIndex = 27;
            this.l2.Text = "label6";
            // 
            // Koniec
            // 
            this.Koniec.Location = new System.Drawing.Point(10, 97);
            this.Koniec.Name = "Koniec";
            this.Koniec.Size = new System.Drawing.Size(75, 23);
            this.Koniec.TabIndex = 28;
            this.Koniec.Text = "Koniec";
            this.Koniec.UseVisualStyleBackColor = true;
            this.Koniec.Click += new System.EventHandler(this.Koniec_Click);
            // 
            // ResponseBox
            // 
            this.ResponseBox.Location = new System.Drawing.Point(594, 18);
            this.ResponseBox.Multiline = true;
            this.ResponseBox.Name = "ResponseBox";
            this.ResponseBox.Size = new System.Drawing.Size(145, 87);
            this.ResponseBox.TabIndex = 29;
            // 
            // ResponseCPU
            // 
            this.ResponseCPU.Location = new System.Drawing.Point(592, 122);
            this.ResponseCPU.Multiline = true;
            this.ResponseCPU.Name = "ResponseCPU";
            this.ResponseCPU.Size = new System.Drawing.Size(145, 87);
            this.ResponseCPU.TabIndex = 30;
            // 
            // ResponseDisk
            // 
            this.ResponseDisk.Location = new System.Drawing.Point(594, 225);
            this.ResponseDisk.Multiline = true;
            this.ResponseDisk.Name = "ResponseDisk";
            this.ResponseDisk.Size = new System.Drawing.Size(145, 87);
            this.ResponseDisk.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 488);
            this.Controls.Add(this.ResponseDisk);
            this.Controls.Add(this.ResponseCPU);
            this.Controls.Add(this.ResponseBox);
            this.Controls.Add(this.Koniec);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.Dos_PROC);
            this.Controls.Add(this.Dos_CPU);
            this.Controls.Add(this.Dos_RAM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Start_req_resp);
            this.Controls.Add(this.prog_resp_disk);
            this.Controls.Add(this.Prog_res_CPU);
            this.Controls.Add(this.prog_resp_RAM);
            this.Controls.Add(this.prog_req_DISK);
            this.Controls.Add(this.pro_req_CPU);
            this.Controls.Add(this.prog_req_ram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IpText);
            this.Controls.Add(this.l);
            this.Controls.Add(this.pasekpostepu3);
            this.Controls.Add(this.pasekpostepu2);
            this.Controls.Add(this.pasekpostepu);
            this.Controls.Add(this.zuzycieProcesora);
            this.Controls.Add(this.uzycieRAM);
            this.Controls.Add(this.uzycieCPU);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.CheckBox uzycieCPU;
        private System.Windows.Forms.CheckBox uzycieRAM;
        private System.Windows.Forms.CheckBox zuzycieProcesora;
        private System.Windows.Forms.ProgressBar pasekpostepu;
        private System.Windows.Forms.ProgressBar pasekpostepu2;
        private System.Windows.Forms.ProgressBar pasekpostepu3;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox IpText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prog_req_ram;
        private System.Windows.Forms.ProgressBar pro_req_CPU;
        private System.Windows.Forms.ProgressBar prog_req_DISK;
        private System.Windows.Forms.ProgressBar prog_resp_RAM;
        private System.Windows.Forms.ProgressBar Prog_res_CPU;
        private System.Windows.Forms.ProgressBar prog_resp_disk;
        private System.Windows.Forms.Button Start_req_resp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Dos_PROC;
        private System.Windows.Forms.CheckBox Dos_CPU;
        private System.Windows.Forms.CheckBox Dos_RAM;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Button Koniec;
        private System.Windows.Forms.TextBox ResponseBox;
        private System.Windows.Forms.TextBox ResponseCPU;
        private System.Windows.Forms.TextBox ResponseDisk;
    }
}

