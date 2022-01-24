using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Domain.Interfaces
{
    public interface IPhotoGalleryRepository
    {
        int AddPhoto(PhotoGallery photoGallery);
        void DeletePhoto(int id);
        void EditPhoto(PhotoGallery photoGallery;
        PhotoGallery GetPhotoById(int idPhoto);
        IQueryable<PhotoGallery> GetAllPhotos();
    }
}
