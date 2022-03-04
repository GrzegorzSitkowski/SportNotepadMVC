using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.ViewModels.Competition;
using SportNotepadMVC.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportNotepadMVC.Web.Controllers
{
    public class CompetitionController : Controller
    {
        private readonly ICompetitionService _competitionService;
        private readonly Context _context;

        public CompetitionController(ICompetitionService competitionService, Context context)
        {
            _competitionService = competitionService;
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _competitionService.GetAllCompetitions(5, 1, "");
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo, string searchString)
        {
            if(!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if(searchString is null)
            {
                searchString = String.Empty;
            }

            var model = _competitionService.GetAllCompetitions(pageSize, pageNo.Value, searchString);
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var competition = _competitionService.GetCompetitionDetails(id);
            return View(competition);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new NewCompetitionVm());
        }
        [HttpPost]
        public ActionResult Create(NewCompetitionVm model)
        {
            if(ModelState.IsValid)
            {
                var competition = _competitionService.AddCopmetition(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var competition = _competitionService.CompetitionForEdit(id);
            return View(competition);
        }

        [HttpPost]
        public ActionResult Edit(NewCompetitionVm model)
        {
            _competitionService.EditCompetition(model);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _competitionService.DeleteCompetition(id);
            return RedirectToAction("Index");
        }

        public ActionResult DownloadList()
        {
            _competitionService.DownloadList();
            return RedirectToAction("Index");
        }
    }
}
