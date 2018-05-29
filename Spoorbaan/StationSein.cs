using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class StationSein : Sein
    {
        //Default status is uit voor de stations
        private StationSeinStatus status = StationSeinStatus.Uit;

        //Bij het maken van de station sein is het belangrijk dat de hoogte een grotere waarde heeft dan de breedte
        //Hoewel het mogelijk is om een check te doen of de hoogte een hogere waarde dan de breedte, en om deze om te wisselen als dat niet zo is,
        //ik weet niet hoe ik dat kan implementeren als de breedte en hoogte meteen worden ingevoerd in de base classe
        public StationSein(int breedte, int hoogte, int x, int y) : base(breedte, hoogte, x, y)
        {
            Lamp lamp1 = new Lamp(x, y);
            Lamp lamp2 = new Lamp(x, y+20, LampKleur.Groen);
            Lamp1 = lamp1;
            Lamp2 = lamp2;
        }
        //
        public StationSeinStatus Status
        {
            get => status;
        }
        
        private void SetStatus(StationSeinStatus s)
        {
            status = s;
        }
        //Override voor het tekenen van een stationsein. Bij de juiste status worden de correcte lampen aangezet
        //De lampen hebben de correcte kleur nodig al ontvangen bij de constructor
        //zodra de juiste lampen aanstaan wordt de basis teken methode aangeroepen om het sein daadwerkelijk te tekenen
        public override void Teken(Graphics g)
        {
            switch (status)
            {
                case StationSeinStatus.Groen:
                    Lamp1.Status = LampStatus.Uit;
                    Lamp2.Status = LampStatus.Aan;
                    break;
                case StationSeinStatus.Rood:
                    Lamp1.Status = LampStatus.Aan;
                    Lamp2.Status = LampStatus.Uit;
                    break;
                case StationSeinStatus.Uit:
                    Lamp1.Status = LampStatus.Uit;
                    Lamp2.Status = LampStatus.Uit;
                    break;
                case StationSeinStatus.Storing:
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