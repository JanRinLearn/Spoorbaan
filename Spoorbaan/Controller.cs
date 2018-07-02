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

        //Controller krijgt de timer mee vanuit de form, te samen met een graphics element die gemaakt is door het tekenvlak
        public Controller(Spoorbaan spoorbaan, Timer overgangTimer, Timer storingTimer, Graphics g)
        {
            this.spoorbaan = spoorbaan;
            this.overgangTimer = overgangTimer;
            this.storingTimer = storingTimer;
            overgangTimer.Tick += new EventHandler(overgangTimer_Elapsed);
            storingTimer.Tick += new EventHandler(storingTimer_Elapsed);
            this.g = g;

        }
        //Timer staat op het moment op 1000 miliseconden.
        //Als de overgang timer over is, dan wordt het andere licht aangezet voor alle overgangen die aanstaan.
        private void overgangTimer_Elapsed(object sender, EventArgs e)
        {
            foreach (SpoorwegOvergang o in spoorbaan.Overgangen)
            {
                if (o.Status == OvergangSeinStatus.Aan)
                {
                    o.Status = OvergangSeinStatus.AanR;
                }
                else if (o.Status == OvergangSeinStatus.AanR)
                {
                    o.Status = OvergangSeinStatus.Aan;
                }
            }
        }
        //Storing timer staat op 1000 miliseconden
        //Bij de storing timer gaan alle lichten aan en uit knipperren.
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
        //Gebaseert op de status van de overgang knoppen worden de overgangen en de bijbehorende timer aan of uit gezet
        //List waarde staat best hard coded voor maar twee overgangen, mogelijk had je meerdere lijsten kunnen hebben waarin als de status van de meegegeven lijst index op true stond,
        //dan gaat de bijbehorende overgang ook aan.
        private void UpdateOvergangen(bool overgangLinks, bool overgangRechts)
        {
            if (overgangLinks)
            {
                spoorbaan.Overgangen[0].Status = OvergangSeinStatus.Aan;
                overgangTimer.Start();
            }
            else
            {
                spoorbaan.Overgangen[0].Status = OvergangSeinStatus.Uit;
                overgangTimer.Stop();
            }
            if (overgangRechts)
            {
                spoorbaan.Overgangen[1].Status = OvergangSeinStatus.Aan;
                overgangTimer.Start();
            }
            else
            {
                spoorbaan.Overgangen[1].Status = OvergangSeinStatus.Uit;
                overgangTimer.Stop();
            }
        }
        //De station button regelt of de linker sein aan moet of de rechter sein.
        //Zie commentaar hierboven over hard coded argumentatie.
        private void UpdateStations(bool station)
        {
            if (station)
            {
                spoorbaan.Stations[0].StationSeinStatus = StationSeinStatus.Groen;
            }
            else
            {
                spoorbaan.Stations[0].StationSeinStatus = StationSeinStatus.Rood;
            }
        }

        //Publieke methode om vanuit de form de spoorweg aan te passen.
        public void ZetSpoorwegStatus(bool overgangLinks, bool overgangRechts, bool station)
        {
            UpdateOvergangen(overgangLinks, overgangRechts);
            UpdateStations(station);
            spoorbaan.Teken(g);
        }
        //publieke methode om vanuit de form de storing aan te zetten.
        //Als de methode wordt aangezet dan wordt ook de overgang timer gestopt.
        public void ZetStoring(bool actief)
        {
            List<SpoorwegOvergang> opslagOvergang = spoorbaan.Overgangen;
            List<TreinStation> opslagTrein = spoorbaan.Stations;

            if (actief)
            {
                overgangTimer.Stop();
                foreach (SpoorwegOvergang Overgang in spoorbaan.Overgangen)
                {
                    Overgang.Status = OvergangSeinStatus.Storing;
                }
                foreach (TreinStation Overgang in spoorbaan.Stations)
                {
                    Overgang.StationSeinStatus = StationSeinStatus.Storing;
                }
                storingTimer.Start();
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
                storingTimer.Stop();
            }

        }
    }
}