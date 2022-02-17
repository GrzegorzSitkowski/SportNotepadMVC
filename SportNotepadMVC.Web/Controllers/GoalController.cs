using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.ViewModels.Goal;
using SportNotepadMVC.Web.Filtres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportNotepadMVC.Web.Controllers
{
    public class GoalController : Controller
    {
        private readonly IGoalService _goalService;

        public GoalController(IGoalService goalService)
        {
            _goalService = goalService;
        }

        [CheckPermission("Read")]
        public ActionResult Index()
        {
            var model = _goalService.GetAllGoal();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var goal = _goalService.GetGoalDetails(id);
            return View(goal);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new NewGoalVm());
        }

        [HttpPost]
        public ActionResult Create(NewGoalVm model)
        {
            if(ModelState.IsValid)
            {
                var goal = _goalService.AddGoal(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var goal = _goalService.GoalForEdit(id);
            return View(goal);
        }
        [HttpPost]
        public ActionResult Edit(NewGoalVm model)
        {
            _goalService.EditGoal(model);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _goalService.DeleteGoal(id);
            return RedirectToAction("Index");
        }
    }
}
