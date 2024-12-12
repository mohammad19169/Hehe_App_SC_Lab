using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace heheapp
{
    public partial class Form1 : Form
    {
       
        TcpClient client= null;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  TcpClient client = null;
            NetworkStream ns = client.GetStream();
            StreamWriter writer = new StreamWriter(ns);
            writer.WriteLine(textBox2.Text);
            writer.Flush();

        }
        public Form1()
        {
            InitializeComponent();
            client = new TcpClient("127.0.0.1", 8888);
            NetworkStream ns=client.GetStream();
            StreamReader sr=new StreamReader(ns);
           // StreamWriter sw = new StreamWriter(ns);
            textBox1.Text= sr.ReadLine();



        }
    }

}
