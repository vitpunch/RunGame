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

        private void SetNewLeader(Игрок gamer)
        {
            throw new NotImplementedException();
        }
    }
}
