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
        private Timer overgangTimer;
        private Timer storingTimer;
        private Spoorbaan spoorbaan;
        private Graphics g;

        public Controller(Spoorbaan spoorbaan, Timer overgangTimer, Timer storingTimer, Graphics g)
        {
            this.spoorbaan = spoorbaan;
            this.overgangTimer = overgangTimer;
            this.storingTimer = storingTimer;
            overgangTimer.Tick += new EventHandler(storingTimer_Elapsed);
            this.g = g;

        }

        private void overgangTimer_Elapsed()
        {
            throw new System.NotImplementedException();
        }

        private void storingTimer_Elapsed(object sender, EventArgs e)
        {
            foreach (SpoorwegOvergang o in spoorbaan.Overgangen)
            {
                if (o.Status == OvergangSeinStatus.Storing)
                {
                    o.Status = OvergangSeinStatus.Uit;
                }
                else if (o.Status == OvergangSeinStatus.Uit)
                {
                    o.Status = OvergangSeinStatus.Storing;
                }
            }

            foreach (TreinStation o in spoorbaan.Stations)
            {
                if (o.StationSeinStatus == StationSeinStatus.Storing)
                {
                    o.StationSeinStatus = StationSeinStatus.Uit;
                }
                else if (o.StationSeinStatus == StationSeinStatus.Uit)
                {
                    o.StationSeinStatus = StationSeinStatus.Storing;
                }
            }
            spoorbaan.Teken(g);

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

        public void ZetStoring(bool actief)
        {
            List<SpoorwegOvergang> opslagOvergang = spoorbaan.Overgangen;
            List<TreinStation> opslagTrein = spoorbaan.Stations;

            if (actief)
            {
                foreach (SpoorwegOvergang Overgang in spoorbaan.Overgangen)
                {
                    Overgang.Status = OvergangSeinStatus.Storing;
                }
                foreach (TreinStation Overgang in spoorbaan.Stations)
                {
                    Overgang.StationSeinStatus = StationSeinStatus.Storing;
                }
                overgangTimer.Start();
            }


            else
            {
                foreach (SpoorwegOvergang Overgang in spoorbaan.Overgangen)
                {
                    Overgang.Status = OvergangSeinStatus.Uit;
                }
                foreach (TreinStation Overgang in spoorbaan.Stations)
                {
                    Overgang.StationSeinStatus = StationSeinStatus.Groen;
                }
                overgangTimer.Stop();
            }

        }
    }
}