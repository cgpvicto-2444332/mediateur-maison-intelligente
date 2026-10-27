using System;
using System.Collections.Generic;
using System.Text;

namespace MediateurMaisonIntelligente.Mediateur
{
    public interface IMediateurDomotique
    {
        void Notifier(object expediteur, string ev);
    }
}
