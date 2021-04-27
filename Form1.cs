using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace keyboard
{
    public partial class Form1 : Form
    {
        private int d_count = 0;
        private int u_count = 0;
        private int o_count = 0;
        private int total_count = 0;

        private Stopwatch stopWatch;

        private float sum = 0;

        private bool isRunning = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyboardListener.s_KeyEventHandler += new EventHandler(KeyboardListener_s_KeyEventHandler);
            stopWatch = new Stopwatch();
        }

        private void KeyboardListener_s_KeyEventHandler(object sender, EventArgs e)
        {
            KeyboardListener.UniversalKeyEventArgs eventArgs =
                                        (KeyboardListener.UniversalKeyEventArgs)e;
            
            // 256 : key down    257 : key up
            if (isRunning && eventArgs.m_Msg == 256)
            {
                switch (eventArgs.KeyData)
                {
                    case Keys.D:
                        {
                            d_count++;
                            d_label.Text = d_count.ToString();
                            updateTotal("+");
                            break;
                        }
                    case Keys.U:
                        {
                            u_count++;
                            u_label.Text = u_count.ToString();
                            updateTotal("+");
                            break;
                        }
                    case Keys.O:
                        {
                            o_count++;
                            o_label.Text = o_count.ToString();
                            updateTotal("+");
                            break;
                        }
                    case Keys.B:
                        {
                            updateTotal("-");
                            break;
                        }
                    case Keys.F:
                        {
                            updateTotal("+");
                            break;
                        }
                }
            
            }
        }

        void updateTotal(String s)
        {
            if(s == "+")
            {
                total_count++;
            } else if (s == "-")
            {
                total_count--;
            }

            sum = total_count * 80 / 900;

            total_label.Text = total_count.ToString();
            Approxnis.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopWatch.Restart();
            stopWatch.Stop();
            isRunning = false;

            d_count = o_count = u_count = total_count = 0;
            sum = 0;
            total_label.Text = total_count.ToString();
            u_label.Text = u_count.ToString();
            o_label.Text = o_count.ToString();
            d_label.Text = d_count.ToString();
            Approxnis.Text = sum.ToString();
            
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            isRunning = true;
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            isRunning = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 20);
            label6.Text = string.Format("{0:hh\\:mm\\:ss}", ts - stopWatch.Elapsed);
        }
    }
}




    
    

