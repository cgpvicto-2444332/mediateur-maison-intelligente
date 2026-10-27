using System;
using System.Collections.Generic;
using System.Text;

namespace MediateurMaisonIntelligente.Composants
{
    /// <summary>
    /// 
    /// </summary>
    internal class AmpouleIntelligente : Appareil
    {
        /// <summary>
        /// 
        /// </summary>
        public bool EstAllumee { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        public AmpouleIntelligente(string id, string nom) : base(id, nom)
        {
            EstAllumee = false;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Allumer()
        {
            if (EstAllumee) 
                return;

            EstAllumee = true;
            Console.WriteLine($"[{Nom}] s'allume.");
        }

        /// <summary>
        /// 
        /// </summary>
        public void Eteindre()
        {
            if (!EstAllumee)
                return;

            EstAllumee = false;
            Console.WriteLine($"[{Nom}] s'éteint.");
        }

        /// <summary>
        /// 
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
