using MediateurMaisonIntelligente.Composants;
using MediateurMaisonIntelligente.Mediateur;

namespace MediateurMaisonIntelligente
{
    /// <summary>
    /// 
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
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
