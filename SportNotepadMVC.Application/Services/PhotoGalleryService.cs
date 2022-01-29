using AutoMapper;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.ViewModels.PhotoGallery;
using SportNotepadMVC.Domain.Interfaces;
using SportNotepadMVC.Domain.Model;
using SportNotepadMVC.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.Services
{
    public class PhotoGalleryService : IPhotoGalleryService
    {
        private readonly IMapper _mapper;
        private readonly IPhotoGalleryRepository _photoGalleryRepo;
        public PhotoGalleryService(IMapper mapper, IPhotoGalleryRepository photoGalleryRepo)
        {
            _mapper = mapper;
            _photoGalleryRepo = photoGalleryRepo;
        }
        public int AddPhoto(PhotoGalleryVm photoGallery)
        {
            string fileName = UploadPhoto(photoGallery);

            var _photoGallery = _mapper.Map<PhotoGallery>(photoGallery);
            _photoGallery.Path = fileName;
            var id = _photoGalleryRepo.AddPhoto(_photoGallery);

            return id;
        }

        public void DeletePhoto(int id)
        {
            throw new NotImplementedException();
        }

        public void EditPhoto(PhotoGalleryVm model)
        {
            throw new NotImplementedException();
        }
        public PhotoGalleryVm PhotoForEdit(int id)
        {
            throw new NotImplementedException();
        }


        public ListPhotoGalleryForListVm GetAllPhotos()
        {
            throw new NotImplementedException();
        }

        public PhotoGallery GetPhotoById(int idPhoto)
        {
            throw new NotImplementedException();
        }     

        public string UploadPhoto(PhotoGalleryVm model)
        {
            string fileName = null;
            if (model.Path != null)
                {
                    string uploadDir = Path.Combine(@"C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\wwwroot\Pictures\");
                    fileName = Guid.NewGuid().ToString() + "-" + model.Path.FileName;
                    string filePath = Path.Combine(uploadDir, fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        model.Path.CopyTo(fileStream);
                    }
                }
            return fileName;
        }
    }
}
