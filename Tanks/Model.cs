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

        public Tank tank;

        public Model(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            this.sizeField = sizeField;
            this.amountTanks = amountTanks;
            this.amountApples = amountApples;
            this.speedGame = speedGame;

            tank = new Tank();
        }

        public void Play()
        {
            while(true)
            {
                Thread.Sleep(speedGame);
                tank.Run();
            }
        }
    }
}
