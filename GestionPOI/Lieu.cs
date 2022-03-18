using System;
using System.Collections.Generic;
using System.Text;

namespace GestionPOI
{
   public class Lieu
    {
        private string laVille;
        private string lePays;

        public string Afficher()
        {
            return "La ville: " + this.laVille + " Le pays: " + lePays;
        }
        public Lieu(string pUneVille, string pUnPays)
        {
            this.laVille = pUneVille;
            this.lePays = pUnPays;
        }
    }
}
