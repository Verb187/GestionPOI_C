using System;
using System.Collections.Generic;
using System.Text;

namespace GestionPOI
{
    class POI
    {
        private double laNote;
        private string leNom;
        private Lieu leLieu;

        public string Afficher()
        {
            return "Le Nom: " + this.leNom + " La note : " + this.laNote + " Le Lieu: " + this.leLieu.Afficher();
        }

        public double GetlaNote()
        {
            return this.laNote;
        }

        public Lieu GetleLieu()
        {
            return this.leLieu;
        }

        public string GetleNom()
        {
            return this.leNom;
        }

        public void ModifierNote(string pUnsens, double pUneValeur)
        {
            if (pUnsens == "augmenter")
            {
                this.laNote = this.laNote + pUneValeur;
            }

            if (pUnsens == "diminuer")
            {
                this.laNote = this.laNote - pUneValeur;
            }

        }

        public POI(string pUnNom, double UneNote, Lieu pUnLieu)
        {
            this.leNom = pUnNom;
            this.laNote = UneNote;
            this.leLieu = pUnLieu;

        }

        public void SetlaNote(double pUneNote)
        {
            this.laNote = pUneNote;

        }

        public void SetLeLieu(Lieu pUnLieu)
        {
            this.leLieu = pUnLieu;
           
        }

        public void SetLeNom(string pUnNom)
        {
            this.leNom = pUnNom;

        }
    }
}
