﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class TreinStation : SpoorElement
    {
        private StationSeinStatus status;
        private StationSein sein1;
        private StationSein sein2;

        public TreinStation()
        {
            throw new System.NotImplementedException();
        }

        public StationSein Sein1
        {
            get => default(int);
            set
            {
            }
        }

        public StationSein Sein2
        {
            get => default(int);
            set
            {
            }
        }

        public StationSeinStatus StationSeinStatus
        {
            get => default(int);
            set
            {
            }
        }

        public void SetStatus()
        {
            throw new System.NotImplementedException();
        }

        public void Teken()
        {
            throw new System.NotImplementedException();
        }
    }
}