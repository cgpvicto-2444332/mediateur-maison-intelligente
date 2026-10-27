using System;
using System.Collections.Generic;
using System.Text;

namespace MediateurMaisonIntelligente.Composants
{
    /// <summary>
    /// Ampoule qui peut être allumée ou éteinte.
    /// </summary>
    internal class AmpouleIntelligente : Appareil
    {
        /// <summary>
        /// Indique si l'ampoule est allumée.
        /// </summary>
        public bool EstAllumee { get; private set; }

        /// <summary>
        /// Crée une ampoule éteinte.
        /// </summary>
        /// <param name="id">L'identifiant de l'ampoule.</param>
        /// <param name="nom">Le nom de l'ampoule.</param>
        public AmpouleIntelligente(string id, string nom) : base(id, nom)
        {
            EstAllumee = false;
        }

        /// <summary>
        /// Allume l'ampoule si elle est éteinte.
        /// </summary>
        public void Allumer()
        {
            if (EstAllumee) 
                return;

            EstAllumee = true;
            Console.WriteLine($"[{Nom}] s'allume.");
        }

        /// <summary>
        /// Éteint l'ampoule si elle est allumée.
        /// </summary>
        public void Eteindre()
        {
            if (!EstAllumee)
                return;

            EstAllumee = false;
            Console.WriteLine($"[{Nom}] s'éteint.");
        }

        /// <summary>
        /// Inverse l'état de l'ampoule.
        /// </summary>
        public void BasculerEtat()
        {
            if (EstAllumee) 
                Eteindre();
            else 
                Allumer();
        }
    }
}
