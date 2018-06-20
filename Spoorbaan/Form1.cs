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
        //De scherm resolutie van mijn laptop, wat mijn actieve werkcomputer is voor deze opdracht, is 1386 bij 788.
        //Dit zorgt ervoor dat ik niet het venster groter kan maken dan deze resolutie.
        private void TekenGrond_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            TreinStation treinStation = new TreinStation(100, 100, 100, 100);
            treinStation.StationSeinStatus = StationSeinStatus.Groen;
            TreinStation station = new TreinStation(100, 100, 200, 100);
            station.StationSeinStatus = StationSeinStatus.Rood;
            treinStation.Teken(g);
            station.Teken(g);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
