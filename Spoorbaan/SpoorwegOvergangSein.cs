using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;

namespace Spoorbaan
{
    public class SpoorwegOvergangSein : Sein
    {
        //Default waarde van de overgangsein is uit
        private OvergangSeinStatus status = OvergangSeinStatus.Uit;

        //Bij een overgangsein is het belangrijk dat de breedte groter is dan de hoogte
        public SpoorwegOvergangSein(int breedte, int hoogte, int x, int y) : base(breedte, hoogte, x, y)
        {
            Lamp lamp1 = new Lamp(x, y);
            Lamp lamp2 = new Lamp(x+10, y);
            Lamp1 = lamp1;
            Lamp2 = lamp2;
        }

        public OvergangSeinStatus Status
        {
            get => status;
            set
            {
                SetStatus(value);
            }
        }

        private void SetStatus(OvergangSeinStatus s)
        {
            status = s;
        }
        //Wordt nog verder aangepast, is nog niet volledig klaar.
        public override void Teken(Graphics g)
        {
            switch (status)
            {
                case OvergangSeinStatus.Aan:
                    Lamp1.Status = LampStatus.Aan;
                    Lamp2.Status = LampStatus.Uit;
                    break;
                case OvergangSeinStatus.Aan2:
                    Lamp1.Status = LampStatus.Uit;
                    Lamp2.Status = LampStatus.Aan;
                    break;
                case OvergangSeinStatus.Uit:
                    Lamp1.Status = LampStatus.Uit;
                    Lamp2.Status = LampStatus.Uit;
                    break;
                case OvergangSeinStatus.Storing:
                    Lamp1.Status = LampStatus.Aan;
                    Lamp2.Status = LampStatus.Aan;
                    break;
                default:
                    break;
            }
            
            
            base.Teken(g);
            
        }
    }
}