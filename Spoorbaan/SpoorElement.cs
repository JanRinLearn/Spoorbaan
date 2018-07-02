using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public abstract class SpoorElement
    {
        //Abstracte klasse voor de spoorelementen.
        //Hoewel er in het oorspronkelijk document stond dat er geen field was voor orientatie, maar alleen een property, heb ik er wel een field bijgedaan.
        protected int breedte, grootte, x, y;
        protected Orientatie orientatie;

        //Alle sproorelementen hebben een breedte, een hoogte/grootte, en een x+y coordinaat
        public SpoorElement(int breedte, int grootte, int x, int y)
        {
            this.breedte = breedte;
            this.grootte = grootte;
            this.x = x;
            this.y = y;
            
            
        }

        public Orientatie Orientatie
        {
            get => orientatie;
            set
            {
                value = orientatie;
            }
        }
        //De base methode tekent de achtergrond voor het sproorelement.
        public virtual void Teken(Graphics g)
        {
            SolidBrush sb = new SolidBrush(Color.LightGray);
            Pen pen = new Pen(Color.Black);
            g.FillRectangle(sb, x, y, 100, 100);
            g.DrawRectangle(pen, x, y, 100, 100);
        }
    }
}