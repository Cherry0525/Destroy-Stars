using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Destroy
{
    public partial class Game : Form
    {

        int Add_width = 35;  //消灭格子的宽
        int Add_height = 160; //消灭格子的长
        Diamond[] Cherry = new Diamond[100 * 100];  //创建diamond类的数组,每一个里面表示一个格子
        int height = 9;//层数
        int width = 9;//每层几个格子
        int[,] map = new int[100, 100];//定义地图
        int[,] vis = new int[100, 100];//用于深度优先搜索求连通块
        int[,] dir = new int[4, 2];//搜索时用到的四个方向
        int[] tot = new int[100];//方块掉落时候用的 
        int[] temp = new int[100];//临时存储
        int D;//控制下落

        Label[] destroy_Diamond = new Label[100 * 100];
        int T;//控制显示效果
        int Tot;//控制显示效果
        int GameState;//控制游戏状态


        //显示在界面中的
        int time_font;//控制下一关字样的显示时间
        int Now_toll = 1;//关卡数量
        int score = 0;//计分
        int RMB = 10;//金钱值

        int num_Skill1 = 0; //技能一所能使用数
        int num_Skill2 = 0; //技能二所能使用数
        int num_Skill3 = 0; //技能三所能使用数

        String news;  //text_Show中的显示内容

        public Game()
        {
            InitializeComponent();
        }


        //随机生成地图，map中存储改格子中是什么颜色的，用Cherry数组新建图案
        void Rand()
        {
            Random rand_Seed = new Random(DateTime.Now.Second); //创建一个新的随机数生成器
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    map[i, j] = rand_Seed.Next(1, 6);//得到[1,6）中的随机数
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    //传入颜色，左上角x，y坐标，右下角x,y坐标
                    Cherry[i * width + j] = new Diamond(map[i, j], 40 * j + Add_width, 40 * i + Add_height, 40 * j + Add_width, 40 * i + Add_height);
                }
            }

        }



        //鼠标点击消灭连通块时，图进行更新,使得消灭的块会消失，不会再出现
        void Updating()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Cherry[i * width + j] = new Diamond(map[i, j], 40 * j + Add_width, 40 * i + Add_height, 40 * j + Add_width, 40 * i + Add_height);
                }
            }
        }


        void DFS(int x, int y)
        {
            vis[x, y] = 1;
            for (int i = 0; i < 4; i++)
            {
                //map[x,y]四个方向上的格子的新坐标xx,yy
                int xx = x + dir[i, 0];
                int yy = y + dir[i, 1];
                //如果在可执行格子中并且颜色相同又没有走到过，就继续走
                if (xx >= 0 && xx < height && yy >= 0 && yy < width)
                {
                    if (map[x, y] == map[xx, yy] && map[x, y] != 0)
                    {
                        if (vis[xx, yy] == 0)
                        {
                            DFS(xx, yy);
                        }
                    }
                }
            }
        }


        //进入下一关
        void Game_Start()
        {
            Now_toll++; //关数增加
            goal_Num.Text = "Goal：" + (Now_toll * 500 + Now_toll * Now_toll * Now_toll * 25).ToString(); //此关通关分数 ！！！还需要再讨论
            State_Num.Text = "关卡：" + Now_toll.ToString(); //显示此关是第几关
            news = news + "恭喜你，可以进入下一关，" + State_Num.Text + "\r\n"; //显示框显示进入下一关信息
            text_Show.Text = news;

            //让文本框获取焦点
            this.text_Show.Focus();
            //设置光标的位置到文本尾
            this.text_Show.Select(this.text_Show.TextLength, 0);
            //滚动到控件光标处
            this.text_Show.ScrollToCaret();

            GameState = 2; //游戏状态更改
            Rand(); //随机生成新一张地图
            //左边窗体刷新
            pictureBox1.Invalidate();
        }
        

        //启动或者重新开始游戏之后的初始化
        void init()
        {
            //四个方向的x，y更改值
            dir[0, 0] = 0; dir[0, 1] = 1;
            dir[1, 0] = 0; dir[1, 1] = -1;
            dir[2, 0] = 1; dir[2, 1] = 0;
            dir[3, 0] = -1; dir[3, 1] = 0;

            //设置游戏状态
            GameState = 0;
            RMB = 10;
            money_Num.Text = "Money：" + RMB.ToString();
            score = 0;
            Now_toll = 1;
            num_Skill1 = 0;
            num_Skill2 = 0;
            num_Skill3 = 0;

            //绘制“游戏即将开始”字样
            Cherry[400] = new Diamond(6, 60, 250, 60, 250); 

            //下一关字样
            Cherry[399] = new Diamond(7, 60, 250, 60, 250);

            //更新技能
            update_skill_button();

            //更新信息栏和按钮是否可见
            news = "消息列表：\r\n" + "欢迎来到Cherry's game，Come on and play it！\r\n";
            text_Show.Text = news;
            restart_Game.Enabled = false;
            start_Game.Enabled = true;
            text_Name.Enabled = true;
        }

        //计算下落
        void move_Down()
        {
            for (int j = 0; j < width; j++)
            {
                //初始化
                for (int i = 0; i < 100; i++)
                {
                    tot[i] = 0;
                }
                for (int i = height - 1; i >= 0; i--)
                {
                    if (map[i, j] == 0) tot[i] = tot[i + 1] + 1;
                    else tot[i] = tot[i + 1];
                }
                //那么此时tot[i]不为-1的就是还要保留的
                for (int i = height - 1; i >= 0; i--)
                {
                    if (map[i, j] == 0) tot[i] = -1;
                    temp[i] = map[i, j];
                    map[i, j] = 0;
                }
                for (int i = height - 1; i >= 0; i--)
                {
                    if (tot[i] != -1)
                    {
                        //要是要往下降就降
                        map[i + tot[i], j] = temp[i];

                        int id = i * width + j;
                        Cherry[id].Ex = j * 40 + Add_width;
                        Cherry[id].Ey = (i + tot[i]) * 40 + Add_height;
                    }
                }
            }
        }

        //计算左靠
        void move_Left()
        {
            for (int j = 0; j < 100; j++)
            {
                tot[j] = 0;
            }
            for (int j = 0; j < width; j++)
            {
                if (j == 0)
                {
                    //最左下角的那个方块判断
                    if (map[height - 1, 0] == 0) tot[j] = 1;
                    else tot[j] = 0;
                }
                else
                {
                    if (map[height - 1, j] == 0) tot[j] = tot[j - 1] + 1;
                    else tot[j] = tot[j - 1];
                }
            }

            //最后一排要消掉就tot[j]=-1；
            for (int j = 0; j < width; j++)
            {
                if (map[height - 1, j] == 0)
                {
                    tot[j] = -1;
                }
            }

            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < height; i++)
                {
                    //更新过去
                    if (tot[j] != -1)
                    {
                        map[i, j - tot[j]] = map[i, j];
                    }
                }
            }
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int id = i * width + j;
                    Cherry[id].Ex = (j - tot[j]) * 40 + Add_width;
                    Cherry[id].Ey = i * 40 + Add_height;
                }
            }
            int Max = -1;
            for (int j = 0; j < width; j++)
            {
                if (tot[j] != -1)
                {
                    //这一行最后能到哪里
                    if (j - tot[j] > Max)
                    {
                        Max = j - tot[j];
                    }
                }
            }
            for (int j = Max + 1; j < width; j++)
            {
                for (int i = 0; i < height; i++)
                {
                    map[i, j] = 0;
                }
            }
        }

        //执行一系列操作
        void Effect()
        {
            Tot = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    //要消除
                    if (vis[i, j] == 1)
                    {
                        destroy_Diamond[Tot] = new Label();
                        destroy_Diamond[Tot].Size = new System.Drawing.Size(32, 32);
                        destroy_Diamond[Tot].Image = Image.FromFile("Image\\xg.gif");
                        destroy_Diamond[Tot].Location = new Point(j * 40 + Add_width + 4, i * 40 + Add_height + 4);
                        this.pictureBox1.Controls.Add(destroy_Diamond[Tot]);
                        Tot++;
                        vis[i, j] = 0;
                    }
                }
            }
             
            T = 0; //控制显示效果
            timer3.Enabled = true;
        }

        //判断是否还可以消去
        void Judge()
        {
            int res = 0; //状态，选择的能不能被消去
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (map[i, j] == 0) continue;
                    //初始化！vis数组
                    for (int p = 0; p < height; p++)
                    {
                        for (int q = 0; q < width; q++)
                        {
                            vis[p, q] = 0;
                        }
                    }

                    //计算连通块
                    DFS(i, j);

                    int Count = 0; //计算此连通块中有几个方格
                    for (int p = 0; p < height; p++)
                    {
                        for (int q = 0; q < width; q++)
                        {
                            if (vis[p, q] == 1)
                            {
                                Count++;
                            }
                        }
                    }

                    if (Count >= 2)  //只有联通快大于等于2才可以消除
                    {
                        res = 1;
                        break;
                    }
                }
                if (res == 1) break;
            }

            for (int ii = 0; ii < height; ii++)
            {
                for (int jj = 0; jj < width; jj++)
                {
                    vis[ii, jj] = 0;
                }
            }

            if (res == 0)  //已经不能再消除了，判断进入下一关还是就此失败
            {
                axWindowsMediaPlayer1.URL = "Music\\Next_Turn.mp3";
                axWindowsMediaPlayer1.Ctlcontrols.play();

                //显示下一关字样
                if (score >= Now_toll * 500 + Now_toll * Now_toll * Now_toll * 25)
                {
                    GameState = 1;
                    time_font = 0;
                    pictureBox1.Invalidate();
                    timer4.Enabled = true;
                }

                else//游戏结束，跳出窗口
                {
                    score_Num.Text = "Score：0";
                    goal_Num.Text = "Goal：0";
                    start_Game.Enabled = true;
                    text_Name.Enabled = true;
                    text_Show.Text = "";
                    player_Name.Text = "Player：";

                    MessageBox.Show("由于未达到本关的目标分数，所以本次游戏结束啦！\r\n" + text_Name.Text + "，你的最终得分为 " + score.ToString(), "友情提示");
                    End_Game end_Game1= new End_Game();
                    end_Game1.Show();

                    this.Close();
                    init();
                    pictureBox1.Invalidate();
                }
            }
        }

        //技能1 重置地图
        void Skill_1()
        {
            Random rand_Seed = new Random(DateTime.Now.Second);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (map[i, j] != 0)
                    {
                        map[i, j] = rand_Seed.Next(1, 6);
                    }
                }
            }
            Updating();
        }

        //技能2 随机清除一列或一行
        void Skill_2()
        {
            Random rand_Seed = new Random(DateTime.Now.Second);
            int rand_rowcol = rand_Seed.Next(0, 2);
            if (rand_rowcol == 0)
            {
                int Max = 0;
                for (int i = 0; i < width; i++)
                {
                    if (map[height - 1, i] != 0)
                    {
                        Max = i;
                    }
                }

                int res = rand_Seed.Next(0, Max);
                for (int i = 0; i < height; i++)
                {
                    if (map[i, res] != 0)
                    {
                        map[i, res] = 0;
                        vis[i, res] = 1;
                        score = score + 5;
                    }
                }

                score_Num.Text = "Score：" + score.ToString();

                Effect();
            }
            else
            {
                int Max = 0;
                for (int i = 0; i < height; i++)
                {
                    if (map[i, width - 1] != 0)
                    {
                        Max = i;
                    }
                }

                int res = rand_Seed.Next(0, Max);
                for (int i = 0; i < width; i++)
                {
                    if (map[res, i] != 0)
                    {
                        map[res, i] = 0;
                        vis[res, i] = 1;
                        score = score + 5;
                    }
                }

                score_Num.Text = "Score：" + score.ToString();

                Effect();
            }

        }

        //技能3 随机清除一种颜色
        void Skill_3()
        {
            int[] Kind = new int[100]; //存储颜色，每种只会出现一次
            int[] Flag = new int[100]; //存储次颜色是否出现过
            int n = 0;
            int num = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (map[i, j] != 0 && Flag[map[i, j]] == 0)
                    {
                        Flag[map[i, j]] = 1;
                        Kind[n++] = map[i, j];
                    }
                }
            }
            //有颜色可以删除
            if (n != 0)
            {
                Random rand_Seed = new Random(DateTime.Now.Second);
                //删除所有颜色为Kind【res】的方格
                int res = rand_Seed.Next(0, n);

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (map[i, j] == Kind[res])
                        {
                            num++;
                            map[i, j] = 0;
                            vis[i, j] = 1;
                        }
                    }
                }

                score = score + num * 10;
                score_Num.Text = "Score：" + score.ToString();
                Effect();
            }
        }

       
        //鼠标点击，消除联通快
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (timer1.Enabled == false && timer2.Enabled == false && timer3.Enabled == false && timer4.Enabled == false && e.Y - Add_height > 0 && e.X - Add_width > 0)
            {
                int nowR = (e.Y - Add_height) / 40;//鼠标点击的行
                int nowC = (e.X - Add_width) / 40;//鼠标点击的列

                if (vis[nowR, nowC] == 0) //如果正在选择
                {
                    Updating();
                    axWindowsMediaPlayer1.URL = "Music\\click.wav";
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    //初始化
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            vis[i, j] = 0;
                        }
                    }

                    //计算连通块
                    DFS(nowR, nowC);

                    int Count = 0;
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (vis[i, j] == 1)
                            {
                                Count++;
                            }
                        }
                    }

                    if (Count < 2) //不能清除，个数不够
                    {
                        for (int i = 0; i < height; i++)
                            for (int j = 0; j < width; j++)
                                vis[i, j] = 0;
                    }

                    else
                    {
                        //画连通块的外边框线
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                if (vis[i, j] == 1)
                                {
                                    int id = i * width + j;
                                    Cherry[id].Change();  //换成选中后的图片
                                }
                            }
                        }


                        //计算金额
                        int add_RMB = 0;
                        if (Count <= 4) add_RMB = 0;
                        if (Count >= 5 && Count <= 6) add_RMB = 2;
                        if (Count >= 7 && Count <= 8) add_RMB = 5;
                        if (Count >= 9) add_RMB = 10;
                        
                        add_Show.Text = "消除选中部分 积分+" + (5 * Count * Count).ToString() + "，金币+" + add_RMB.ToString();
                        pictureBox1.Invalidate();
                    }

                }

                else if (vis[nowR, nowC] == 1) //如果已经选中，再按就是消除
                {

                    //计算连通块
                    int Count = 0;
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (vis[i, j] == 1)
                            {
                                Count++;
                            }
                        }
                    }

                    score = score + Count * Count * 5;

                    score_Num.Text = "Score：" + score.ToString();

                    int add_RMB = 0;
                    if (Count <= 4)
                    {
                        add_RMB = 0;
                        add_Show.Text = "Good! ";
                    }
                    if (Count >= 5 && Count <= 6)
                    {
                        add_RMB = 2;
                        add_Show.Text = "Great! ";
                    }
                    if (Count >= 7 && Count <= 8)
                    {
                        add_RMB = 5;
                        add_Show.Text = "Perfect! ";
                    }
                    if (Count >= 9)
                    {
                        add_RMB = 10;
                        add_Show.Text = "Unbelievable! ";
                    }
                    add_Show.Text += "积分+" + (5 * Count * Count).ToString() + "，金币+" + add_RMB.ToString();
                    news = news + add_Show.Text + "\r\n";
                    text_Show.Text = news;

                    //让文本框获取焦点
                    this.text_Show.Focus();
                    //设置光标的位置到文本尾
                    this.text_Show.Select(this.text_Show.TextLength, 0);
                    //滚动到控件光标处
                    this.text_Show.ScrollToCaret();

                    RMB = RMB + add_RMB;

                    money_Num.Text = "Money：" + RMB.ToString();

                    update_skill_button();

                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (vis[i, j] == 1)
                            {
                                map[i, j] = 0;
                            }
                        }
                    }

                    //进行一系列操作
                    Effect();

                }
            }
        }

        //Timer3执行消除方块的效果
        private void timer3_Tick(object sender, EventArgs e)
        {
           
            timer3.Enabled = false;
            for (int i = 0; i < Tot; i++)
            {
                //移除窗体上的picture控件
                this.pictureBox1.Controls.Remove(destroy_Diamond[i]); 
            }

            //更新
            Updating();

            //计算下落
            move_Down();

            //开始下落
            timer1.Enabled = true;
            pictureBox1.Invalidate();
        }


        //Timer1执行下落
        private void timer1_Tick(object sender, EventArgs e)
        {
            D = width * height;
            for (int i = 0; i < width * height; i++)
                D = D - Cherry[i].move();

            if (D == 0)
            {
                timer1.Enabled = false;
                Updating();

                //计算左靠
                move_Left();

                //开始左靠
                timer2.Enabled = true;
            }
            pictureBox1.Invalidate();
        }

        //Timer2执行左靠
        private void timer2_Tick(object sender, EventArgs e)
        {
            D = width * height;
            for (int i = 0; i < width * height; i++)
                D = D - Cherry[i].move();

            if (D == 0)
            {
                timer2.Enabled = false;
                Updating();

                //判断是否还有解
                Judge();
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (GameState == 2)
            {
                for (int i = width * height - 1; i >= 0; i--)
                    Cherry[i].Draw(e.Graphics);
            }

            else if (GameState == 1)
            {
                Cherry[399].Draw(e.Graphics);
            }

            else if (GameState == 0)
            {
                Cherry[400].Draw(e.Graphics);
            }
        }
   
        //初始加载 初始化
        private void Game_Load(object sender, EventArgs e)
        {
            init();
        }

        //技能按钮状态更新
        void update_skill_button()
        {
            if (num_Skill1 > 0) use_1.Enabled = true;
            else use_1.Enabled = false;

            if (num_Skill2 > 0) use_2.Enabled = true;
            else use_2.Enabled = false;

            if (num_Skill3 > 0) use_3.Enabled = true;
            else use_3.Enabled = false;

            if (RMB < 5) purchase_1.Enabled = false;
            else purchase_1.Enabled = true;

            if (RMB < 8) purchase_2.Enabled = false;
            else purchase_2.Enabled = true;

            if (RMB < 10) purchase_3.Enabled = false;
            else purchase_3.Enabled = true;
        }

        //开始游戏
        private void start_Game_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "Music\\click.wav";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            init();
            news += "游戏已经开始啦！" + "当前玩家：" + text_Name.Text + "！\r\n";
            text_Show.Text = news;
            
            //开始游戏后，不可再点击开始游戏或重新输入用户名，只能重新开始
            restart_Game.Enabled = true;
            start_Game.Enabled = false;
            text_Name.Enabled = false;


            RMB = 10;
            num_Skill1 = 0;
            num_Skill2 = 0;
            num_Skill3 = 0;
            GameState = 2;
            score = 0;
            Now_toll = 0;
            player_Name.Text = "Player：" + text_Name.Text;
            score_Num.Text = "Score：" + score.ToString();
            update_skill_button(); //更新购买服务
            Game_Start();
        }

        //购买1技能
        private void purchase_1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "Music\\click.wav";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            if (RMB >= 5)
            {
                //显示金钱
                RMB = RMB - 5;
                num_Skill1++;
                money_Num.Text = "金币：" + RMB.ToString();
                magic_num1.Text = "乾坤大挪移 ×" + num_Skill1.ToString();
                news = news + "你获得了一个乾坤大挪移,金币 - 5." + "\r\n";
                text_Show.Text = news;
                //让文本框获取焦点
                this.text_Show.Focus();
                //设置光标的位置到文本尾
                this.text_Show.Select(this.text_Show.TextLength, 0);
                //滚动到控件光标处
                this.text_Show.ScrollToCaret();
            }
            else
            {
                news = news + "你没钱啦!!!!" + "\r\n";
                text_Show.Text = news;
                //让文本框获取焦点
                this.text_Show.Focus();
                //设置光标的位置到文本尾
                this.text_Show.Select(this.text_Show.TextLength, 0);
                //滚动到控件光标处
                this.text_Show.ScrollToCaret();
            }
            //更新金钱
            money_Num.Text = "Money：" + RMB.ToString();
            update_skill_button();
        }

        //购买2技能
        private void purchase_2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "Music\\click.wav";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            if (RMB >= 8)
            {
                RMB = RMB - 8;
                num_Skill2++;
                money_Num.Text = "金币：" + RMB.ToString();
                magic_num2.Text = "大金刚指 ×" + num_Skill2.ToString();
                news = news + "你获得了一个大金刚指,金币 - 8." + "\r\n";
                text_Show.Text = news;
                //让文本框获取焦点
                this.text_Show.Focus();
                //设置光标的位置到文本尾
                this.text_Show.Select(this.text_Show.TextLength, 0);
                //滚动到控件光标处
                this.text_Show.ScrollToCaret();
            }
            else
            {
                news = news + "你没钱啦!!!!" + "\r\n";
                text_Show.Text = news;
                //让文本框获取焦点
                this.text_Show.Focus();
                //设置光标的位置到文本尾
                this.text_Show.Select(this.text_Show.TextLength, 0);
                //滚动到控件光标处
                this.text_Show.ScrollToCaret();
            }
            //更新金钱
            money_Num.Text = "Money：" + RMB.ToString();
            update_skill_button();
        }


        //购买三技能
        private void purchase_3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "Music\\click.wav";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            if (RMB >= 10)
            {
                RMB = RMB - 10;
                num_Skill3++;
                money_Num.Text = "金币：" + RMB.ToString();
                magic_num3.Text = "潜龙在天 ×" + num_Skill3.ToString();
                news = news + "你获得了一个潜龙在天,金币 - 10." + "\r\n";
                text_Show.Text = news;
                //让文本框获取焦点
                this.text_Show.Focus();
                //设置光标的位置到文本尾
                this.text_Show.Select(this.text_Show.TextLength, 0);
                //滚动到控件光标处
                this.text_Show.ScrollToCaret();
            }
            else
            {
                news = news + "你没钱啦!!!!" + "\r\n";
                text_Show.Text = news;
                //让文本框获取焦点
                this.text_Show.Focus();
                //设置光标的位置到文本尾
                this.text_Show.Select(this.text_Show.TextLength, 0);
                //滚动到控件光标处
                this.text_Show.ScrollToCaret();
            }
            //更新金钱
            money_Num.Text = "Money：" + RMB.ToString();
            update_skill_button();
        }


        //重新开始后画面更新
        private void restart_Game_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "Music\\click.wav";
            axWindowsMediaPlayer1.Ctlcontrols.play();

            //各种数值的初始化和按件的初始化
            player_Name.Text = "Player：";
            score_Num.Text = "Score：0";
            goal_Num.Text = "Goal：0";
            money_Num.Text = "Money：0";

            start_Game.Enabled = true;
            text_Show.Text = "";
            text_Name.Enabled = true;
            text_Name.Text = "";

            init();
            pictureBox1.Invalidate();
        }


        //使用技能一：消除一种颜色
        private void use_1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false && timer2.Enabled == false && timer3.Enabled == false && timer4.Enabled == false)
            {
                news = news + "使用技能:乾坤大挪移\r\n";
                text_Show.Text = news;
                //让文本框获取焦点
                this.text_Show.Focus();
                //设置光标的位置到文本尾
                this.text_Show.Select(this.text_Show.TextLength, 0);
                //滚动到控件光标处
                this.text_Show.ScrollToCaret();
                num_Skill1--;
                magic_num1.Text = "乾坤大挪移 ×" + num_Skill1.ToString();
                Skill_1();
                update_skill_button();
                pictureBox1.Invalidate();
            }
        }

        //使用技能二：消失一行和一列
        private void use_2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false && timer2.Enabled == false && timer3.Enabled == false && timer4.Enabled == false)
            {
                news = news + "使用技能:大金刚指\r\n";
                text_Show.Text = news;
                //让文本框获取焦点
                this.text_Show.Focus();
                //设置光标的位置到文本尾
                this.text_Show.Select(this.text_Show.TextLength, 0);
                //滚动到控件光标处
                this.text_Show.ScrollToCaret();
                this.text_Show.ScrollToCaret();
                num_Skill2--;
                magic_num2.Text = "大金刚指 ×" + num_Skill2.ToString();
                Skill_2();
                update_skill_button();
                pictureBox1.Invalidate();
            }
        }



        //使用技能三：消失一块
        private void use_3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false && timer2.Enabled == false && timer3.Enabled == false && timer4.Enabled == false)
            {
                news = news + "使用技能:潜龙在渊\r\n";
                text_Show.Text = news;
                //让文本框获取焦点
                this.text_Show.Focus();
                //设置光标的位置到文本尾
                this.text_Show.Select(this.text_Show.TextLength, 0);
                //滚动到控件光标处
                this.text_Show.ScrollToCaret();
                num_Skill3--;
                magic_num3.Text = "潜龙在渊 ×" + num_Skill3.ToString();
                Skill_3();
                update_skill_button();
                pictureBox1.Invalidate();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            time_font++;
            if (time_font == 25)
            {
                timer4.Enabled = false;
                Game_Start();
            }
        }





    }
}
