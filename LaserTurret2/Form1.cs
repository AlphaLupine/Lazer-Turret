using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LaserTurret2
{
    public partial class Form1 : Form
    {

        bool isFound;

        public Stopwatch watch { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort.PortName = String.Format("COM{0}", portSelector.Value);
            watch = Stopwatch.StartNew();
            try
            {
                serialPort.Open();
                isFound = true;
                portToggle.Text = "Turn Port Off";
            }
            catch 
            {
                isFound = false;
                portToggle.Text = "PORT NOT FOUND";
            }
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
            if(isFound) writeToPort(new Point(e.X, e.Y));
        }

        public void writeToPort(Point coords) {
            if (watch.ElapsedMilliseconds < 15) return;
            watch = Stopwatch.StartNew();
            serialPort.Write(String.Format("X{0}Y{1}",
                (coords.X / (Size.Width / 180)),
                (coords.Y / (Size.Height / 180))));
        }

        private void portSelector_ValueChanged(object sender, EventArgs e)
        {
            if (serialPort.IsOpen) {
                serialPort.Close();
                portToggle.Text = "Turn Port On";
            }
            serialPort.PortName = String.Format("COM{0}", portSelector.Value);
            try
            {
                serialPort.Open();
                portToggle.Text = "Turn Port Off";
                isFound = true;
            }
            catch 
            {
                portToggle.Text = "PORT NOT FOUND";
                isFound = false;
            }
       
        }

        private void portToggle_Click(object sender, EventArgs e)
        {
            if (!isFound) return;

            if (serialPort.IsOpen)
            {
                serialPort.Close();
                isFound = false;
                portToggle.Text = "Turn Port On";
            }
            else 
            {
                serialPort.Open();
                portToggle.Text = "Turn Port Off";
            }
        }
    }
}
