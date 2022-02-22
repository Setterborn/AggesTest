using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AggesTest.Model;

namespace AggesTest.Pages
{
    public class IndexModel : PageModel
    {
        public Question TempQuestion { get; set; }
        public List<Answer> TempAnswerList { get; set; } = new();
        public string Message { get; set; }
        [BindProperty]
        public string input { get; set; }
        public void OnGet()
        {
            Message = Data.QuizManager.tempMessage;
            Data.QuestionSamples.RandomQuestion();
            TempQuestion = Data.QuestionSamples.TempQuestion;
            TempAnswerList = Data.AnswerSamples.RandomAnswers(TempQuestion.Id);
            
        }

        public IActionResult OnPost()
        {
            if (input != Data.QuestionSamples.TempQuestion.Id.ToString())
            {
                Data.QuizManager.tempMessage = "Wrong!";
            }
            if (input == Data.QuestionSamples.TempQuestion.Id.ToString())
            {
                Data.QuizManager.tempMessage = "Correct!";
            }
            return Page();
        }
    }
}