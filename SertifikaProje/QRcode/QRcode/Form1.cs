using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;


namespace QRcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "http://192.168.8.49:81/Certificate/UserList?cno=";
            QRCodeEncoder enc = new QRCodeEncoder();
            pictureBox1.Image = enc.Encode(url + textBox1.Text);
        }
    }
}
