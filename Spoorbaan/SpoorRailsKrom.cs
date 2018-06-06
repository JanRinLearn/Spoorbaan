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

        public SpoorRailsKrom(int breedte, int grootte, int x, int y, RailRotatie rotatie) : base(breedte, grootte, x, y)
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
                    g.DrawArc(pen, x + 50, y + 50, 100, 100, 180, 90);
                    g.DrawArc(pen, x + 40, y + 40, 120, 120, 180, 90);
                    break;
                case RailRotatie._90:
                    g.DrawArc(pen, x - 50, y + 50, 100, 100, 270, 90);
                    g.DrawArc(pen, x - 60, y + 40, 120, 120, 270, 90);
                    break;
                case RailRotatie._180:
                    g.DrawArc(pen, x - 50, y - 50, 100, 100, 0, 90);
                    g.DrawArc(pen, x - 60, y - 60, 120, 120, 0, 90);
                    break;
                case RailRotatie._270:
                    g.DrawArc(pen, x + 50, y - 50, 100, 100, 90, 90);
                    g.DrawArc(pen, x + 40, y - 60, 120, 120, 90, 90);
                    break;
                default:
                    break;
            }
        }
    }
}