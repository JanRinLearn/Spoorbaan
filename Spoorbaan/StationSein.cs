using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class StationSein : Sein
    {
        private StationSeinStatus status;

        public StationSein(int breedte, int hoogte, int x, int y) : base(breedte, hoogte, x, y)
        {
            Lamp lamp1 = new Lamp(x, y);
            Lamp lamp2 = new Lamp(x, y, LampKleur.Groen);
            Lamp1 = lamp1;
            Lamp2 = lamp2;
        }

        public StationSeinStatus Status
        {
            get => status;
        }

        private void SetStatus(StationSeinStatus s)
        {
            status = s;
        }

        public override void Teken(Graphics g)
        {
            throw new System.NotImplementedException();
        }
    }
}