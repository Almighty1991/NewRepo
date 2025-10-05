using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Versandsservice_Polymorphy.Klassen
{
    internal class VerfolgbaresPacket:Packet
    {
        private List<Station> _station;

        public VerfolgbaresPacket(int id, Adressen absender, Adressen empfänger, double gewicht, bool versichert = false) : base(id, absender, empfänger,gewicht)
        {
            _station = new List<Station>();
            _station.Add(new Station(absender.GetPlzOrt()));
        }

        public void SetzeStation(string ort)
        {
            _station.Add(new Station(ort));
        }

        public override string ToString()
        {
            string basis = base.ToString();
            string verlauf = string.Join("\n", _station.Select(s => s.ToString()));
            return $"{basis}\nVerlauf:\n{verlauf}";
        }


    }
}
