using System;
using System.Collections.Generic;
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

        public SpoorElement()
        {
            throw new System.NotImplementedException();
        }

        public Orientatie Orientatie
        {
            get => default(int);
            set
            {
            }
        }

        public void Teken()
        {
            throw new System.NotImplementedException();
        }
    }
}