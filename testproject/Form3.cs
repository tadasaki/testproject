using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testproject
{
    public partial class Form3 : Form
    {
        
        string[] arrDay = new string[8] { "","Mon","Tue","Wed","Thu","Fri","Sat","Sun" };
        string[] arrMonth = new string[13] { "","Jan.", "Feb.", "Mar.", "Apr.", "May", "Jun.", "Jul.", 
                                            "Aug.", "Sep.", "Oct.", "Nov.", "Dec." };
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Message.Msg4, Message.Title3, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = arrDay[1];
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label1.Text = arrDay[2];

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label1.Text = arrDay[3];

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label1.Text = arrDay[4];
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                label1.Text = arrDay[5];
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                label1.Text = arrDay[6];
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                label1.Text = arrDay[7];
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            radioButton1.Text = arrDay[1];
            radioButton2.Text = arrDay[2];
            radioButton3.Text = arrDay[3];
            radioButton4.Text = arrDay[4];
            radioButton5.Text = arrDay[5];
            radioButton6.Text = arrDay[6];
            radioButton7.Text = arrDay[7];

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(arrDay);

            panel4.BackgroundImageLayout = ImageLayout.Zoom;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.Text;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(arrDay);
            comboBox1.SelectedIndex = 0;
            label2.Text = "Days";

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(arrMonth);
            comboBox1.SelectedIndex = 0;
            label2.Text = "Years";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            check_cnf();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            check_cnf();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            check_cnf();
        }
        public void check_cnf()
        {
            if(checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;

            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            panel4.BackgroundImageLayout = ImageLayout.Center;
        }
        //マウスカーソル有り
        

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.Yellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button1.ForeColor = Color.Black;

        }
    }
}
