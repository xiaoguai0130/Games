using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 交通灯
{
    

    public partial class Form1 : Form
    {


        int red, yellow, green;//接受运行时间的
        int on;//红黄绿换
        int time=1; //计算秒数的
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "交通灯指示";
            try
            {
                
                green = Convert.ToInt32(textBox1.Text.Trim());
                red = Convert.ToInt32(textBox2.Text.Trim());
                yellow = Convert.ToInt32(textBox3.Text.Trim());
                if (green >= 0 && yellow >= 0 && red >= 0)
                {
                    if (this.listBox1.SelectedItem == "红灯")
                    {
                        on = 2;
                    }
                    else if (this.listBox1.SelectedItem == "黄灯")
                    {
                        on = 3;
                    }
                    else if (this.listBox1.SelectedItem == "绿灯")
                    {
                        on = 1;
                    }
                    timer1.Enabled = !timer1.Enabled;
                }
                else
                {
                    MessageBox.Show("输入大于零的数");
                }
            }
            catch
            {
                MessageBox.Show("请输入整数");
            }
        }//开始按钮

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            yellow = 0;
            green = 0;
            red = 0;
            time = 0;
            on = 0;
            pictureBox1.Image = Properties.Resources.nolight;
            this.listBox1.SelectedItem = "";
            this.Text = "请重新输入";
        }//重置按钮

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            switch (on)
            {
                case 1:
                    {
                        this.Text = "绿灯亮了" + time + "秒";
                        pictureBox1.Image = Properties.Resources.greenlight;
                        time++;
                        if (time == green+1)
                        {
                            on = 2;
                            time = 1;
                        }

                        break;
                    }
                case 2:
                    {
                        this.Text = "红灯亮了" + time + "秒";
                        pictureBox1.Image = Properties.Resources.redlight;
                        time++;
                        if (time == red+1)
                        {
                            on = 3;
                            time = 1;
                        }

                        break;
                    }
                case 3:
                    {
                        this.Text = "黄灯亮了" + time + "秒";
                        pictureBox1.Image = Properties.Resources.yellowlight;
                        time++;
                        if(time==yellow+1)
                        {
                            on = 1;
                            time = 1;
                        }
                            
                        break;
                    }
            }
            
        }//时间进程




    }
}
