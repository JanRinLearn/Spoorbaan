using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spoorbaan
{
    public class Controller
    {
        private int overgangTimer;
        private int storingTimer;
        private Spoorbaan spoorbaan;

        public Controller()
        {
            this.spoorbaan = new Spoorbaan(100, 100, 2, 1, 1000, 1000);
        }

        private void overgangTimer_Elapsed()
        {
            throw new System.NotImplementedException();
        }

        private void storingTimer_Elapsed()
        {
            throw new System.NotImplementedException();
        }

        private void UpdateOvergangen()
        {
            throw new System.NotImplementedException();
        }

        private void UpdateStations()
        {
            throw new System.NotImplementedException();
        }

        public void ZetSpoorwegStatus()
        {
            throw new System.NotImplementedException();
        }

        public void ZetStoring()
        {
            throw new System.NotImplementedException();
        }
    }
}