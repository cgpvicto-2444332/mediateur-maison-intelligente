using System;
using System.Collections.Generic;
using System.Text;

namespace MediateurMaisonIntelligente.Composants
{
    /// <summary>
    /// Détecteur qui prévient le médiateur lorsqu'il détecte un mouvement.
    /// </summary>
    internal class DetecteurMouvement : Appareil
    {
        /// <summary>
        /// Indique si un mouvement a été détecté.
        /// </summary>
        public bool MouvementEstDetecte {  get; set; }

        /// <summary>
        /// Crée un détecteur sans mouvement détecté.
        /// </summary>
        /// <param name="id">L'identifiant du détecteur.</param>
        /// <param name="nom">Le nom du détecteur.</param>
        public DetecteurMouvement(string id, string nom) : base(id, nom)
        {
            MouvementEstDetecte = false;
        }

        /// <summary>
        /// Détecte un mouvement et notifie le médiateur.
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
