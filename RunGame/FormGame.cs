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
        GameCatch gameCatch;
        public FormGame()
        {
            InitializeComponent();
            arena = new Arena(pictureBox);
            //gameCatch = new GameCatch();
        }

        private void buttonAddGamer_Click(object sender, EventArgs e)
        {
            Circle circle = Arena.NewCircle();
            //gameCatch.AddGamer(circle);
            arena.Show(circle);
            arena.Refresh();
        }
    }
}
