using System;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            // Déclarez les variables
            int score = 0;
            string answer;

            //On crée les questions/réponses
            List<string> quizQuestions = new List<string> {
            "Quelle est la taille d'un bison adulte ?\na) 1m80\nb) 2m\nc) 2m20\n",
            "D'où viennent les bisons ?\na) Asie\nb) Amérique\nc) Océanie\n",
            "Quels sont les prédateurs naturels des bisons ?\na) Les loups\nb) Les loutres\nc) Les tigres\n",
            "Comment les bisons se nourrissent-ils ?\na) Ils mangent de la viande\nb) Ils mangent du poisson et crustacés\nc) Ils mangent des plantes herbacées\n",
            "Sont-ils en voie de disparition ?\na) Oui\nb) Non\nc) Ils sont protégés\n",
            "Comment se comportent les bisons en groupe ?\na) Ils sont en troupeaux\nb) Ils sont solitaires\nc) Ils sont en petits groupes\n",
            "Quelle est la durée de vie moyenne d'un bison ?\na) 10 à 15 ans\nb) 15 à 20 ans\nc) 20 à 25 ans\n",
            "Les bisons sont-ils des animaux domestiques ?\na) Oui\nb) Non\n",
            "Quelle est la période de reproduction des bisons ?\na) Entre juillet et août\nb) Entre octobre et novembre\nc) Entre mars et avril\n",
            "Comment les bisons se défendent-ils contre des prédateurs ?\na) Ils font le mort\nb) Ils intimident\nc) Ils chargent leurs ennemis\n"
            };

            
            // Demandez à l'utilisateur combien de questions il souhaite répondre
            Console.WriteLine("À combien de questions souhaitez-vous répondre ?\n");
            int nbQuestions = int.Parse(Console.ReadLine());

            // Démarrez un chronomètre
            var time = new System.Diagnostics.Stopwatch();
            time.Start();

            Console.WriteLine(quizQuestions[0]);
            answer = Console.ReadLine();

            if (answer == "a")
            {
                Console.WriteLine("Bonne réponse !\n");
                score++;
            }
            else
            {
                Console.WriteLine("Mauvaise réponse. La bonne réponse était Paris.\n");
            }

            /*
            // Posez des questions et vérifiez les réponses
            for (int i = 0; i < nbQuestions; i++)
            {
                
            }*/

            // Arrêtez le chronomètre
            time.Stop();

            // Affichez le score final et le temps écoulé
            Console.WriteLine("Votre score final est : " + score + " sur " + 1);//nbQuestions * 2);
            Console.WriteLine("Temps écoulé : " + time.Elapsed);

            /*
            // Affichez un message de félicitations si le score est élevé
            if (score >= nbQuestions * 1.5)
            {
                Console.WriteLine("Félicitations");
            }*/
        }
    }
}
