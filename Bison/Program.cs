using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclarez les variables
            int score = 0;
            string reponseUtilisateur;

            // Demandez à l'utilisateur combien de questions il souhaite répondre
            Console.WriteLine("Combien de questions souhaitez-vous répondre ?\n");
            int nbQuestions = int.Parse(Console.ReadLine());

            // Démarrez un chronomètre
            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            // Posez des questions et vérifiez les réponses
            for (int i = 0; i < nbQuestions; i++)
            {
                Console.WriteLine("Quelle est la capitale de la France ?\n");
                Console.WriteLine("a) Londres\nb) Rome\nc) Paris\n");
                reponseUtilisateur = Console.ReadLine();

                if (reponseUtilisateur == "c")
                {
                    Console.WriteLine("Bonne réponse !\n");
                    score++;
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse. La bonne réponse était Paris.\n");
                }

                Console.WriteLine("Quelle est la ville la plus peuplée du monde ?\n");
                Console.WriteLine("a) New York\nb) Tokyo\nc) Mexico\n");
                reponseUtilisateur = Console.ReadLine();

                if (reponseUtilisateur == "b")
                {
                    Console.WriteLine("Bonne réponse !\n");
                    score++;
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse. La bonne réponse était Tokyo.\n");
                }
            }

            // Arrêtez le chronomètre
            stopwatch.Stop();

            // Affichez le score final et le temps écoulé
            Console.WriteLine("Votre score final est : " + score + " sur " + nbQuestions * 2);
            Console.WriteLine("Temps écoulé : " + stopwatch.Elapsed);

            // Affichez un message de félicitations si le score est élevé
            if (score >= nbQuestions * 1.5)
            {
                Console.WriteLine("Félicitations");
            }
        }
    }
}
