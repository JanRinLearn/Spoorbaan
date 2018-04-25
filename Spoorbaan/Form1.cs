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
            Lamp lamp = new Lamp(4, 4);
            lamp.Status = LampStatus.Aan;
            Graphics g = e.Graphics;
            lamp.Teken(g);
        }
    }
}
