using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Versandsservice_Polymorphy.Klassen
{
    internal class Packet : Postsendung
    {
        public double _gewicht;
        public bool _versichert;
        public Packet(int id, Adressen absender, Adressen empfänger, double gewicht,bool versichert=false) : base(id, absender, empfänger)
        {
            _gewicht = gewicht;
            _versichert = versichert;
        }

        public double GetGewicht() { return _gewicht; }

        public bool GetVersicherung() {  return _versichert; }
        public void SetVersichert() {  _versichert = true; }

        public override string ToString()
        {
           return $"Medium: {GetType().Name}\n" +
                $"Gewicht: {_gewicht} Kg\n" +
                $"Versichert: {_versichert}\n" +
                $"ID: {_id}\n" +
                $"Absender:\n{_absender.AusgabeBrief()}\n" +
                $"Empfänger:\n{_empfänger.AusgabeBrief()}\n" +
                $"Zugestellt: {GetZugestellt()}";
        }
    }
}
