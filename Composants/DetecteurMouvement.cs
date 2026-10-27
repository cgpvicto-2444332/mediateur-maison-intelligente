using System;
using System.Collections.Generic;
using System.Text;

namespace MediateurMaisonIntelligente.Composants
{
    internal class DetecteurMouvement : Appareil
    {
        public bool MouvementEstDetecte {  get; set; }

        public DetecteurMouvement(string id, string nom) : base(id, nom)
        {
            MouvementEstDetecte = false;
        }

        public void DetecterMouvement()
        {
            if (MouvementEstDetecte)
                return;

            MouvementEstDetecte = true;
            Console.WriteLine($"[{Nom}] détecte du mouvement.");
            NotifierMediateur("MouvEstDetecte");
        }
    }
}
