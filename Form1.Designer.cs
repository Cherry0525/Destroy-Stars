namespace Destroy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start_Game = new System.Windows.Forms.Button();
            this.exit_Game = new System.Windows.Forms.Button();
            this.teach_Game = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // start_Game
            // 
            this.start_Game.BackColor = System.Drawing.SystemColors.WindowText;
            this.start_Game.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start_Game.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.start_Game.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.start_Game.Location = new System.Drawing.Point(570, 68);
            this.start_Game.Name = "start_Game";
            this.start_Game.Size = new System.Drawing.Size(115, 59);
            this.start_Game.TabIndex = 0;
            this.start_Game.Text = "开始";
            this.start_Game.UseVisualStyleBackColor = false;
            this.start_Game.Click += new System.EventHandler(this.start_Game_Click);
            // 
            // exit_Game
            // 
            this.exit_Game.BackColor = System.Drawing.SystemColors.WindowText;
            this.exit_Game.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exit_Game.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit_Game.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exit_Game.Location = new System.Drawing.Point(570, 147);
            this.exit_Game.Name = "exit_Game";
            this.exit_Game.Size = new System.Drawing.Size(115, 53);
            this.exit_Game.TabIndex = 1;
            this.exit_Game.Text = "退出";
            this.exit_Game.UseVisualStyleBackColor = false;
            this.exit_Game.Click += new System.EventHandler(this.exit_Game_Click);
            // 
            // teach_Game
            // 
            this.teach_Game.BackColor = System.Drawing.SystemColors.WindowText;
            this.teach_Game.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.teach_Game.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.teach_Game.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.teach_Game.Location = new System.Drawing.Point(571, 222);
            this.teach_Game.Name = "teach_Game";
            this.teach_Game.Size = new System.Drawing.Size(114, 60);
            this.teach_Game.TabIndex = 2;
            this.teach_Game.Text = "新手教程";
            this.teach_Game.UseVisualStyleBackColor = false;
            this.teach_Game.Click += new System.EventHandler(this.teach_Game_Click);
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(570, 307);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer2.TabIndex = 3;
            this.axWindowsMediaPlayer2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 391);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.teach_Game);
            this.Controls.Add(this.exit_Game);
            this.Controls.Add(this.start_Game);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.teach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_Game;
        private System.Windows.Forms.Button exit_Game;
        private System.Windows.Forms.Button teach_Game;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
    }
}

