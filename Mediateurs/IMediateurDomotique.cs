using MediateurMaisonIntelligente.Composants;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediateurMaisonIntelligente.Mediateur
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMediateurDomotique
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="expediteur"></param>
        /// <param name="evenement"></param>
        void Notifier(Appareil expediteur, string evenement);
    }
}