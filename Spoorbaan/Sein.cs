using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class Sein
    {
        //Voorbeeld diagram had ook een contante voor lampbreedte, maar die is verplaatst naar de straal constante in de lamp
        private int breedte, hoogte, x, y;
        private Lamp lamp1, lamp2;

        //Lampen worden specifiek aangemaakt in de afgeleide klasse, de afmetingen van de sein achtergrond kunnen wel generiek
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

        //Basic methode voor de sein tekening, doet het daatwerkelijke tekenen van het gehele sein
        //if NULL check ingevoegt omdat er in de basis methode geen lampen worden aangemaakt. Basis methode breekt nu niet de applicatie
        public virtual void Teken(Graphics g)
        {
            SolidBrush sb = new SolidBrush(Color.Black);
            g.FillRectangle(sb, x, y, breedte, hoogte);
            if (lamp1 != null)
            {
                lamp1.Teken(g);
            }
            if (lamp2 != null)
            {
                lamp2.Teken(g);
            }
            
        }
    }
}