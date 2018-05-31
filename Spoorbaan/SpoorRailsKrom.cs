using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class SpoorRailsKrom : SpoorElement
    {
        private const int RAILS_BREEDTE = 1;
        private RailRotatie rotatie;

        public SpoorRailsKrom(int breedte, int grootte, int x, int y) : base(breedte, grootte, x, y)
        {
            throw new System.NotImplementedException();
        }

        public void Teken()
        {
            throw new System.NotImplementedException();
        }
    }
}