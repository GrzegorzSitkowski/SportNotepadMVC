using SportNotepadMVC.Domain.Interfaces;
using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Infrastructure.Repositories
{
    public class PhotoGalleryRepository : IPhotoGalleryRepository
    {
        private readonly Context _context;

        public int AddPhoto(PhotoGallery photoGallery)
        {
            throw new NotImplementedException();
        }

        public void DeletePhoto(int id)
        {
            throw new NotImplementedException();
        }

        public void EditPhoto(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PhotoGallery> GetAllPhotos()
        {
            throw new NotImplementedException();
        }

        public PhotoGallery GetPhotoById(int idPhoto)
        {
            throw new NotImplementedException();
        }
    }
}
