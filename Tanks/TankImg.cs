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
        Image imgUp = Properties.Resources.TankUp;
        Image imgDown = Properties.Resources.TankDown;
        Image imgLeft = Properties.Resources.TankLeft;
        Image imgRight = Properties.Resources.TankRight;

        //создадим свойства для каждого поля
        public Image ImgUp
        {
            get { return imgUp; }
            set { imgUp = value; }
        }
        public Image ImgDown
        {
            get { return imgDown; }
            set { imgDown = value; }
        }
        public Image ImgLeft
        {
            get { return imgLeft; }
            set { imgLeft = value; }
        }
        public Image ImgRight
        {
            get { return imgRight; }
            set { imgRight = value; }
        }
    }
}
