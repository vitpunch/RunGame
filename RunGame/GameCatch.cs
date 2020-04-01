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
            leader = null;
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
            if (leader == null)
                return;
            foreach (Игрок g in gamers)
            {
                if (leader.Поймал(g)) {
                    SetNewLeader(g);
                    break;
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
            if(leader!=null)
                leader.НеГоля();
            leader = gamer;
            leader.Голя();
        }
    }
}
