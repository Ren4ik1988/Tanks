using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class Tank
    {
        int x, y;

        TankImg tankImg = new TankImg();

        public TankImg TankImg { get => tankImg; }
        public int X { get => x; }
        public int Y { get => y; }

        public void Run()
        {
            x = ++y;
        }
    }
}
