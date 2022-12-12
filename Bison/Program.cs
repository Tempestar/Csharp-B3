using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Quiz
{

    public class Program
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }

    public class Program
    {
        static Random rnd = new Random();
        private string question;
        private string answer;

        static void Main(string[] args)
        {
            // Déclarez les variables
            int score = 0;
            string answer;
            Random rand_num = new Random();

            Dictionary<string, string> quizQuestions = new Dictionary<string, string>
            {
                { "Quelle est la taille d'un bison adulte ?\na) 1m80\nb) 2m\nc) 2m20\n", "a" },
                { "D'où viennent les bisons ?\na) Asie\nb) Amérique\nc) Océanie\n", "b" },
                { "Quels sont les prédateurs naturels des bisons ?\na) Les loups\nb) Les loutres\nc) Les tigres\n", "a" },
                { "Comment les bisons se nourrissent-ils ?\na) Ils mangent de la viande\nb) Ils mangent du poisson et crustacés\nc) Ils mangent des plantes herbacées\n", "c" },
                { "Sont-ils en voie de disparition ?\na) Oui\nb) Ils sont protégés\nc) Non\n", "b" },
                { "Comment se comportent les bisons en groupe ?\na) Ils sont en troupeaux\nb) Ils sont solitaires\nc) Ils sont en petits groupes\n", "a" },
                { "Quelle est la durée de vie moyenne d'un bison ?\na) 10 à 15 ans\nb) 15 à 20 ans\nc) 20 à 25 ans\n", "b" },
                { "Les bisons sont-ils des animaux domestiques ?\na) Oui\nb) Non\nc) Oui, mais c'est de la nourriture d'urgence\n", "b" },
                { "Quelle est la période de reproduction des bisons ?\na) Entre juillet et août\nb) Entre octobre et novembre\nc) Entre mars et avril\n", "c" },
                { "Comment les bisons se défendent-ils contre des prédateurs ?\na) Ils font le mort\nb) Ils intimident\nc) Ils chargent leurs ennemis\n", "c" }
            };


            // Demandez à l'utilisateur combien de questions il souhaite répondre
            Console.WriteLine("À combien de questions souhaitez-vous répondre ?\n");
            int nbQuestions = int.Parse(Console.ReadLine());
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nChoisissez la bonne réponse en écrivant a, b ou c.\n");

            // Démarrez un chronomètre
            var time = new System.Diagnostics.Stopwatch();
            time.Start();

            for (int i = 1; i < nbQuestions+1; i++)
            {
                int index = rand_num.Next(quizQuestions.Count);

                KeyValuePair<string, string> pair = quizQuestions.ElementAt(index);

                
                Console.WriteLine("Question "+ i + " : " + pair.Key);

                answer = Console.ReadLine();

                while (true)
                {
                    if (answer == "a" || answer == "b" || answer == "c")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Veuillez entrer une réponse autorisée (a, b ou c)\n");
                        answer = Console.ReadLine();
                    }
                }
                
                if (answer == pair.Value)
                {
                    Console.WriteLine("Bonne réponse !\n");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                    score++;
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse.\n");
                }
                    

            }

            // Arrêtez le chronomètre
            time.Stop();

            // Affichez le score final et le temps écoulé
            Console.WriteLine("Votre score final est : " + score + " sur " + nbQuestions);
            Console.WriteLine("Temps écoulé : " + time.Elapsed);
        }
    }
}
