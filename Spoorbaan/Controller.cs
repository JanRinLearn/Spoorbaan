using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spoorbaan
{
    public class Controller
    {
        private Timer overgangTimer = new Timer();
        private Timer storingTimer = new Timer();
        private Spoorbaan spoorbaan;

        public Controller(Spoorbaan spoorbaan)
        {
            this.spoorbaan = spoorbaan;
            
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
            foreach (SpoorwegOvergang Overgang in spoorbaan.Overgangen)
            {
                Overgang.Status = OvergangSeinStatus.Aan;
            }
        }

        public void ZetStoring()
        {
            foreach (SpoorwegOvergang Overgang in spoorbaan.Overgangen)
            {
                Overgang.Status = OvergangSeinStatus.Storing;
            }
            foreach (TreinStation Overgang in spoorbaan.Stations)
            {
                Overgang.StationSeinStatus = StationSeinStatus.Storing;
            }
            
        }
    }
}