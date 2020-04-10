using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunGame
{
    class GameVirus
    {
        public List<Игрок> gamers { get; private set; }
        private List<Игрок> virused;
        public GameVirus()
        {
            gamers = new List<Игрок>();
            virused = new List<Игрок>();
        }
        public void AddGamer(Игрок gamer)
        {
            gamers.Add(gamer);
            SetNewVirus(gamer);
        }
        public void Step()
        {
            RunAll();
            FindNewVirused();
        }

        private void FindNewVirused()
        {
            foreach (Игрок g in gamers)
                if (!virused.Contains(g))
                {
                    if (virused.Count == gamers.Count - 1)
                    {
                        SetNewVirus(g);
                        break;
                    }
                    foreach (Игрок virus in virused)
                        if (g.Поймал(virus))
                        {
                            virused.Add(g);
                            g.Голя();
                            break;
                        }
                }
        }

        private void RunAll()
        {
            foreach (Игрок gamer in gamers)
                if (virused.Contains(gamer))
                    gamer.Беги();
        }

        private void SetNewVirus(Игрок gamer)
        {
            virused = new List<Игрок>();
            foreach (Игрок g in gamers)
                g.НеГоля();
            gamer.Голя();
            virused.Add(gamer);
        }
    }
}
