using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 环周灯
{
    public partial class Form1 : Form
    {
        public Label[] bb = new Label[40];
        public int place = 0;
        public int he = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//生成一串label
        {
            Random guss = new Random();
            for (int i =1;i<40;i++)
            {

                int nummber1 = guss.Next(0, 255);
                int nummber2 = guss.Next(0, 255);
                int nummber3 = guss.Next(0, 255);
                int nummber4 = guss.Next(0, 255);

                bb[i] = new Label();
                bb[i].Size = new Size(50, 50);
                bb[i].BackColor = Color.FromArgb(nummber1, nummber2, nummber3, nummber4);
              
                if (i<10)
                {
                  
                    bb[i].Location = new Point(place, 0);
                    panel1.Controls.Add(bb[i]);
                    place+=50;
                }
                else if(10<i&&i<20)
                {
                    bb[i].Location = new Point(place, he);
                    panel1.Controls.Add(bb[i]);
                    he+=50;
                }
                else if(20<i&&i<30)
                {
                    bb[i].Location = new Point(place, he);
                    panel1.Controls.Add(bb[i]);
                    place-=50;
                }
                else if(30<i&&i<40)
                {
                    bb[i].Location = new Point(0, he);
                    panel1.Controls.Add(bb[i]);
                    he-=50;
                }
            panel1.Controls.Add(bb[i]);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {   Random rad = new Random();
            for(int i =1;i<40;i++)
            {
                int nummber1 = rad.Next(0, 255);
                int nummber2 = rad.Next(0, 255);
                int nummber3 = rad.Next(0, 255);
                int nummber4 = rad.Next(0, 255);

                bb[i].BackColor = new Color();
                bb[i].BackColor = Color.FromArgb(nummber1, nummber2, nummber3, nummber4);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
