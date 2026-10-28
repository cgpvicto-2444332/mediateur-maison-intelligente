using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MediateurMaisonIntelligente.Composants
{
    /// <summary>
    /// Caméra de sécurité qui peut enregistrer.
    /// </summary>
    internal class CameraSecurite : Appareil
    {
        /// <summary>
        /// Indique si la caméra est en train d'enregistrer.
        /// </summary>
        public bool EstEnEnregistrement {  get; set; }

        /// <summary>
        /// Crée une caméra qui n'enregistre pas.
        /// </summary>
        /// <param name="id">L'identifiant de la caméra.</param>
        /// <param name="nom">Le nom de la caméra.</param>
        public CameraSecurite(string id, string nom) : base(id, nom)
        {
            EstEnEnregistrement = false;
        }

        /// <summary>
        /// Démarre l'enregistrement s'il n'est pas déjà en cours.
        /// </summary>
        public void DemarrerEnregistrement()
        {
            if (EstEnEnregistrement)
            {
                Console.WriteLine("La caméra enregistre déjà.");
                return;
            }

            EstEnEnregistrement=true;
            Console.WriteLine($"[{Nom}] commence à enregistrer.");
        }

        /// <summary>
        /// Arrête l'enregistrement s'il est en cours.
        /// </summary>
        public void ArreterEnregistrement()
        {
            if (!EstEnEnregistrement)
            {
                Console.WriteLine("La caméra n'enregistre déjà pas.");
                return;
            }

            EstEnEnregistrement = false;
            Console.WriteLine($"[{Nom}] arrête d'enregistrer.");
        }
    }
}
