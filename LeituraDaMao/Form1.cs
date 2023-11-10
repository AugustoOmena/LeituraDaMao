using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeituraDaMao
{
    public partial class Form1 : Form
    {
        // Declare a instância de SerialPort
        private SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();

            serialPort = new SerialPort();

            serialPort.PortName = "COM4";
            serialPort.BaudRate = 9600; 
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;

            serialPort.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string data = serialPort.ReadLine();
            dados.Text = data;
            if (data == "1")
            {
                pictureBox1.Visible = true;
            } else
            {
                pictureBox1.Visible = false;
            }

        }

        private void dados_Click(object sender, EventArgs e)
        {

        }
    }
}
