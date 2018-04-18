using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class Lamp
    {
        private int kleur;
        private int straal;
        private int x;
        private int y;
        private LampStatus status;

        public Lamp()
        {
            throw new System.NotImplementedException();
        }

        public int Kleur
        {
            get => default(int);
            set
            {
            }
        }

        public int Status
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