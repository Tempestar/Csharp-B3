using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Quiz
{
    public struct Questions
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

            Dictionary<string, List<string>> quizQuestions = new Dictionary<string, List<string>>
            {
                { "Quelle est la taille d'un bison adulte ?\na) 1m80\nb) 2m\nc) 2m20\n", new List<string>() { "a) 1m80", "b) 2m", "c) 2m20" } },
                { "D'où viennent les bisons ?\na) Asie\nb) Amérique\nc) Océanie\n", new List<string>() { "a) Asie", "b) Amérique", "c) Océanie" } },
                { "Quels sont les prédateurs naturels des bisons ?\na) Les loups\nb) Les loutres\nc) Les tigres\n", new List<string>() { "a) Les loups", "b) Les loutres", "c) Les tigres" } },
                { "Comment les bisons se nourrissent-ils ?\na) Ils mangent de la viande\nb) Ils mangent du poisson et crustacés\nc) Ils mangent des plantes herbacées\n", new List<string>() { "a) Ils mangent de la viande", "b) Ils mangent du poisson et des crustacés", "c) Ils mangent des plantes herbacées" } },
                { "Sont-ils en voie de disparition ?\na) Oui\nb) Non\nc) Ils sont protégés\n", new List<string>() { "a) Oui", "b) Non", "c) Ils sont protégés" } },
                { "Comment se comportent les bisons en groupe ?\na) Ils sont en troupeaux\nb) Ils sont solitaires\nc) Ils sont en petits groupes\n", new List<string>() { "a) Ils sont en troupeaux", "b) Ils sont solitaires", "c) Ils sont en petits groupes" } },
                { "Quelle est la durée de vie moyenne d'un bison ?\na) 10 à 15 ans\nb) 15 à 20 ans\nc) 20 à 25 ans\n", new List<string>() { "a) 10 à 15 ans", "b) 15 à 20 ans", "c) 20 à 25 ans" } },
                { "Les bisons sont-ils des animaux domestiques ?\na) Oui\nb) Non\nc) Oui, mais c'est de la nourriture d'urgence\n", new List<string>() { "a) Oui", "b) Non", "c) Oui, mais c'est de la nourriture d'urgence" } },
                { "Quelle est la période de reproduction des bisons ?\na) Entre juillet et août\nb) Entre octobre et novembre\nc) Entre mars et avril\n", new List<string>() { "a) Entre juillet et août", "b) Entre octobre et novembre", "c) Entre mars et avril" } },
                { "Comment les bisons se défendent-ils contre des prédateurs ?\na) Ils font le mort\nb) Ils intimident\nc) Ils chargent leurs ennemis\n", new List<string>() { "a) Ils font le mort", "b) Ils intimident", "c) Ils chargent leurs ennemis" } }
            };



            // Demandez à l'utilisateur combien de questions il souhaite répondre
            Console.WriteLine("À combien de questions souhaitez-vous répondre ?\n");
            int nbQuestions = int.Parse(Console.ReadLine());

            // Démarrez un chronomètre
            var time = new System.Diagnostics.Stopwatch();
            time.Start();

            for (int i = 0; i < nbQuestions; i++)
            {
                int index = rand_num.Next(quizQuestions.Count);

                KeyValuePair<string, List<string>> pair = quizQuestions.ElementAt(index);

                Console.WriteLine(pair.Key);

                answer = Console.ReadLine();

                if (answer == "c")
                {
                    Console.WriteLine("Bonne réponse !\n");
                    score++;
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse.\n");
                }

                /*
                switch (rand_num)
                {
                    case 0:
                        do
                        {
                            Console.WriteLine(quizQuestions[rand_num]);

                            answer = Console.ReadLine();

                            if (answer == "a")
                            {
                                Console.WriteLine("Bonne réponse !\n");
                                score++;
                            }
                            else if (answer == "b" | answer == "c")
                            {
                                Console.WriteLine("Mauvaise réponse.\n");
                            }
                            else
                            {
                                Console.WriteLine("Veuillez entrer une valeur correcte");
                            }
                        }
                        while (answer != "a" | answer != "b" | answer != "c");
                        break;
                    case 1:
                        do
                        {
                            Console.WriteLine(quizQuestions[rand_num]);
                            answer = Console.ReadLine();
                            if (answer == "b")
                            {
                                Console.WriteLine("Bonne réponse !\n");
                                score++;
                            }
                            else if (answer == "a" | answer == "c")
                            {
                                Console.WriteLine("Mauvaise réponse.\n");
                            }
                            else
                            {
                                Console.WriteLine("Veuillez entrer une valeur correcte");
                            }
                        }
                        while (answer != "a" | answer != "b" | answer != "c");
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine(quizQuestions[rand_num]);
                            answer = Console.ReadLine();
                            if (answer == "a")
                            {
                                Console.WriteLine("Bonne réponse !\n");
                                score++;
                            }
                            else if (answer == "b" | answer == "c")
                            {
                                Console.WriteLine("Mauvaise réponse.\n");
                            }
                            else
                            {
                                Console.WriteLine("Veuillez entrer une valeur correcte");
                            }
                        }
                        while (answer != "a" | answer != "b" | answer != "c");
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine(quizQuestions[rand_num]);
                            answer = Console.ReadLine();
                            if (answer == "c")
                            {
                                Console.WriteLine("Bonne réponse !\n");
                                score++;
                            }
                            else if (answer == "a" | answer == "b")
                            {
                                Console.WriteLine("Mauvaise réponse.\n");
                            }
                            else
                            {
                                Console.WriteLine("Veuillez entrer une valeur correcte");
                            }
                        }
                        while (answer != "a" | answer != "b" | answer != "c");
                        break;
                    case 4:
                        do
                        {
                            Console.WriteLine(quizQuestions[rand_num]);
                            answer = Console.ReadLine();
                            if (answer == "c")
                            {
                                Console.WriteLine("Bonne réponse !\n");
                                score++;
                            }
                            else if (answer == "a" | answer == "b")
                            {
                                Console.WriteLine("Mauvaise réponse.\n");
                            }
                            else
                            {
                                Console.WriteLine("Veuillez entrer une valeur correcte");
                            }
                        }
                        while (answer != "a" | answer != "b" | answer != "c");
                        break;
                    case 5:
                        do
                        {
                            Console.WriteLine(quizQuestions[rand_num]);
                            answer = Console.ReadLine();
                            if (answer == "a")
                            {
                                Console.WriteLine("Bonne réponse !\n");
                                score++;
                            }
                            else if (answer == "b" | answer == "c")
                            {
                                Console.WriteLine("Mauvaise réponse.\n");
                            }
                            else
                            {
                                Console.WriteLine("Veuillez entrer une valeur correcte");
                            }
                        }
                        while (answer != "a" | answer != "b" | answer != "c");
                        break;
                    case 6:
                        do
                        {
                            Console.WriteLine(quizQuestions[rand_num]);
                            answer = Console.ReadLine();
                            if (answer == "b")
                            {
                                Console.WriteLine("Bonne réponse !\n");
                                score++;
                            }
                            else if (answer == "a" | answer == "c")
                            {
                                Console.WriteLine("Mauvaise réponse.\n");
                            }
                            else
                            {
                                Console.WriteLine("Veuillez entrer une valeur correcte");
                            }
                        }
                        while (answer != "a" | answer != "b" | answer != "c");
                        break;
                    case 7:
                        do
                        {
                            Console.WriteLine(quizQuestions[rand_num]);
                            answer = Console.ReadLine();
                            if (answer == "b")
                            {
                                Console.WriteLine("Bonne réponse !\n");
                                score++;
                            }
                            else if (answer == "a")
                            {
                                Console.WriteLine("Mauvaise réponse.\n");
                            }
                            else
                            {
                                Console.WriteLine("Veuillez entrer une valeur correcte");
                            }
                        }
                        while (answer != "a" | answer != "b");
                        break;
                    case 8:
                        do
                        {
                            Console.WriteLine(quizQuestions[rand_num]);
                            answer = Console.ReadLine();
                            if (answer == "c")
                            {
                                Console.WriteLine("Bonne réponse !\n");
                                score++;
                            }
                            else if (answer == "a" | answer == "c")
                            {
                                Console.WriteLine("Mauvaise réponse.\n");
                            }
                            else
                            {
                                Console.WriteLine("Veuillez entrer une valeur correcte");
                            }
                        }
                        while (answer != "a" | answer != "b" | answer != "c");
                        break;
                    case 9:
                        do
                        {
                            Console.WriteLine(quizQuestions[rand_num]);
                            answer = Console.ReadLine();
                            if (answer == "c")
                            {
                                Console.WriteLine("Bonne réponse !\n");
                                score++;
                            }
                            else if (answer == "a" | answer == "c")
                            {
                                Console.WriteLine("Mauvaise réponse.\n");
                            }
                            else
                            {
                                Console.WriteLine("Veuillez entrer une valeur correcte");
                            }
                        }
                        while (answer != "a" | answer != "b" | answer != "c");
                        break;
                }
                */
            }

            // Arrêtez le chronomètre
            time.Stop();

            // Affichez le score final et le temps écoulé
            Console.WriteLine("Votre score final est : " + score + " sur " + nbQuestions);
            Console.WriteLine("Temps écoulé : " + time.Elapsed);
        }
    }
}
