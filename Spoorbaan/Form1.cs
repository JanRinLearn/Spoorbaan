using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spoorbaan
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

        }

        private void TekenGrond_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SpoorRailsKrom spoorRailsKrom = new SpoorRailsKrom(100, 100, 100, 100, Orientatie.Horizontaal, RailRotatie._0);
            spoorRailsKrom.Teken(g);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
