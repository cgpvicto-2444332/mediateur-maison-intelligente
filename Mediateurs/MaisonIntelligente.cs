using MediateurMaisonIntelligente.Composants;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediateurMaisonIntelligente.Mediateur
{
    /// <summary>
    /// Coordonne les différents appareils domotiques.
    /// </summary>
    internal class MaisonIntelligente : IMediateurDomotique
    {
        private AmpouleIntelligente _ampoule;
        private DetecteurMouvement _detecteurMouvement;
        private CameraSecurite _cameraSecurite;

        /// <summary>
        /// Crée la maison et se branche comme médiateur de chaque appareil.
        /// </summary>
        /// <param name="ampoule">L'ampoule de la maison.</param>
        /// <param name="detecteurMouvement">Le détecteur de mouvement de la maison.</param>
        /// <param name="cameraSecurite">La caméra de sécurité de la maison.</param>
        public MaisonIntelligente(AmpouleIntelligente ampoule, DetecteurMouvement detecteurMouvement, CameraSecurite cameraSecurite)
        {
            this._ampoule = ampoule;
            this._ampoule.SetMediateur(this);

            this._detecteurMouvement = detecteurMouvement;
            this._detecteurMouvement.SetMediateur(this);

            this._cameraSecurite = cameraSecurite;
            this._cameraSecurite.SetMediateur(this);
        }

        /// <summary>
        /// Si un mouvement est détecté, allume l'ampoule et démarre la caméra.
        /// </summary>
        /// <param name="expediteur">L'appareil qui envoie l'événement.</param>
        /// <param name="evenement">Le nom de l'événement.</param>
        public void Notifier(Appareil expediteur, string evenement)
        {
            if (evenement == "MouvEstDetecte")
            {
                Console.WriteLine("Le médiateur reçoit le signal du détecteur et allume l'ampoule");
                _ampoule.Allumer();
                _cameraSecurite.DemarrerEnregistrement();
            }
        }
    }
}
