using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoorbaan
{
    public enum OvergangSeinStatus
    {
        Aan, Aan2, Uit, Storing
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
