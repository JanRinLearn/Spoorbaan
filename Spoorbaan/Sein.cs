using System;
using System.Collections.Generic;
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
        private const int LAMP_BREEDTE = 1;
        private Lamp lamp1;
        private Lamp lamp2;

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

        public virtual void Teken()
        {
            throw new System.NotImplementedException();
        }
    }
}