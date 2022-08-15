using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace YazıYazmaCocuk
{
    public partial class Form2 : Form
    {
        System.Timers.Timer t;
        int h, m, s;
        public Form2()
        {
            InitializeComponent();

            //Graphics g; //g isimli grafik işlemleri yapacağım değişenimi tanımlıyorum.
            //Font fontum = new Font("tahoma", 15); //Kullanacağım yazı fontunu özellikilerini oluşturuyorum. Kullanımı: (yazı tipi,yazı boyutu)
            //SolidBrush fircam = new SolidBrush(Color.Black); //Kullanacağım fırçayı özellikilerini oluşturuyorum. Kullanımı: (fırça rengi)
            //Pen kalemim = new Pen(Color.Black, 4); //Kullanacağım kalemin özellikilerini oluşturuyorum. Kullanımı: (kalem rengi,kalem uç kalınlığı)       // çizim yapmak için eklenmelidir

            //g = this.CreateGraphics();
            //g.Clear(this.BackColor);
            //Point[] p1 = { new Point(100, 60), new Point(125, 100), new Point(150, 150), new Point(200, 50) };
            //g.DrawCurve(kalemim, p1, 1);
            //g.Dispose();
        }
        Graphics graphics;
        Pen kalem;
        int x, y;
        Boolean secim;

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            kalem = new Pen(Color.Black, 3);
            graphics = this.CreateGraphics();
            Point point1 = new Point(x, y);
            Point point2 = new Point(e.X, e.Y);
            if (secim==true)
            {
                graphics.DrawLine(kalem,point1,point2);
                x = e.X;
                y = e.Y;
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            secim= false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s++;
                if (s==60)
                {
                    s = 0;
                    m += 1;
                }
                if(m==60)
                {
                    m = 0;
                    h += 1;
                }
                txtResult.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));


        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.DoEvents();
        }

        private void btStp_Click(object sender, EventArgs e)
        {
            graphics.Clear(BackColor);// Şuanda sadece temizleme için var.
            t.Stop();

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            secim = true;
            x = e.X;//Mause'un x ekseninde durduğu alan
            y = e.Y;//Mause'un y ekseninde durduğu alan
        }
    }
}
