using MediateurMaisonIntelligente.Composants;
using MediateurMaisonIntelligente.Mediateur;
using System.ComponentModel;

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

            bool continuer = true;

            while (continuer)
            {
                AfficherMenu();
                string choix = Console.ReadLine();
                Console.WriteLine();

                switch (choix)
                {
                    case "1":
                        mouvement.DetecterMouvement();
                        break;
                    case "2":
                        mouvement.DetectePlusMouvement();
                        break;
                    case "3":
                        ampoule.BasculerEtat();
                        break;
                    case "4":
                        continuer = false;
                        Console.WriteLine("Au revoir!");
                        break;
                    default:
                        Console.WriteLine("Choix invalide, entrez un chiffre de 1 à 4.");
                        break;
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Affiche les options du menu dans le terminal.
        /// </summary>
        private static void AfficherMenu()
        {
            Console.WriteLine("=== Maison intelligente ===");
            Console.WriteLine("1. Détecter du mouvement");
            Console.WriteLine("2. Plus de mouvement");
            Console.WriteLine("3. Basculer l'ampoule");
            Console.WriteLine("4. Quitter");
            Console.Write("Votre choix : ");
        }
    }
}
