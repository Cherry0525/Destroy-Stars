using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;


namespace Destroy
{
    public partial class Form1 : Form
    {
        //初始化窗体组件
        public Form1()
        {
            InitializeComponent();
        }

        //写在窗口的load事件中，LOAD事件是加载事件，当你窗体加载成功后就会触发的事件
        //循环播放音乐
        private void teach_Load(object sender, EventArgs e)  
        {
            axWindowsMediaPlayer2.URL = "Music\\music_background.mp3";
            axWindowsMediaPlayer2.settings.setMode("loop", true);
            axWindowsMediaPlayer2.settings.volume = 35;
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        //开始游戏
        private void start_Game_Click(object sender, EventArgs e)
        {
            Game game1 = new Game();
            game1.Show();
            //this.Hide();
        }


        //关闭页面，退出游戏
        private void exit_Game_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //新手教程页面跳转
        private void teach_Game_Click(object sender, EventArgs e)
        {
            teaching_Game teaching_Game1 = new teaching_Game();
            teaching_Game1.Show();
        }


    }
}
