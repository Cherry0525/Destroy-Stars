namespace Destroy
{
    partial class End_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(End_Game));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.restart_Game = new System.Windows.Forms.Button();
            this.give_Money = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 307);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // restart_Game
            // 
            this.restart_Game.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.restart_Game.Location = new System.Drawing.Point(45, 220);
            this.restart_Game.Name = "restart_Game";
            this.restart_Game.Size = new System.Drawing.Size(175, 62);
            this.restart_Game.TabIndex = 1;
            this.restart_Game.Text = "技术帝";
            this.restart_Game.UseVisualStyleBackColor = true;
            this.restart_Game.Click += new System.EventHandler(this.restart_Game_Click);
            // 
            // give_Money
            // 
            this.give_Money.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.give_Money.Location = new System.Drawing.Point(374, 220);
            this.give_Money.Name = "give_Money";
            this.give_Money.Size = new System.Drawing.Size(175, 62);
            this.give_Money.TabIndex = 2;
            this.give_Money.Text = "大土豪";
            this.give_Money.UseVisualStyleBackColor = true;
            this.give_Money.Click += new System.EventHandler(this.give_Money_Click);
            // 
            // End_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 308);
            this.Controls.Add(this.give_Money);
            this.Controls.Add(this.restart_Game);
            this.Controls.Add(this.pictureBox1);
            this.Name = "End_Game";
            this.Text = "End_Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button restart_Game;
        private System.Windows.Forms.Button give_Money;
    }
}