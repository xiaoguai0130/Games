namespace 贪吃蛇
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.食物的颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黄色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绿色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.橙色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rgb随机颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.蛇的颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黄色ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.蓝色ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.难度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.困难ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.噩梦ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.地狱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.动态色彩蛇ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 450);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(477, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "分数：";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(680, 25);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.食物的颜色ToolStripMenuItem,
            this.蛇的颜色ToolStripMenuItem,
            this.难度ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 食物的颜色ToolStripMenuItem
            // 
            this.食物的颜色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.黄色ToolStripMenuItem,
            this.黑色ToolStripMenuItem,
            this.绿色ToolStripMenuItem,
            this.橙色ToolStripMenuItem,
            this.rgb随机颜色ToolStripMenuItem});
            this.食物的颜色ToolStripMenuItem.Name = "食物的颜色ToolStripMenuItem";
            this.食物的颜色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.食物的颜色ToolStripMenuItem.Text = "食物的颜色";
            // 
            // 黄色ToolStripMenuItem
            // 
            this.黄色ToolStripMenuItem.Name = "黄色ToolStripMenuItem";
            this.黄色ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.黄色ToolStripMenuItem.Text = "黄色";
            this.黄色ToolStripMenuItem.Click += new System.EventHandler(this.黄色ToolStripMenuItem_Click);
            // 
            // 黑色ToolStripMenuItem
            // 
            this.黑色ToolStripMenuItem.Name = "黑色ToolStripMenuItem";
            this.黑色ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.黑色ToolStripMenuItem.Text = "黑色";
            this.黑色ToolStripMenuItem.Click += new System.EventHandler(this.黑色ToolStripMenuItem_Click);
            // 
            // 绿色ToolStripMenuItem
            // 
            this.绿色ToolStripMenuItem.Name = "绿色ToolStripMenuItem";
            this.绿色ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.绿色ToolStripMenuItem.Text = "绿色";
            this.绿色ToolStripMenuItem.Click += new System.EventHandler(this.绿色ToolStripMenuItem_Click);
            // 
            // 橙色ToolStripMenuItem
            // 
            this.橙色ToolStripMenuItem.Name = "橙色ToolStripMenuItem";
            this.橙色ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.橙色ToolStripMenuItem.Text = "橙色";
            this.橙色ToolStripMenuItem.Click += new System.EventHandler(this.橙色ToolStripMenuItem_Click);
            // 
            // rgb随机颜色ToolStripMenuItem
            // 
            this.rgb随机颜色ToolStripMenuItem.Name = "rgb随机颜色ToolStripMenuItem";
            this.rgb随机颜色ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.rgb随机颜色ToolStripMenuItem.Text = "rgb随机颜色";
            this.rgb随机颜色ToolStripMenuItem.Click += new System.EventHandler(this.rgb随机颜色ToolStripMenuItem_Click);
            // 
            // 蛇的颜色ToolStripMenuItem
            // 
            this.蛇的颜色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.黄色ToolStripMenuItem1,
            this.蓝色ToolStripMenuItem1,
            this.动态色彩蛇ToolStripMenuItem});
            this.蛇的颜色ToolStripMenuItem.Name = "蛇的颜色ToolStripMenuItem";
            this.蛇的颜色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.蛇的颜色ToolStripMenuItem.Text = "蛇的颜色";
            // 
            // 黄色ToolStripMenuItem1
            // 
            this.黄色ToolStripMenuItem1.Name = "黄色ToolStripMenuItem1";
            this.黄色ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.黄色ToolStripMenuItem1.Text = "黄色";
            this.黄色ToolStripMenuItem1.Click += new System.EventHandler(this.黄色ToolStripMenuItem1_Click);
            // 
            // 蓝色ToolStripMenuItem1
            // 
            this.蓝色ToolStripMenuItem1.Name = "蓝色ToolStripMenuItem1";
            this.蓝色ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.蓝色ToolStripMenuItem1.Text = "蓝色";
            this.蓝色ToolStripMenuItem1.Click += new System.EventHandler(this.蓝色ToolStripMenuItem1_Click);
            // 
            // 难度ToolStripMenuItem
            // 
            this.难度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.简单ToolStripMenuItem,
            this.困难ToolStripMenuItem,
            this.噩梦ToolStripMenuItem,
            this.地狱ToolStripMenuItem});
            this.难度ToolStripMenuItem.Name = "难度ToolStripMenuItem";
            this.难度ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.难度ToolStripMenuItem.Text = "难度";
            // 
            // 简单ToolStripMenuItem
            // 
            this.简单ToolStripMenuItem.Name = "简单ToolStripMenuItem";
            this.简单ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.简单ToolStripMenuItem.Text = "简单";
            this.简单ToolStripMenuItem.Click += new System.EventHandler(this.简单ToolStripMenuItem_Click);
            // 
            // 困难ToolStripMenuItem
            // 
            this.困难ToolStripMenuItem.Name = "困难ToolStripMenuItem";
            this.困难ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.困难ToolStripMenuItem.Text = "困难";
            this.困难ToolStripMenuItem.Click += new System.EventHandler(this.困难ToolStripMenuItem_Click);
            // 
            // 噩梦ToolStripMenuItem
            // 
            this.噩梦ToolStripMenuItem.Name = "噩梦ToolStripMenuItem";
            this.噩梦ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.噩梦ToolStripMenuItem.Text = "噩梦";
            this.噩梦ToolStripMenuItem.Click += new System.EventHandler(this.噩梦ToolStripMenuItem_Click);
            // 
            // 地狱ToolStripMenuItem
            // 
            this.地狱ToolStripMenuItem.Name = "地狱ToolStripMenuItem";
            this.地狱ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.地狱ToolStripMenuItem.Text = "地狱";
            this.地狱ToolStripMenuItem.Click += new System.EventHandler(this.地狱ToolStripMenuItem_Click);
            // 
            // 动态色彩蛇ToolStripMenuItem
            // 
            this.动态色彩蛇ToolStripMenuItem.Name = "动态色彩蛇ToolStripMenuItem";
            this.动态色彩蛇ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.动态色彩蛇ToolStripMenuItem.Text = "动态色彩蛇";
            this.动态色彩蛇ToolStripMenuItem.Click += new System.EventHandler(this.动态色彩蛇ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void menuStrip1_ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 食物的颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 蛇的颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 难度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 简单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 困难ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 噩梦ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地狱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黄色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黑色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绿色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 橙色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rgb随机颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黄色ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 蓝色ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 动态色彩蛇ToolStripMenuItem;
    }
}

