﻿using System;
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

        void DrawWall(PaintEventArgs e)
        {
            for (int i = 30; i < 390; i += 60)
                for (int j = 30; j < 390; j += 60)
                    e.Graphics.DrawImage(model.wall.Img, new Point(i, j));
        }

        void DrawTank (PaintEventArgs e)
        {
           e.Graphics.DrawImage(model.tank.Img, new Point(model.tank.X, model.tank.Y));
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
