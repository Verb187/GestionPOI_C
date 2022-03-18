using System;

namespace GestionPOI
{
    class Program
    {
        static void Main(string[] args)
        {
            Lieu Nausicaa = new Lieu("Boulogne sur mer", "France");
            POI Matheo = new POI("Nosicaa", 4, Nausicaa);

            Matheo.SetLeNom("Nausicaa");
            Matheo.ModifierNote("augmenter", 0.5);
            Console.WriteLine(Matheo.Afficher());
            
        }
    }
}
