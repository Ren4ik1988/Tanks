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

        public GameStatus gameStatus;

        public Tank tank;

        public Model(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            this.sizeField = sizeField;
            this.amountTanks = amountTanks;
            this.amountApples = amountApples;
            this.speedGame = speedGame;

            tank = new Tank();

            gameStatus = GameStatus.stoping;
        }

        public void Play()
        {
            while(gameStatus == GameStatus.playing)
            {
                Thread.Sleep(speedGame);
                tank.Run();
            }
        }
    }
}
