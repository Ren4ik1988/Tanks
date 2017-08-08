using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tanks
{
    class Model
    {
        int sizeField;
        int amountTanks;
        int amountApples;
        public int speedGame;
        public Wall wall;
        Random r;

        public GameStatus gameStatus;

        List<Tank> tanks;
        internal List<Tank> Tanks { get => tanks; }

        List<Apple> apples;
        internal List<Apple> Apples { get => apples; }

        public Model(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            tanks = new List<Tank>();
            apples = new List<Apple>();
            this.sizeField = sizeField;
            this.amountTanks = amountTanks;
            this.amountApples = amountApples;
            this.speedGame = speedGame;
            r = new Random();

            CreateTanks();
            CreateApples();
            wall = new Wall();

            gameStatus = GameStatus.stoping;
        }

        private void CreateApples()
        {
            int x, y;
            while (apples.Count < amountApples)
            {
                x = r.Next(7) * 60;
                y = r.Next(7) * 60;
                bool flag = true;

                foreach (Apple a in apples)
                    if (a.X == x && a.Y == y)
                    {
                        flag = false;
                        break;
                    }

                if (flag)
                    tanks.Add(new Tank(sizeField, x, y));

            }
        }

        private void CreateTanks()
        {
            int x, y;
            while (tanks.Count < amountTanks)
            {
                x = r.Next(7) * 60;
                y = r.Next(7) * 60;
                bool flag = true;

                foreach (Tank t in Tanks)
                    if (t.X == x && t.Y == y)
                    {
                        flag = false;
                        break;
                    }

                if (flag)
                    tanks.Add(new Tank(sizeField, x, y));

            }
        }

        public void Play()
        {
            while(gameStatus == GameStatus.playing)
            {
                Thread.Sleep(speedGame);
                foreach (Tank t in tanks)
                    t.Run();

                for (int i = 0; i < tanks.Count - 1; i++)
                    for (int j = 1; j < tanks.Count; j++)
                        if (
                                Math.Abs(tanks[i].X - tanks[j].X) <= 30 && tanks[i].Y ==tanks[j].Y
                            ||
                                Math.Abs(tanks[i].Y - tanks[j].Y) <= 30 && tanks[i].X == tanks[j].X
                            ||
                                Math.Abs(tanks[i].X - tanks[j].X) <= 30 && Math.Abs(tanks[i].Y - tanks[j].Y) <= 30
                            )
                        {
                            tanks[i].TurnArroud();
                            tanks[j].TurnArroud();
                        }
            }
        }
    }
}
