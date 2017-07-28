using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class Model
    {
        int sizeField;
        int amountTanks;
        int amountApples;
        int speedGame;

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
                tank.Run();
            }
        }
    }
}
