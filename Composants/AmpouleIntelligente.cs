using System;
using System.Collections.Generic;
using System.Text;

namespace MediateurMaisonIntelligente.Composants
{
    internal class AmpouleIntelligente : Appareil
    {
        public bool EstAllumee { get; private set; }

        public AmpouleIntelligente(string id, string nom) : base(id, nom)
        {
            EstAllumee = false;
        }

        public void Allumer()
        {
            if (EstAllumee) 
                return;

            EstAllumee = true;
            Console.WriteLine($"[{Nom}] s'allume.");
        }

        public void Eteindre()
        {
            if (!EstAllumee)
                return;

            EstAllumee = false;
            Console.WriteLine($"[{Nom}] s'éteint.");
        }

        public void BasculerEtat()
        {
            if (EstAllumee) 
                Eteindre();
            else 
                Allumer();
        }
    }
}
