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
            SpoorwegOvergang treinStation = new SpoorwegOvergang(100, 100, 100, 100,Orientatie.Verticaal);
            treinStation.Status = OvergangSeinStatus.Aan;
            treinStation.Teken(g);

            SpoorwegOvergang spoorweg = new SpoorwegOvergang(100, 100, 200, 200, Orientatie.Horizontaal);
            spoorweg.Teken(g);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
