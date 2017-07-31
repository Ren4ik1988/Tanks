﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class Tank : IRun, ITurn, ITransparent
    {
        TankImg tankImg = new TankImg();
        Image img;

        int x, y, direct_x, direct_y, sizeField;

        static Random r;

        public Tank(int sizeField)
        {
            this.sizeField = sizeField;
            r = new Random();
            img = tankImg.Img;
            Direct_x = 0;
            Direct_y = 1;
            x = 120;
            y = 120;
        }

        public Image Img { get => img; }
        public int X { get => x; }
        public int Y { get => y; }
        public int Direct_x
        {
            get => direct_x;
            set
            {
                if (value == 0 || value == -1 || value == 1)
                    direct_x = value;
                else
                    direct_x = 0;
            }
        }

        public int Direct_y
        {
            get => direct_y;
            set
            {
                if (value == 0 || value == -1 || value == 1)
                    direct_y = value;
                else
                    direct_y = 0;
            }
        }

        public void Run()
        {
            x += direct_x;
            y += direct_y;

            if (Math.IEEERemainder(x, 60) == 0 && Math.IEEERemainder(y, 60) == 0)
                Turn();

            Transparernt();

        }

        public void Turn()
        {
            if (r.Next(5000) < 2500)// двигаемся далее по вертикали
            {
                if (direct_y != 0)
                    Direct_y = direct_y;
                else
                {
                    direct_x = 0;
                    while (direct_y == 0)
                        Direct_y = r.Next(-1, 2);
                }
            }
            else //двигаемся по горизонтали
            {
                if (direct_x != 0)
                    Direct_x = direct_x;
                else
                {
                    direct_y = 0;
                    while (Direct_x == 0)
                        Direct_x = r.Next(-1, 2);
                }
            }
        }

        public void Transparernt()
        {
            if (x == -1)
                x = sizeField-31;
            if (x == sizeField - 29)
                x = 1;

            if (y == -1)
                y = sizeField - 61;
            if (y == sizeField-29)
                y = 1;
        }
    }
}
