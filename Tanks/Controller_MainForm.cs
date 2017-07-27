using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanks
{
    public partial class Controller_MainForm : Form
    {
        View view;

        public Controller_MainForm(): this(260) { }
        public Controller_MainForm(int sizeField): this (sizeField, 5) { }
        public Controller_MainForm(int sizeField, int amountTanks): this (sizeField, amountTanks, 5) { }
        public Controller_MainForm(int sizeField, int amountTanks, int amountApples) : this(sizeField, amountTanks, amountApples, 40) { }
        public Controller_MainForm(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            InitializeComponent();
            view = new View();
            this.Controls.Add(view);
        }
    }
}
