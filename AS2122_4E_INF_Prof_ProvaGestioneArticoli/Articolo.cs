using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4E_INF_Prof_ProvaGestioneArticoli
{
    class Articolo
    {
        // TODO: (8) aggiungere attributi privati di Articolo
        // ...
        int codice;
        string descrizione;
        string unitaDiMisura;
        double prezzo;


        // TODO: (9) aggiungere property di sola lettura dei dati necessari all'esterno di Articolo
        // ...
        public String Descrizione
        {
            get { return descrizione; }
        }
        public String UnitaDiMisura
        {
            get { return unitaDiMisura; }
        }
        public double Prezzo
        {
            get { return prezzo; }
        }


        public Articolo(int codice, string descrizione, string unitaMisura, double prezzo)
        {
            // TODO: (10) impostazione costruttore classe Articolo come utilizzato da frmMain
            // ...
            this.descrizione = descrizione;
            this.unitaDiMisura = unitaDiMisura;
            this.prezzo = prezzo;       
        }

        public string Visualizzati()
        {
            return $"{descrizione} {unitaDiMisura} {prezzo} ({codice})";
        }
    }
}
