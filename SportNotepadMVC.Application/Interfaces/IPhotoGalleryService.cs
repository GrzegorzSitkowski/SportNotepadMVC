using SportNotepadMVC.Application.ViewModels.PhotoGallery;
using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.Interfaces
{
    public interface IPhotoGalleryService
    {
        int AddPhoto(PhotoGalleryVm photoGallery);
        void DeletePhoto(int id);
        void EditPhoto(PhotoGalleryVm model);
        PhotoGalleryVm PhotoForEdit(int id);
        PhotoGallery GetPhotoById(int idPhoto);
        ListPhotoGalleryForListVm GetAllPhotos();
        string UploadPhoto(PhotoGalleryVm model);
    }
}
