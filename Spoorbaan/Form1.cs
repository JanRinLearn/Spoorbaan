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
            SpoorRailsKrom spoorRailsKrom1 = new SpoorRailsKrom(100, 100, 100, 100, RailRotatie._0);
            spoorRailsKrom1.Teken(g);

            SpoorRailsKrom spoorRailsKrom2 = new SpoorRailsKrom(100, 100, 300, 100, RailRotatie._90);
            spoorRailsKrom2.Teken(g);

            SpoorRailsKrom spoorRailsKrom3 = new SpoorRailsKrom(100, 100, 300, 300, RailRotatie._180);
            spoorRailsKrom3.Teken(g);

            SpoorRailsKrom spoorRailsKrom4 = new SpoorRailsKrom(100, 100, 100, 300, RailRotatie._270);
            spoorRailsKrom4.Teken(g);

            SpoorRailsRecht spoorRailsRecht1 = new SpoorRailsRecht(100, 100, 100, 200, Orientatie.Verticaal);
            spoorRailsRecht1.Teken(g);

            SpoorRailsRecht spoorRailsRecht2 = new SpoorRailsRecht(100, 100, 300, 200, Orientatie.Verticaal);
            spoorRailsRecht2.Teken(g);

            SpoorRailsRecht spoorRailsRecht3 = new SpoorRailsRecht(100, 100, 200, 100, Orientatie.Horizontaal);
            spoorRailsRecht3.Teken(g);

            SpoorRailsRecht spoorRailsRecht4 = new SpoorRailsRecht(100, 100, 200, 300, Orientatie.Horizontaal);
            spoorRailsRecht4.Teken(g);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
