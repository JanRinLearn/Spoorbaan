using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoorbaan
{
    //Om ervoor te kunnen zorgen dat de lampen van een sein apart kunnen worden aangezet, is er een extra waarde bij deze enum gekomen.
    public enum OvergangSeinStatus
    {
        Aan, AanR, Uit, Storing
    }
    public enum StationSeinStatus
    {
        Groen, Rood, Uit, Storing
    }
    public enum Orientatie
    {
        Horizontaal, Verticaal
    }
    public enum LampStatus
    {
        Aan, Uit
    }
    public enum RailRotatie
    {
        _0,_90,_180,_270
    }
    public enum LampKleur
    {
        Groen, Rood
    }
}
