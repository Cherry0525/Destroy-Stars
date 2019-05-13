namespace Destroy
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.restart_Game = new System.Windows.Forms.Button();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.text_Show = new System.Windows.Forms.TextBox();
            this.player_Name = new System.Windows.Forms.Label();
            this.score_Num = new System.Windows.Forms.Label();
            this.purchase_1 = new System.Windows.Forms.Button();
            this.purchase_2 = new System.Windows.Forms.Button();
            this.purchase_3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.use_1 = new System.Windows.Forms.Button();
            this.use_3 = new System.Windows.Forms.Button();
            this.use_2 = new System.Windows.Forms.Button();
            this.money_Num = new System.Windows.Forms.Label();
            this.magic_num1 = new System.Windows.Forms.Label();
            this.magic_num2 = new System.Windows.Forms.Label();
            this.magic_num3 = new System.Windows.Forms.Label();
            this.goal_Num = new System.Windows.Forms.Label();
            this.State_Num = new System.Windows.Forms.Label();
            this.add_Show = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.start_Game = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 562);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(430, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(432, 562);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // restart_Game
            // 
            this.restart_Game.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.restart_Game.ForeColor = System.Drawing.SystemColors.ControlText;
            this.restart_Game.Location = new System.Drawing.Point(718, 87);
            this.restart_Game.Name = "restart_Game";
            this.restart_Game.Size = new System.Drawing.Size(101, 37);
            this.restart_Game.TabIndex = 4;
            this.restart_Game.Text = "重新开始";
            this.restart_Game.UseVisualStyleBackColor = true;
            this.restart_Game.Click += new System.EventHandler(this.restart_Game_Click);
            // 
            // text_Name
            // 
            this.text_Name.BackColor = System.Drawing.SystemColors.Info;
            this.text_Name.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_Name.Location = new System.Drawing.Point(468, 89);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(124, 33);
            this.text_Name.TabIndex = 5;
            // 
            // text_Show
            // 
            this.text_Show.BackColor = System.Drawing.SystemColors.InfoText;
            this.text_Show.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_Show.ForeColor = System.Drawing.SystemColors.Window;
            this.text_Show.Location = new System.Drawing.Point(471, 356);
            this.text_Show.Multiline = true;
            this.text_Show.Name = "text_Show";
            this.text_Show.Size = new System.Drawing.Size(347, 157);
            this.text_Show.TabIndex = 6;
            // 
            // player_Name
            // 
            this.player_Name.AutoSize = true;
            this.player_Name.BackColor = System.Drawing.Color.Tan;
            this.player_Name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.player_Name.Location = new System.Drawing.Point(34, 89);
            this.player_Name.Name = "player_Name";
            this.player_Name.Size = new System.Drawing.Size(63, 14);
            this.player_Name.TabIndex = 7;
            this.player_Name.Text = "Player：";
            // 
            // score_Num
            // 
            this.score_Num.AutoSize = true;
            this.score_Num.BackColor = System.Drawing.Color.Tan;
            this.score_Num.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.score_Num.Location = new System.Drawing.Point(179, 89);
            this.score_Num.Name = "score_Num";
            this.score_Num.Size = new System.Drawing.Size(63, 14);
            this.score_Num.TabIndex = 8;
            this.score_Num.Text = "Score：0";
            // 
            // purchase_1
            // 
            this.purchase_1.Location = new System.Drawing.Point(530, 287);
            this.purchase_1.Name = "purchase_1";
            this.purchase_1.Size = new System.Drawing.Size(48, 23);
            this.purchase_1.TabIndex = 9;
            this.purchase_1.Text = "购买";
            this.purchase_1.UseVisualStyleBackColor = true;
            this.purchase_1.Click += new System.EventHandler(this.purchase_1_Click);
            // 
            // purchase_2
            // 
            this.purchase_2.Location = new System.Drawing.Point(654, 287);
            this.purchase_2.Name = "purchase_2";
            this.purchase_2.Size = new System.Drawing.Size(49, 22);
            this.purchase_2.TabIndex = 10;
            this.purchase_2.Text = "购买";
            this.purchase_2.UseVisualStyleBackColor = true;
            this.purchase_2.Click += new System.EventHandler(this.purchase_2_Click);
            // 
            // purchase_3
            // 
            this.purchase_3.Location = new System.Drawing.Point(787, 287);
            this.purchase_3.Name = "purchase_3";
            this.purchase_3.Size = new System.Drawing.Size(38, 23);
            this.purchase_3.TabIndex = 11;
            this.purchase_3.Text = "购买";
            this.purchase_3.UseVisualStyleBackColor = true;
            this.purchase_3.Click += new System.EventHandler(this.purchase_3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(465, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "金币：5元";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(589, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "金币：8元";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(716, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "金币：10元";
            // 
            // use_1
            // 
            this.use_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("use_1.BackgroundImage")));
            this.use_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.use_1.Location = new System.Drawing.Point(467, 130);
            this.use_1.Name = "use_1";
            this.use_1.Size = new System.Drawing.Size(120, 151);
            this.use_1.TabIndex = 15;
            this.use_1.UseVisualStyleBackColor = true;
            this.use_1.Click += new System.EventHandler(this.use_1_Click);
            // 
            // use_3
            // 
            this.use_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("use_3.BackgroundImage")));
            this.use_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.use_3.Location = new System.Drawing.Point(719, 130);
            this.use_3.Name = "use_3";
            this.use_3.Size = new System.Drawing.Size(106, 151);
            this.use_3.TabIndex = 16;
            this.use_3.UseVisualStyleBackColor = true;
            this.use_3.Click += new System.EventHandler(this.use_3_Click);
            // 
            // use_2
            // 
            this.use_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("use_2.BackgroundImage")));
            this.use_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.use_2.Location = new System.Drawing.Point(593, 130);
            this.use_2.Name = "use_2";
            this.use_2.Size = new System.Drawing.Size(119, 151);
            this.use_2.TabIndex = 17;
            this.use_2.UseVisualStyleBackColor = true;
            this.use_2.Click += new System.EventHandler(this.use_2_Click);
            // 
            // money_Num
            // 
            this.money_Num.AutoSize = true;
            this.money_Num.BackColor = System.Drawing.Color.Tan;
            this.money_Num.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.money_Num.Location = new System.Drawing.Point(316, 89);
            this.money_Num.Name = "money_Num";
            this.money_Num.Size = new System.Drawing.Size(63, 14);
            this.money_Num.TabIndex = 18;
            this.money_Num.Text = "Money：0";
            // 
            // magic_num1
            // 
            this.magic_num1.AutoSize = true;
            this.magic_num1.BackColor = System.Drawing.Color.Tan;
            this.magic_num1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.magic_num1.Location = new System.Drawing.Point(464, 319);
            this.magic_num1.Name = "magic_num1";
            this.magic_num1.Size = new System.Drawing.Size(88, 16);
            this.magic_num1.TabIndex = 19;
            this.magic_num1.Text = "乾坤大挪移";
            // 
            // magic_num2
            // 
            this.magic_num2.AutoSize = true;
            this.magic_num2.BackColor = System.Drawing.Color.Tan;
            this.magic_num2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.magic_num2.Location = new System.Drawing.Point(588, 319);
            this.magic_num2.Name = "magic_num2";
            this.magic_num2.Size = new System.Drawing.Size(72, 16);
            this.magic_num2.TabIndex = 20;
            this.magic_num2.Text = "大金刚指";
            // 
            // magic_num3
            // 
            this.magic_num3.AutoSize = true;
            this.magic_num3.BackColor = System.Drawing.Color.Tan;
            this.magic_num3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.magic_num3.Location = new System.Drawing.Point(714, 319);
            this.magic_num3.Name = "magic_num3";
            this.magic_num3.Size = new System.Drawing.Size(72, 16);
            this.magic_num3.TabIndex = 21;
            this.magic_num3.Text = "潜龙在渊";
            // 
            // goal_Num
            // 
            this.goal_Num.AutoSize = true;
            this.goal_Num.BackColor = System.Drawing.Color.BurlyWood;
            this.goal_Num.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goal_Num.Location = new System.Drawing.Point(164, 37);
            this.goal_Num.Name = "goal_Num";
            this.goal_Num.Size = new System.Drawing.Size(78, 19);
            this.goal_Num.TabIndex = 22;
            this.goal_Num.Text = "Goal：0";
            // 
            // State_Num
            // 
            this.State_Num.AutoSize = true;
            this.State_Num.BackColor = System.Drawing.Color.BurlyWood;
            this.State_Num.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.State_Num.Location = new System.Drawing.Point(608, 39);
            this.State_Num.Name = "State_Num";
            this.State_Num.Size = new System.Drawing.Size(64, 16);
            this.State_Num.TabIndex = 23;
            this.State_Num.Text = "关卡：1";
            // 
            // add_Show
            // 
            this.add_Show.AutoSize = true;
            this.add_Show.BackColor = System.Drawing.Color.Tan;
            this.add_Show.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add_Show.Location = new System.Drawing.Point(49, 130);
            this.add_Show.Name = "add_Show";
            this.add_Show.Size = new System.Drawing.Size(85, 21);
            this.add_Show.TabIndex = 24;
            this.add_Show.Text = "Welcome:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 50;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(319, 490);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 25;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // start_Game
            // 
            this.start_Game.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start_Game.ForeColor = System.Drawing.SystemColors.ControlText;
            this.start_Game.Location = new System.Drawing.Point(611, 87);
            this.start_Game.Name = "start_Game";
            this.start_Game.Size = new System.Drawing.Size(101, 37);
            this.start_Game.TabIndex = 2;
            this.start_Game.Text = "开始游戏";
            this.start_Game.UseVisualStyleBackColor = true;
            this.start_Game.Click += new System.EventHandler(this.start_Game_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 593);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.add_Show);
            this.Controls.Add(this.State_Num);
            this.Controls.Add(this.goal_Num);
            this.Controls.Add(this.magic_num3);
            this.Controls.Add(this.magic_num2);
            this.Controls.Add(this.magic_num1);
            this.Controls.Add(this.money_Num);
            this.Controls.Add(this.use_2);
            this.Controls.Add(this.use_3);
            this.Controls.Add(this.use_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.purchase_3);
            this.Controls.Add(this.purchase_2);
            this.Controls.Add(this.purchase_1);
            this.Controls.Add(this.score_Num);
            this.Controls.Add(this.player_Name);
            this.Controls.Add(this.text_Show);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.restart_Game);
            this.Controls.Add(this.start_Game);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button restart_Game;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.TextBox text_Show;
        private System.Windows.Forms.Label player_Name;
        private System.Windows.Forms.Label score_Num;
        private System.Windows.Forms.Button purchase_1;
        private System.Windows.Forms.Button purchase_2;
        private System.Windows.Forms.Button purchase_3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button use_1;
        private System.Windows.Forms.Button use_3;
        private System.Windows.Forms.Button use_2;
        private System.Windows.Forms.Label money_Num;
        private System.Windows.Forms.Label magic_num1;
        private System.Windows.Forms.Label magic_num2;
        private System.Windows.Forms.Label magic_num3;
        private System.Windows.Forms.Label goal_Num;
        private System.Windows.Forms.Label State_Num;
        private System.Windows.Forms.Label add_Show;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button start_Game;
    }
}