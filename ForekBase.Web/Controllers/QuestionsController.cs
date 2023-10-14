using ForekBase.Application.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ForekBase.Web.Controllers
{
    public class QuestionsController : Controller
    {
        public readonly IUnitOfWork _unitOfWork;

        public QuestionsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var questions = _unitOfWork.Question.GetAll(includeProperties: "Survey");

            return View(questions);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
