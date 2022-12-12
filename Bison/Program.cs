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

            for (int i = 0; i < nbQuestions; i++)
            {
                int rand_num = rnd.Next(quizQuestions.Count);
                Console.WriteLine(quizQuestions[rand_num]);

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
