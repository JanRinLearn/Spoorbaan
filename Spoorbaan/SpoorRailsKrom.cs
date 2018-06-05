using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class SpoorRailsKrom : SpoorElement
    {
        private const int RAILS_BREEDTE = 2;
        private RailRotatie rotatie;

        public SpoorRailsKrom(int breedte, int grootte, int x, int y, Orientatie orientatie, RailRotatie rotatie) : base(breedte, grootte, x, y, orientatie)
        {
            this.rotatie = rotatie;
        }

        public override void Teken(Graphics g)
        {
            base.Teken(g);
            Pen pen = new Pen(Color.Black, RAILS_BREEDTE);
            switch (rotatie)
            {
                case RailRotatie._0:
                    g.DrawArc(pen, x + 40, y + 100, 90, 90, 90, 90);
                    break;
                case RailRotatie._90:
                    break;
                case RailRotatie._180:
                    break;
                case RailRotatie._270:
                    break;
                default:
                    break;
            }
        }
    }
}