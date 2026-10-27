using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MediateurMaisonIntelligente.Composants
{
    internal class CameraSecurite : Appareil
    {
        public bool EstEnEnregistrement {  get; set; }
        public CameraSecurite(string id, string nom) : base(id, nom)
        {
            EstEnEnregistrement = false;
        }

        public void DemarrerEnregistrement()
        {
            if (EstEnEnregistrement)
                return;

            EstEnEnregistrement=true;
            Console.WriteLine($"[{Nom}] commence à enregistrer.");
        }

    }
}
