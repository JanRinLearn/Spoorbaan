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
            Spoorbaan spoorbaan = new Spoorbaan(100, 100, 1000, 1000);
            spoorbaan.Teken(g);
            Controller controller = new Controller(spoorbaan);

        }

        private void overgang1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void storing_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
