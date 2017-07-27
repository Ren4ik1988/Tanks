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
        public Controller_MainForm()
        {
            InitializeComponent();
            view = new View();
            this.Controls.Add(view);
        }
    }
}
