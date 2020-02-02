using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 贪吃蛇
{ 
    public partial class Form1 : Form
    {
        enum jian
        {
            left,
            down,
            up,
            right
        }//键位的枚举

        jian jianwei;//定义的判断键位的case;
        List<Label> aa = new List<Label>();
        int place = 300;
        Random kuai = new Random();//
        public Label cc = new Label();//随机的色彩块
        public Label ee = new Label();//加入队尾的色块
        public int w;//随机生成的横向坐标
        public int h;//随机生成的纵向坐标
        public bool chong = false;
        public int fenshu = 0;
        Random guss = new Random();
        public bool yanse = false;//色块的颜色
        public bool yanse2 = false;//贪吃蛇颜色
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//最初始生成的五个label
        {
            for (int i = 0; i < 5; i++)
            {
                Label bb = new Label();
                bb.Size = new Size(30, 30);
                bb.BackColor = Color.Orange;
                bb.BorderStyle = BorderStyle.FixedSingle;
                bb.Location = new Point(place, 210);
                place += 30;
                panel1.Controls.Add(bb);
                aa.Add(bb);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)//开始按钮
        {
            timer1.Enabled = !timer1.Enabled;
            rand();
        }

        private void timer1_Tick(object sender, EventArgs e)//时间按钮
        {
            for (int i = aa.Count-1; i >0; i--)
            {
                aa[i].Location = aa[i - 1].Location;
            }
            switch (jianwei)
            {
                case jian.up: aa[0].Top -= 30; break;
                case jian.down: aa[0].Top += 30; break;
                case jian.left: aa[0].Left -= 30; break;
                case jian.right: aa[0].Left += 30; break;
            }
            eat();
            qiang();          
            zhuang();
            if (chong)
            {
                button2_Click(sender, e);
                chong = false;
            }
            this.label1.Text = "分数:" + fenshu;
            黄色ToolStripMenuItem1_Click(sender, e);
            蓝色ToolStripMenuItem1_Click(sender, e);
            动态色彩蛇ToolStripMenuItem_Click( sender,  e);



        }

        private void button1_KeyDown(object sender, KeyEventArgs e)//判断键位
        {
            if(e.KeyCode==Keys.W)
            {
                if (jianwei != jian.down)
                {
                    jianwei = jian.up;
                }
            }
            if(e.KeyCode==Keys.S)
            {
                if (jianwei != jian.up)
                {
                    jianwei = jian.down;
                }
            }
            if(e.KeyCode==Keys.A)
            {
                if(jianwei!=jian.right)
                {
                jianwei = jian.left;
                }
            }
            if(e.KeyCode==Keys.D)
            {
                if (jianwei != jian.left)
                {
                    jianwei = jian.right;
                }
            }
        }

        public void rand()//随机生成色块
        {
            bool ee = true;
        aaa:
            while (ee)
            {
                w = kuai.Next(0, 600);
                if (w % 30 == 0)
                {
                    h = kuai.Next(0, 450);
                    if (h % 30 == 0)
                    {
                       if(!yanse)
                        {
                            cc.BackColor = Color.Black;
                        }
                       
                        cc.Size = new Size(30, 30);
                        cc.Location = new Point(w, h);
                        panel1.Controls.Add(cc);
                        for (int i = 0; i <= aa.Count; i++)
                        {
                            if (aa[i].Location != cc.Location)
                            {
                                ee = false;
                                goto aaa;

                            }
                            else
                            {
                                goto aaa;
                            }
                        }
                    }
                }
             }
            }

        public void eat()//吃
        {
            if (aa[0].Location == cc.Location)
            {
                ee = new Label();
                ee.Size = new Size(30, 30);
                
                    ee.BackColor = Color.Orange;
                
                ee.BorderStyle = BorderStyle.FixedSingle;
                panel1.Controls.Add(ee);
                
                if (jianwei ==jian.up)
                {
                    ee.Location = new Point(w, h+aa.Count*30);
                }
                if (jianwei == jian.left)
                {
                    ee.Location = new Point(w-aa.Count*30, h);
                }
                if (jianwei == jian.down)
                {
                    ee.Location = new Point(w, h-aa.Count*30);
                }
                if (jianwei == jian.right)
                {
                    ee.Location = new Point(w + aa.Count*30, h);
                }
                aa.Add(ee);
                rand();
                fenshu += 10;
            }
        }

        public void qiang()//撞墙失败
        {
            if ((aa[0].Left <0) ||( aa[0].Right >panel1.Width )||( aa[0].Top < 0 ) || (aa[0].Bottom > panel1.Height ))
            {
                timer1.Enabled = false;
                MessageBox.Show("撞墙了  失败");
                chong = true;
            }
        }

        public void zhuang()//通关失败 自己撞自己
        {
            for (int i = 1; i < aa.Count-1; i++)
            {
                if (aa[0].Location == aa[i].Location)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("通关失败");
                    chong = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)//重置按钮
        {
            w = 0;
            h = 0;
            label1.Text = "分数：0";
            place = 300;
            timer1.Enabled = false;
            aa.Clear();
            jianwei = jian.left;
            panel1.Controls.Clear();
            Form1_Load(sender, e);
        }
        
        private void 简单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 300;
        }

        private void 困难ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 200;
        }

        private void 噩梦ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;

        }

        private void 地狱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
        }

        private void 黄色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cc.BackColor = Color.Yellow;
            yanse = true;
        }

        private void 黑色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cc.BackColor = Color.Black;
            yanse = true;

        }

        private void 绿色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cc.BackColor = Color.Green;
            yanse = true;
        }

        private void 橙色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cc.BackColor = Color.Orange;
            yanse = true;
        }

        private void rgb随机颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nummber1 = guss.Next(0, 255);
            int nummber2 = guss.Next(0, 255);
            int nummber3 = guss.Next(0, 255);
            int nummber4 = guss.Next(0, 255);
            cc.BackColor = Color.FromArgb(nummber1, nummber2, nummber3, nummber4);
            yanse = true;
        }

        private void 黄色ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<aa.Count;i++)
            {
                //ee.BackColor = Color.Yellow;
                aa[i].BackColor = Color.Yellow;
                //  yanse2 = true;
            }
        }

        private void 蓝色ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < aa.Count; i++)
            {
               // ee.BackColor = Color.Blue;
                aa[i].BackColor = Color.Blue;
             //   yanse2 = true;
            }
        }



        private void 动态色彩蛇ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nummber1 = guss.Next(0, 255);
            int nummber2 = guss.Next(0, 255);
            int nummber3 = guss.Next(0, 255);
            int nummber4 = guss.Next(0, 255);
            for (int i = 0; i < aa.Count; i++)
            {
                aa[i].BackColor = Color.FromArgb(nummber1, nummber2, nummber3, nummber4);
            }
        }
    }
}
