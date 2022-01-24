using SportNotepadMVC.Application.ViewModels.PhotoGallery;
using SportNotepadMVC.Infrastructure.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.Interfaces
{
    public interface IPhotoGalleryService
    {
        int AddPhoto(PhotoGallery photoGallery);
        void DeletePhoto(int id);
        void EditPhoto(PhotoGallery model);
        PhotoGallery PohtoForEdit(int id);
        PhotoGallery GetPhotoById(int idPhoto);
        ListPhotoGalleryForListVm GetAllPhotos();
    }
}
