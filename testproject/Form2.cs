using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace testproject
{
    public partial class Form2 : Form
    {
        private string str_text;
        public string TextStr { get; private set; } = "";
        public Form2(string str)
        {
            InitializeComponent();
            str_text = str;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = str_text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextStr = textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var arr1 = label1.Text.Split(',');
            int i = arr1.Length;
            if (arr1.Length >= 1) {
                textBox2.Text = arr1[0];
                if (arr1.Length >= 2)
                {
                    textBox3.Text = arr1[1];
                    if (arr1.Length >= 3)
                    {
                        textBox4.Text = arr1[2];
                        if (arr1.Length >= 4)
                        {
                            textBox5.Text = arr1[3];
                        }
                    }
                }
                
            }

            trim_text();
        }
        public void trim_text()
        {
            
            textBox2.Text = textBox2.Text.Trim();
            textBox3.Text = textBox3.Text.Trim();
            textBox4.Text = textBox4.Text.Trim();
            textBox5.Text = textBox5.Text.Trim();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            trim_text();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            //階段作成
            int i, j;
            for (i = 1; i < (numericUpDown1.Value +1); i++)
            {
                for (j = 0; j < i; j++)
                {
                    richTextBox1.Text += j;
                }
                richTextBox1.Text += "\r\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

                textBox2.Text = Regex.Replace(textBox2.Text, @"\s", "");
                textBox3.Text = Regex.Replace(textBox3.Text, @"\s", "");
                textBox4.Text = Regex.Replace(textBox4.Text, @"\s", "");
                textBox5.Text = Regex.Replace(textBox5.Text, @"\s", "");
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] str_txt = new string[4];
            str_txt[0] = textBox2.Text;
            str_txt[1] = textBox3.Text;
            str_txt[2] = textBox4.Text;
            str_txt[3] = textBox5.Text;
            textBox1.Text = string.Join(",", str_txt);
        }
    }
}
