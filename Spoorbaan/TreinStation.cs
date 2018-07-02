using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class TreinStation : SpoorElement
    {
        private StationSeinStatus status = StationSeinStatus.Uit;
        private StationSein sein1;
        private StationSein sein2;
        
        public TreinStation(int breedte, int grootte, int x, int y) : base(breedte, grootte, x, y)
        {
            sein1 = new StationSein(10, 30, x, y);
            sein2 = new StationSein(10, 30, x+90, y);
        }

        public StationSein Sein1
        {
            get => sein1;
            set
            {
                value = sein1;
            }
        }

        public StationSein Sein2
        {
            get => sein2;
            set
            {
                value = sein2;
            }
        }

        public StationSeinStatus StationSeinStatus
        {
            get => status;
            set
            {
                SetStatus(value);
            }
        }

        //Set de sein status gebaseerd op de sein status van het treinstation
        private void SetStatus(StationSeinStatus s)
        {
            status = s;
            switch (status)
            {
                case StationSeinStatus.Groen:
                    sein1.Status = StationSeinStatus.Groen;
                    sein2.Status = StationSeinStatus.Rood;
                    break;
                case StationSeinStatus.Rood:
                    sein1.Status = StationSeinStatus.Rood;
                    sein2.Status = StationSeinStatus.Groen;
                    break;
                case StationSeinStatus.Uit:
                    sein1.Status = StationSeinStatus.Uit;
                    sein2.Status = StationSeinStatus.Uit;
                    break;
                case StationSeinStatus.Storing:
                    sein1.Status = StationSeinStatus.Storing;
                    sein2.Status = StationSeinStatus.Storing;
                    break;
                default:
                    break;
            }
        }

        //Tekent eerst de achtergrond, gevolgt door de seinen, en vervolgens door een plaatje van een station die in de applicatie zit.
        public override void Teken(Graphics g)
        {
            base.Teken(g);
            Image image = Image.FromFile("images/station.png");
            sein1.Teken(g);
            sein2.Teken(g);
            g.DrawImage(image, x, y, breedte, grootte);
            
        }
    }
}