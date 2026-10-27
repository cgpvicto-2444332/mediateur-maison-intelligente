using MediateurMaisonIntelligente.Mediateur;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediateurMaisonIntelligente.Composants
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Appareil
    {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// 
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// 
        /// </summary>
        protected IMediateurDomotique _mediateur;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="mediateur"></param>
        public Appareil(string id, string nom, IMediateurDomotique mediateur = null)
        {
            this.Id = id;
            this.Nom = nom;
            this._mediateur = mediateur;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="evenement"></param>
        protected void NotifierMediateur(string evenement)
        {
            _mediateur.Notifier(this, evenement);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mediateur"></param>
        public void SetMediateur(IMediateurDomotique mediateur)
        {
            this._mediateur = mediateur;
        }
    }
}
