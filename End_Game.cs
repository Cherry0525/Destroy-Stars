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
    public partial class End_Game : Form
    {
        public End_Game()
        {
            InitializeComponent();
        }

        private void restart_Game_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game game2 = new Game();
            game2.Show();
        }

        private void give_Money_Click(object sender, EventArgs e)
        {
            this.Hide();
            giving_Money giveing_Money1 = new giving_Money();
            giveing_Money1.Show();
        }
    }
}
