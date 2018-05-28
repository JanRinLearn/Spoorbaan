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
            Sein sein = new Sein(20, 10, 100, 100);
            Graphics g = e.Graphics;
            sein.Teken(g);
            
        }
    }
}
