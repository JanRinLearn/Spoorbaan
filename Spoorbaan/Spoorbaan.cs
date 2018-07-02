using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class Spoorbaan
    {
        //De breedte en hoogte hier wordt gebruikt voor de individuele elementen, terwijl de X en Y worden gebruikt voor het totale teken vlak.
        private int breedte;
        private int hoogte;
        private List<SpoorwegOvergang> overgangen = new List<SpoorwegOvergang>();
        private List<TreinStation> stations = new List<TreinStation>();
        private int x;
        private int y;
        private List<SpoorElement> elementen = new List<SpoorElement>();

        //De spoorbaan wordt meteen gevult in de constructor
        public Spoorbaan(int breedte, int hoogte,int x, int y)
        {
            this.breedte = breedte;
            this.hoogte = hoogte;
            this.x = x;
            this.y = y;
            MaakSpoorbaan();
        }

        public List<SpoorwegOvergang> Overgangen
        {
            get => overgangen;
            set
            {
                value = overgangen;
            }
        }

        public List<TreinStation> Stations
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
            SpoorwegOvergang spoorweg2 = new SpoorwegOvergang(breedte, hoogte, 600, 100, Orientatie.Verticaal);
            SpoorRailsRecht rechtH1 = new SpoorRailsRecht(breedte, hoogte, 200, 0, Orientatie.Horizontaal);
            SpoorRailsRecht rechtH2 = new SpoorRailsRecht(breedte, hoogte, 300, 0, Orientatie.Horizontaal);
            SpoorRailsRecht rechtH3 = new SpoorRailsRecht(breedte, hoogte, 400, 0, Orientatie.Horizontaal);
            SpoorRailsRecht rechtH4 = new SpoorRailsRecht(breedte, hoogte, 500, 0, Orientatie.Horizontaal);
            SpoorRailsRecht rechtH5 = new SpoorRailsRecht(breedte, hoogte, 100, 400, Orientatie.Horizontaal);
            SpoorRailsRecht rechtH6 = new SpoorRailsRecht(breedte, hoogte, 300, 400, Orientatie.Horizontaal);
            SpoorRailsRecht rechtV1 = new SpoorRailsRecht(breedte, hoogte, 100, 100, Orientatie.Verticaal);
            SpoorRailsRecht rechtV2 = new SpoorRailsRecht(breedte, hoogte, 100, 200, Orientatie.Verticaal);
            SpoorRailsRecht rechtV3 = new SpoorRailsRecht(breedte, hoogte, 500, 300, Orientatie.Verticaal);
            SpoorRailsKrom krom0G1 = new SpoorRailsKrom(breedte, hoogte, 0, 300, RailRotatie._0);
            SpoorRailsKrom krom0G2 = new SpoorRailsKrom(breedte, hoogte, 500, 200, RailRotatie._0);
            SpoorRailsKrom krom0G3 = new SpoorRailsKrom(breedte, hoogte, 100, 0, RailRotatie._0);
            SpoorRailsKrom krom90G1 = new SpoorRailsKrom(breedte, hoogte, 600, 0, RailRotatie._90);
            SpoorRailsKrom krom180G1 = new SpoorRailsKrom(breedte, hoogte, 600, 200, RailRotatie._180);
            SpoorRailsKrom krom180G2 = new SpoorRailsKrom(breedte, hoogte, 100, 300, RailRotatie._180);
            SpoorRailsKrom krom180G3 = new SpoorRailsKrom(breedte, hoogte, 500, 400, RailRotatie._180);
            SpoorRailsKrom krom270G1 = new SpoorRailsKrom(breedte, hoogte, 0, 400, RailRotatie._270);

            //Toevoegen aan de lijsten
            elementen.Add(trein);
            elementen.Add(spoorweg1);
            elementen.Add(spoorweg2);
            elementen.Add(rechtH1);
            elementen.Add(rechtH2);
            elementen.Add(rechtH3);
            elementen.Add(rechtH4);
            elementen.Add(rechtH5);
            elementen.Add(rechtH6);
            elementen.Add(rechtV1);
            elementen.Add(rechtV2);
            elementen.Add(rechtV3);
            elementen.Add(krom0G1);
            elementen.Add(krom0G2);
            elementen.Add(krom0G3);
            elementen.Add(krom90G1);
            elementen.Add(krom180G1);
            elementen.Add(krom180G2);
            elementen.Add(krom180G3);
            elementen.Add(krom270G1);
            stations.Add(trein);
            overgangen.Add(spoorweg1);
            overgangen.Add(spoorweg2);

        }

        //Roept de teken methode aan voor elke spoorelement in de elementen lijst.
        public void Teken(Graphics g)
        {
            SolidBrush sb = new SolidBrush(Color.Pink);
            g.FillRectangle(sb, 0, 0, x, y);
            foreach (SpoorElement e in elementen)
            {
                e.Teken(g);
            }
        }
    }
}