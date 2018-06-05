using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class SpoorRailsRecht : SpoorElement
    {
        private const int RAILS_BREEDTE = 3;


        public SpoorRailsRecht(int breedte, int grootte, int x, int y, Orientatie orientatie) : base(breedte, grootte, x, y)
        {
            base.orientatie = orientatie;
        }

        public override void Teken(Graphics g)
        {
            base.Teken(g);
            Pen pen = new Pen(Color.Black,RAILS_BREEDTE);
            if (Orientatie == Orientatie.Horizontaal)
            {
                g.DrawLine(pen, x + 40, y, x + 40, y + 100);
                g.DrawLine(pen, x + 60, y, x + 60, y + 100);
                g.DrawLine(pen, x + 40, y + 20, x + 60, y + 20);
                g.DrawLine(pen, x + 40, y + 40, x + 60, y + 40);
                g.DrawLine(pen, x + 40, y + 60, x + 60, y + 60);
                g.DrawLine(pen, x + 40, y + 80, x + 60, y + 80);

            }
            else if (Orientatie == Orientatie.Verticaal)
            {
                g.DrawLine(pen, x, y + 40, x + 100, y + 40);
                g.DrawLine(pen, x, y + 60, x + 100, y + 60);
                g.DrawLine(pen, x + 20, y + 40, x + 20, y + 60);
                g.DrawLine(pen, x + 40, y + 40, x + 40, y + 60);
                g.DrawLine(pen, x + 60, y + 40, x + 60, y + 60);
                g.DrawLine(pen, x + 80, y + 40, x + 80, y + 60);
            }
            else
            {

            }

        }
    }
}