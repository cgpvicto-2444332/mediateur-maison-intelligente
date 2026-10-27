using MediateurMaisonIntelligente.Mediateur;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediateurMaisonIntelligente.Composants
{
    public abstract class Appareil
    {
        public string Id { get; }
        public string Nom { get; }
        protected IMediateurDomotique _mediateur;

        public Appareil(string id, string nom, IMediateurDomotique mediateur = null)
        {
            this.Id = id;
            this.Nom = nom;
            this._mediateur = mediateur;
        }

        public void SetMediateur(IMediateurDomotique mediateur)
        {
            this._mediateur = mediateur;
        }
    }
}
