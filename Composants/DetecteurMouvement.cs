using System;
using System.Collections.Generic;
using System.Text;

namespace MediateurMaisonIntelligente.Composants
{
    /// <summary>
    /// 
    /// </summary>
    internal class DetecteurMouvement : Appareil
    {
        /// <summary>
        /// 
        /// </summary>
        public bool MouvementEstDetecte {  get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        public DetecteurMouvement(string id, string nom) : base(id, nom)
        {
            MouvementEstDetecte = false;
        }

        /// <summary>
        /// 
        /// </summary>
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
