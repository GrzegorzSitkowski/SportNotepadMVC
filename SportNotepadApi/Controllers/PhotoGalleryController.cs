using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.ViewModels.PhotoGallery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportNotepadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoGalleryController : ControllerBase
    {
        private readonly IPhotoGalleryService _photoGalleryService;

        public PhotoGalleryController(IPhotoGalleryService photoGalleryService)
        {
            _photoGalleryService = photoGalleryService;
        }

        [HttpGet("PhotoGallery")]
        public ActionResult<ListPhotoGalleryForListVm> GetAllPhotos()
        {
            var photos = _photoGalleryService.GetAllPhotos();
            if(photos == null)
            {
                return NoContent();
            }
            return Ok(photos);
        }

        [HttpGet("{id")]
        public ActionResult GetPhotosById(int id)
        {
            var result = _photoGalleryService.GetPhotoById(id);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("New")]
        public IActionResult AddPhoto([FromBody]PhotoGalleryVm photoVm)
        {
            if(!ModelState.IsValid || photoVm.Id != 0)
            {
                return Conflict(ModelState);
            }
            _photoGalleryService.AddPhoto(photoVm);
            return Ok();
        }

        [HttpGet("Edit/{id}")]
        public IActionResult EditPhoto([FromBody]PhotoGalleryVm photoVm)
        {
            if(!ModelState.IsValid || photoVm.Id != 0)
            {
                return Conflict(ModelState);
            }
            _photoGalleryService.EditPhoto(photoVm);
            return Ok();
        }
    }
}
