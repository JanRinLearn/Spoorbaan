﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class SpoorwegOvergangSein : Sein
    {
        private OvergangSeinStatus status;

        public SpoorwegOvergangSein(int breedte, int hoogte, int x, int y) : base(breedte, hoogte, x, y)
        {
            Lamp lamp1 = new Lamp(x, y);
            Lamp lamp2 = new Lamp(x, y);
            Lamp1 = lamp1;
            Lamp2 = lamp2;
        }

        public int Status
        {
            get => default(int);
            set
            {
            }
        }

        private void SetStatus()
        {
            throw new System.NotImplementedException();
        }

        public override void Teken()
        {
            throw new System.NotImplementedException();
        }
    }
}