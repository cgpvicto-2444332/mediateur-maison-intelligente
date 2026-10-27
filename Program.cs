using MediateurMaisonIntelligente.Composants;
using MediateurMaisonIntelligente.Mediateur;

namespace MediateurMaisonIntelligente
{
    /// <summary>
    /// Simule la détection d'un mouvement dans la maison.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Crée les appareils et la maison, puis déclenche des événements.
        /// </summary>
        /// <param name="args">Les arguments de la ligne de commande (non utilisés).</param>
        static void Main(string[] args)
        {
            AmpouleIntelligente ampoule = new AmpouleIntelligente("123456789", "Lumière salon");
            DetecteurMouvement mouvement = new DetecteurMouvement("987654321", "Détecteur de mouvement");
            CameraSecurite camera = new CameraSecurite("564738291", "Caméra du salon");
            new MaisonIntelligente(ampoule, mouvement, camera);

            mouvement.DetecterMouvement();

            Console.WriteLine();
        }
    }
}
