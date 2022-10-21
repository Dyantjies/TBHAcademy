using System.Collections.Generic;

namespace TBHAcademy.Models
{
    public class QuizQuestionAnswerViewModel
    {
        public int OptionId { get; set; }
        public int QuestionID { get; set; }
        public string QuestionNumber { get; set; }
        public string QuestionDes { get; set; }
        public List<QuizOptions> ListOfQuizOptions { get; set; }
    }
    public class QuizOptions
    {
        public int OptionID { get; set; }
        public string optionName { get; set; }
    }
}
