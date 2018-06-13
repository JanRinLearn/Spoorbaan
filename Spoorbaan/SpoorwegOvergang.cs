using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class SpoorwegOvergang : SpoorElement
    {
        private int rails;
        private SpoorwegOvergangSein sein1;
        private SpoorwegOvergangSein sein2;
        private OvergangSeinStatus status = OvergangSeinStatus.Aan;

        public SpoorwegOvergang(int breedte, int grootte, int x, int y, Orientatie orientatie) : base(breedte, grootte, x, y)
        {
            sein1 = new SpoorwegOvergangSein(20, 10, x, y);
            sein2 = new SpoorwegOvergangSein(20, 10, x + 80, y + 90);
            this.orientatie = orientatie;
        }

        public Sein Sein1
        {
            get => sein1;
            set
            {
                value = sein1;
            }
        }

        public Sein Sein2
        {
            get => sein2;
            set
            {
                value = sein2;
            }
        }

        public OvergangSeinStatus Status
        {
            get => status;

        }

        private void SetStatus(OvergangSeinStatus s)
        {
            status = s;

        }

        //Ik veronschuldig mij alvast voor de lengte van deze methode.
        //De reden waarom ik 
        public override void Teken(Graphics g)
        {
            base.Teken(g);
            sein1.Teken(g);
            sein2.Teken(g);


            if (status == OvergangSeinStatus.Aan)
            {
                SolidBrush brush = new SolidBrush(Color.White);
                if (orientatie == Orientatie.Verticaal)
                {
                    rails = 14;
                    Rectangle[] rectanglesLeft =
                    {
                    new Rectangle(x + 10, y + 10, 5, 5),
                    new Rectangle(x + 10, y + 15, 5, 5),
                    new Rectangle(x + 10, y + 20, 5, 5),
                    new Rectangle(x + 10, y + 25, 5, 5),
                    new Rectangle(x + 10, y + 30, 5, 5),
                    new Rectangle(x + 10, y + 35, 5, 5),
                    new Rectangle(x + 10, y + 40, 5, 5),
                    new Rectangle(x + 10, y + 45, 5, 5),
                    new Rectangle(x + 10, y + 50, 5, 5),
                    new Rectangle(x + 10, y + 55, 5, 5),
                    new Rectangle(x + 10, y + 60, 5, 5),
                    new Rectangle(x + 10, y + 65, 5, 5),
                    new Rectangle(x + 10, y + 70, 5, 5),
                    new Rectangle(x + 10, y + 75, 5, 5),
                    };

                    Rectangle[] rectanglesRight =
                    {
                    new Rectangle(x + 80, y + 10, 5, 5),
                    new Rectangle(x + 80, y + 15, 5, 5),
                    new Rectangle(x + 80, y + 20, 5, 5),
                    new Rectangle(x + 80, y + 25, 5, 5),
                    new Rectangle(x + 80, y + 30, 5, 5),
                    new Rectangle(x + 80, y + 35, 5, 5),
                    new Rectangle(x + 80, y + 40, 5, 5),
                    new Rectangle(x + 80, y + 45, 5, 5),
                    new Rectangle(x + 80, y + 50, 5, 5),
                    new Rectangle(x + 80, y + 55, 5, 5),
                    new Rectangle(x + 80, y + 60, 5, 5),
                    new Rectangle(x + 80, y + 65, 5, 5),
                    new Rectangle(x + 80, y + 70, 5, 5),
                    new Rectangle(x + 80, y + 75, 5, 5),
                    };
                    for (int i = 0; i < rails; i++)
                    {
                        if (i%2 == 0)
                        {
                            brush.Color = Color.Red;
                            g.FillRectangle(brush, rectanglesLeft[i]);
                            g.FillRectangle(brush, rectanglesRight[i]);
                        }
                        else
                        {
                            brush.Color = Color.White;
                            g.FillRectangle(brush, rectanglesLeft[i]);
                            g.FillRectangle(brush, rectanglesRight[i]);
                        }
                    }

                }
                else
                {
                    rails = 10;
                }

            }

            Pen pen = new Pen(Color.Black, 3);
            if (Orientatie == Orientatie.Verticaal)
            {
                g.DrawLine(pen, x + 40, y, x + 40, y + 100);
                g.DrawLine(pen, x + 60, y, x + 60, y + 100);
                g.DrawLine(pen, x + 40, y + 20, x + 60, y + 20);
                g.DrawLine(pen, x + 40, y + 40, x + 60, y + 40);
                g.DrawLine(pen, x + 40, y + 60, x + 60, y + 60);
                g.DrawLine(pen, x + 40, y + 80, x + 60, y + 80);

            }
            else
            {
                g.DrawLine(pen, x, y + 40, x + 100, y + 40);
                g.DrawLine(pen, x, y + 60, x + 100, y + 60);
                g.DrawLine(pen, x + 20, y + 40, x + 20, y + 60);
                g.DrawLine(pen, x + 40, y + 40, x + 40, y + 60);
                g.DrawLine(pen, x + 60, y + 40, x + 60, y + 60);
                g.DrawLine(pen, x + 80, y + 40, x + 80, y + 60);
            }

        }
    }
}