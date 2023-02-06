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
using System.Globalization;

namespace Ps3_Zad2_Serwer
{
    public partial class Form1 : Form
    {
        int interval = 1000;
        PerformanceCounter RAM = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter CPU = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
        PerformanceCounter Dysk = new PerformanceCounter("LogicalDisk", "% Free Space", "_Total");
        Task t;
        
        PublisherSocket ps = new PublisherSocket();
        public Form1()
        {
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
           
                t = Task.Run(() => publikuj());   
            
        }

        void publikuj()
        {
            try
            {
                using (PublisherSocket ps = new PublisherSocket())
                {

                    ps.Options.SendHighWatermark = 1000;
                    ps.Bind("tcp://*:12345");
                    while (true)
                    {
                        if (uzycieRAM.Checked)
                        {
                            float wartosc = RAM.NextValue();
                           
                              ps.SendMoreFrame("RAM").SendFrame(wartosc.ToString());

                            pasekpostepu.InvokeIfRequired(() =>
                            {
                                l.Text = "Dostepna pamiec: " + wartosc.ToString() + " MB";
                                pasekpostepu.Value = (int)wartosc;
                            });
                           
                        }
                        if (uzycieCPU.Checked)
                        {
                            float wartosc = CPU.NextValue();
                            ps.SendMoreFrame("CPU").SendFrame(wartosc.ToString());
                            pasekpostepu2.InvokeIfRequired(() =>
                            {
                                l2.Text = "Zuzycie procesora: " + wartosc.ToString() + " %";
                                pasekpostepu2.Value = (int)wartosc;
                            });

                        }

                        if (zuzycieProcesora.Checked)
                        {

                            float wartosc = Dysk.NextValue();
                            ps.SendMoreFrame("DISK").SendFrame(wartosc.ToString());
                            pasekpostepu3.InvokeIfRequired(() =>
                            {
                                l3.Text = "Wolne miejsce: " + wartosc.ToString() + " MB";
                                pasekpostepu3.Value = (int)wartosc;
                            });

                        }
                        Thread.Sleep(interval);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        string messageCPU;
        string messageRAM;
        string messageDYSK;

        void req_resp()
        {
            try
            {
                using (var responseSocket = new ResponseSocket("@tcp://*:5555"))
                {
                    while (true)
                    {
                        if (Dos_RAM.Checked)
                        {
                            messageRAM = responseSocket.ReceiveFrameString();
                            if (messageRAM.StartsWith("RAM"))
                                ResponseBox.InvokeIfRequired(() =>
                                {

                                    ResponseBox.Text = messageRAM.ToString();

                                });
                            responseSocket.SendMoreFrame("RAM").SendFrame("Response");
                        }

                        if (Dos_CPU.Checked)
                        {
                            messageCPU = responseSocket.ReceiveFrameString();
                            if (messageCPU.StartsWith("CPU"))
                            {
                                ResponseCPU.InvokeIfRequired(() =>
                                {
                                    //  messageCPU = responseSocket.ReceiveFrameString();
                                    ResponseCPU.Text = messageCPU.ToString();

                                });
                                responseSocket.SendMoreFrame("CPU").SendFrame("Response");
                            }
                        }
                        if (Dos_PROC.Checked)
                        {
                            messageDYSK = responseSocket.ReceiveFrameString();

                            if (messageDYSK.StartsWith("DYSK"))
                            {
                                ResponseDisk.InvokeIfRequired(() =>
                                {
                                    //         messageDYSK = responseSocket.ReceiveFrameString();
                                    ResponseDisk.Text = messageDYSK.ToString();

                                });
                                responseSocket.SendMoreFrame("DYSK").SendFrame("Response");
                            }
                        }
                    }
                }

            
            }



            catch (Exception ex)
            { }


           /* try
            {
                using (var responseSocket = new ResponseSocket("@tcp://*:5555"))
                using (var requestSocket = new RequestSocket(">tcp://localhost:5555"))
                {
                    while (true)
                    {
                        if (Dos_RAM.Checked)
                        {
                            float wartosc = RAM.NextValue();

                            requestSocket.SendMoreFrame("RAM").SendFrame(wartosc.ToString());
                            prog_req_ram.InvokeIfRequired(() =>
                            {
                                label2.Text = "Dostepna pamiec: " + wartosc.ToString() + " MB";
                                prog_req_ram.Value = (int)wartosc;
                            });
                            responseSocket.ReceiveFrameString();
                            float wartosc2 = float.Parse(responseSocket.ReceiveFrameString());

                            prog_resp_RAM.InvokeIfRequired(() =>
                            {
                                label3.Text = "Dostepna pamiec: " + wartosc2.ToString() + " MB";
                                prog_resp_RAM.Value = (int)wartosc2;
                            });
                        }
                        if (Dos_CPU.Checked)
                        {
                            float wartosc = CPU.NextValue();
                            requestSocket.SendMoreFrame("CPU").SendFrame(wartosc.ToString());
                            pro_req_CPU.InvokeIfRequired(() =>
                            {
                                label2.Text = "Zuzycie procesora: " + wartosc.ToString() + " %";
                                pro_req_CPU.Value = (int)wartosc;
                            });
                            responseSocket.ReceiveFrameString();
                            float wartosc2 = float.Parse(responseSocket.ReceiveFrameString());

                            Prog_res_CPU.InvokeIfRequired(() =>
                            {
                                label3.Text = "Zuzycie procesora: " + wartosc2.ToString() + " %";
                                Prog_res_CPU.Value = (int)wartosc2;
                            });

                        }
                        if (Dos_PROC.Checked)
                        {
                            float wartosc = Dysk.NextValue();
                            requestSocket.SendMoreFrame("DISK").SendFrame(wartosc.ToString());
                            prog_req_DISK.InvokeIfRequired(() =>
                            {
                                label2.Text = "Wolne miejsce: " + wartosc.ToString() + " MB";
                                prog_req_DISK.Value = (int)wartosc;
                            });
                            responseSocket.ReceiveFrameString();
                            float wartosc2 = float.Parse(responseSocket.ReceiveFrameString());

                            prog_resp_disk.InvokeIfRequired(() =>
                            {
                                label3.Text = "Wolne miejsce: " + wartosc2.ToString() + " MB";
                                prog_resp_disk.Value = (int)wartosc2;
                            });
                        }

                    }
                }
            }
            catch (Exception ex)
            {

            }*/
        }
        private void Start_req_resp_Click(object sender, EventArgs e)
        {
            t = Task.Run(() => req_resp());
        }
        private void Koniec_Click(object sender, EventArgs e)
        {
            ps.Close();
        }
        enum WyswietlanyTemat
        {
            RAM, CPU, DISK
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
      

        private void IpText_TextChanged(object sender, EventArgs e)
        {

        }

        private void pasekpostepu_Click(object sender, EventArgs e)
        {

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

       

        private void pro_req_CPU_Click(object sender, EventArgs e)
        {

        }
      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
