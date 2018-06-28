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
        public Form1()
        {
            InitializeComponent();
            g = TekenGrond.CreateGraphics();
        }
        //De scherm resolutie van mijn laptop, wat mijn actieve werkcomputer is voor deze opdracht, is 1386 bij 788.
        //Dit zorgt ervoor dat ik niet het venster groter kan maken dan deze resolutie.
        private void TekenGrond_Paint(object sender, PaintEventArgs e)
        {
            if (spoorbaan == null && controller == null)
            {
                spoorbaan = new Spoorbaan(100, 100, 1000, 1000);
                controller = new Controller(spoorbaan,overgangTimer,storingTimer, g);
            }
            spoorbaan.Teken(g);
        }

        private void TekenGrond_Ververs()
        {
            spoorbaan.Teken(g);
        }

        private void overgang1_CheckedChanged(object sender, EventArgs e)
        {

        }

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

        
    }
}
