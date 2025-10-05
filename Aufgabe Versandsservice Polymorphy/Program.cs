using Aufgabe_Versandsservice_Polymorphy.Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Versandsservice_Polymorphy
{
    internal class Program
    {

        static void Main(string[] args)
        {
            VersandService service=new VersandService();

            Adressen sender1 = new Adressen("Schmidt", "Herbert", "Sedanstr. 3",
            "44866 Bochum");
            Adressen empfänger1 = new Adressen("Müller", "Olaf", "Frankenweg 6",
            "44879 Bochum");

            service.NeuesPacket(sender1,empfänger1,10);
            service.Ausliefern();

            service.AusgabeListe();


        }
    }
}
