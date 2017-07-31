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
        public Wall wall;

        public Model(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            this.sizeField = sizeField;
            this.amountTanks = amountTanks;
            this.amountApples = amountApples;
            this.speedGame = speedGame;

            wall = new Wall();
            tank = new Tank(sizeField);

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
