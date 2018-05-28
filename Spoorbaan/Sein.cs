using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class Sein
    {
        private int breedte;
        private int hoogte;
        private int x;
        private int y;
        private Lamp lamp1;
        private Lamp lamp2;
        private SolidBrush sb = new SolidBrush(Color.Black);

        public Sein(int breedte, int hoogte, int x, int y)
        {
            this.breedte = breedte;
            this.hoogte = hoogte;
            this.x = x;
            this.y = y;
        }

        public Lamp Lamp1
        {
            get => lamp1;
            set
            {
                lamp1 = value;
            }
        }

        public Lamp Lamp2
        {
            get => lamp2;
            set
            {
                lamp2 = value;
            }
        }

        public virtual void Teken(Graphics g)
        {
            g.FillRectangle(sb, x, y, breedte, hoogte);
            lamp1.Teken(g);
            lamp2.Teken(g);
        }
    }
}