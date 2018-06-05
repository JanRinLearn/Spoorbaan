using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class SpoorComponent : SpoorElement
    {
        private List<SpoorElement> elementen;

        public SpoorComponent(int breedte, int grootte, int x, int y, Orientatie orientatie) : base(breedte, grootte, x, y, orientatie)
        {
            throw new System.NotImplementedException();
        }

        public void Teken()
        {
            throw new System.NotImplementedException();
        }

        public void VoegToe()
        {
            throw new System.NotImplementedException();
        }
    }
}