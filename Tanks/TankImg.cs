using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class TankImg
    {
        Image[] up = new Image[] {
                                    Properties.Resources.TankUp,
                                    Properties.Resources.TankUp1,
                                    Properties.Resources.TankUp2,
                                    Properties.Resources.TankUp3 };

        Image[] down = new Image[] {
                                    Properties.Resources.TankDown,
                                    Properties.Resources.TankDown1,
                                    Properties.Resources.TankDown2,
                                    Properties.Resources.TankDown3 };

        Image[] left = new Image[] {
                                    Properties.Resources.TankLeft,
                                    Properties.Resources.TankLeft1,
                                    Properties.Resources.TankLeft2,
                                    Properties.Resources.TankLeft3 };

        Image[] right = new Image[] {
                                    Properties.Resources.TankRight,
                                    Properties.Resources.TankRight1,
                                    Properties.Resources.TankRight2,
                                    Properties.Resources.TankRight3 };


        //определяем свойства массивов
        public Image[] Up { get => up; }
        public Image[] Down { get => down; }
        public Image[] Left { get => left; }
        public Image[] Right { get => right; }
    }
}
