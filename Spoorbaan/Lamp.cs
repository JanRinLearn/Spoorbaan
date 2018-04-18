using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Spoorbaan
{
    public class Lamp
    {
        //LampKleur kan eigenlijk alleen Rood of Groen zijn bij een spoorlicht, slecht af te handelen in string.
        protected LampKleur kleur;
        protected int straal;
        protected int x;
        protected int y;
        protected LampStatus status;

        //Default Lamp heeft altijd een x en y coordinaat nodig, maar de straal kleur en status kunnen default zijn
        public Lamp(int x, int y)
        {
            this.x = x;
            this.y = y;
            straal = 2;
            kleur = LampKleur.Groen;
            status = LampStatus.Aan;
        }

        public LampKleur Kleur
        {
            get => kleur;
            set
            {
                kleur = value;
            }
        }

        public LampStatus Status
        {
            get => status;
            set
            {
                status = value;
            }
        }

        public void Teken()
        {
            Graphics g;
            if (status == LampStatus.Aan)
            {
                switch (kleur) 
                {
                    case LampKleur.Groen:
                        break;
                    case LampKleur.Rood:
                        break;
                    default:
                        break;
                }
            }
            else
            {

            }
        }
    }
}