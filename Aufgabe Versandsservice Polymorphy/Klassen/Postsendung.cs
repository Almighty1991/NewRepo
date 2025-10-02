using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Versandsservice_Polymorphy.Klassen
{
    internal abstract class Postsendung
    {
        protected int _id;
        protected Adressen _absender;
        protected Adressen _empfänger;
        protected bool _zugestellt;

        public Postsendung(int id, Adressen sender, Adressen empfänger)
        {
            _id= id;
            _absender= sender;
            _empfänger=empfänger;

        }

        public abstract void Ausgabe();


        public void SetZugestellt()
        {
            _zugestellt = true;
        }

        public bool GetZugestellt() { return _zugestellt; }

        public Adressen GetSender() { return _absender;}
        public Adressen GetEmpfänger() { return _empfänger; }


    }
}
