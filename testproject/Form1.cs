using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace testproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //タイマー起動
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label_design();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult DiaRes = MessageBox.Show(Message.Msg1, Message.Title3 +
                "",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (DiaRes == DialogResult.OK)
            {
                //Form2を表示
                Form2 f2 = new Form2(label3.Text);
                f2.ShowDialog();

                label5.Text = f2.TextStr;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.FileName = "";
            ofd.InitialDirectory = @"C:\";

            //[ファイルの種類]に表示される選択肢を指定する
            ofd.Filter = "HTMLファイル(*.html;*.htm)|*.html;*.htm|すべてのファイル(*.*)|*.*";
            //[ファイルの種類]で2番目の「すべてのファイル」が選択されているようにする
            ofd.FilterIndex = 2;
            //タイトルを設定する
            ofd.Title = Message.Title1;
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                textBox1.Text = ofd.FileName;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = null;
            try
            {
               string path = textBox1.Text;
                sr = new StreamReader(path);

                // ファイルの内容をすべて読み込みます。
                string text = sr.ReadToEnd();

                // コンソールにファイルの内容を表示します。
                label3.Text = text;

                sr.Close();
            }

            // ファイルが無かった場合などで例外が発生します。
            catch (Exception ex)
            {
                string message = ex.Message; 
                MessageBox.Show(Message.Msg2, Message.Title4, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //黄色
            Color color = Color.Yellow;
            Color_Change(color);
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            //緑
            Color color = Color.LightGreen;
            Color_Change(color);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //青
            Color color = Color.LightSkyBlue;
            Color_Change(color);
        }
        private void Color_Change(Color color)
        {
            //背景色変更処理
            label5.BackColor = color;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //文字コード設定
            Encoding enc = Encoding.GetEncoding("Shift_JIS");
            try
            {
                //ファイルを開く
                StreamWriter writer = new StreamWriter(textBox1.Text, false, enc);
                //書き込み処理
                writer.WriteLine(label5.Text);
                //ファイルを閉じる
                writer.Close();
                MessageBox.Show(Message.Msg3, Message.Title2, MessageBoxButtons.OK, MessageBoxIcon.None);
                
            }
            // ファイルが無かった場合などで例外が発生します。
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(Message.Msg2, Message.Title4, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult DiaRes = MessageBox.Show(Message.Msg1, Message.Title3 +
                "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DiaRes == DialogResult.OK)
            {
                //Form2を表示
                Form3 f3 = new Form3();
                f3.ShowDialog();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 現在時を取得
            DateTime datetime = DateTime.Now;
            label4.Text = datetime.ToLongTimeString();
        }
        public void Label_design()
        {
            //描画先とするImageオブジェクトを作成
            Bitmap canvas = new Bitmap(label4.Width, label4.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成
            Graphics g = Graphics.FromImage(canvas);

            //縦にグラデーションのブラシを作成
            LinearGradientBrush gb = new LinearGradientBrush(
                    g.VisibleClipBounds,
                    Color.LightCyan,
                    Color.Blue,
                    LinearGradientMode.Vertical);

            //四角を描く
            g.FillRectangle(gb, g.VisibleClipBounds);
            //リソースを解放する
            gb.Dispose();
            g.Dispose();

            //PictureBox1に表示する
            label4.Image = canvas;
        }
    }
}
