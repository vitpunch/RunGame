using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunGame
{
    class GameCatch
    {
        public List<Игрок> gamers { get; private set; }
        Игрок leader;
        public GameCatch()
        {
            gamers = new List<Игрок>();
        }
        public void AddGamer(Игрок gamer)
        {
            gamers.Add(gamer);
            SetNewLeader(gamer);
        }
        public void Step()
        {
            RunAll();
            FindNewLeader();
        }
        private void FindNewLeader()
        {
            foreach (Игрок g in gamers)
            {
                foreach (Игрок gg in gamers)
                {
                    if (g.Поймал(gg))
                        SetNewLeader(g);
                }
            }
        }
        private void RunAll()
        {
            foreach (Игрок g in gamers)
            {
                g.Беги();
            }
        }
        private void SetNewLeader(Игрок gamer)
        {
            leader = gamer;
        }
    }
}
