using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.ViewModels.PhotoGallery;
using SportNotepadMVC.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportNotepadMVC.Web.Controllers
{
    public class PhotoGalleryController : Controller
    {
        private readonly IPhotoGalleryService _photoGalleryService;
        private readonly Context _context;

        public PhotoGalleryController(IPhotoGalleryService photoGalleryService, Context context)
        {
            _photoGalleryService = photoGalleryService;
            _context = context;
        }
        public ActionResult Index()
        {
            var photos = _photoGalleryService.GetAllPhotos();
            return View(photos);
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

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var photoGallery = _photoGalleryService.PhotoForEdit(id);
            return View(photoGallery);
        }

        
        [HttpPost]
        public ActionResult Edit(PhotoGalleryVm model)
        {
            _photoGalleryService.EditPhoto(model);
            return RedirectToAction("Index");
        }

     
        public ActionResult Delete(int id)
        {
            _photoGalleryService.DeletePhoto(id);
            return RedirectToAction("Index");
        }
    }
}
