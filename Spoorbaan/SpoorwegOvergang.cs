using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class SpoorwegOvergang : SpoorElement
    {
        private int rails;
        private SpoorwegOvergangSein sein1;
        private SpoorwegOvergangSein sein2;
        private OvergangSeinStatus status;

        public SpoorwegOvergang(int breedte, int grootte, int x, int y, Orientatie orientatie) : base(breedte, grootte, x, y)
        {
            throw new System.NotImplementedException();
        }

        public int Sein1
        {
            get => default(int);
            set
            {
            }
        }

        public int Sein2
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

        private void SetStatus()
        {
            throw new System.NotImplementedException();
        }

        public void Teken()
        {
            throw new System.NotImplementedException();
        }
    }
}