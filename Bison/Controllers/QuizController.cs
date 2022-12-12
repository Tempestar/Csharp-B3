using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public ActionResult<Question> GetQuestion()
        {
            if (currentQuestion >= questions.Count)
            {
                return NoContent();
            }

            return Ok(questions[currentQuestion]);
        }

        [HttpPost]
        public ActionResult<Answer> SubmitAnswer(int index)
        {
            var result = new Answer();
            result.Correct = questions[currentQuestion].CorrectAnswer == index;
            result.NextQuestion = questions.Count > currentQuestion + 1;

            if (result.Correct)
            {
                currentQuestion++;
            }

            return Ok(result);
        }

        public class Question
        {
            public string Text { get; set; }
            public List<string> Answers { get; set; }
            public int CorrectAnswer { get; set; }
        }

        public class Answer
        {
            public bool Correct { get; set; }
            public bool NextQuestion { get; set; }
        }
    }


}
