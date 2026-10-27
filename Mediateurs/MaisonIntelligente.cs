using MediateurMaisonIntelligente.Composants;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediateurMaisonIntelligente.Mediateur
{
    /// <summary>
    /// 
    /// </summary>
    internal class MaisonIntelligente : IMediateurDomotique
    {
        private AmpouleIntelligente _ampoule;
        private DetecteurMouvement _detecteurMouvement;
        private CameraSecurite _cameraSecurite;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ampoule"></param>
        /// <param name="detecteurMouvement"></param>
        /// <param name="cameraSecurite"></param>
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
        /// 
        /// </summary>
        /// <param name="expediteur"></param>
        /// <param name="evenement"></param>
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
