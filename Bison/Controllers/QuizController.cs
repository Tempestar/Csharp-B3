using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

[Route("api/quiz")]
namespace QuizBison.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
public class QuizController : ControllerBase
{
        private List<Question> questions;
        private int currentQuestion;

        public QuizController()
        {
            questions = new List<Question>
    {
        new Question
        {
            Text = "Quelle est la couleur du cheval blanc d'Henry IV?",
            Answers = new List<string> {"Blanc", "Noir", "Gris", "Rouge"},
            CorrectAnswer = 1
        },
        new Question
        {
            Text = "Combien font 2 plus 2?",
            Answers = new List<string> {"4", "22", "5", "3"},
            CorrectAnswer = 0
        },
        // Ajoutez ici d'autres questions
    };
            currentQuestion = 0;
        }

    [HttpGet]
    [Route("questions")]
    public IEnumerable<Question> GetQuestions()
    {
        // Retourne une liste de questions pour le quiz sur les bisons
        return new List<Question>
        {
            new Question { Text = "Quel est le nom scientifique du bison?", Answer = "Bison bison" },
            new Question { Text = "Combien de temps un bison peut-il rester sous l'eau?", Answer = "Jusqu'à 5 minutes" },
            new Question { Text = "Combien de temps un bison peut-il courir?", Answer = "Jusqu'à 40 km/h pendant une courte distance" },
        };
    }
    // Ajoutez une méthode pour gérer les réponses du quiz
    [HttpPost]
    public ActionResult<bool> SubmitAnswer(Answer answer)
    {
        // Vérifie si la réponse est correcte et retourne un booléen indiquant si elle est correcte ou non
        return answer.Text == "Bison bison";
    }

    public class Question
    {
        public string Text { get; set; }
        public string Answer { get; set; }
    }

    public class Answer
    {
        public string Text { get; set; }
    }


}
