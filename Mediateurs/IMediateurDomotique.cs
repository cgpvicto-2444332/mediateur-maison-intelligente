using MediateurMaisonIntelligente.Composants;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediateurMaisonIntelligente.Mediateur
{
    /// <summary>
    /// Reçoit les notifications des appareils.
    /// </summary>
    public interface IMediateurDomotique
    {
        /// <summary>
        /// Reçoit un événement envoyé par un appareil.
        /// </summary>
        /// <param name="expediteur">L'appareil qui envoie l'événement.</param>
        /// <param name="evenement">Le nom de l'événement.</param>
        void Notifier(Appareil expediteur, string evenement);
    }
}