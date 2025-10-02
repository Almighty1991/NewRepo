using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Versandsservice_Polymorphy.Klassen
{
    internal class Adressen
    {
        private string _nachname;
        private string _vorname;
        private string _straßeHausnr;
        private string _plzOrt;
        private string _land;

        public Adressen(string nachname, string vorname, string straßeHausnr,
            string plzOrt, string land = "Deutschland")
        {
            _nachname = nachname;
            _vorname = vorname;
            _straßeHausnr = straßeHausnr;
            _plzOrt = plzOrt;
            _land = land;
           
        }
        public bool AdressCheck()
        {
            if (_nachname != null && _vorname != null &&
                _straßeHausnr != null && _plzOrt != null)
            {
                return true;
            }
            else {  return false; }
        }

        public string GetNachname() { return _nachname; }
        public string GetVorname() { return _vorname; }
        public string GetPlzOrt() { return _plzOrt; }
        public string GetLand() { return _land; }
        public string GetStraßeHausnr() { return _straßeHausnr;}

        public string AusgabeBrief()
        {
            return$"-------------------\n" +
                $"Nachname: {GetNachname()}\n" +
                $"Vorname: {GetVorname()}\n" +
                $"Straße/Hausnr.: {GetStraßeHausnr()}\n" +
                $"Plz./Ort: {GetPlzOrt()}\n" +
                $"Land: {GetLand()}\n";
        }

    }



}
