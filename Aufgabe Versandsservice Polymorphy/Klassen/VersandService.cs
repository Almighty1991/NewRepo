using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Versandsservice_Polymorphy.Klassen
{
    internal class VersandService
    {
        static Random rnd = new Random();
        private List<Postsendung> _versand;
        static private List<int> idList;

        public VersandService()
        {
            _versand = new List<Postsendung>();
            idList = new List<int>();
        }

        public void NeuerBrief(Adressen sender, Adressen empfänger)
        {
            Postsendung brief = new Brief(IdCreator(),sender,empfänger);
            _versand.Add(brief);
        }
        public void NeuesPacket(Adressen sender, Adressen empfänger, double gewicht)
        {
            Postsendung packet = new Packet(IdCreator(), sender, empfänger,gewicht);
            _versand.Add(packet);
        }

        public void Ausliefern()
        {
            foreach(Postsendung a in _versand)
            {
                if (a.GetEmpfänger().AdressCheck()&& a.GetSender().AdressCheck())
                {
                    a.SetZugestellt();
                }
            }
        }

        public void AusgabeListe()
        {
            foreach (Postsendung a in _versand)
            {
                a.Ausgabe();
            }
        }


        static int IdCreator()
        {
            int id = 0;
            bool check = false;
            do
            {
                id = rnd.Next(100000, 100000000);
                if (idList.Count > 0)
                {
                    foreach (int s in idList)
                    {
                        if (s == id)
                        {
                            check = false;
                            break;
                        }
                        else
                        {
                            check = true;
                        }
                    }
                    if (check)
                    {
                        idList.Add(id);
                    }
                }
                else
                {
                    check = true;
                    idList.Add(id);
                }
            } while (!check);
            return id;
        }


    }
}
