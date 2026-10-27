using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MediateurMaisonIntelligente.Composants
{
    /// <summary>
    /// 
    /// </summary>
    internal class CameraSecurite : Appareil
    {
        /// <summary>
        /// 
        /// </summary>
        public bool EstEnEnregistrement {  get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        public CameraSecurite(string id, string nom) : base(id, nom)
        {
            EstEnEnregistrement = false;
        }

        /// <summary>
        /// 
        /// </summary>
        public void DemarrerEnregistrement()
        {
            if (EstEnEnregistrement)
                return;

            EstEnEnregistrement=true;
            Console.WriteLine($"[{Nom}] commence à enregistrer.");
        }

    }
}
