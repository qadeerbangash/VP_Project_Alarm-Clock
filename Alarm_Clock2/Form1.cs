using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Alarm_Clock2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hr, sec, min;
        string alarmhr, alarmmin;

        private void button1_Click(object sender, EventArgs e)
        {
             alarmhr = comboBox1.Text;
             alarmmin = comboBox2.Text;
          //  label9.Text = "Alarm Set Of Time " + comboBox1.SelectedItem + " hour " + comboBox2.SelectedItem + " minutes";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             sec = DateTime.Now.Second;
              min = DateTime.Now.Minute;
              hr = DateTime.Now.Hour;
              label2.Text = hr.ToString();
              label4.Text = min.ToString();
              label6.Text = sec.ToString();
           /* label2.Text = DateTime.Now.ToString("hh");
            label4.Text = DateTime.Now.ToString("mm");
            label6.Text = DateTime.Now.ToString("ss");*/
            Ring_Alarm();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        void Ring_Alarm()
        {
              if (alarmhr == hr.ToString() && alarmmin == min.ToString() && sec.ToString() == "0")
              {
                  timer1.Stop();

                  axWindowsMediaPlayer1.URL = "C:\\Users\\Qadeer Hussain\\Desktop\\Alarm01.mp3";
                  MessageBox.Show("Alarm Start");

              }
           /* int hr = Convert.ToInt32(label2.Text);
            int min = Convert.ToInt32(label4.Text);
            int sec = Convert.ToInt32(label6.Text);
            int chr = Convert.ToInt32(comboBox1.SelectedItem);
            int cmin = Convert.ToInt32(comboBox2.SelectedItem);
            if(hr==chr&&min==cmin&&sec==0)
            {
                MessageBox.Show("Alarm Start");
            }*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            for(int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i);
            }
            for(int j = 0; j < 60; j++)
            {
                comboBox2.Items.Add(j);
            }
        }
    }
}
