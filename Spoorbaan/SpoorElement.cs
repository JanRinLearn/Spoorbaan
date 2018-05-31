﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public abstract class SpoorElement
    {
        private int breedte;
        private int grootte;
        private int x;
        private int y;
        private Orientatie orientatie;

        public SpoorElement(int breedte, int grootte, int x, int y, Orientatie orientatie)
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

        public virtual void Teken(Graphics g)
        {
            SolidBrush sb = new SolidBrush(Color.LightGray);
            Pen pen = new Pen(Color.Black);
            g.FillRectangle(sb, x, y, 100, 100);
            g.DrawRectangle(pen, x, y, 100, 100);
        }
    }
}