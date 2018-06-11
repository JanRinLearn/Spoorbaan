using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class TreinStation : SpoorElement
    {
        private StationSeinStatus status;
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
        }

        private void SetStatus(StationSeinStatus s)
        {
            status = s;
            
        }

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