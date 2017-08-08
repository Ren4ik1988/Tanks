using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tanks
{
    partial class View : UserControl
    {
        Model model;

        public View(Model model)
        {
            InitializeComponent();

            this.model = model;
        }

        void DrawApple(PaintEventArgs e)
        {
            foreach (Apple a in model.Apples)
                e.Graphics.DrawImage(a.Img, new Point(a.X, a.Y));
        }

        void DrawWall(PaintEventArgs e)
        {
            for (int i = 30; i < 390; i += 60)
                for (int j = 30; j < 390; j += 60)
                    e.Graphics.DrawImage(model.wall.Img, new Point(i, j));
        }

        void DrawTank (PaintEventArgs e)
        {
            foreach(Tank t in model.Tanks)
            e.Graphics.DrawImage(t.CurrentImg, new Point(t.X, t.Y));
        }

        void Draw(PaintEventArgs e)
        {
            DrawWall(e);
            DrawTank(e);

            if (model.gameStatus != GameStatus.playing)
                return;

            Thread.Sleep(model.speedGame);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e);
        }
    }
}
