using MediateurMaisonIntelligente.Composants;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediateurMaisonIntelligente.Mediateur
{
    public interface IMediateurDomotique
    {
        void Notifier(Appareil expediteur, string evenement);
    }
}