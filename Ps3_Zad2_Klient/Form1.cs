using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using NetMQ;
using NetMQ.Sockets;
using System.Net.Sockets;
using System.Globalization;

namespace Ps3_Zad2_Klient
{
    public partial class Form1 : Form
    {
        bool subUzycieRamu = false;
        bool subUzycieCpu = false;
        bool subUzycieDysk = false;
        private readonly BackgroundWorker backgroundWorker1;
        private readonly BackgroundWorker backgroundWorker2;
        private readonly BackgroundWorker backgroundWorker3;
        public string topicPick = "";
        public static IList<string> allowableCommandLineArgs
              = new[] { "RAM", "CPU", "DISK" };
        float wartosc;
        

        SubscriberSocket sub_s = new SubscriberSocket();
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1 = new BackgroundWorker
            {
                WorkerSupportsCancellation = true
            };
            backgroundWorker1.DoWork += new DoWorkEventHandler(Background1_doWork);
            backgroundWorker2 = new BackgroundWorker
            {
                WorkerSupportsCancellation = true
            };
            backgroundWorker2.DoWork += new DoWorkEventHandler(Background2_doWork);
            backgroundWorker3 = new BackgroundWorker
            {
                WorkerSupportsCancellation = true
            };
            backgroundWorker3.DoWork += new DoWorkEventHandler(Background3_doWork);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     
        private void Start_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            if (backgroundWorker2.IsBusy)
            {
                backgroundWorker2.CancelAsync();
            }
            if (backgroundWorker3.IsBusy)
            {
                backgroundWorker3.CancelAsync();
            }
            if (Dos_RAM.Checked)
            {
                subUzycieRamu = true;
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
           
            }
        private void Start2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            if (backgroundWorker2.IsBusy)
            {
                backgroundWorker2.CancelAsync();
            }
            if (backgroundWorker3.IsBusy)
            {
                backgroundWorker3.CancelAsync();
            }
            if (Dos_CPU.Checked)
            {
                subUzycieCpu = true;
                if (!backgroundWorker2.IsBusy)
                {
                    backgroundWorker2.RunWorkerAsync();
                }
            }
        }
        private void Start3_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            if (backgroundWorker2.IsBusy)
            {
                backgroundWorker2.CancelAsync();
            }
            if (backgroundWorker3.IsBusy)
            {
                backgroundWorker3.CancelAsync();
            }
            if (Dos_PROC.Checked)
            {
                subUzycieDysk = true;
                if (!backgroundWorker3.IsBusy)
                {
                    backgroundWorker3.RunWorkerAsync();
                }
            }
        }

        private void Background1_doWork(object sender, DoWorkEventArgs e)
        {
            using (SubscriberSocket sub_s = new SubscriberSocket())
            {
                try
                {
                sub_s.Options.ReceiveHighWatermark = 1000;
                    sub_s.Connect("tcp://localhost:12345");
                }
                catch (SocketException ex)
                {
                    Start.InvokeIfRequired(() => {

                        MessageBox.Show(ex.Message);

                        
                       
                    });
                }
                subUzycieRamu = true;
          //      sub_s.Subscribe(topicPick);
                sub_s.Subscribe("RAM");
             ;
                while (subUzycieRamu)   
                {
                    sub_s.ReceiveFrameString();
                   
                    wartosc = float.Parse(sub_s.ReceiveFrameString());    

                    pasekpost1.InvokeIfRequired(() => {
                        aktualizujPaskipostepu(pasekpost1, wartosc, l, TrescWiadomosci.RAM);
                    });  
                }
            }
        }

        private void Background2_doWork(object sender, DoWorkEventArgs e)
        {
            using (SubscriberSocket sub_s = new SubscriberSocket())
            {
                try
                {
                    sub_s.Options.ReceiveHighWatermark = 1000;
                    sub_s.Connect("tcp://localhost:12345");
                }
                catch (SocketException ex)
                {
                    Start.InvokeIfRequired(() => {
                        MessageBox.Show(ex.Message);
                    });

                    return;
                }
                subUzycieCpu = true;
           //     sub_s.Subscribe(topicPick);
                sub_s.Subscribe("CPU");
                while (true && subUzycieCpu)
                {
                    sub_s.ReceiveFrameString();
                    float wartosc = float.Parse(sub_s.ReceiveFrameString());    

                    pasekpost1.InvokeIfRequired(() => {
                        aktualizujPaskipostepu(pasekpost2, wartosc, l2_2, TrescWiadomosci.CPU);
                    });

                }
            }
        }

        private void Background3_doWork(object sender, DoWorkEventArgs e)
        {
            using (SubscriberSocket sub_s = new SubscriberSocket())
            {
                try
                {
                    
                   sub_s.Options.ReceiveHighWatermark = 1000;
                    sub_s.Connect("tcp://localhost:12345");
                }
                catch (SocketException ex)
                {
                    Start.InvokeIfRequired(() => {

                        MessageBox.Show(ex.Message);
                        
                    });

                    return;
                }
                subUzycieDysk = true;
           //     sub_s.Subscribe(topicPick);
                sub_s.Subscribe("DISK");
                while (true && subUzycieDysk)
                {
                    sub_s.ReceiveFrameString();
                    float wartosc = float.Parse(sub_s.ReceiveFrameString());    

                    pasekpost1.InvokeIfRequired(() => {
                        aktualizujPaskipostepu(pasekpost3, wartosc, l2_3, TrescWiadomosci.DISK);


                    });
                }
            }
        }

    
        void  aktualizujPaskipostepu(ProgressBar pb, float wartosc, Label l, TrescWiadomosci tw)
        {
            pb.Value = (int)wartosc;
           switch (tw)
         
            {
                 case TrescWiadomosci.RAM:
            
                    l.Text = "Dostepna pamiec: " + wartosc.ToString() + " MB";
                    break;
                   case TrescWiadomosci.CPU:
            
                    l.Text = "Zuzycie procesora: " + wartosc.ToString() + " %";
                    break;
                 case TrescWiadomosci.DISK:
            
                    l.Text = "Wolne miejsce: " + wartosc.ToString() + " MB";
                    break;
                default:
                    break;
            }
        }
        enum TrescWiadomosci
        {
            RAM, CPU, DISK
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                sub_s.Close();
                pasekpost1.Value = 0;
                l.ResetText();
            }
            if (backgroundWorker2.IsBusy)
            {
                backgroundWorker2.CancelAsync();
                sub_s.Close();
                pasekpost2.Value = 0;
                l2_2.ResetText();
            }
            if (backgroundWorker3.IsBusy)
            {
                backgroundWorker3.CancelAsync();
                sub_s.Close();
                pasekpost3.Value = 0;
                l2_3.ResetText();
            }
        }

        private void Polocz_Click(object sender, EventArgs e)
        {
            if (!Dos_RAM.Checked && !Dos_CPU.Checked && !Dos_PROC.Checked)
            {
                MessageBox.Show("Wybierz temat");
                return;

            }
      

        }
       
      
      
        private void ObecneTematy_Click(object sender, EventArgs e)
        {
           
        }
        
        
        private void StalaCzasowa_Click(object sender, EventArgs e)
        {
            
        }

        private void SubsProc_Click(object sender, EventArgs e)
        {

        }

        private void SubsRam_Click(object sender, EventArgs e)
        {

        }

        private void Wszystko_Click(object sender, EventArgs e)
        {

        }

        private void interwal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ipbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pasekpost1_Click(object sender, EventArgs e)
        {

        }

        private void pasekpost3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
    }
}
