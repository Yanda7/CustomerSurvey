using ForekBase.Domain.Entities.Enums;
using ForekBase.Domain.Entities;

namespace ForekBase.Web.ViewModels
{
    public class QuestionVM
    {
        public Guid QuestionId { get; set; }

        public string QuestionText { get; set; }

        public QuestionType Type { get; set; }

        public Guid SurveyId { get; set; }

        public Survey Survey { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}
