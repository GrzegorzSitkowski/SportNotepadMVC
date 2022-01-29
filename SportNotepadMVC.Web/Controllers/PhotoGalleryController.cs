using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.ViewModels.PhotoGallery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportNotepadMVC.Web.Controllers
{
    public class PhotoGalleryController : Controller
    {
        private readonly IPhotoGalleryService _photoGalleryService;

        public PhotoGalleryController(IPhotoGalleryService photoGalleryService)
        {
            _photoGalleryService = photoGalleryService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new PhotoGalleryVm());
        }

        
        [HttpPost]
        public ActionResult Create(PhotoGalleryVm model)
        {
            _photoGalleryService.AddPhoto(model);
            return RedirectToAction("Index");
        }

        
        public ActionResult Edit(int id)
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
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
    }
}
