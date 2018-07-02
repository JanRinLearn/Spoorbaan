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
        Graphics g;
        Spoorbaan spoorbaan;
        Controller controller;
        bool overgangLinks, overgangRechts, station = false;
        public Form1()
        {
            InitializeComponent();
            g = TekenGrond.CreateGraphics();
        }
        //De scherm resolutie van mijn laptop, wat mijn actieve werkcomputer is voor deze opdracht, is 1386 bij 788.
        //Dit zorgt ervoor dat ik niet het venster groter kan maken dan deze resolutie.
        //Simpele null check in het geval dat deze methode op een of andere manier twee keer wordt aangeroepen.
        private void TekenGrond_Paint(object sender, PaintEventArgs e)
        {
            if (spoorbaan == null && controller == null)
            {
                spoorbaan = new Spoorbaan(100, 100, 1000, 1000);
                controller = new Controller(spoorbaan, overgangTimer, storingTimer, g);
            }
            spoorbaan.Teken(g);
        }
        //Simpele methode om de spoorbaan opnieuw te tekenen in de form
        private void TekenGrond_Ververs()
        {
            spoorbaan.Teken(g);
        }

        //Checkbox voor de storing, roept de zet storing methode in de controller aan
        private void storing_CheckedChanged(object sender, EventArgs e)
        {
            if (storing.Checked)
            {
                controller.ZetStoring(true);

            }
            else
            {
                controller.ZetStoring(false);

            }
            TekenGrond_Ververs();
        }
        //Alle button methode werken het zelfde, er wordt gekeken of de bool voor de button aan stond, en wordt de bool geflipt,
        //vervolgens worden de status van alle buttons doorgestuurd naar de controller om de spoorbaan aan te passen.
        private void stationButton_Click(object sender, EventArgs e)
        {
            if (station)
            {
                station = false;
            }
            else
            {
                station = true;
            }
            controller.ZetSpoorwegStatus(overgangLinks, overgangRechts, station);
        }

        private void overgang1_Click(object sender, EventArgs e)
        {
            if (overgangLinks)
            {
                overgangLinks = false;
            }
            else
            {
                overgangLinks = true;
            }
            controller.ZetSpoorwegStatus(overgangLinks, overgangRechts, station);
        }
        private void overgang2_Click(object sender, EventArgs e)
        {
            if (overgangRechts)
            {
                overgangRechts = false;
            }
            else
            {
                overgangRechts = true;
            }
            controller.ZetSpoorwegStatus(overgangLinks, overgangRechts, station);
        }
    }
}
