using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64EncoderDecoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = this.richTextBox1.Text;
            var result = Base64Decode(data);
            this.richTextBox2.Text = result;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public static string Base64Decode(string base64EncodedData)
        {
            int mod4 = base64EncodedData.Length % 4;
            if(mod4 > 0)
            {
                base64EncodedData += new string('=', 4 - mod4);
            }
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = this.richTextBox1.Text;
            var result = Base64Encode(data);
            this.richTextBox2.Text = result;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
