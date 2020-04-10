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
        int leaderSkipSteps;
        static int maxSkipSteps=0;
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
            if (leaderSkipSteps > 0)
            {
                leaderSkipSteps--;
                return;
            }
            if (leader == null)
                return;
            foreach (Игрок g in gamers)
            {
                if(!leader.Equals(g))
                    if (leader.Поймал(g)) {    
                        gamers.Remove(leader);
                        Arena.RefreshCounter(gamers.Count);
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
            
            if (leader != null)
            {
                leader.НеГоля();
            }
            leader = gamer;
            leader.Голя();
            leaderSkipSteps = maxSkipSteps;
        }
    }
}
