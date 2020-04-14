using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunGame
{
    public partial class FormGame : Form
    {
        Arena arena;
        GameVirus game;
        public FormGame()
        {
            InitializeComponent();
            arena = new Arena(pictureBox);
            game = new GameVirus();
        }

        private void buttonAddGamer_Click(object sender, EventArgs e)
        {
            game.AddGamer(Arena.NewBox());
            //arena.Show(circle);
            arena.Refresh();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            game.Step();
            arena.Clear();
            foreach(Box box in game.gamers)
                arena.Show(box);
            arena.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
                game.AddGamer(Arena.NewBox());
            arena.Refresh();
        }
        
    }
}
