using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Versandsservice_Polymorphy.Klassen
{
    internal class Brief:Postsendung
    {
        private string _briefkategorie;
        

        public Brief(int id, Adressen absender, Adressen empfänger, string briefkategorie="Standard"):base(id,absender,empfänger)
        {
            _briefkategorie = briefkategorie;

        }

        public string GetBriefkategorie() {  return _briefkategorie; }

        

        public override void Ausgabe()
        {
            Console.WriteLine($"Medium: {GetType().Name}\n" +
                $"Art: {_briefkategorie}\n" +
                $"ID: {_id}\n" +
                $"Absender:\n{_absender.AusgabeBrief()}\n" +
                $"Empfänger:\n{_empfänger.AusgabeBrief()}\n" +
                $"Zugestellt: {GetZugestellt()}");
        }
    }
}
