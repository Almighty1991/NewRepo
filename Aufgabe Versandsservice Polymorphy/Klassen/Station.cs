using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Versandsservice_Polymorphy.Klassen
{
    internal class Station
    {
        private string _ort;
        private DateTime _zeitstempel;

        public Station(string ort)
        {
            _ort = ort;
            _zeitstempel = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Ort: {_ort}\nZeit: {_zeitstempel}";
        }

    }
}
