using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Infoline.Api.Business.Abstract;
using Infoline.Api.Dto;
using Infoline.Api.Models;
using Infoline.Api.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Infoline.Api.Controllers
{

    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IQuestionService _questionService;
        private readonly IUsersAnswerService _usersAnswerService;


        public UserController(
            IUsersAnswerService usersAnswerService,
            IUserService userService,
            IQuestionService questionService)
        {
            _usersAnswerService = usersAnswerService;
            _userService = userService;
            _questionService = questionService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var responseViewModel = _userService.GetUsers();

            return View(responseViewModel);
        }

        [HttpGet]
        public IActionResult GenerateUsers()
        {
            var responseViewModel = _userService.GetRandomUsers();
            responseViewModel.AddedUsers = new List<UserDto>();
            return View(responseViewModel);
        }

        [HttpPost]
        public IActionResult GenerateUsers(List<UserDto> users)
        {
            var result = _userService.AddUsers(users);

            if (result)
            {
                return RedirectToAction("Index", "User");
            }
            else
            {
                return Content("Hata oluştu daha sonra tekrar deneyiniz.");
            }
        }

        public IActionResult Delete(int id)
        {

            var deleted = _userService.DeleteUser(id);
            if (deleted)
            {

                return RedirectToAction("Index");
            }
            else
            {
                return Content("Hata oluştu daha sonra tekrar deneyiniz.");

            }
        }

        public IActionResult UserQuestion()
        {
            var viewModel = new UserQuestionViewModel();
            viewModel.Users = _userService.GetUsersSummary();
            viewModel.QuestionDto = _questionService.GetRandomQuestion();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult UserQuestion(UserQuestionViewModel viewModel)
        {
            var saveAnswer = _usersAnswerService.AddUserAnswer(viewModel);
            if (saveAnswer)
            {
                return RedirectToAction("UserQuestion");
            }
            else
            {
                return Content("Hata oluştu daha sonra tekrar deneyiniz.");

            }
        }

        public IActionResult UsersAnswers()
        {
            var viewModel = new UsersAnswersViewModel();

            viewModel = _usersAnswerService.GetAnswers();

            return View(viewModel);
        }


        public IActionResult AddQuestion()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddQuestion(string question)
        {
            var addQuestion = _questionService.AddQuestion(question);

            if (addQuestion)
            {
                return RedirectToAction("Index", "User");
            }
            else
            {
                return Content("Hata oluştu daha sonra tekrar deneyiniz.");

            }

        }
    }
}