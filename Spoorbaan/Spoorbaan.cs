using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class Spoorbaan
    {
        private int breedte;
        private int hoogte;
        private int overgangen;
        private int stations;
        private int x;
        private int y;
        private List<SpoorElement> elementen = new List<SpoorElement>();

        public Spoorbaan(int breedte, int hoogte, int overgangen, int stations, int x, int y)
        {
            this.breedte = breedte;
            this.hoogte = hoogte;
            this.overgangen = overgangen;
            this.stations = stations;
            this.x = x;
            this.y = y;
            MaakSpoorbaan();
        }

        public int Overgangen
        {
            get => overgangen;
            set
            {
                value = overgangen;
            }
        }

        public int Stations
        {
            get => stations;
            set
            {
                value = stations;
            }
        }

        private void MaakSpoorbaan()
        {
            //Maken van de elementen
            TreinStation trein = new TreinStation(breedte, hoogte, 200, 400);
            SpoorwegOvergang spoorweg1 = new SpoorwegOvergang(breedte, hoogte, 400, 400, Orientatie.Horizontaal);
            SpoorwegOvergang spoorweg2 = new SpoorwegOvergang(breedte, hoogte, 500, 100, Orientatie.Verticaal);
            SpoorRailsRecht recht1 = new SpoorRailsRecht(breedte, hoogte, 200, 0, Orientatie.Horizontaal);
            SpoorRailsRecht recht2 = new SpoorRailsRecht(breedte, hoogte, 300, 0, Orientatie.Horizontaal);
            SpoorRailsRecht recht3 = new SpoorRailsRecht(breedte, hoogte, 400, 0, Orientatie.Horizontaal);
            SpoorRailsRecht recht4 = new SpoorRailsRecht(breedte, hoogte, 500, 0, Orientatie.Horizontaal);

            //Toevoegen aan de lijst
            elementen.Add(trein);
            elementen.Add(spoorweg1);
            elementen.Add(spoorweg2);
            elementen.Add(recht1);
            elementen.Add(recht2);
            elementen.Add(recht3);
            elementen.Add(recht4);


        }

        public void Teken(Graphics g)
        {
            foreach (SpoorElement e in elementen)
            {
                e.Teken(g);
            }
        }
    }
}