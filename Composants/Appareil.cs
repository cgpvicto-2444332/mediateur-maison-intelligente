using MediateurMaisonIntelligente.Mediateur;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediateurMaisonIntelligente.Composants
{
    /// <summary>
    /// Classe de base de tous les appareils connectés à un médiateur.
    /// </summary>
    public abstract class Appareil
    {
        /// <summary>
        /// Identifiant unique de l'appareil.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Nom de l'appareil.
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Médiateur auquel l'appareil envoie ses événements.
        /// </summary>
        protected IMediateurDomotique _mediateur;

        /// <summary>
        /// Crée un appareil. Le médiateur est optionnel, car l'appareil est créé avant le médiateur.
        /// Celui-ci se branche ensuite avec la méthode <see cref="SetMediateur"/>.
        /// Référence pour le see cref : https://stackoverflow.com/questions/30255085/how-do-i-reference-method-parameters-in-a-method-summary-when-writing-xml-docume
        /// </summary>
        /// <param name="id">L'identifiant de l'appareil.</param>
        /// <param name="nom">Le nom de l'appareil.</param>
        /// <param name="mediateur">Le médiateur auquel l'appareil est relié.</param>
        public Appareil(string id, string nom, IMediateurDomotique mediateur = null)
        {
            this.Id = id;
            this.Nom = nom;
            this._mediateur = mediateur;
        }

        /// <summary>
        /// Envoie un événement au médiateur.
        /// </summary>
        /// <param name="evenement"></param>
        protected void NotifierMediateur(string evenement)
        {
            _mediateur.Notifier(this, evenement);
        }

        /// <summary>
        /// Définit le médiateur auquel l'appareil est relié.
        /// </summary>
        /// <param name="mediateur"></param>
        public void SetMediateur(IMediateurDomotique mediateur)
        {
            this._mediateur = mediateur;
        }
    }
}
