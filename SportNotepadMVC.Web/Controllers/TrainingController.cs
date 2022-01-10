using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.ViewModels.Training;
using SportNotepadMVC.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportNotepadMVC.Web.Controllers
{
    public class TrainingController : Controller
    {
        private readonly Context _context;
        private readonly ITrainingService _traningService;

        public TrainingController(Context context, ITrainingService trainingService)
        {
            _context = context;
            _traningService = trainingService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = _traningService.GetAllTrainigs(5,1,"");
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(int pageSize, int? pageNo, string searchString)
        {
            if(!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if(searchString is null)
            {
                searchString = String.Empty;
            }

            var model = _traningService.GetAllTrainigs(pageSize, pageNo.Value, searchString);
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var training = _traningService.GetTrainingDetails(id);
            return View(training);
        }

        [HttpGet]
        public ActionResult Create()
        {           
            return View(new NewTrainingVm());
        }

        
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(NewTrainingVm model)
        {
            if(ModelState.IsValid)
            {
                var training = _traningService.AddTraining(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        
        public ActionResult Edit(int id)
        { 
            return View();
        }

        
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Delete(int id)
        {
            return View();
        }

        
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
