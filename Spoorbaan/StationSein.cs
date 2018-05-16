using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class StationSein : Sein
    {
        private const int LAMP_BREEDTE = 1;
        private StationSeinStatus status;

        public StationSein(int breedte, int hoogte, int x, int y) : base(breedte, hoogte, x, y)
        {
            Lamp lamp1 = new Lamp(x, y, LAMP_BREEDTE);
            Lamp lamp2 = new Lamp(x, y, LAMP_BREEDTE, LampKleur.Groen);
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

        public override void Teken()
        {
            throw new System.NotImplementedException();
        }
    }
}